using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Entidades
{
    // Implementa la interfaz IEquatable<T> con el fin de crear un método específico "Equals" para el tipo "Contacto".
    public class Contacto : IEquatable<Contacto>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }

        public override bool Equals(object obj)
        {
            var _contacto = obj as Contacto;

            if (_contacto == null) return false;

            return Equals(_contacto);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode()
                        ^ this.Nombre.GetHashCode()
                        ^ this.Apellido.GetHashCode()
                        ^ this.Ciudad.GetHashCode()
                        ^ this.Telefono.GetHashCode(); ;
        }

        public bool Equals(Contacto _contacto)
        {
            //¿Se trata de la misma instancia?
            if (ReferenceEquals(this, _contacto)) return true;

            // Devuelvo que los objetos son iguales, si cualquiera de las propiedades comienza por la cadena introducida por el usuario
            // en el textbox que hace referencia a dicha propiedad.
            if ((this.Nombre.Trim().ToUpper().StartsWith(_contacto.Nombre.Trim().ToUpper()))
                && (this.Apellido.Trim().ToUpper().StartsWith(_contacto.Apellido.Trim().ToUpper()))
                && (this.Ciudad.Trim().ToUpper().StartsWith(_contacto.Ciudad.Trim().ToUpper())))

                return true;
            else
                return false;

        }
    }
}
