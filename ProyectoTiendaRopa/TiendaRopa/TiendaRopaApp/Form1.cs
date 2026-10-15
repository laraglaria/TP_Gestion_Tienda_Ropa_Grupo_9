using AccesoDatos.Models;
using AccesoDatos.Repositories;
using System;

namespace TiendaRopaApp
{
    public partial class FormProductos : Form
    {
        private GenericRepository<Producto> repositorio = new GenericRepository<Producto>();
        private int idProductoSeleccionado = 0;
        public FormProductos()
        {
            InitializeComponent();
            CargarProductos();
        }
        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = repositorio.ObtenerTodos();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" ||
                txtDescripcion.Text == "" ||
                txtPrecio.Text == "" ||
                txtStock.Text == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            decimal precio;
            int stock;

            if (!decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Ingresá un precio y un stock válidos.");
                return;
            }

            if (precio < 0 || stock < 0)
            {
                MessageBox.Show("El precio y el stock no pueden ser negativos.");
                return;
            }

            Producto producto = new Producto();

            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = precio;
            producto.Stock = stock;

            repositorio.Agregar(producto);

            MessageBox.Show("Producto agregado correctamente.");

            CargarProductos();
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProductoSeleccionado = Convert.ToInt32(
                    dgvProductos.Rows[e.RowIndex].Cells["Id"].Value);

                txtNombre.Text = dgvProductos.Rows[e.RowIndex]
                    .Cells["Nombre"].Value?.ToString() ?? "";

                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex]
                    .Cells["Descripcion"].Value?.ToString() ?? "";

                txtPrecio.Text = dgvProductos.Rows[e.RowIndex]
                    .Cells["Precio"].Value?.ToString() ?? "";

                txtStock.Text = dgvProductos.Rows[e.RowIndex]
                    .Cells["Stock"].Value?.ToString() ?? "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un producto de la tabla.");
                return;
            }

            if (txtNombre.Text == "" ||
                txtDescripcion.Text == "" ||
                txtPrecio.Text == "" ||
                txtStock.Text == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            decimal precio;
            int stock;

            if (!decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Ingresá un precio y un stock válidos.");
                return;
            }

            if (precio < 0 || stock < 0)
            {
                MessageBox.Show("El precio y el stock no pueden ser negativos.");
                return;
            }

            Producto producto = new Producto();

            producto.Id = idProductoSeleccionado;
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = precio;
            producto.Stock = stock;

            repositorio.Modificar(producto);

            MessageBox.Show("Producto modificado correctamente.");

            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un producto de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás segura de que querés eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            repositorio.Eliminar(idProductoSeleccionado);

            MessageBox.Show("Producto eliminado correctamente.");

            CargarProductos();

            idProductoSeleccionado = 0;

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idProductoSeleccionado = 0;

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

            dgvProductos.ClearSelection();
        }
    }
}
