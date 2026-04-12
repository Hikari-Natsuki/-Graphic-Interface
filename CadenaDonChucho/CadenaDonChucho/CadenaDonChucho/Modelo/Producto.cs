using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDonChucho.Modelo
{
    public class Producto
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad_disponible { get; set; }
        
        public Producto() { }
        
    }
}
