namespace stock_rafaelgamarra
{
    partial class frm_listaIvas
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
            this.gbx_listaIvas = new System.Windows.Forms.GroupBox();
            this.dgv_listaIvas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_listaIvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaIvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_listaIvas
            // 
            this.gbx_listaIvas.Controls.Add(this.dgv_listaIvas);
            this.gbx_listaIvas.Location = new System.Drawing.Point(12, 12);
            this.gbx_listaIvas.Name = "gbx_listaIvas";
            this.gbx_listaIvas.Size = new System.Drawing.Size(743, 331);
            this.gbx_listaIvas.TabIndex = 0;
            this.gbx_listaIvas.TabStop = false;
            this.gbx_listaIvas.Text = "Lista Ivas";
            // 
            // dgv_listaIvas
            // 
            this.dgv_listaIvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaIvas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Porcentaje});
            this.dgv_listaIvas.Location = new System.Drawing.Point(17, 19);
            this.dgv_listaIvas.Name = "dgv_listaIvas";
            this.dgv_listaIvas.Size = new System.Drawing.Size(704, 293);
            this.dgv_listaIvas.TabIndex = 0;
            this.dgv_listaIvas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaIvas_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // frm_listaIvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 355);
            this.Controls.Add(this.gbx_listaIvas);
            this.Name = "frm_listaIvas";
            this.Text = "Lista Ivas";
            this.Load += new System.EventHandler(this.frm_listaIvas_Load);
            this.gbx_listaIvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaIvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_listaIvas;
        private System.Windows.Forms.DataGridView dgv_listaIvas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}