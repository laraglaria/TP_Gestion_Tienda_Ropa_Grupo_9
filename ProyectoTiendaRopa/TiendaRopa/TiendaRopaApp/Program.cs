
using System;
using System.IO;
using System.Windows.Forms;
using AccesoDatos.Data;
using AccesoDatos.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TiendaRopaApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            string rutaBaseDatos = Path.Combine(
                AppContext.BaseDirectory,
                "tiendaRopa.db");

            // Registrar el contexto de Entity Framework.
            services.AddDbContext<TiendaRopaDbContext>(options =>
                options.UseSqlite(
                    $"Data Source={rutaBaseDatos}"));

            // Registrar el repositorio genérico.
            services.AddScoped(
                typeof(IGenericRepository<>),
                typeof(GenericRepository<>));

            // Registrar los formularios.
            services.AddTransient<FormMenu>();
            services.AddTransient<FormProductos>();
            services.AddTransient<FormCategorias>();
            services.AddTransient<FormClientes>();
            services.AddTransient<FormVendedores>();
            services.AddTransient<FormVentas>();
            services.AddTransient<FormReportes>();

            // Construir el contenedor.
            using (ServiceProvider serviceProvider =
                services.BuildServiceProvider())
            {
                FormMenu menu =
                    serviceProvider.GetRequiredService<FormMenu>();

                Application.Run(menu);
            }
        }
    }
}
