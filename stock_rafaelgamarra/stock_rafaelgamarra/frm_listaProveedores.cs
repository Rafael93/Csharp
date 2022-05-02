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
    public partial class frm_listaProveedores : Form
    {
        public frm_listaProveedores()
        {
            InitializeComponent();
        }

        private void frm_listaProveedores_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void dgv_listaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int proveedorId = Convert.ToInt32(dgv_listaProveedores[0, e.RowIndex].Value);
            Proveedor proveedor = Utilitarios.LISTA_PROVEEDORES[proveedorId];

            frm_proveedor formProveedor = new frm_proveedor();
            formProveedor.Proveedor(proveedor);
            formProveedor.ShowDialog();

            this.cargarTabla();
        }
        private void cargarTabla()
        {
            dgv_listaProveedores.Rows.Clear();
            foreach (Proveedor proveedor in Utilitarios.LISTA_PROVEEDORES.Values)
            {
                string[] fila = new string[] { Convert.ToString(proveedor.ID),
                                               proveedor.razonSocial,
                                               proveedor.ruc,
                                               proveedor.telefono,
                                               proveedor.direccion
                                               };
                dgv_listaProveedores.Rows.Add(fila);
            }
        }
    }
  }

