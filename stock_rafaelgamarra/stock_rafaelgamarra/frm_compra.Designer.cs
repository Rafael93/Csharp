namespace stock_rafaelgamarra
{
    partial class frm_compra
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
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_numBoleta = new System.Windows.Forms.Label();
            this.lbl_fechaRecepcion = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precioUnit = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_compra = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nroBoleta = new System.Windows.Forms.TextBox();
            this.cbx_proveedores = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cbx_productos = new System.Windows.Forms.ComboBox();
            this.dtp_fechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_compra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(22, 23);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(78, 19);
            this.lbl_proveedor.TabIndex = 0;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(22, 93);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(49, 19);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(22, 162);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(68, 19);
            this.lbl_producto.TabIndex = 2;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_numBoleta
            // 
            this.lbl_numBoleta.AutoSize = true;
            this.lbl_numBoleta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numBoleta.Location = new System.Drawing.Point(324, 23);
            this.lbl_numBoleta.Name = "lbl_numBoleta";
            this.lbl_numBoleta.Size = new System.Drawing.Size(87, 19);
            this.lbl_numBoleta.TabIndex = 3;
            this.lbl_numBoleta.Text = "Nro. Boleta";
            // 
            // lbl_fechaRecepcion
            // 
            this.lbl_fechaRecepcion.AutoSize = true;
            this.lbl_fechaRecepcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaRecepcion.Location = new System.Drawing.Point(324, 93);
            this.lbl_fechaRecepcion.Name = "lbl_fechaRecepcion";
            this.lbl_fechaRecepcion.Size = new System.Drawing.Size(137, 19);
            this.lbl_fechaRecepcion.TabIndex = 4;
            this.lbl_fechaRecepcion.Text = "Fecha de recepción";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(324, 162);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(69, 19);
            this.lbl_cantidad.TabIndex = 5;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_precioUnit
            // 
            this.lbl_precioUnit.AutoSize = true;
            this.lbl_precioUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioUnit.Location = new System.Drawing.Point(464, 162);
            this.lbl_precioUnit.Name = "lbl_precioUnit";
            this.lbl_precioUnit.Size = new System.Drawing.Size(109, 19);
            this.lbl_precioUnit.TabIndex = 6;
            this.lbl_precioUnit.Text = "Precio Unitario";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_agregar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(662, 150);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(80, 31);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(405, 489);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(80, 31);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(299, 489);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 31);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // gb_compra
            // 
            this.gb_compra.Controls.Add(this.dataGridView1);
            this.gb_compra.Location = new System.Drawing.Point(12, 196);
            this.gb_compra.Name = "gb_compra";
            this.gb_compra.Size = new System.Drawing.Size(736, 287);
            this.gb_compra.TabIndex = 10;
            this.gb_compra.TabStop = false;
            this.gb_compra.Text = "Compra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.cantidad,
            this.precioUnit,
            this.subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precioUnit
            // 
            this.precioUnit.HeaderText = "Precio Unitario";
            this.precioUnit.Name = "precioUnit";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // txt_nroBoleta
            // 
            this.txt_nroBoleta.Location = new System.Drawing.Point(417, 23);
            this.txt_nroBoleta.Name = "txt_nroBoleta";
            this.txt_nroBoleta.Size = new System.Drawing.Size(192, 20);
            this.txt_nroBoleta.TabIndex = 11;
            // 
            // cbx_proveedores
            // 
            this.cbx_proveedores.FormattingEnabled = true;
            this.cbx_proveedores.Location = new System.Drawing.Point(107, 21);
            this.cbx_proveedores.Name = "cbx_proveedores";
            this.cbx_proveedores.Size = new System.Drawing.Size(135, 21);
            this.cbx_proveedores.TabIndex = 12;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(77, 91);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 13;
            // 
            // cbx_productos
            // 
            this.cbx_productos.FormattingEnabled = true;
            this.cbx_productos.Location = new System.Drawing.Point(96, 160);
            this.cbx_productos.Name = "cbx_productos";
            this.cbx_productos.Size = new System.Drawing.Size(135, 21);
            this.cbx_productos.TabIndex = 14;
            // 
            // dtp_fechaRecepcion
            // 
            this.dtp_fechaRecepcion.Location = new System.Drawing.Point(467, 91);
            this.dtp_fechaRecepcion.Name = "dtp_fechaRecepcion";
            this.dtp_fechaRecepcion.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaRecepcion.TabIndex = 15;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(399, 161);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(56, 20);
            this.txt_cantidad.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 17;
            // 
            // frm_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(760, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.dtp_fechaRecepcion);
            this.Controls.Add(this.cbx_productos);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.cbx_proveedores);
            this.Controls.Add(this.txt_nroBoleta);
            this.Controls.Add(this.gb_compra);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_precioUnit);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_fechaRecepcion);
            this.Controls.Add(this.lbl_numBoleta);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_proveedor);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frm_compra";
            this.Text = "Compra";
            this.gb_compra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_numBoleta;
        private System.Windows.Forms.Label lbl_fechaRecepcion;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precioUnit;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gb_compra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.TextBox txt_nroBoleta;
        private System.Windows.Forms.ComboBox cbx_proveedores;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cbx_productos;
        private System.Windows.Forms.DateTimePicker dtp_fechaRecepcion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox textBox1;
    }
}