using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiPlus.Modelo
{
    public class Adquisicion
    {
        public int Id_adquisicion { get; set; }
        public int Id_cliente { get; set; }
        public int Id_servicio { get; set; }
        public string Sede { get; set; } 
    }
}
