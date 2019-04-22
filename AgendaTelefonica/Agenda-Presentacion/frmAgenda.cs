using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

//Hacemos las importaciones del espacio de nombres de los dos proyectos que referenciamos.
//En esta capa solo referencio a Agenda_LogicNegocio y a Agenda_Entidades
//y no se referencia a la clase de acceso a Datos.
using Agenda_Entidades;
using Agenda_LogicaNegocio;

namespace Agenda_Presentacion
{
    public partial class frmAgenda : Form
    {
        //Creamos la instancia de la clase ContactoBol de la Business Object Layer
        private readonly ContactoBol _contactoBol = new ContactoBol();

        //Creamos una lista de la clase Contacto para guardar las coincidencias de las busquedas
        private List<Contacto> _contactos = new List<Contacto>();

        //Creamos una instancia de la clase Contacto que nos va a servir para pasar todos los parametros de busqueda
        private Contacto _contacto = new Contacto();

        //Para controlar si se ha cargado el fichero para que el usuario pueda hacer consultas o no.
        bool ficheroCargado = false;



        public frmAgenda()
        {
            InitializeComponent();
        }

        // Método que muestra los contacto en el DataGridView
        private void MostrarDatos()
        {
            // Establezco la lista obtenida como el origen de datos del DataGridView.
            if (_contactos.Count > 0)
            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = _contactos;
                dgvDatos.Columns["columnNombre"].DataPropertyName = "Nombre";
                dgvDatos.Columns["columnApellido"].DataPropertyName = "Apellido";
                dgvDatos.Columns["columnCiudad"].DataPropertyName = "Ciudad";
                dgvDatos.Columns["columnTelefono"].DataPropertyName = "Telefono";
            }
            else
            {
                dgvDatos.DataSource = _contactos;
                MessageBox.Show("No existen contactos");
            }
        }

        // Método que busca un texto en el nombre, apellido o ciudad, y nos muestra todos los contactos en los que hay alguna coincidencia.
        private void Listar(string texto)
        {
            if (ficheroCargado)
            {
                // El método Listar de la capa de Negocio llamará a la capa de datos y nos devolverá
                // la lista de los contactos en los que encuentre el parametro "texto".
                _contactos = _contactoBol.Listar(texto);

                // Si los parametros no cumplían las reglas de negocio.
                if (_contactoBol.erroresBol.Length != 0)
                {
                    MessageBox.Show(_contactoBol.erroresBol.ToString());
                }
                else
                {
                    //Muestra los contacto en el DataGridView
                    MostrarDatos();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún fichero cargado");
            }
        }

        // Método que busca en una ciudad determinada, todos los contactos en los que aparezca el texto introducido. 
        private void Buscar(string texto, string ciudad)
        {
            if (ficheroCargado)
            {
                // El método Buscar de la capa de Negocio llamará a la capa de Datos y nos devolverá
                // la lista de los contactos que cumplan las condiciones
                _contactos = _contactoBol.Buscar(texto, ciudad);

                // Si los parametros no cumplían las reglas de negocio.
                if (_contactoBol.erroresBol.Length != 0)
                {
                    MessageBox.Show(_contactoBol.erroresBol.ToString());
                }
                else
                {
                    //Muestra los contacto en el DataGridView
                    MostrarDatos();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún fichero cargado");
            }
        }

        // Método que pasa Nombre, Apellido o Ciudad a buscar, a través de un objeto
        private void ListarContactosFiltrados(Contacto contacto)
        {
            if (ficheroCargado)
            {
                // El método "ListarContactosFiltrados" de la capa de Negocio llamará a la capa de Datos y nos devolverá
                // la lista de los contactos que cumplan las condiciones
                _contactos = _contactoBol.ListarContactosFiltrados(_contacto);

                // Si los parametros no cumplían las reglas de negocio.
                if (_contactoBol.erroresBol.Length != 0)
                {
                    MessageBox.Show(_contactoBol.erroresBol.ToString());
                }
                else
                {
                    //Muestra los contacto en el DataGridView
                    MostrarDatos();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún fichero cargado");
            }
}

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                _contacto.Nombre = txtNombre.Text;
                _contacto.Apellido = txtApellido.Text;
                _contacto.Ciudad = txtCiudad.Text;

                ListarContactosFiltrados(_contacto);
            }
        }

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                _contacto.Nombre = txtNombre.Text;
                _contacto.Apellido = txtApellido.Text;
                _contacto.Ciudad = txtCiudad.Text;

                ListarContactosFiltrados(_contacto);
            }
            
        }

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                _contacto.Nombre = txtNombre.Text;
                _contacto.Apellido = txtApellido.Text;
                _contacto.Ciudad = txtCiudad.Text;

                ListarContactosFiltrados(_contacto);
            }
        }


        // Cuando pulsan el botón se llama al método que nos busca el texto en Nombre o Apellido, en una ciudad determinada.
        private void btnBuscarTextoYCiudad_Click(object sender, EventArgs e)
        {
            Buscar(txtTextoEnCiudad.Text,txtCiudadABuscar.Text);
        }

        // Cuando pulsan el botón se llama al método que nos busca el texto en Nombre o Apellido o Ciudad de todos los contactos.
        private void btnBuscarTexto_Click(object sender, EventArgs e)
        {
            Listar(txtCadenaBusqueda.Text);
        }

        // Vacía todos los Textbox y el DataGridView
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            grpoBoxDatos.Controls.OfType<TextBox>().ToList().ForEach(o => o.Clear());
            dgvDatos.DataSource = null;
        }

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            _contacto.Nombre = txtNombre.Text;
            _contacto.Apellido = txtApellido.Text;
            _contacto.Ciudad = txtCiudad.Text;

            ListarContactosFiltrados(_contacto);
        }
        // Al pulsar este botón, el usuario podrá seleccionar el fichero de texto que contiene la agenda
        private void btnSeleccionarFichero_Click(object sender, EventArgs e)
        {
            if (abrirFicheroDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = abrirFicheroDialog.FileName;
                CargaFichero(filePath);
            }
        }

        private void CargaFichero(string filePath)
        {
            try
            {
                //El método llamará a la Capa de Negocio para que procese el fichero.
                if (_contactoBol.CargaFichero(filePath))
                {
                    MessageBox.Show("Fichero procesado correctamente");
                    ficheroCargado = true;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);        
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message);   
            }
        }

       
    }      
}
