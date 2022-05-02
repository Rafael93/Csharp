namespace stock_rafaelgamarra
{
    partial class frm_listaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_listaClientes = new System.Windows.Forms.GroupBox();
            this.dgv_listaClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_listaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_listaClientes
            // 
            this.gbx_listaClientes.Controls.Add(this.dgv_listaClientes);
            this.gbx_listaClientes.Location = new System.Drawing.Point(12, 12);
            this.gbx_listaClientes.Name = "gbx_listaClientes";
            this.gbx_listaClientes.Size = new System.Drawing.Size(662, 432);
            this.gbx_listaClientes.TabIndex = 0;
            this.gbx_listaClientes.TabStop = false;
            this.gbx_listaClientes.Text = "Lista de Clientes";
            this.gbx_listaClientes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_listaClientes
            // 
            this.dgv_listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.apellido,
            this.documento,
            this.fechaNacimiento,
            this.edad,
            this.fechaIngreso,
            this.sexo,
            this.email,
            this.direccion,
            this.numTelefono,
            this.numCelular});
            this.dgv_listaClientes.Location = new System.Drawing.Point(12, 31);
            this.dgv_listaClientes.Name = "dgv_listaClientes";
            this.dgv_listaClientes.Size = new System.Drawing.Size(650, 395);
            this.dgv_listaClientes.TabIndex = 0;
            this.dgv_listaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaClientes_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.HeaderText = "Fecha de Ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // numTelefono
            // 
            this.numTelefono.HeaderText = "Nº Telefóno";
            this.numTelefono.Name = "numTelefono";
            // 
            // numCelular
            // 
            this.numCelular.HeaderText = "Nº Celular";
            this.numCelular.Name = "numCelular";
            // 
            // frm_listaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 469);
            this.Controls.Add(this.gbx_listaClientes);
            this.Name = "frm_listaClientes";
            this.Text = "ListaClientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            this.gbx_listaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_listaClientes;
        private System.Windows.Forms.DataGridView dgv_listaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCelular;
    }
}