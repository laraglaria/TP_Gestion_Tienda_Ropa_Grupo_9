using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Descripcion { get; set; }
        public bool Estado { get; set; } 
        public List<Producto> Producto { get; set; } = new();

    }
}
