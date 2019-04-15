using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Entidades
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }

    }

    public class FiltroContactos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ciudad { get; set; }
    }
}
