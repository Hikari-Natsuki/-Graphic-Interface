using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaDonChucho.Modelo
{
    public class Empleado
    {
        public int Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public double Salario_base { get; set; }
        public string Genero { get; set; }
    }
}
