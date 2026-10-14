using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public bool Estado { get; set; } = true;
        public List<Venta> Venta { get; set; } = new();
    }
}
