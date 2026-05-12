using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsegurADO.Model
{
    public class Poliza
    {
        public int id_poliza { get; set; }
        public int id_cliente { get; set; }
        public int id_seguro { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_final { get; set; }
        public string estado { get; set; }
        public string informe { get; set; }
        public string exclusiones { get; set; }
    }
}
