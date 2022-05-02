namespace stock_rafaelgamarra
{
    partial class frm_producto
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_tipoProducto = new System.Windows.Forms.Label();
            this.cmbx_tipoProducto = new System.Windows.Forms.ComboBox();
            this.lbl_unidadMedida = new System.Windows.Forms.Label();
            this.cmbx_unidad_de_medida = new System.Windows.Forms.ComboBox();
            this.lbl_cantidadMinima = new System.Windows.Forms.Label();
            this.txt_cantidad_minima = new System.Windows.Forms.TextBox();
            this.lbl_cantidad_total = new System.Windows.Forms.Label();
            this.txt_cantidad_total = new System.Windows.Forms.TextBox();
            this.lbl_precio_compra = new System.Windows.Forms.Label();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.lbl_margenGanancia = new System.Windows.Forms.Label();
            this.txt_margen_ganancia = new System.Windows.Forms.TextBox();
            this.lbl_precioVenta = new System.Windows.Forms.Label();
            this.txt_precio_de_venta = new System.Windows.Forms.TextBox();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.cmbx_iva = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 29);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(91, 22);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "*Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(113, 29);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(188, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // lbl_tipoProducto
            // 
            this.lbl_tipoProducto.AutoSize = true;
            this.lbl_tipoProducto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tipoProducto.Location = new System.Drawing.Point(307, 29);
            this.lbl_tipoProducto.Name = "lbl_tipoProducto";
            this.lbl_tipoProducto.Size = new System.Drawing.Size(131, 22);
            this.lbl_tipoProducto.TabIndex = 2;
            this.lbl_tipoProducto.Text = "Tipo producto:";
            // 
            // cmbx_tipoProducto
            // 
            this.cmbx_tipoProducto.FormattingEnabled = true;
            this.cmbx_tipoProducto.Items.AddRange(new object[] {
            "Electronica",
            "Informática",
            "Mueblería",
            "Electrodoméstico",
            "Gimnasia",
            "Deporte"});
            this.cmbx_tipoProducto.Location = new System.Drawing.Point(444, 29);
            this.cmbx_tipoProducto.Name = "cmbx_tipoProducto";
            this.cmbx_tipoProducto.Size = new System.Drawing.Size(114, 21);
            this.cmbx_tipoProducto.TabIndex = 3;
            this.cmbx_tipoProducto.Leave += new System.EventHandler(this.cmbx_tipoProducto_Leave);
            // 
            // lbl_unidadMedida
            // 
            this.lbl_unidadMedida.AutoSize = true;
            this.lbl_unidadMedida.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidadMedida.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_unidadMedida.Location = new System.Drawing.Point(18, 91);
            this.lbl_unidadMedida.Name = "lbl_unidadMedida";
            this.lbl_unidadMedida.Size = new System.Drawing.Size(171, 22);
            this.lbl_unidadMedida.TabIndex = 4;
            this.lbl_unidadMedida.Text = "*Unidad de medida:";
            // 
            // cmbx_unidad_de_medida
            // 
            this.cmbx_unidad_de_medida.FormattingEnabled = true;
            this.cmbx_unidad_de_medida.Items.AddRange(new object[] {
            "Unidades"});
            this.cmbx_unidad_de_medida.Location = new System.Drawing.Point(189, 91);
            this.cmbx_unidad_de_medida.Name = "cmbx_unidad_de_medida";
            this.cmbx_unidad_de_medida.Size = new System.Drawing.Size(112, 21);
            this.cmbx_unidad_de_medida.TabIndex = 5;
            this.cmbx_unidad_de_medida.Leave += new System.EventHandler(this.cmbx_unidad_de_medida_Leave);
            // 
            // lbl_cantidadMinima
            // 
            this.lbl_cantidadMinima.AutoSize = true;
            this.lbl_cantidadMinima.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadMinima.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cantidadMinima.Location = new System.Drawing.Point(307, 92);
            this.lbl_cantidadMinima.Name = "lbl_cantidadMinima";
            this.lbl_cantidadMinima.Size = new System.Drawing.Size(158, 22);
            this.lbl_cantidadMinima.TabIndex = 6;
            this.lbl_cantidadMinima.Text = "Cantidad Mínima:";
            // 
            // txt_cantidad_minima
            // 
            this.txt_cantidad_minima.Location = new System.Drawing.Point(471, 92);
            this.txt_cantidad_minima.Name = "txt_cantidad_minima";
            this.txt_cantidad_minima.Size = new System.Drawing.Size(48, 20);
            this.txt_cantidad_minima.TabIndex = 7;
            this.txt_cantidad_minima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_minima_KeyPress);
            this.txt_cantidad_minima.Leave += new System.EventHandler(this.txt_cantidad_minima_Leave);
            // 
            // lbl_cantidad_total
            // 
            this.lbl_cantidad_total.AutoSize = true;
            this.lbl_cantidad_total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_total.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cantidad_total.Location = new System.Drawing.Point(18, 148);
            this.lbl_cantidad_total.Name = "lbl_cantidad_total";
            this.lbl_cantidad_total.Size = new System.Drawing.Size(147, 22);
            this.lbl_cantidad_total.TabIndex = 8;
            this.lbl_cantidad_total.Text = "*Cantidad Total:";
            // 
            // txt_cantidad_total
            // 
            this.txt_cantidad_total.Location = new System.Drawing.Point(162, 148);
            this.txt_cantidad_total.Name = "txt_cantidad_total";
            this.txt_cantidad_total.Size = new System.Drawing.Size(48, 20);
            this.txt_cantidad_total.TabIndex = 9;
            this.txt_cantidad_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_total_KeyPress);
            this.txt_cantidad_total.Leave += new System.EventHandler(this.txt_cantidad_total_Leave);
            // 
            // lbl_precio_compra
            // 
            this.lbl_precio_compra.AutoSize = true;
            this.lbl_precio_compra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_compra.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_precio_compra.Location = new System.Drawing.Point(307, 145);
            this.lbl_precio_compra.Name = "lbl_precio_compra";
            this.lbl_precio_compra.Size = new System.Drawing.Size(150, 22);
            this.lbl_precio_compra.TabIndex = 10;
            this.lbl_precio_compra.Text = "*Precio Compra:";
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.Location = new System.Drawing.Point(453, 147);
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(66, 20);
            this.txt_precio_compra.TabIndex = 11;
            this.txt_precio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_compra_KeyPress);
            this.txt_precio_compra.Leave += new System.EventHandler(this.txt_precio_compra_Leave);
            // 
            // lbl_margenGanancia
            // 
            this.lbl_margenGanancia.AutoSize = true;
            this.lbl_margenGanancia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_margenGanancia.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_margenGanancia.Location = new System.Drawing.Point(21, 207);
            this.lbl_margenGanancia.Name = "lbl_margenGanancia";
            this.lbl_margenGanancia.Size = new System.Drawing.Size(174, 22);
            this.lbl_margenGanancia.TabIndex = 12;
            this.lbl_margenGanancia.Text = "*Margen Ganancia:";
            // 
            // txt_margen_ganancia
            // 
            this.txt_margen_ganancia.Location = new System.Drawing.Point(201, 205);
            this.txt_margen_ganancia.Name = "txt_margen_ganancia";
            this.txt_margen_ganancia.Size = new System.Drawing.Size(73, 20);
            this.txt_margen_ganancia.TabIndex = 13;
            this.txt_margen_ganancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_margen_ganancia_KeyPress);
            this.txt_margen_ganancia.Leave += new System.EventHandler(this.txt_margen_ganancia_Leave);
            // 
            // lbl_precioVenta
            // 
            this.lbl_precioVenta.AutoSize = true;
            this.lbl_precioVenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_precioVenta.Location = new System.Drawing.Point(137, 268);
            this.lbl_precioVenta.Name = "lbl_precioVenta";
            this.lbl_precioVenta.Size = new System.Drawing.Size(143, 22);
            this.lbl_precioVenta.TabIndex = 14;
            this.lbl_precioVenta.Text = "Precio de Venta:";
            // 
            // txt_precio_de_venta
            // 
            this.txt_precio_de_venta.Location = new System.Drawing.Point(286, 268);
            this.txt_precio_de_venta.Name = "txt_precio_de_venta";
            this.txt_precio_de_venta.Size = new System.Drawing.Size(104, 20);
            this.txt_precio_de_venta.TabIndex = 15;
            this.txt_precio_de_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_de_venta_KeyPress);
            this.txt_precio_de_venta.Leave += new System.EventHandler(this.txt_precio_de_venta_Leave);
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_iva.Location = new System.Drawing.Point(307, 204);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(51, 22);
            this.lbl_iva.TabIndex = 16;
            this.lbl_iva.Text = "*IVA";
            // 
            // cmbx_iva
            // 
            this.cmbx_iva.FormattingEnabled = true;
            this.cmbx_iva.Items.AddRange(new object[] {
            "10",
            "5"});
            this.cmbx_iva.Location = new System.Drawing.Point(357, 204);
            this.cmbx_iva.Name = "cmbx_iva";
            this.cmbx_iva.Size = new System.Drawing.Size(68, 21);
            this.cmbx_iva.TabIndex = 17;
            this.cmbx_iva.Leave += new System.EventHandler(this.cmbx_iva_Leave);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.Location = new System.Drawing.Point(235, 325);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(113, 37);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(596, 374);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmbx_iva);
            this.Controls.Add(this.lbl_iva);
            this.Controls.Add(this.txt_precio_de_venta);
            this.Controls.Add(this.lbl_precioVenta);
            this.Controls.Add(this.txt_margen_ganancia);
            this.Controls.Add(this.lbl_margenGanancia);
            this.Controls.Add(this.txt_precio_compra);
            this.Controls.Add(this.lbl_precio_compra);
            this.Controls.Add(this.txt_cantidad_total);
            this.Controls.Add(this.lbl_cantidad_total);
            this.Controls.Add(this.txt_cantidad_minima);
            this.Controls.Add(this.lbl_cantidadMinima);
            this.Controls.Add(this.cmbx_unidad_de_medida);
            this.Controls.Add(this.lbl_unidadMedida);
            this.Controls.Add(this.cmbx_tipoProducto);
            this.Controls.Add(this.lbl_tipoProducto);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_producto";
            this.Text = "Formulario Producto";
            this.Load += new System.EventHandler(this.frm_producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_tipoProducto;
        private System.Windows.Forms.ComboBox cmbx_tipoProducto;
        private System.Windows.Forms.Label lbl_unidadMedida;
        private System.Windows.Forms.ComboBox cmbx_unidad_de_medida;
        private System.Windows.Forms.Label lbl_cantidadMinima;
        private System.Windows.Forms.TextBox txt_cantidad_minima;
        private System.Windows.Forms.Label lbl_cantidad_total;
        private System.Windows.Forms.TextBox txt_cantidad_total;
        private System.Windows.Forms.Label lbl_precio_compra;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.Label lbl_margenGanancia;
        private System.Windows.Forms.TextBox txt_margen_ganancia;
        private System.Windows.Forms.Label lbl_precioVenta;
        private System.Windows.Forms.TextBox txt_precio_de_venta;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.ComboBox cmbx_iva;
        private System.Windows.Forms.Button btn_guardar;
    }
}