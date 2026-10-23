using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;

namespace AccesoDatos.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public bool Estado { get; set; }

        public Cliente? Cliente { get; set; }
        public Vendedor? Vendedor { get; set; }

        public List<DetalleVenta> Detalles { get; set; }
            = new List<DetalleVenta>();
    }
}
