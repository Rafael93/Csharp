namespace stock_rafaelgamarra
{
    partial class frm_proveedor
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
            this.lbl_razon_social = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.lbl_ruc = new System.Windows.Forms.Label();
            this.txt_ruc = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.cmbx_telefono = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_razon_social
            // 
            this.lbl_razon_social.AutoSize = true;
            this.lbl_razon_social.Location = new System.Drawing.Point(23, 61);
            this.lbl_razon_social.Name = "lbl_razon_social";
            this.lbl_razon_social.Size = new System.Drawing.Size(132, 22);
            this.lbl_razon_social.TabIndex = 0;
            this.lbl_razon_social.Text = "*Razon Social:";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon_social.Location = new System.Drawing.Point(155, 54);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(338, 26);
            this.txt_razon_social.TabIndex = 1;
            this.txt_razon_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_razon_social_KeyPress);
            this.txt_razon_social.Leave += new System.EventHandler(this.txt_razon_social_Leave);
            // 
            // lbl_ruc
            // 
            this.lbl_ruc.AutoSize = true;
            this.lbl_ruc.Location = new System.Drawing.Point(89, 122);
            this.lbl_ruc.Name = "lbl_ruc";
            this.lbl_ruc.Size = new System.Drawing.Size(66, 22);
            this.lbl_ruc.TabIndex = 2;
            this.lbl_ruc.Text = "*RUC:";
            // 
            // txt_ruc
            // 
            this.txt_ruc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ruc.Location = new System.Drawing.Point(155, 115);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Size = new System.Drawing.Size(338, 26);
            this.txt_ruc.TabIndex = 3;
            this.txt_ruc.Leave += new System.EventHandler(this.txt_ruc_Leave);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(60, 183);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(95, 22);
            this.lbl_telefono.TabIndex = 4;
            this.lbl_telefono.Text = "*Telefóno:";
            // 
            // cmbx_telefono
            // 
            this.cmbx_telefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_telefono.FormattingEnabled = true;
            this.cmbx_telefono.Items.AddRange(new object[] {
            "Copaco",
            "Tigo",
            "Personal"});
            this.cmbx_telefono.Location = new System.Drawing.Point(155, 174);
            this.cmbx_telefono.Name = "cmbx_telefono";
            this.cmbx_telefono.Size = new System.Drawing.Size(141, 27);
            this.cmbx_telefono.TabIndex = 5;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(302, 174);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(191, 26);
            this.txt_telefono.TabIndex = 6;
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(51, 244);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(104, 22);
            this.lbl_direccion.TabIndex = 7;
            this.lbl_direccion.Text = "*Dirección:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(155, 244);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(338, 89);
            this.txt_direccion.TabIndex = 8;
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(239, 382);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 41);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(543, 459);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.cmbx_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_ruc);
            this.Controls.Add(this.lbl_ruc);
            this.Controls.Add(this.txt_razon_social);
            this.Controls.Add(this.lbl_razon_social);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_proveedor";
            this.Text = "Formulario Proveedor";
            this.Load += new System.EventHandler(this.frm_proveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_razon_social;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label lbl_ruc;
        private System.Windows.Forms.TextBox txt_ruc;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.ComboBox cmbx_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button btn_guardar;
    }
}