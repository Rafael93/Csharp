namespace stock_rafaelgamarra
{
    partial class frm_principal
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
            this.menuItem_administracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_nuevoProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_listaProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_nuevoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_listaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.ivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_nuevoIva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_listaIva = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_nuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_listaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_compra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_nuevaCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_listaCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_venta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_nuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_listaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItem_administracion
            // 
            this.menuItem_administracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_proveedor,
            this.productoToolStripMenuItem,
            this.ivaToolStripMenuItem});
            this.menuItem_administracion.Name = "menuItem_administracion";
            this.menuItem_administracion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.menuItem_administracion.Size = new System.Drawing.Size(101, 20);
            this.menuItem_administracion.Text = "Aḏministracion";
            // 
            // menuItem_proveedor
            // 
            this.menuItem_proveedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_nuevoProveedor,
            this.menuItem_listaProveedor});
            this.menuItem_proveedor.Name = "menuItem_proveedor";
            this.menuItem_proveedor.Size = new System.Drawing.Size(152, 22);
            this.menuItem_proveedor.Text = "Proveedor";
            // 
            // menuItem_nuevoProveedor
            // 
            this.menuItem_nuevoProveedor.Name = "menuItem_nuevoProveedor";
            this.menuItem_nuevoProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.menuItem_nuevoProveedor.Size = new System.Drawing.Size(175, 22);
            this.menuItem_nuevoProveedor.Text = "Nuevo";
            this.menuItem_nuevoProveedor.Click += new System.EventHandler(this.menuItem_nuevoProveedor_Click);
            // 
            // menuItem_listaProveedor
            // 
            this.menuItem_listaProveedor.Name = "menuItem_listaProveedor";
            this.menuItem_listaProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuItem_listaProveedor.Size = new System.Drawing.Size(175, 22);
            this.menuItem_listaProveedor.Text = "Lista";
            this.menuItem_listaProveedor.Click += new System.EventHandler(this.menuItem_listaProveedor_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_nuevoProducto,
            this.menuItem_listaProducto});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // menuItem_nuevoProducto
            // 
            this.menuItem_nuevoProducto.Name = "menuItem_nuevoProducto";
            this.menuItem_nuevoProducto.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.menuItem_nuevoProducto.Size = new System.Drawing.Size(176, 22);
            this.menuItem_nuevoProducto.Text = "Nuevo";
            this.menuItem_nuevoProducto.Click += new System.EventHandler(this.menuItem_nuevoProducto_Click);
            // 
            // menuItem_listaProducto
            // 
            this.menuItem_listaProducto.Name = "menuItem_listaProducto";
            this.menuItem_listaProducto.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.menuItem_listaProducto.Size = new System.Drawing.Size(176, 22);
            this.menuItem_listaProducto.Text = "Lista";
            this.menuItem_listaProducto.Click += new System.EventHandler(this.menuItem_listaProducto_Click);
            // 
            // ivaToolStripMenuItem
            // 
            this.ivaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_nuevoIva,
            this.menuItem_listaIva});
            this.ivaToolStripMenuItem.Name = "ivaToolStripMenuItem";
            this.ivaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ivaToolStripMenuItem.Text = "Iva";
            // 
            // menuItem_nuevoIva
            // 
            this.menuItem_nuevoIva.Name = "menuItem_nuevoIva";
            this.menuItem_nuevoIva.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.menuItem_nuevoIva.Size = new System.Drawing.Size(171, 22);
            this.menuItem_nuevoIva.Text = "Nuevo";
            this.menuItem_nuevoIva.Click += new System.EventHandler(this.menuItem_NuevoIva_Click);
            // 
            // menuItem_listaIva
            // 
            this.menuItem_listaIva.Name = "menuItem_listaIva";
            this.menuItem_listaIva.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.menuItem_listaIva.Size = new System.Drawing.Size(171, 22);
            this.menuItem_listaIva.Text = "Lista";
            this.menuItem_listaIva.Click += new System.EventHandler(this.menuItem_listaIva_Click);
            // 
            // MenuItem_cliente
            // 
            this.MenuItem_cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_nuevoCliente,
            this.menuItem_listaCliente});
            this.MenuItem_cliente.Name = "MenuItem_cliente";
            this.MenuItem_cliente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.MenuItem_cliente.Size = new System.Drawing.Size(58, 20);
            this.MenuItem_cliente.Text = "Cḻiente";
            // 
            // menuItem_nuevoCliente
            // 
            this.menuItem_nuevoCliente.Name = "menuItem_nuevoCliente";
            this.menuItem_nuevoCliente.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.menuItem_nuevoCliente.Size = new System.Drawing.Size(179, 22);
            this.menuItem_nuevoCliente.Text = "Nuevo";
            this.menuItem_nuevoCliente.Click += new System.EventHandler(this.menuItem_nuevoCliente_Click);
            // 
            // menuItem_listaCliente
            // 
            this.menuItem_listaCliente.Name = "menuItem_listaCliente";
            this.menuItem_listaCliente.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.menuItem_listaCliente.Size = new System.Drawing.Size(179, 22);
            this.menuItem_listaCliente.Text = "Listar";
            this.menuItem_listaCliente.Click += new System.EventHandler(this.menuItem_listaCliente_Click);
            // 
            // menuItem_compra
            // 
            this.menuItem_compra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_nuevaCompra,
            this.menuItem_listaCompra});
            this.menuItem_compra.Name = "menuItem_compra";
            this.menuItem_compra.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.menuItem_compra.Size = new System.Drawing.Size(61, 20);
            this.menuItem_compra.Text = "Compṟa";
            // 
            // menuItem_nuevaCompra
            // 
            this.menuItem_nuevaCompra.Name = "menuItem_nuevaCompra";
            this.menuItem_nuevaCompra.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.menuItem_nuevaCompra.Size = new System.Drawing.Size(180, 22);
            this.menuItem_nuevaCompra.Text = "Nuevo";
            // 
            // menuItem_listaCompra
            // 
            this.menuItem_listaCompra.Name = "menuItem_listaCompra";
            this.menuItem_listaCompra.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuItem_listaCompra.Size = new System.Drawing.Size(180, 22);
            this.menuItem_listaCompra.Text = "Listar";
            // 
            // menuItem_venta
            // 
            this.menuItem_venta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_nuevaVenta,
            this.menuItem_listaVenta});
            this.menuItem_venta.Name = "menuItem_venta";
            this.menuItem_venta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.menuItem_venta.Size = new System.Drawing.Size(52, 20);
            this.menuItem_venta.Text = "Veṉta";
            // 
            // menuItem_nuevaVenta
            // 
            this.menuItem_nuevaVenta.Name = "menuItem_nuevaVenta";
            this.menuItem_nuevaVenta.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.menuItem_nuevaVenta.Size = new System.Drawing.Size(179, 22);
            this.menuItem_nuevaVenta.Text = "Nuevo";
            // 
            // menuItem_listaVenta
            // 
            this.menuItem_listaVenta.Name = "menuItem_listaVenta";
            this.menuItem_listaVenta.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.menuItem_listaVenta.Size = new System.Drawing.Size(179, 22);
            this.menuItem_listaVenta.Text = "Listar";
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_administracion,
            this.MenuItem_cliente,
            this.menuItem_compra,
            this.menuItem_venta});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(797, 24);
            this.menu_principal.TabIndex = 8;
            this.menu_principal.Text = "Menu Principal";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(797, 566);
            this.Controls.Add(this.menu_principal);
            this.MainMenuStrip = this.menu_principal;
            this.Name = "frm_principal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuItem_administracion;
        private System.Windows.Forms.ToolStripMenuItem menuItem_proveedor;
        private System.Windows.Forms.ToolStripMenuItem menuItem_nuevoProveedor;
        private System.Windows.Forms.ToolStripMenuItem menuItem_listaProveedor;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_nuevoProducto;
        private System.Windows.Forms.ToolStripMenuItem menuItem_listaProducto;
        private System.Windows.Forms.ToolStripMenuItem ivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_nuevoIva;
        private System.Windows.Forms.ToolStripMenuItem menuItem_listaIva;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_cliente;
        private System.Windows.Forms.ToolStripMenuItem menuItem_nuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem menuItem_listaCliente;
        private System.Windows.Forms.ToolStripMenuItem menuItem_compra;
        private System.Windows.Forms.ToolStripMenuItem menuItem_nuevaCompra;
        private System.Windows.Forms.ToolStripMenuItem menuItem_listaCompra;
        private System.Windows.Forms.ToolStripMenuItem menuItem_venta;
        private System.Windows.Forms.ToolStripMenuItem menuItem_nuevaVenta;
        private System.Windows.Forms.ToolStripMenuItem menuItem_listaVenta;
        private System.Windows.Forms.MenuStrip menu_principal;
    }
}