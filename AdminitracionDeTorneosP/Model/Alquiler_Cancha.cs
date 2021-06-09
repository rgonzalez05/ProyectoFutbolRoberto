using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    public class Alquiler_Cancha
    {
        public int ID { get; set; }
        public int Numero_Cancha { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_Apartada { get; set; }
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Final { get; set; }
        public decimal Precio_Total_Cancha { get; set; }
    }
}
