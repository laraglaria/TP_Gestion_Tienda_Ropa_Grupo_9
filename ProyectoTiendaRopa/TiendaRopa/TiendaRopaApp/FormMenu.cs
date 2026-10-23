
using System;
using System.Windows.Forms;

namespace TiendaRopaApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formulario = new FormProductos();
            formulario.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias formulario = new FormCategorias();
            formulario.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formulario = new FormClientes();
            formulario.ShowDialog();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            FormVendedores formulario = new FormVendedores();
            formulario.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formulario = new FormVentas();
            formulario.ShowDialog();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes formulario = new FormReportes();
            formulario.ShowDialog();
        }

    }
}
