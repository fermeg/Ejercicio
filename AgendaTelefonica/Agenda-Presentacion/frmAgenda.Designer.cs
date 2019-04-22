using System;
using System.Windows.Forms;

namespace Agenda_Presentacion
{
    partial class frmAgenda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoBolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpoBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarFichero = new System.Windows.Forms.Button();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblTextoEnCiudad = new System.Windows.Forms.Label();
            this.txtTextoEnCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudadABuscar = new System.Windows.Forms.Label();
            this.lblCadenaBusqueda = new System.Windows.Forms.Label();
            this.txtCiudadABuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarTextoYCiudad = new System.Windows.Forms.Button();
            this.txtCadenaBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscarTexto = new System.Windows.Forms.Button();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpoBoxAgenda = new System.Windows.Forms.GroupBox();
            this.abrirFicheroDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBolBindingSource)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.grpoBoxDatos.SuspendLayout();
            this.grpoBoxAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnCiudad,
            this.ColumnTelefono});
            this.dgvDatos.DataSource = this.contactoBolBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(6, 21);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.Size = new System.Drawing.Size(859, 236);
            this.dgvDatos.TabIndex = 0;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.Name = "ColumnApellido";
            this.ColumnApellido.ReadOnly = true;
            // 
            // ColumnCiudad
            // 
            this.ColumnCiudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCiudad.HeaderText = "Ciudad";
            this.ColumnCiudad.Name = "ColumnCiudad";
            this.ColumnCiudad.ReadOnly = true;
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            this.ColumnTelefono.ReadOnly = true;
            // 
            // contactoBolBindingSource
            // 
            this.contactoBolBindingSource.DataSource = typeof(Agenda_LogicaNegocio.ContactoBol);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.37063F));
            this.tableLayoutPanel.Controls.Add(this.grpoBoxDatos, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.grpoBoxAgenda, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.44291F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.55709F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(883, 544);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // grpoBoxDatos
            // 
            this.grpoBoxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpoBoxDatos.AutoSize = true;
            this.grpoBoxDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpoBoxDatos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpoBoxDatos.Controls.Add(this.btnSeleccionarFichero);
            this.grpoBoxDatos.Controls.Add(this.btnBuscarContacto);
            this.grpoBoxDatos.Controls.Add(this.btnLimpiarCampos);
            this.grpoBoxDatos.Controls.Add(this.lblTextoEnCiudad);
            this.grpoBoxDatos.Controls.Add(this.txtTextoEnCiudad);
            this.grpoBoxDatos.Controls.Add(this.lblCiudadABuscar);
            this.grpoBoxDatos.Controls.Add(this.lblCadenaBusqueda);
            this.grpoBoxDatos.Controls.Add(this.txtCiudadABuscar);
            this.grpoBoxDatos.Controls.Add(this.btnBuscarTextoYCiudad);
            this.grpoBoxDatos.Controls.Add(this.txtCadenaBusqueda);
            this.grpoBoxDatos.Controls.Add(this.btnBuscarTexto);
            this.grpoBoxDatos.Controls.Add(this.lblCiudad);
            this.grpoBoxDatos.Controls.Add(this.txtCiudad);
            this.grpoBoxDatos.Controls.Add(this.lblApellido);
            this.grpoBoxDatos.Controls.Add(this.txtApellido);
            this.grpoBoxDatos.Controls.Add(this.lblNombre);
            this.grpoBoxDatos.Controls.Add(this.txtNombre);
            this.grpoBoxDatos.Location = new System.Drawing.Point(6, 8);
            this.grpoBoxDatos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpoBoxDatos.Name = "grpoBoxDatos";
            this.grpoBoxDatos.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpoBoxDatos.Size = new System.Drawing.Size(871, 247);
            this.grpoBoxDatos.TabIndex = 3;
            this.grpoBoxDatos.TabStop = false;
            this.grpoBoxDatos.Text = "Datos Contactos";
            // 
            // btnSeleccionarFichero
            // 
            this.btnSeleccionarFichero.Location = new System.Drawing.Point(690, 84);
            this.btnSeleccionarFichero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarFichero.Name = "btnSeleccionarFichero";
            this.btnSeleccionarFichero.Size = new System.Drawing.Size(128, 26);
            this.btnSeleccionarFichero.TabIndex = 20;
            this.btnSeleccionarFichero.Text = "Seleccionar Fichero";
            this.btnSeleccionarFichero.UseVisualStyleBackColor = true;
            this.btnSeleccionarFichero.Click += new System.EventHandler(this.btnSeleccionarFichero_Click);
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.Location = new System.Drawing.Point(515, 59);
            this.btnBuscarContacto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(128, 26);
            this.btnBuscarContacto.TabIndex = 3;
            this.btnBuscarContacto.Text = "Buscar Contacto";
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(690, 134);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(128, 26);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblTextoEnCiudad
            // 
            this.lblTextoEnCiudad.AutoSize = true;
            this.lblTextoEnCiudad.Location = new System.Drawing.Point(175, 142);
            this.lblTextoEnCiudad.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblTextoEnCiudad.Name = "lblTextoEnCiudad";
            this.lblTextoEnCiudad.Size = new System.Drawing.Size(60, 13);
            this.lblTextoEnCiudad.TabIndex = 19;
            this.lblTextoEnCiudad.Text = "Texto Libre";
            // 
            // txtTextoEnCiudad
            // 
            this.txtTextoEnCiudad.Location = new System.Drawing.Point(175, 162);
            this.txtTextoEnCiudad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTextoEnCiudad.Name = "txtTextoEnCiudad";
            this.txtTextoEnCiudad.Size = new System.Drawing.Size(128, 20);
            this.txtTextoEnCiudad.TabIndex = 7;
            // 
            // lblCiudadABuscar
            // 
            this.lblCiudadABuscar.AutoSize = true;
            this.lblCiudadABuscar.Location = new System.Drawing.Point(341, 142);
            this.lblCiudadABuscar.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblCiudadABuscar.Name = "lblCiudadABuscar";
            this.lblCiudadABuscar.Size = new System.Drawing.Size(40, 13);
            this.lblCiudadABuscar.TabIndex = 17;
            this.lblCiudadABuscar.Text = "Ciudad";
            // 
            // lblCadenaBusqueda
            // 
            this.lblCadenaBusqueda.AutoSize = true;
            this.lblCadenaBusqueda.Location = new System.Drawing.Point(341, 92);
            this.lblCadenaBusqueda.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblCadenaBusqueda.Name = "lblCadenaBusqueda";
            this.lblCadenaBusqueda.Size = new System.Drawing.Size(60, 13);
            this.lblCadenaBusqueda.TabIndex = 16;
            this.lblCadenaBusqueda.Text = "Texto Libre";
            // 
            // txtCiudadABuscar
            // 
            this.txtCiudadABuscar.Location = new System.Drawing.Point(345, 162);
            this.txtCiudadABuscar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCiudadABuscar.Name = "txtCiudadABuscar";
            this.txtCiudadABuscar.Size = new System.Drawing.Size(128, 20);
            this.txtCiudadABuscar.TabIndex = 8;
            // 
            // btnBuscarTextoYCiudad
            // 
            this.btnBuscarTextoYCiudad.Location = new System.Drawing.Point(515, 159);
            this.btnBuscarTextoYCiudad.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnBuscarTextoYCiudad.Name = "btnBuscarTextoYCiudad";
            this.btnBuscarTextoYCiudad.Size = new System.Drawing.Size(128, 26);
            this.btnBuscarTextoYCiudad.TabIndex = 9;
            this.btnBuscarTextoYCiudad.Text = "Buscar en Ciudad";
            this.btnBuscarTextoYCiudad.UseVisualStyleBackColor = true;
            this.btnBuscarTextoYCiudad.Click += new System.EventHandler(this.btnBuscarTextoYCiudad_Click);
            // 
            // txtCadenaBusqueda
            // 
            this.txtCadenaBusqueda.Location = new System.Drawing.Point(345, 112);
            this.txtCadenaBusqueda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCadenaBusqueda.Name = "txtCadenaBusqueda";
            this.txtCadenaBusqueda.Size = new System.Drawing.Size(128, 20);
            this.txtCadenaBusqueda.TabIndex = 5;
            // 
            // btnBuscarTexto
            // 
            this.btnBuscarTexto.Location = new System.Drawing.Point(515, 109);
            this.btnBuscarTexto.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnBuscarTexto.Name = "btnBuscarTexto";
            this.btnBuscarTexto.Size = new System.Drawing.Size(128, 26);
            this.btnBuscarTexto.TabIndex = 6;
            this.btnBuscarTexto.Text = "Buscar Texto";
            this.btnBuscarTexto.UseVisualStyleBackColor = true;
            this.btnBuscarTexto.Click += new System.EventHandler(this.btnBuscarTexto_Click);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(341, 41);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(345, 62);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(128, 20);
            this.txtCiudad.TabIndex = 2;
            this.txtCiudad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCiudad_KeyDown);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(175, 41);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(175, 62);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(128, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 42);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(5, 62);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // grpoBoxAgenda
            // 
            this.grpoBoxAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpoBoxAgenda.Controls.Add(this.dgvDatos);
            this.grpoBoxAgenda.Location = new System.Drawing.Point(6, 271);
            this.grpoBoxAgenda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpoBoxAgenda.Name = "grpoBoxAgenda";
            this.grpoBoxAgenda.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpoBoxAgenda.Size = new System.Drawing.Size(871, 265);
            this.grpoBoxAgenda.TabIndex = 4;
            this.grpoBoxAgenda.TabStop = false;
            this.grpoBoxAgenda.Text = "Agenda Contactos";
            // 
            // abrirFicheroDialog
            // 
            this.abrirFicheroDialog.FileName = "AgendaTelefonica.txt";
            this.abrirFicheroDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 544);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.Name = "frmAgenda";
            this.Text = "Agenda Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBolBindingSource)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.grpoBoxDatos.ResumeLayout(false);
            this.grpoBoxDatos.PerformLayout();
            this.grpoBoxAgenda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource contactoBolBindingSource;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpoBoxDatos;
        private System.Windows.Forms.GroupBox grpoBoxAgenda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBuscarTexto;
        private TextBox txtCadenaBusqueda;
        private Button btnBuscarTextoYCiudad;
        private TextBox txtCiudadABuscar;
        private Label lblTextoEnCiudad;
        private TextBox txtTextoEnCiudad;
        private Label lblCiudadABuscar;
        private Label lblCadenaBusqueda;
        private Button btnLimpiarCampos;
        private Button btnBuscarContacto;
        private OpenFileDialog abrirFicheroDialog;
        private Button btnSeleccionarFichero;
    }
}

