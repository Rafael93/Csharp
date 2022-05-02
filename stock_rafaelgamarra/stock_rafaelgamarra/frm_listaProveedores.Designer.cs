namespace stock_rafaelgamarra
{
    partial class frm_listaProveedores
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
            this.gbx_listaProveedores = new System.Windows.Forms.GroupBox();
            this.dgv_listaProveedores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_listaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_listaProveedores
            // 
            this.gbx_listaProveedores.Controls.Add(this.dgv_listaProveedores);
            this.gbx_listaProveedores.Location = new System.Drawing.Point(12, 12);
            this.gbx_listaProveedores.Name = "gbx_listaProveedores";
            this.gbx_listaProveedores.Size = new System.Drawing.Size(874, 478);
            this.gbx_listaProveedores.TabIndex = 0;
            this.gbx_listaProveedores.TabStop = false;
            this.gbx_listaProveedores.Text = "Lista Proveedores";
            // 
            // dgv_listaProveedores
            // 
            this.dgv_listaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.razonSocial,
            this.ruc,
            this.telefono,
            this.direccion});
            this.dgv_listaProveedores.Location = new System.Drawing.Point(20, 29);
            this.dgv_listaProveedores.Name = "dgv_listaProveedores";
            this.dgv_listaProveedores.Size = new System.Drawing.Size(833, 431);
            this.dgv_listaProveedores.TabIndex = 0;
            this.dgv_listaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaProveedores_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            // 
            // ruc
            // 
            this.ruc.HeaderText = "RUC";
            this.ruc.Name = "ruc";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // frm_listaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 502);
            this.Controls.Add(this.gbx_listaProveedores);
            this.Name = "frm_listaProveedores";
            this.Text = "Lista Proveedores";
            this.Load += new System.EventHandler(this.frm_listaProveedores_Load);
            this.gbx_listaProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_listaProveedores;
        private System.Windows.Forms.DataGridView dgv_listaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}