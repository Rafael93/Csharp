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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_frmCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_listaClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_frmIva_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_listaIva_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_frmProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_listaProductos_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_frmProveedor_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_listaProveedores_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItem_nuevoCliente_Click(object sender, EventArgs e)
        {
            frm_cliente formCliente = new frm_cliente();
            formCliente.Cliente(new Cliente());
            formCliente.ShowDialog();
        }

        private void menuItem_listaCliente_Click(object sender, EventArgs e)
        {
            frm_listaClientes formListaClientes = new frm_listaClientes();
            formListaClientes.ShowDialog();
        }

        private void menuItem_NuevoIva_Click(object sender, EventArgs e)
        {
            frm_iva formIva = new frm_iva();
            formIva.Iva(new Iva());
            formIva.ShowDialog();
        }

        private void menuItem_listaIva_Click(object sender, EventArgs e)
        {
            frm_listaIvas formListaClientes = new frm_listaIvas();
            formListaClientes.ShowDialog();
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void menuItem_nuevoProducto_Click(object sender, EventArgs e)
        {
            frm_producto formProducto = new frm_producto();
            formProducto.Producto(new Producto());
            formProducto.ShowDialog();
        }

        private void menuItem_listaProducto_Click(object sender, EventArgs e)
        {
            frm_listaProductos formListaProductos = new frm_listaProductos();
            formListaProductos.ShowDialog();
        }

        private void menuItem_nuevoProveedor_Click(object sender, EventArgs e)
        {
            frm_proveedor formProveedor = new frm_proveedor();
            formProveedor.Proveedor(new Proveedor());
            formProveedor.ShowDialog();
        }

        private void menuItem_listaProveedor_Click(object sender, EventArgs e)
        {
            frm_listaProveedores formListaProductos = new frm_listaProveedores();
            formListaProductos.ShowDialog();
        }
    }
}
