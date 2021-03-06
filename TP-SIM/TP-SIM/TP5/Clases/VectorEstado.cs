using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SIM.TP5.Clases
{
    public class VectorEstado
    {
        public decimal reloj { get; set; }
        public Evento evento { get; set; }
        public double rnd1 { get; set; }
        public decimal t_llegada { get; set; }
        public decimal t_prox_llegada { get; set; }
        public decimal rnd2 { get; set; }
        public decimal t_mantenimiento { get; set; }
        public List<decimal> t_fin_mantenimiento { get; set; }
        public decimal t_remanente_mantenimiento { get; set; }
        public List<Camion> cola_mantenimiento { get; set; }
        public List<Servidor> servidor_mantenimiento { get; set; }
        public decimal rnd3 { get; set; }
        public decimal t_lavado { get; set; }
        public List<decimal> t_fin_lavado { get; set; }
        public List<Camion> cola_lavado { get; set; }
        public List<Servidor> servidor_lavado{ get; set; }
        public List<Camion> camiones { get; set; }
        public decimal tasa_entrada { get; set; }
        public decimal tasa_salida { get; set; }
        public decimal tiempoPermanenciaColaMantenimiento { get; set; }
        public decimal tiempoPermanenciaColaLavado{ get; set; }
        public decimal cantPromCamionesEnColaMantenimiento { get; set; }
        public decimal cantPromCamionesEnColaLavado { get; set; }
        public List<decimal> porc_ocupacion_mecanico { get; set; }
        public List<decimal> porc_ocupacion_lavador { get; set; }
        public decimal porc_camiones_atendidos_sin_esperar { get; set; }

        public decimal t_prox_ataque { get; set; }

        public double rnd4 { get; set; }

        public string ataque { get; set; } = "--";

        public decimal t_fin_ataque_cliente { get; set; }
        public decimal t_fin_ataque_servidor { get; set; }

        public List<Camion> cola_llegada { get; set; }
    }
}
