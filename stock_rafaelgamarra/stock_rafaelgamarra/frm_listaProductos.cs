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
    public partial class frm_listaProductos : Form
    {
        public frm_listaProductos()
        {
            InitializeComponent();
        }

        private void frm_listaProductos_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void dgv_listaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productoId = Convert.ToInt32(dgv_listaProductos[0, e.RowIndex].Value);
            Producto producto = Utilitarios.LISTA_PRODUCTOS[productoId];

            frm_producto formProducto = new frm_producto();
            formProducto.Producto(producto);
            formProducto.ShowDialog();

            this.cargarTabla();
        }
        private void cargarTabla()
        {
            dgv_listaProductos.Rows.Clear();
            foreach (Producto producto in Utilitarios.LISTA_PRODUCTOS.Values)
            {
                string[] fila = new string[] { Convert.ToString(producto.ID),
                                               producto.nombre,
                                               producto.tipoProducto,
                                               producto.unidadMedida,
                                               Convert.ToString(producto.cantidadMinima),
                                               Convert.ToString(producto.cantidadTotal),
                                               Convert.ToString(producto.precioCompra),
                                               Convert.ToString(producto.margenGanancia),
                                               Convert.ToString(producto.iva),
                                               Convert.ToString(producto.precioVenta)
                                               };
                dgv_listaProductos.Rows.Add(fila);
            }
        }
    }
 }
