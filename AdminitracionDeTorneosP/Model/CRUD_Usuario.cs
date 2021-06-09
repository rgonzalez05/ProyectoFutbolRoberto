using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    public class CRUD_Usuario
    {
        public int ID_Usuario { get; set; }
        public string DPI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Puesto { get; set; }
        public string Rol { get; set; }
        public Boolean Estado { get; set; }
    }
}
