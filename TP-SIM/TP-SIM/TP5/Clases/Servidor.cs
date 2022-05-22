using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SIM.TP5.Clases
{
    public class Servidor
    {
        public int id { get; set; }
        public Estado estado { get; set; }
        public int tipoServidor { get; set; }
        public double tiempoLibre { get; set; }
    }
}
