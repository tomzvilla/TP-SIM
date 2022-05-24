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
        public decimal tiempoOcupado { get; set; }
        public decimal inicioTiempoCupacion { get; set; }
        public int contadorAtendidos { get; set; }
        public decimal prom_atendidos_x_dia { get; set; }
    }
}
