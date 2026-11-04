using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace TiendaRopaApp
{
    public partial class FormMenu : Form
    {
        private readonly IServiceScopeFactory scopeFactory;

        public FormMenu(IServiceScopeFactory scopeFactory)
        {
            InitializeComponent();

            this.scopeFactory = scopeFactory;
        }

        private void AbrirFormulario<TFormulario>()
            where TFormulario : Form
        {
            using (IServiceScope scope = scopeFactory.CreateScope())
            {
                TFormulario formulario =
                    scope.ServiceProvider.GetRequiredService<TFormulario>();

                formulario.ShowDialog(this);

                formulario.Dispose();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCategorias>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVendedores>();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVentas>();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormReportes>();
        }
    }
}
