using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Model
{
    class Peticiones //Traté de heredar de Usuarios, pero encontré una incompatibilidad, por falta de tiempo he preferido repetir campos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Peticion { get; set; }
        public string fechaHora { get; set; }
        public string esAceptado { get; set; }
    }
}
