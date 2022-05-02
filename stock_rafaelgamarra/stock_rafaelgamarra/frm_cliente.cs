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
    public partial class frm_cliente : Form
    {
        private Cliente _cliente;

        public frm_cliente()
        {
            InitializeComponent();
        }
        public void Cliente(Cliente cliente)
        {
            _cliente = cliente;
        }

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_num_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_nun_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void dtp_fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime fechaNacimiento = dtp_fechaNacimiento.Value;
            int edad = hoy.AddTicks(-fechaNacimiento.Ticks).Year - 1;
            txt_edad.Text = Convert.ToString(edad);
            _cliente.Edad = Convert.ToInt32(txt_edad.Text);
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {
            frm_cliente formCliente = new frm_cliente();
            formCliente.Cliente(new Cliente());
            

            dtp_fechaNacimiento.Value = DateTime.Now;
            dtp_fechaNacimiento.MaxDate = DateTime.Now;
            dtp_fechadeingreso.Value = DateTime.Today;
            dtp_fechadeingreso.MaxDate = DateTime.Today;
            dtp_fechadeingreso.MinDate = DateTime.Today;
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            _cliente.Nombre = txt_nombre.Text;
        }

        private void txt_apellido_Leave(object sender, EventArgs e)
        {
            _cliente.Apellido = txt_apellido.Text;
        }

        private void txt_documento_Leave(object sender, EventArgs e)
        {
            _cliente.Documento = Convert.ToInt32(txt_documento.Text);
        }

        private void txt_edad_Leave(object sender, EventArgs e)
        {
            _cliente.Edad = Convert.ToInt32(txt_edad.Text);
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            _cliente.Email = txt_email.Text;
        }

        private void dtp_fechadeingreso_Leave(object sender, EventArgs e)
        { 
            _cliente.Fechaingreso = dtp_fechadeingreso.Value;
        }

        private void dtp_fechaNacimiento_Leave(object sender, EventArgs e)
        {
            _cliente.FechaNacimiento = dtp_fechaNacimiento.Value.ToString("dd,mm,yyyy");
        }

        private void rbn_hombre_Leave(object sender, EventArgs e)
        {
            _cliente.Sexo = rbn_hombre.Text;
        }

        private void rbn_mujer_Leave(object sender, EventArgs e)
        {
            _cliente.Sexo = rbn_mujer.Text;
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            _cliente.Direccion = txt_direccion.Text;
        }

        private void txt_celular_Leave(object sender, EventArgs e)
        {
            _cliente.Celular = txt_celular.Text;
        }

        private void txt_nuntelefono_Leave(object sender, EventArgs e)
        {
            _cliente.Telefono = txt_nuntelefono.Text;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (esValido())
            {
                _cliente.Guardar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos marcados como requeridos '*'", "Formulario Alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool esValido()
        {
            if (string.Empty.Equals(_cliente.Nombre))
            {
                return false;
            }
            else if (string.Empty.Equals(_cliente.Apellido))
            {
                return false;
            }
            else if (_cliente.Documento == 0)
            {
                return false;
            }
            else if (_cliente.Edad == 0)
            {
                return false;
            }
            else if (string.Empty.Equals(_cliente.FechaNacimiento))
            {
                return false;
            }
            else if (string.Empty.Equals(_cliente.Fechaingreso))
            {
                return false;
            }
            else if (string.Empty.Equals(_cliente.Sexo))
            {
                return false;
            }
            else if (string.Empty.Equals(_cliente.Direccion))
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

