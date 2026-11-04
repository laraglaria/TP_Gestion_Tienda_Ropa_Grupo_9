
using AccesoDatos.Data;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TiendaRopaApp
{
    public partial class FormVentas : Form
    {
        private List<DetalleVenta> detallesPendientes =
            new List<DetalleVenta>();
        private readonly TiendaRopaDbContext context;
        public FormVentas(TiendaRopaDbContext context)
        {
            InitializeComponent();

            this.context = context;

            btnQuitarDetalle.Enabled = false;

            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarDatos();
            ActualizarDetalles();
        }

        private void CargarDatos()
        {

            cmbClientes.DataSource = context.Clientes
                .Where(c => c.Estado)
                .OrderBy(c => c.Apellido)
                .ThenBy(c => c.Nombre)
                .ToList();

            cmbClientes.DisplayMember = "Apellido";
            cmbClientes.ValueMember = "Id";

            cmbVendedores.DataSource = context.Vendedores
                .Where(v => v.Estado)
                .OrderBy(v => v.Apellido)
                .ThenBy(v => v.Nombre)
                .ToList();

            cmbVendedores.DisplayMember = "Apellido";
            cmbVendedores.ValueMember = "Id";

            CargarProductos();
        }

        private void CargarProductos()
        {

            var productos = context.Productos
                .OrderBy(p => p.Nombre)
                .ToList();

            cmbProductos.DataSource = null;
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id";
            cmbProductos.DataSource = productos;
        }

        private void dgvDetalles_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnQuitarDetalle.Enabled = true;
            }
            else
            {
                btnQuitarDetalle.Enabled = false;
            }
        }

        private void btnAgregarDetalle_Click(
            object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("No hay productos disponibles para seleccionar.");
                return;
            }

            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad) ||
                cantidad <= 0)
            {
                MessageBox.Show("Ingresá una cantidad mayor que cero.");
                return;
            }

            Producto productoSeleccionado =
                (Producto)cmbProductos.SelectedItem;

            Producto? productoActual = context.Productos
                .FirstOrDefault(p => p.Id == productoSeleccionado.Id);

            if (productoActual == null)
            {
                MessageBox.Show(
                    "No se encontró el producto en la base de datos. ID: " +
                    productoSeleccionado.Id);
                CargarProductos();
                return;
            }

            if (!productoActual.Estado)
            {
                MessageBox.Show("El producto existe, pero está inactivo.");
                return;
            }

            if (productoActual.Stock <= 0)
            {
                MessageBox.Show(
                    "El producto existe, pero su stock es: " +
                    productoActual.Stock);
                return;
            }

            int cantidadExistente = detallesPendientes
                .Where(d => d.ProductoId == productoActual.Id)
                .Sum(d => d.Cantidad);

            if (cantidad + cantidadExistente > productoActual.Stock)
            {
                MessageBox.Show(
                    "No hay stock suficiente. Stock disponible: " +
                    (productoActual.Stock - cantidadExistente));
                return;
            }

            DetalleVenta? detalleExistente = detallesPendientes
                .FirstOrDefault(d => d.ProductoId == productoActual.Id);

            if (detalleExistente != null)
            {
                detalleExistente.Cantidad += cantidad;
                detalleExistente.Subtotal =
                    detalleExistente.Cantidad *
                    detalleExistente.PrecioUnitario;
            }
            else
            {
                DetalleVenta detalle = new DetalleVenta();

                detalle.ProductoId = productoActual.Id;
                detalle.Producto = productoActual;
                detalle.Cantidad = cantidad;
                detalle.PrecioUnitario = productoActual.Precio;
                detalle.Subtotal = cantidad * productoActual.Precio;

                detallesPendientes.Add(detalle);
            }

            ActualizarDetalles();
            txtCantidad.Clear();
        }

        private void ActualizarDetalles()
        {
            dgvDetalles.DataSource = null;

            dgvDetalles.DataSource = detallesPendientes
                .Select(d => new
                {
                    Producto = d.Producto!.Nombre,
                    d.Cantidad,
                    d.PrecioUnitario,
                    d.Subtotal
                })
                .ToList();

            decimal total = detallesPendientes.Sum(d => d.Subtotal);

            lblTotal.Text = "Total: $" + total.ToString("N2");
        }

        private void btnQuitarDetalle_Click(
            object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow == null ||
                dgvDetalles.CurrentRow.Index < 0 ||
                dgvDetalles.CurrentRow.Index >= detallesPendientes.Count)
            {
                MessageBox.Show("Seleccioná un producto de la tabla.");
                return;
            }

            detallesPendientes.RemoveAt(dgvDetalles.CurrentRow.Index);

            ActualizarDetalles();

            btnQuitarDetalle.Enabled = false;
        }

        private void btnRegistrarVenta_Click(
            object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue == null ||
                cmbVendedores.SelectedValue == null)
            {
                MessageBox.Show("Seleccioná un cliente y un vendedor.");
                return;
            }

            if (detallesPendientes.Count == 0)
            {
                MessageBox.Show("Agregá al menos un producto a la venta.");
                return;
            }

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);
            int vendedorId = Convert.ToInt32(cmbVendedores.SelectedValue);

            using var transaccion = context.Database.BeginTransaction();

            try
            {
                Venta venta = new Venta();

                venta.Fecha = DateTime.Now;
                venta.ClienteId = clienteId;
                venta.VendedorId = vendedorId;
                venta.Estado = true;
                venta.Total = 0;

                foreach (DetalleVenta detalle in detallesPendientes)
                {
                    Producto? producto = context.Productos
                        .FirstOrDefault(p => p.Id == detalle.ProductoId);

                    if (producto == null ||
                        !producto.Estado ||
                        producto.Stock < detalle.Cantidad)
                    {
                        throw new Exception(
                            "No hay stock suficiente para el producto: " +
                            detalle.Producto!.Nombre);
                    }

                    DetalleVenta nuevoDetalle = new DetalleVenta();

                    nuevoDetalle.ProductoId = producto.Id;
                    nuevoDetalle.Cantidad = detalle.Cantidad;
                    nuevoDetalle.PrecioUnitario = producto.Precio;
                    nuevoDetalle.Subtotal =
                        producto.Precio * detalle.Cantidad;

                    venta.Detalles.Add(nuevoDetalle);
                    venta.Total += nuevoDetalle.Subtotal;

                    producto.Stock -= detalle.Cantidad;
                }

                context.Ventas.Add(venta);
                context.SaveChanges();

                transaccion.Commit();

                MessageBox.Show(
                    "Venta registrada correctamente.\n" +
                    "Número de venta: " + venta.Id +
                    "\nTotal: $" + venta.Total.ToString("N2"));

                detallesPendientes.Clear();
                ActualizarDetalles();

                btnQuitarDetalle.Enabled = false;

                CargarDatos();
                txtCantidad.Clear();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();

                MessageBox.Show(
                    "No se pudo registrar la venta.\n" + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            detallesPendientes.Clear();

            ActualizarDetalles();

            btnQuitarDetalle.Enabled = false;

            txtCantidad.Clear();

            if (cmbClientes.Items.Count > 0)
                cmbClientes.SelectedIndex = 0;

            if (cmbVendedores.Items.Count > 0)
                cmbVendedores.SelectedIndex = 0;

            if (cmbProductos.Items.Count > 0)
                cmbProductos.SelectedIndex = 0;
        }
    }
}

