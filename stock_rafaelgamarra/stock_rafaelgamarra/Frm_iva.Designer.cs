namespace stock_rafaelgamarra
{
    partial class frm_iva
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
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(39, 126);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(122, 22);
            this.lbl_descripcion.TabIndex = 0;
            this.lbl_descripcion.Text = "*Descripción:";
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(39, 198);
            this.lbl_porcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(114, 22);
            this.lbl_porcentaje.TabIndex = 1;
            this.lbl_porcentaje.Text = "*Porcentaje:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(158, 119);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(151, 29);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.Leave += new System.EventHandler(this.txt_descripcion_Leave);
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(158, 191);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(151, 29);
            this.txt_porcentaje.TabIndex = 3;
            this.txt_porcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_porcentaje_KeyPress);
            this.txt_porcentaje.Leave += new System.EventHandler(this.txt_porcentaje_Leave);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(201, 261);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(93, 32);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_iva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(489, 354);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_porcentaje);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_porcentaje);
            this.Controls.Add(this.lbl_descripcion);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_iva";
            this.Text = "Formulario IVA";
            this.Load += new System.EventHandler(this.Frm_iva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Button btn_guardar;
    }
}