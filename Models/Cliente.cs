using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; } 
        public string Email { get; set; } 
        public string Telefono { get; set; } 
        public string Direccion { get; set; } 
        public bool Estado { get; set; } 

        public List<Venta> Venta { get; set; } = new();
    }
}
