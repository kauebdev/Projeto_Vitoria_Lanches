using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitoria_lanches
{
    public partial class frm_pedidos : Form
    {
        public frm_pedidos()
        {
            InitializeComponent();
        }

        // clique cad prod
        private void btn_CadPed_Click(object sender, EventArgs e)
        {
            frm_AcomPedidos frm_cadpedidos = new frm_AcomPedidos();
            frm_cadpedidos.ShowDialog();
        }

        // clique acom prod
        private void btnAcomPed_Click(object sender, EventArgs e)
        {
            frm_CadPedido frm_acompedidos = new frm_CadPedido();
            frm_acompedidos.ShowDialog();
        }

        // botao sair
        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
