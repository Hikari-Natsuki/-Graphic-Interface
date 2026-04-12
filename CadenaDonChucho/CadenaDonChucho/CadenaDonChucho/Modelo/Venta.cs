using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDonChucho.Modelo
{
    public class Venta
    {
        public string cliente { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public double valor {  get; set; }
        public Venta() { }

        public double calcular()
        {
            return this.cantidad * this.valor;
        }
    }
}
