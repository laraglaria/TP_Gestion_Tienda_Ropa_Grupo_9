using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AccesoDatos.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TiendaRopaApp
{
    public partial class FormReportes : Form
    {
        private readonly TiendaRopaDbContext context;
        public FormReportes(TiendaRopaDbContext context)
        {
            InitializeComponent();

            this.context = context;

            cmbTipoReporte.Items.Add("Productos con stock disponible");
            cmbTipoReporte.Items.Add("Ventas por cliente");
            cmbTipoReporte.Items.Add("Ventas por vendedor");
            cmbTipoReporte.Items.Add("Vendedor con mayor cantidad de ventas");
            cmbTipoReporte.Items.Add("Productos por categoría");

            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.SelectedIndex = 0;

            dgvReportes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReportes.ReadOnly = true;
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoGenerateColumns = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            switch (cmbTipoReporte.SelectedIndex)
            {
                case 0:
                    ReporteProductosStock(context);
                    break;

                case 1:
                    ReporteVentasPorCliente(context);
                    break;

                case 2:
                    ReporteVentasPorVendedor(context);
                    break;

                case 3:
                    ReporteVendedorConMasVentas(context);
                    break;

                case 4:
                    ReporteProductosPorCategoria(context);
                    break;
            }
        }

        private void ReporteProductosStock(TiendaRopaDbContext context)
        {
            var resultado = context.Productos
                .Where(p => p.Estado && p.Stock > 0)
                .OrderBy(p => p.Nombre)
                .Select(p => new
                {
                    Producto = p.Nombre,
                    p.Precio,
                    p.Stock
                })
                .ToList();

            dgvReportes.DataSource = resultado;
            lblTitulo.Text = "Productos con stock disponible";
        }

        private void ReporteVentasPorCliente(TiendaRopaDbContext context)
        {
            var resultado = context.Ventas
                .Where(v => v.Estado)
                .GroupBy(v => new
                {
                    v.ClienteId,
                    v.Cliente.Nombre,
                    v.Cliente.Apellido
                })
                .Select(g => new
                {
                    Cliente = g.Key.Apellido + ", " + g.Key.Nombre,
                    CantidadVentas = g.Count(),
                    TotalGastado = g.Sum(v => v.Total)
                })
                .OrderByDescending(r => r.TotalGastado)
                .ToList();

            dgvReportes.DataSource = resultado;
            lblTitulo.Text = "Ventas por cliente";
        }

        private void ReporteVentasPorVendedor(TiendaRopaDbContext context)
        {
            var resultado = context.Ventas
                .Where(v => v.Estado)
                .GroupBy(v => new
                {
                    v.VendedorId,
                    v.Vendedor.Nombre,
                    v.Vendedor.Apellido
                })
                .Select(g => new
                {
                    Vendedor = g.Key.Apellido + ", " + g.Key.Nombre,
                    CantidadVentas = g.Count(),
                    TotalVendido = g.Sum(v => v.Total)
                })
                .OrderByDescending(r => r.TotalVendido)
                .ToList();

            dgvReportes.DataSource = resultado;
            lblTitulo.Text = "Ventas por vendedor";
        }

        private void ReporteVendedorConMasVentas(TiendaRopaDbContext context)
        {
            var resultado = context.Ventas
                .Where(v => v.Estado)
                .GroupBy(v => new
                {
                    v.VendedorId,
                    v.Vendedor.Nombre,
                    v.Vendedor.Apellido
                })
                .Select(g => new
                {
                    Vendedor = g.Key.Apellido + ", " + g.Key.Nombre,
                    CantidadVentas = g.Count(),
                    TotalVendido = g.Sum(v => v.Total)
                })
                .OrderByDescending(r => r.CantidadVentas)
                .ThenByDescending(r => r.TotalVendido)
                .Take(1)
                .ToList();

            dgvReportes.DataSource = resultado;
            lblTitulo.Text = "Vendedor con mayor cantidad de ventas";
        }

        private void ReporteProductosPorCategoria(TiendaRopaDbContext context)
        {
            var resultado = context.Productos
                .Where(p => p.Estado)
                .Select(p => new
                {
                    Categoria = p.Categoria != null
                        ? p.Categoria.Nombre
                        : "Sin categoría",
                    Producto = p.Nombre,
                    p.Precio,
                    p.Stock
                })
                .OrderBy(r => r.Categoria)
                .ThenBy(r => r.Producto)
                .ToList();

            dgvReportes.DataSource = resultado;
            lblTitulo.Text = "Productos por categoría";
        }
    }
}
