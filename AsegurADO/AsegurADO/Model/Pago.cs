using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsegurADO.Model
{
    public class Pago
    {
        public int id_pago { get; set; }
        public int id_poliza { get; set; }
        public DateTime fecha_pago { get; set; }
        public string banco { get; set; }
        public decimal monto_pagado { get; set; }
        public string forma_pago { get; set; }
        public int cuotas_totales { get; set; }
        public int cuotas_restantes { get; set; }
        public string informe { get; set; }
    }
}
