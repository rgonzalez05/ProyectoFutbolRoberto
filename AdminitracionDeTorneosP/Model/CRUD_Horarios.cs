using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    public class CRUD_Horarios
    {
        public string Dia { get; set; }
        public TimeSpan Hora_Apertura { get; set; }
        public TimeSpan Hora_Cierre { get; set; }
    }
}
