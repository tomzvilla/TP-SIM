using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SIM.TP5.Clases
{
    public class Camion
    {
        public int id { get; set; }
        public Estado estado { get; set; }
        public double diaInicioAtencion { get; set; }
        public double diaFinAtencion { get; set; }


    }
}
