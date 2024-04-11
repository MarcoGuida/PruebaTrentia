using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTrentia.Model
{
    public class Usuarios
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Usuario { get; set; }
        public string Contras { get; set; }
        public string esSupervisor { get; set; }//No es lo mejor, habría que tratarlo como un bool
    }
}
