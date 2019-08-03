using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPIntegra
{    
    public partial class frmBusquedaPedido : Form
    {
        csConexion c = new csConexion();
        frmPedido pedido = new frmPedido();
        public frmBusquedaPedido()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnGuardados_CheckedChanged(object sender, EventArgs e)
        {
            pedido.dgvProductoEntrada.DataSource = null;
            int estatus = 3;
            c.BuscaPedido(dgvPedidos,estatus);
        }

        private void rbtnPedidosEnviados_CheckedChanged(object sender, EventArgs e)
        {
            int estatus = 4;
            c.BuscaPedido(dgvPedidos, estatus);
        }

        private void rbtncanceldaos_CheckedChanged(object sender, EventArgs e)
        {
            int estatus = 5;
            c.BuscaPedido(dgvPedidos, estatus);
        }

        private void frmBusquedaPedido_Load(object sender, EventArgs e)
        {

        }
        private void dgvPedidos_DoubleClick(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvPedidos.SelectedRows)
            {
                
                string folio = this.dgvPedidos.CurrentRow.Cells["FOLIO"].Value.ToString();
                string subtotal = this.dgvPedidos.CurrentRow.Cells["SUBTOTAL"].Value.ToString();
               string ivatotal = this.dgvPedidos.CurrentRow.Cells["IVA_TOTAL"].Value.ToString();
                string total = this.dgvPedidos.CurrentRow.Cells["TOTAL_PEDIDO"].Value.ToString();


                c.ExtraePedido(pedido.dgvProductoEntrada, folio);
              

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "frmPedido")
                    {
                        pedido = (frmPedido)frm;

                        pedido.txtTotalPedido.Text = this.dgvPedidos.CurrentRow.Cells["TOTAL_PEDIDO"].Value.ToString();
                        pedido.txtsubtotal.Text = this.dgvPedidos.CurrentRow.Cells["SUBTOTAL"].Value.ToString();
                        pedido.txtIva.Text=this.dgvPedidos.CurrentRow.Cells["IVA_TOTAL"].Value.ToString();
                        this.Close();
                        break;
                    }
                    
                
                }
            }
        }
    }
}
