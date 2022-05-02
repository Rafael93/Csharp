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
    public partial class frm_listaClientes : Form
    {
        public frm_listaClientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void dgv_listaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clienteId = Convert.ToInt32(dgv_listaClientes[0, e.RowIndex].Value);
            Cliente cliente = Utilitarios.LISTA_CLIENTES[clienteId];

            frm_cliente formCliente = new frm_cliente();
            formCliente.Cliente(cliente);
            formCliente.ShowDialog();

            this.cargarTabla();
        }
        private void cargarTabla()
        {
            dgv_listaClientes.Rows.Clear();
            foreach (Cliente cliente in Utilitarios.LISTA_CLIENTES.Values)
            {
                string[] fila = new string[] { Convert.ToString(cliente.ID),
                                               cliente.Nombre,
                                               cliente.Apellido,
                                               Convert.ToString(cliente.Documento),
                                               cliente.FechaNacimiento,
                                               Convert.ToString(cliente.Edad),
                                               cliente.Fechaingreso.ToString("dd/mm/yyyy"),
                                               cliente.Sexo,
                                               cliente.Email,
                                               cliente.Direccion,
                                               cliente.Telefono,
                                               cliente.Celular
                                               };
                dgv_listaClientes.Rows.Add(fila);
            }
        }
    }
    }
    

