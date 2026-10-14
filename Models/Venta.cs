using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } 
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; } 

        public List<DetalleVenta> Detalles { get; set; } = new();
    }
}
