using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agenda_AccesoDatos;
using Agenda_Entidades;


namespace Agenda_LogicaNegocio
{
    public class ContactoBol
    {
        //Instanciamos nuestra clase ContactoDal de la Capa de Acceso a Datos para poder utilizar sus miembros
        private ContactoDAL _contactoDal = new ContactoDAL();
        
        //El método llamará a la Capa de Acceso a Datos para que procese el fichero".
        public void CargaFichero()
        {
            try
            {
                _contactoDal.CargaFichero();

            }
            catch(IOException e)
            {

                throw e;
            }
        }

        //El método Listar llamará a la Capa de Acceso a Datos y nos devolverá
        // la lista de los contactos en los que encuentre el parametro "texto".
        public List<Contacto> Listar(string texto)
        {
            return _contactoDal.Listar(texto);
        }

        //El método Buscar llamará a la Capa de Acceso a Datos y nos devolverá
        // la lista de los contactos de una ciudad determinada, en los que aparezca el texto introducido. 
        public List<Contacto> Buscar(string texto, string ciudad)
        {
            return _contactoDal.Buscar(texto,ciudad);
        }

        //El método ListarContactosFiltrados llamará a la Capa de Acceso a Datos y nos devolverá
        // la lista de los contactos que cumplan las condiciones
        public List<Contacto> ListarContactosFiltrados(FiltroContactos filtroContactos)
        {
            return _contactoDal.ListarContactosFiltrados(filtroContactos);
        }
    }
}
