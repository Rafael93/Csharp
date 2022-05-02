namespace stock_rafaelgamarra
{
    partial class frm_cliente
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_nro_de_socio = new System.Windows.Forms.Label();
            this.lbl_documento = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_fecha_de_nacimiento = new System.Windows.Forms.Label();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fecha_de_ingreso = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.rbn_hombre = new System.Windows.Forms.RadioButton();
            this.rbn_mujer = new System.Windows.Forms.RadioButton();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_ciatelefonica = new System.Windows.Forms.Label();
            this.lbl_num_telefono = new System.Windows.Forms.Label();
            this.txt_nuntelefono = new System.Windows.Forms.TextBox();
            this.dtp_fechadeingreso = new System.Windows.Forms.DateTimePicker();
            this.cbx_ciatelefonica = new System.Windows.Forms.ComboBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_telefono = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_numSocio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(94, 77);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(160, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(24, 77);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(74, 17);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "*Nombre:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(292, 75);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(83, 17);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "*Apellidos:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(374, 75);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(177, 20);
            this.txt_apellido.TabIndex = 3;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            this.txt_apellido.Leave += new System.EventHandler(this.txt_apellido_Leave);
            // 
            // lbl_nro_de_socio
            // 
            this.lbl_nro_de_socio.AutoSize = true;
            this.lbl_nro_de_socio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_de_socio.Location = new System.Drawing.Point(24, 33);
            this.lbl_nro_de_socio.Name = "lbl_nro_de_socio";
            this.lbl_nro_de_socio.Size = new System.Drawing.Size(97, 17);
            this.lbl_nro_de_socio.TabIndex = 4;
            this.lbl_nro_de_socio.Text = "Nro de Socio:";
            // 
            // lbl_documento
            // 
            this.lbl_documento.AutoSize = true;
            this.lbl_documento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento.Location = new System.Drawing.Point(24, 131);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(96, 17);
            this.lbl_documento.TabIndex = 5;
            this.lbl_documento.Text = "*Documento:";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(112, 131);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(141, 20);
            this.txt_documento.TabIndex = 6;
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_documento_KeyPress);
            this.txt_documento.Leave += new System.EventHandler(this.txt_documento_Leave);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(292, 131);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 17);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(344, 130);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(207, 20);
            this.txt_email.TabIndex = 8;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // lbl_fecha_de_nacimiento
            // 
            this.lbl_fecha_de_nacimiento.AutoSize = true;
            this.lbl_fecha_de_nacimiento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_de_nacimiento.Location = new System.Drawing.Point(24, 186);
            this.lbl_fecha_de_nacimiento.Name = "lbl_fecha_de_nacimiento";
            this.lbl_fecha_de_nacimiento.Size = new System.Drawing.Size(153, 17);
            this.lbl_fecha_de_nacimiento.TabIndex = 9;
            this.lbl_fecha_de_nacimiento.Text = "*Fecha de Nacimiento";
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(179, 185);
            this.dtp_fechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaNacimiento.TabIndex = 0;
            this.dtp_fechaNacimiento.ValueChanged += new System.EventHandler(this.dtp_fechaNacimiento_ValueChanged);
            this.dtp_fechaNacimiento.Leave += new System.EventHandler(this.dtp_fechaNacimiento_Leave);
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.Location = new System.Drawing.Point(406, 185);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(54, 17);
            this.lbl_edad.TabIndex = 10;
            this.lbl_edad.Text = "*Edad:";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(460, 185);
            this.txt_edad.Multiline = true;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.ReadOnly = true;
            this.txt_edad.Size = new System.Drawing.Size(40, 19);
            this.txt_edad.TabIndex = 11;
            this.txt_edad.Leave += new System.EventHandler(this.txt_edad_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 12;
            // 
            // lbl_fecha_de_ingreso
            // 
            this.lbl_fecha_de_ingreso.AutoSize = true;
            this.lbl_fecha_de_ingreso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_de_ingreso.Location = new System.Drawing.Point(24, 247);
            this.lbl_fecha_de_ingreso.Name = "lbl_fecha_de_ingreso";
            this.lbl_fecha_de_ingreso.Size = new System.Drawing.Size(128, 17);
            this.lbl_fecha_de_ingreso.TabIndex = 13;
            this.lbl_fecha_de_ingreso.Text = "*Fecha de ingreso";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(292, 247);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(53, 17);
            this.lbl_sexo.TabIndex = 15;
            this.lbl_sexo.Text = "*Sexo:";
            // 
            // rbn_hombre
            // 
            this.rbn_hombre.AutoSize = true;
            this.rbn_hombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_hombre.Location = new System.Drawing.Point(345, 247);
            this.rbn_hombre.Name = "rbn_hombre";
            this.rbn_hombre.Size = new System.Drawing.Size(80, 21);
            this.rbn_hombre.TabIndex = 16;
            this.rbn_hombre.TabStop = true;
            this.rbn_hombre.Text = "Hombre";
            this.rbn_hombre.UseVisualStyleBackColor = true;
            this.rbn_hombre.Leave += new System.EventHandler(this.rbn_hombre_Leave);
            // 
            // rbn_mujer
            // 
            this.rbn_mujer.AutoSize = true;
            this.rbn_mujer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_mujer.Location = new System.Drawing.Point(425, 247);
            this.rbn_mujer.Name = "rbn_mujer";
            this.rbn_mujer.Size = new System.Drawing.Size(67, 21);
            this.rbn_mujer.TabIndex = 17;
            this.rbn_mujer.TabStop = true;
            this.rbn_mujer.Text = "Mujer";
            this.rbn_mujer.UseVisualStyleBackColor = true;
            this.rbn_mujer.Leave += new System.EventHandler(this.rbn_mujer_Leave);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(24, 306);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(84, 17);
            this.lbl_direccion.TabIndex = 18;
            this.lbl_direccion.Text = "*Dirección:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(107, 307);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(444, 20);
            this.txt_direccion.TabIndex = 19;
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // lbl_ciatelefonica
            // 
            this.lbl_ciatelefonica.AutoSize = true;
            this.lbl_ciatelefonica.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciatelefonica.Location = new System.Drawing.Point(24, 364);
            this.lbl_ciatelefonica.Name = "lbl_ciatelefonica";
            this.lbl_ciatelefonica.Size = new System.Drawing.Size(101, 17);
            this.lbl_ciatelefonica.TabIndex = 20;
            this.lbl_ciatelefonica.Text = "Cia Telefónica";
            // 
            // lbl_num_telefono
            // 
            this.lbl_num_telefono.AutoSize = true;
            this.lbl_num_telefono.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_telefono.Location = new System.Drawing.Point(292, 364);
            this.lbl_num_telefono.Name = "lbl_num_telefono";
            this.lbl_num_telefono.Size = new System.Drawing.Size(106, 17);
            this.lbl_num_telefono.TabIndex = 22;
            this.lbl_num_telefono.Text = "Nº de telefóno:";
            // 
            // txt_nuntelefono
            // 
            this.txt_nuntelefono.Location = new System.Drawing.Point(420, 386);
            this.txt_nuntelefono.Name = "txt_nuntelefono";
            this.txt_nuntelefono.Size = new System.Drawing.Size(131, 20);
            this.txt_nuntelefono.TabIndex = 23;
            this.txt_nuntelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nun_telefono_KeyPress);
            this.txt_nuntelefono.Leave += new System.EventHandler(this.txt_nuntelefono_Leave);
            // 
            // dtp_fechadeingreso
            // 
            this.dtp_fechadeingreso.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechadeingreso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechadeingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechadeingreso.Location = new System.Drawing.Point(150, 243);
            this.dtp_fechadeingreso.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_fechadeingreso.Name = "dtp_fechadeingreso";
            this.dtp_fechadeingreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fechadeingreso.Size = new System.Drawing.Size(93, 22);
            this.dtp_fechadeingreso.TabIndex = 24;
            this.dtp_fechadeingreso.Leave += new System.EventHandler(this.dtp_fechadeingreso_Leave);
            // 
            // cbx_ciatelefonica
            // 
            this.cbx_ciatelefonica.FormattingEnabled = true;
            this.cbx_ciatelefonica.Items.AddRange(new object[] {
            "Tigo",
            "Personal",
            "Claro"});
            this.cbx_ciatelefonica.Location = new System.Drawing.Point(28, 386);
            this.cbx_ciatelefonica.Name = "cbx_ciatelefonica";
            this.cbx_ciatelefonica.Size = new System.Drawing.Size(121, 21);
            this.cbx_ciatelefonica.TabIndex = 25;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(155, 387);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(131, 20);
            this.txt_celular.TabIndex = 26;
            this.txt_celular.Leave += new System.EventHandler(this.txt_celular_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nº de celular";
            // 
            // cbx_telefono
            // 
            this.cbx_telefono.FormattingEnabled = true;
            this.cbx_telefono.Items.AddRange(new object[] {
            "Copaco"});
            this.cbx_telefono.Location = new System.Drawing.Point(296, 386);
            this.cbx_telefono.Name = "cbx_telefono";
            this.cbx_telefono.Size = new System.Drawing.Size(121, 21);
            this.cbx_telefono.TabIndex = 28;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guardar.Location = new System.Drawing.Point(342, 430);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 29);
            this.btn_guardar.TabIndex = 29;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_numSocio
            // 
            this.txt_numSocio.Location = new System.Drawing.Point(127, 30);
            this.txt_numSocio.Name = "txt_numSocio";
            this.txt_numSocio.Size = new System.Drawing.Size(100, 20);
            this.txt_numSocio.TabIndex = 30;
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(592, 471);
            this.Controls.Add(this.txt_numSocio);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cbx_telefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.cbx_ciatelefonica);
            this.Controls.Add(this.dtp_fechadeingreso);
            this.Controls.Add(this.txt_nuntelefono);
            this.Controls.Add(this.lbl_num_telefono);
            this.Controls.Add(this.lbl_ciatelefonica);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.rbn_mujer);
            this.Controls.Add(this.rbn_hombre);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_fecha_de_ingreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.lbl_fecha_de_nacimiento);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.lbl_documento);
            this.Controls.Add(this.lbl_nro_de_socio);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Cliente";
            this.Load += new System.EventHandler(this.frm_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_nro_de_socio;
        private System.Windows.Forms.Label lbl_documento;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_fecha_de_nacimiento;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fecha_de_ingreso;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.RadioButton rbn_hombre;
        private System.Windows.Forms.RadioButton rbn_mujer;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_ciatelefonica;
        private System.Windows.Forms.Label lbl_num_telefono;
        private System.Windows.Forms.TextBox txt_nuntelefono;
        private System.Windows.Forms.DateTimePicker dtp_fechadeingreso;
        private System.Windows.Forms.ComboBox cbx_ciatelefonica;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_telefono;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_numSocio;
    }
}