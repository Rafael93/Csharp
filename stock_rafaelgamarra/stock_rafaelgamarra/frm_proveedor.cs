using logica_v2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_rafaelgamarra
{
    public partial class frm_proveedor : Form
    {
        Proveedor _proveedor;

        public frm_proveedor()
        {
            InitializeComponent();
        }

        public void Proveedor(Proveedor proveedor) {
            _proveedor = proveedor;
        }
        private void frm_proveedor_Load(object sender, EventArgs e)
        {

        }

        private void txt_razon_social_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_razon_social_Leave(object sender, EventArgs e)
        {
            _proveedor.razonSocial = txt_razon_social.Text;
        }

        private void txt_ruc_Leave(object sender, EventArgs e)
        {
            _proveedor.ruc = txt_ruc.Text;
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            _proveedor.telefono = txt_telefono.Text;
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            _proveedor.direccion = txt_direccion.Text;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (esValido())
            {
                _proveedor.Guardar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos marcados como requeridos '*'", "Formulario Iva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool esValido()
        {
            if (string.Empty.Equals(_proveedor.razonSocial))
            {
                return false;
            }
            else if (string.Empty.Equals(_proveedor.ruc))
            {
                return false;
            }
            else if (string.Empty.Equals(_proveedor.telefono)) {
                return false;
            }
            else if (string.Empty.Equals(_proveedor.direccion))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
