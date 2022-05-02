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
    public partial class frm_producto : Form
    {
        private Producto _producto;

        public frm_producto()
        {
            InitializeComponent();
        }
        public void Producto(Producto producto)
        {
            _producto = producto;
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_minima_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_margen_ganancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void txt_precio_de_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = Char.IsDigit(e.KeyChar);
            if (!isDigit)
            {
                e.Handled = true;
            }
        }

        private void frm_producto_Load(object sender, EventArgs e)
        {
            frm_producto formProducto = new frm_producto();
            formProducto.Producto(new Producto());
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            _producto.nombre = txt_nombre.Text;
        }

        private void cmbx_tipoProducto_Leave(object sender, EventArgs e)
        {
            _producto.tipoProducto = cmbx_tipoProducto.Text;
        }

        private void cmbx_unidad_de_medida_Leave(object sender, EventArgs e)
        {
            _producto.unidadMedida = cmbx_unidad_de_medida.Text;
        }

        private void txt_cantidad_minima_Leave(object sender, EventArgs e)
        {
            _producto.cantidadMinima = Convert.ToInt32(txt_cantidad_minima.Text);
        }

        private void txt_cantidad_total_Leave(object sender, EventArgs e)
        {
            _producto.cantidadTotal = Convert.ToInt32(txt_cantidad_total.Text);
        }

        private void txt_precio_compra_Leave(object sender, EventArgs e)
        {
            _producto.precioCompra = Convert.ToInt32(txt_precio_compra.Text);
        }

        private void txt_margen_ganancia_Leave(object sender, EventArgs e)
        {
            _producto.margenGanancia = Convert.ToInt32(txt_margen_ganancia.Text);
        }

        private void cmbx_iva_Leave(object sender, EventArgs e)
        {
            _producto.iva = Convert.ToInt32(cmbx_iva.Text);
        }

        private void txt_precio_de_venta_Leave(object sender, EventArgs e)
        {
            _producto.precioVenta = Convert.ToInt32(txt_precio_de_venta.Text);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (esValido())
            {
                _producto.Guardar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos marcados como requeridos '*'", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool esValido()
        {
            if (string.Empty.Equals(_producto.nombre))
            {
                return false;
            }
            else if (string.Empty.Equals(_producto.unidadMedida)) {
                return false;
            }
            else if (_producto.cantidadTotal==0)
            {
                return false;
            }
            else if (_producto.precioCompra == 0)
            {
                return false;
            }
            else if (_producto.margenGanancia == 0)
            {
                return false;
            }
            else if (_producto.iva == 0)
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
