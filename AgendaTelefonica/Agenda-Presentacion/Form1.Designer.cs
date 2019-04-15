using System;
using System.Windows.Forms;

namespace Agenda_Presentacion
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoBolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBolBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnCiudad,
            this.ColumnTelefono});
            this.dgvDatos.DataSource = this.contactoBolBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(4, 24);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(879, 242);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.37063F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.44291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.55709F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 544);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarContacto);
            this.groupBox1.Controls.Add(this.btnLimpiarCampos);
            this.groupBox1.Controls.Add(this.lblTextoEnCiudad);
            this.groupBox1.Controls.Add(this.txtTextoEnCiudad);
            this.groupBox1.Controls.Add(this.lblCiudadABuscar);
            this.groupBox1.Controls.Add(this.lblCadenaBusqueda);
            this.groupBox1.Controls.Add(this.txtCiudadABuscar);
            this.groupBox1.Controls.Add(this.btnBuscarTextoYCiudad);
            this.groupBox1.Controls.Add(this.txtCadenaBusqueda);
            this.groupBox1.Controls.Add(this.btnBuscarTexto);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(887, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Contactos";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(773, 164);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblTextoEnCiudad
            // 
            this.lblTextoEnCiudad.AutoSize = true;
            this.lblTextoEnCiudad.Location = new System.Drawing.Point(230, 201);
            this.lblTextoEnCiudad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTextoEnCiudad.Name = "lblTextoEnCiudad";
            this.lblTextoEnCiudad.Size = new System.Drawing.Size(87, 20);
            this.lblTextoEnCiudad.TabIndex = 19;
            this.lblTextoEnCiudad.Text = "Texto Libre";
            // 
            // txtTextoEnCiudad
            // 
            this.txtTextoEnCiudad.Location = new System.Drawing.Point(232, 223);
            this.txtTextoEnCiudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextoEnCiudad.Name = "txtTextoEnCiudad";
            this.txtTextoEnCiudad.Size = new System.Drawing.Size(176, 26);
            this.txtTextoEnCiudad.TabIndex = 7;
            // 
            // lblCiudadABuscar
            // 
            this.lblCiudadABuscar.AutoSize = true;
            this.lblCiudadABuscar.Location = new System.Drawing.Point(441, 201);
            this.lblCiudadABuscar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCiudadABuscar.Name = "lblCiudadABuscar";
            this.lblCiudadABuscar.Size = new System.Drawing.Size(59, 20);
            this.lblCiudadABuscar.TabIndex = 17;
            this.lblCiudadABuscar.Text = "Ciudad";
            // 
            // lblCadenaBusqueda
            // 
            this.lblCadenaBusqueda.AutoSize = true;
            this.lblCadenaBusqueda.Location = new System.Drawing.Point(441, 142);
            this.lblCadenaBusqueda.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCadenaBusqueda.Name = "lblCadenaBusqueda";
            this.lblCadenaBusqueda.Size = new System.Drawing.Size(87, 20);
            this.lblCadenaBusqueda.TabIndex = 16;
            this.lblCadenaBusqueda.Text = "Texto Libre";
            // 
            // txtCiudadABuscar
            // 
            this.txtCiudadABuscar.Location = new System.Drawing.Point(445, 223);
            this.txtCiudadABuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCiudadABuscar.Name = "txtCiudadABuscar";
            this.txtCiudadABuscar.Size = new System.Drawing.Size(176, 26);
            this.txtCiudadABuscar.TabIndex = 8;
            // 
            // btnBuscarTextoYCiudad
            // 
            this.btnBuscarTextoYCiudad.Location = new System.Drawing.Point(658, 222);
            this.btnBuscarTextoYCiudad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBuscarTextoYCiudad.Name = "btnBuscarTextoYCiudad";
            this.btnBuscarTextoYCiudad.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarTextoYCiudad.TabIndex = 9;
            this.btnBuscarTextoYCiudad.Text = "Buscar en Ciudad";
            this.btnBuscarTextoYCiudad.UseVisualStyleBackColor = true;
            this.btnBuscarTextoYCiudad.Click += new System.EventHandler(this.btnBuscarTextoYCiudad_Click);
            // 
            // txtCadenaBusqueda
            // 
            this.txtCadenaBusqueda.Location = new System.Drawing.Point(445, 164);
            this.txtCadenaBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCadenaBusqueda.Name = "txtCadenaBusqueda";
            this.txtCadenaBusqueda.Size = new System.Drawing.Size(176, 26);
            this.txtCadenaBusqueda.TabIndex = 5;
            // 
            // btnBuscarTexto
            // 
            this.btnBuscarTexto.Location = new System.Drawing.Point(658, 163);
            this.btnBuscarTexto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBuscarTexto.Name = "btnBuscarTexto";
            this.btnBuscarTexto.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarTexto.TabIndex = 6;
            this.btnBuscarTexto.Text = "Buscar Texto";
            this.btnBuscarTexto.UseVisualStyleBackColor = true;
            this.btnBuscarTexto.Click += new System.EventHandler(this.btnBuscarTexto_Click);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(441, 83);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 20);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(445, 108);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(176, 26);
            this.txtCiudad.TabIndex = 2;
            this.txtCiudad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCiudad_KeyDown);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(229, 83);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(234, 108);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 26);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 83);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 26);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDatos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 268);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(887, 271);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agenda Contactos";
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.Location = new System.Drawing.Point(658, 107);
            this.btnBuscarContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarContacto.TabIndex = 3;
            this.btnBuscarContacto.Text = "Buscar Contacto";
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.MaximumSize = new System.Drawing.Size(1024, 800);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBolBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource contactoBolBindingSource;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

