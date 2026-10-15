using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace AccesoDatos.Data
{
    public class TiendaRopaDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string rutaBaseDatos = Path.Combine(
                    AppContext.BaseDirectory,
                    "tiendaRopa.db");

                optionsBuilder.UseSqlite(
                    $"Data Source={rutaBaseDatos}");
            }
        }
    }
}


