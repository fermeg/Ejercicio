using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Hacemos las importaciones del espacio de nombres de los dos proyectos que referenciamos
using Agenda_AccesoDatos;
using Agenda_Entidades;


namespace Agenda_LogicaNegocio
{
    public class ContactoBol
    {
        //Instanciamos nuestra clase ContactoDal de la Capa de Acceso a Datos para poder utilizar sus miembros
        private ContactoDAL _contactoDal = new ContactoDAL();

        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder erroresBol = new StringBuilder();

        //El método llamará a la Capa de Acceso a Datos para que procese el fichero".
        public bool CargaFichero(string filePath)
        {
            try
            {
                _contactoDal.CargaFichero(filePath);
                return true;

            }
            catch(IOException e)
            {

                throw e;
            }
            catch(IndexOutOfRangeException e)
            {

                throw e;
            }
            
        }

        //El método Listar llamará a la Capa de Acceso a Datos y nos devolverá
        // la lista de los contactos en los que encuentre el parametro "texto".
        public List<Contacto> Listar(string texto)
        {
            erroresBol.Clear();

            // Compruebo si el usuario ha introducido datos
            if (string.IsNullOrEmpty(texto))
            {
                // Genero la cadena con el error para que desde la interfaz de usuario, se muestre el error.
                erroresBol.Append("Texto Libre es obligatorio");
                return null;
            }
            else
            {
                return _contactoDal.Listar(texto);
            }          
        }

        //El método Buscar llamará a la Capa de Acceso a Datos y nos devolverá
        // la lista de los contactos de una ciudad determinada, en los que aparezca el texto introducido. 
        public List<Contacto> Buscar(string texto, string ciudad)
        {
            erroresBol.Clear();

            // Compruebo si el usuario ha introducido datos en ambos campos
            if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(ciudad))
            {
                // Genero la cadena con el error para que desde la interfaz de usuario, se muestre el error.
                erroresBol.Append("Texto Libre y Ciudad son obligatorios");
                return null;
            }
            else
            {
                return _contactoDal.Buscar(texto, ciudad);
            }
            
        }

        //El método ListarContactosFiltrados llamará a la Capa de Acceso a Datos y nos devolverá
        // la lista de los contactos que cumplan las condiciones
        public List<Contacto> ListarContactosFiltrados(Contacto contacto)
        {
            erroresBol.Clear();

            // Compruebo si el usuario ha introducido datos en al menos uno de los 3 campos (Nombre;Apellido;Ciudad)
            if (string.IsNullOrEmpty(contacto.Nombre) && string.IsNullOrEmpty(contacto.Apellido) && string.IsNullOrEmpty(contacto.Ciudad))
            {
                // Genero la cadena con el error para que desde la interfaz de usuario, se muestre el error.
                erroresBol.Append("Introduzca al menos un filtro");
                return null;
            }
            else
            {
                return _contactoDal.ListarContactosFiltrados(contacto);
            }
            
        }
    }
}
