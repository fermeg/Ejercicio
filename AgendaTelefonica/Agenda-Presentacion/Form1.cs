using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agenda_Entidades;
using Agenda_LogicaNegocio;

namespace Agenda_Presentacion
{
    public partial class Form1 : Form
    {
        //Creamos la instancia de la clase ContactoBol de la Business Object Layer
        private readonly ContactoBol _contactoBol = new ContactoBol();

        //Creamos una lista de la clase Contacto para guardar las coincidencias de las busquedas
        private List<Contacto> _contactos = new List<Contacto>();

        //Creamos una instancia de la clase FiltroContactos que nos va a servir para pasar todos los parametros de busqueda
        private FiltroContactos _filtroContactos = new FiltroContactos { Nombre = "", Apellido = "", Ciudad = "" };
            
        
        public Form1()
        {
            try
            {
                //El método llamará a la Capa de Negocio para que procese el fichero"
                _contactoBol.CargaFichero();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }

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
                groupBox1.Controls.OfType<TextBox>().ToList().ForEach(o => o.Clear());
            }
        }

        // Método que busca un texto en el nombre, apellido o ciudad, y nos muestra todos los contactos en los que hay alguna coincidencia.
        private void Listar(string texto)
        {
            // El método Listar de la capa de Negocio llamará a la capa de datos y nos devolverá
            // la lista de los contactos en los que encuentre el parametro "texto".
            _contactos = _contactoBol.Listar(texto);

            //Muestra los contacto en el DataGridView
            MostrarDatos();
        }

        // Método que busca en una ciudad determinada, todos los contactos en los que aparezca el texto introducido. 
        private void Buscar(string texto, string ciudad)
        {
            // El método Buscar de la capa de Negocio llamará a la capa de Datos y nos devolverá
            // la lista de los contactos que cumplan las condiciones
            _contactos = _contactoBol.Buscar(texto,ciudad);

            //Muestra los contacto en el DataGridView
            MostrarDatos();
        }

        // Método que pasa Nombre, Apellido o Ciudad a buscar, a través de un objeto
        private void ListarContactosFiltrados(FiltroContactos filtroContactos)
        {
            // El método "ListarContactosFiltrados" de la capa de Negocio llamará a la capa de Datos y nos devolverá
            // la lista de los contactos que cumplan las condiciones
            _contactos = _contactoBol.ListarContactosFiltrados(_filtroContactos);

            //Muestra los contacto en el DataGridView
            MostrarDatos();
        }

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Enter && txtNombre.Text != "")
            {
                e.SuppressKeyPress = true;

                _filtroContactos.Nombre = txtNombre.Text;

                ListarContactosFiltrados(_filtroContactos);
            }
        }

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtApellido.Text != "")
            {
                e.SuppressKeyPress = true;

                _filtroContactos.Apellido = txtApellido.Text;

                ListarContactosFiltrados(_filtroContactos);
            }
            
        }

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtCiudad.Text != "")
            {
                e.SuppressKeyPress = true;

                _filtroContactos.Ciudad = txtCiudad.Text;

                ListarContactosFiltrados(_filtroContactos);
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
            groupBox1.Controls.OfType<TextBox>().ToList().ForEach(o => o.Clear());
            dgvDatos.DataSource = null;
        }

        // Cuando el usuario pulsa "Enter" en el campo, se hace la busqueda con los datos que haya en Nombre, Apellido y Ciudad
        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            _filtroContactos.Nombre = txtNombre.Text;
            _filtroContactos.Apellido = txtApellido.Text;
            _filtroContactos.Ciudad = txtCiudad.Text;

            ListarContactosFiltrados(_filtroContactos);
        }
    }      
}
