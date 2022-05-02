namespace stock_rafaelgamarra
{
    partial class frm_listaProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_listaProductos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Productos";
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.tipoProducto,
            this.unidadMedida,
            this.cantMinima,
            this.cantTotal,
            this.precioCompra,
            this.margenGanancia,
            this.iva,
            this.precioVenta});
            this.dgv_listaProductos.Location = new System.Drawing.Point(19, 29);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.Size = new System.Drawing.Size(838, 449);
            this.dgv_listaProductos.TabIndex = 0;
            this.dgv_listaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaProductos_CellClick);
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
            // tipoProducto
            // 
            this.tipoProducto.HeaderText = "Tipo de Producto";
            this.tipoProducto.Name = "tipoProducto";
            // 
            // unidadMedida
            // 
            this.unidadMedida.HeaderText = "Unidad de Medida";
            this.unidadMedida.Name = "unidadMedida";
            // 
            // cantMinima
            // 
            this.cantMinima.HeaderText = "Cantidad Minima";
            this.cantMinima.Name = "cantMinima";
            // 
            // cantTotal
            // 
            this.cantTotal.HeaderText = "Cantidad Total";
            this.cantTotal.Name = "cantTotal";
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            // 
            // margenGanancia
            // 
            this.margenGanancia.HeaderText = "Margen de Ganancia";
            this.margenGanancia.Name = "margenGanancia";
            // 
            // iva
            // 
            this.iva.HeaderText = "IVA";
            this.iva.Name = "iva";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            // 
            // frm_listaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 508);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_listaProductos";
            this.Text = "frm_listaProductos";
            this.Load += new System.EventHandler(this.frm_listaProductos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_listaProductos;
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
    }
}