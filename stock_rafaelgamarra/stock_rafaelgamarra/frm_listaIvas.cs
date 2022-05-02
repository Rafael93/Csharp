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
    public partial class frm_listaIvas : Form
    {
        public frm_listaIvas()
        {
            InitializeComponent();
        }

        private void frm_listaIvas_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void dgv_listaIvas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ivaId = Convert.ToInt32(dgv_listaIvas[0, e.RowIndex].Value);
            Iva iva = Utilitarios.LISTA_IVAS[ivaId];

            frm_iva formIva = new frm_iva();
            formIva.Iva(iva);
            formIva.ShowDialog();

            this.cargarTabla();
        }
        private void cargarTabla()
        {
            dgv_listaIvas.Rows.Clear();
            foreach (Iva iva in Utilitarios.LISTA_IVAS.Values)
            {
                string[] fila = new string[] { Convert.ToString(iva.ID),
                                               iva.descricion,
                                               Convert.ToString(iva.porcentaje)
                                               };
                dgv_listaIvas.Rows.Add(fila);
            }
        }
    }
}
