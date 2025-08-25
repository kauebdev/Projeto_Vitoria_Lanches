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
    public partial class frm_index : Form
    {
        public frm_index()
        {
            InitializeComponent();
        }         

        // clique boatao pedidos
        private void btnPedidos_Click(object sender, EventArgs e) {
           
        }

        // clique btn cad produtyo
        private void btnCadProd_Click(object sender, EventArgs e)
        {
            frm_produto frm_Produto = new frm_produto();
            frm_Produto.ShowDialog();
        }

        // cliquye botao cad cliente
        private void btnCadCli_Click(object sender, EventArgs e)
        {
            frm_cliente frm_Cliente = new frm_cliente();
            frm_Cliente.ShowDialog();
        }

        // clique botao sair
        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
