using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaRopa.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Descripcion { get; set; } 
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; } = true;
        
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } 
    }
}
