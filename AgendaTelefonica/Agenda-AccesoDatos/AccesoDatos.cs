using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Hacemos las importaciones del espacio de nombres de los dos proyectos que referenciamos
using Agenda_Entidades;

namespace Agenda_AccesoDatos
{
    public class ContactoDAL
    {
        // Creo una lista de contactos para cargar en memoria cada uno de los contactos del fichero de texto.
        private List<Contacto> contactos = new List<Contacto>();

        // Creo una lista de contactos para hacer filtros.
        private List<Contacto> _contactos = new List<Contacto>();

        // Variable que almacenará cada línea del fichero que se vaya leyendo
        private String linea;

        
        // Método que carga el fichero en memoria
        public bool CargaFichero(string filePath)
        {

            try
            {   // Abre el fichero de texto usando un strean reader
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Lee una línea y la almacena
                    linea = sr.ReadLine();

                    // Mientras no llegemos al final del fichero de texto
                    while (linea != null)
                    {
                        // Se le pasa una linea del fichero a recortar y el separador. Devuelve una matriz con los datos separados: Nombre+Apellido
                        // , Ciudad y Teléfono.
                        string[] datosContacto = RecortarCadena(linea, '|');

                        // Se le pasa el Nombre+Apellido. Devuelve una matriz con los datos separados: Nombre,Apellido
                        string[] NombreApellidoSeparados = RecortarCadena(datosContacto[0], ' ');

                        //Guardo la linea del fichero de texto en un contacto
                        Contacto contacto = new Contacto
                        {
                                // Asigna al contacto los datos de la linea recién leída.
                                Nombre = NombreApellidoSeparados[0].ToString(),
                                Apellido = NombreApellidoSeparados[1].ToString(),
                                Ciudad = datosContacto[1].ToString(),
                                Telefono = datosContacto[2].ToString()
                        };

                        // Añade el contacto a la lista.
                        contactos.Add(contacto);
                        
                        // Lee la linea siguiente.
                        linea = sr.ReadLine();
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new System.IndexOutOfRangeException("El fichero seleccionado no tiene el formato adecuado");
            }

            return true;
        }

        // Método que busca un texto en el nombre, apellido o ciudad, y devuelve una lista con todos los contactos en los que hay alguna coincidencia.
        public List<Contacto> Listar(string texto)
        {
          
            // Quito los espacios en blanco que pueda haber al principio y al final, y lo paso a mayúsculas para poder hacer las comparaciones
            texto = texto.Trim().ToUpper();
            
            // Utilizo LinQ para seleccionar los contactos que cumplan las condiciones
            _contactos = contactos.Where(c => (c.Nombre.Trim().ToUpper().Contains(texto) || c.Apellido.Trim().ToUpper().Contains(texto) 
                                            || c.Ciudad.Trim().ToUpper().Contains(texto))
                                        ).ToList();
            

            return _contactos;
                
        }

        //El método Buscar llamará a la Capa de Acceso a Datos y nos devolverá
        // la lista de los contactos de una ciudad determinada, en los que aparezca el texto introducido. 
        public List<Contacto> Buscar(string texto, string ciudad)
        {
            // Quito los espacios en blanco que pueda haber al principio y al final, y lo paso a mayúsculas para poder hacer las comparaciones
            texto = texto.Trim().ToUpper();
            ciudad = ciudad.Trim().ToUpper();

            // Utilizo el método StartsWith que busca una subcadena (texto; ciudad) que coincida con el comienzo en una cadena (Nombre;Apellido;Ciudad)
            _contactos = contactos.Where(c =>((c.Nombre.Trim().ToUpper().StartsWith(texto) || c.Apellido.Trim().ToUpper().StartsWith(texto))
                                        && (c.Ciudad.Trim().ToUpper().StartsWith(ciudad)))
                                        ).ToList();

            return _contactos;

        }

        // El método ListarContactosFiltrados nos devolverá la lista de los contactos que cumplan las condiciones.
        // Hace uso del método específico "Equals" para el tipo "Contacto".
        public List<Contacto> ListarContactosFiltrados(Contacto contacto)
        {
            _contactos = contactos.Where(c => c.Equals(contacto)).ToList();

            return _contactos;

        }

        // Método que devuelve una matriz de cadenas que contiene las subcadenas de un string que están delimitadas por "separador"
        public string[] RecortarCadena(string cadena, char separador)
        {
            // Declara Array para almacenar separadamente subcadenas
            string[] subcadenas;

            // Devuelve una matriz de cadenas que contiene las subcadenas de "linea" que están delimitadas por "separador"
            // y se asigna a la matriz unidimensional "subcadenas"
            subcadenas = cadena.Split(separador);

            return subcadenas;
        }

    }
}


   
    



                        

                   

                    
               
            
               
    
