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
    public partial class frm_Index : Form
    {
        public frm_Index()
        {
            InitializeComponent();
        }         

        // clique boatao pedidos
        private void btnPedidos_Click(object sender, EventArgs e) {
           frm_pedidos frm_Pedidos = new frm_pedidos();
           frm_Pedidos.ShowDialog();
        }

        // clique btn cad produtyo
        private void btnCadProd_Click(object sender, EventArgs e)
        {
            frm_CadProduto frm_Produto = new frm_CadProduto();
            frm_Produto.ShowDialog();
        }

        // cliquye botao cad cliente
        private void btnCadCli_Click(object sender, EventArgs e)
        {
            frm_CadCliente frm_Cliente = new frm_CadCliente();
            frm_Cliente.ShowDialog();
        }

        // clique botao sair
        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clique botao relatorio
        private void btnRel_Click(object sender, EventArgs e)
        {
            Frm_relatorio frm_relatorio = new Frm_relatorio();
            frm_relatorio.ShowDialog();
        }
    }
}
