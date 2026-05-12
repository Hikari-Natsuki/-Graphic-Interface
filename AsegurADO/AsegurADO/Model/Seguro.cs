using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsegurADO.Model
{
    public class Seguro
    {
        public int id_seguro { get; set; }
        public string tipo_seguro { get; set; }
        public decimal costo { get; set; }
        public int duracion_meses { get; set; }
        public string planes { get; set; }
        public string cobertura { get; set; }
        public string condiciones { get; set; }
        public string productos { get; set; }
    }
}
