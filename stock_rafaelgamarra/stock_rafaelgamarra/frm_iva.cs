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
    public partial class frm_iva : Form
    {
        private Iva _iva;

        public frm_iva()
        {
            InitializeComponent();
        }

        public void Iva(Iva iva)
        {
            _iva = iva;
        }

        private void Frm_iva_Load(object sender, EventArgs e)
        {
            frm_iva formIva = new frm_iva();
            formIva.Iva(new Iva());
        }

        private void txt_descripcion_Leave(object sender, EventArgs e)
        {
            _iva.descricion = txt_descripcion.Text;
        }

        private void txt_porcentaje_Leave(object sender, EventArgs e)
        {
            _iva.porcentaje = Convert.ToString(txt_porcentaje.Text)+"%";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (esValido())
            {
                _iva.Guardar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos marcados como requeridos '*'", "Formulario Iva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool esValido()
        {
            if (string.Empty.Equals(_iva.descricion))
            {
                return false;
            }
            else if (string.Empty.Equals(_iva.porcentaje))
            {
                return false;
            }
            else
            {
                return true;
            }
        } 

        private void txt_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }
    }
  }

