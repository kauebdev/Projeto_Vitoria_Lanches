using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitoria_lanches
{
    public partial class frm_CadPedido : Form
    {
        public frm_CadPedido()
        {
            InitializeComponent();
        }



        // clique para ir cadstar cliente
        private void btnTipo_Click(object sender, EventArgs e)
        {
            frm_CadCliente frm_Cliente = new frm_CadCliente();
            frm_Cliente.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
           // verificra variveis globais para finalizar o pedido,
           // precis aprencher pelo menos 1 produto e adicionar forma de pagaento 
        }
        
        // clique confirando o pedido do cliente
        private void btnConfirmClie_Click(object sender, EventArgs e)
        {
            if (cmbNomeClie.Text == "" || cmbNomeClie.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pnlClie.Enabled = false;
            pnlProd.Enabled = true;
            btnConfirmProd.Enabled = true;
            pnlPag.Enabled = true;
            pnlObser.Enabled = true;
            btnFinalizar.Enabled = true;
        }


        // clique sair
        private void btnExt_Click_1(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Deseja mesmo sair? Todo informações do pedido serão perdidas", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Confirm == DialogResult.OK)
            {
                this.Close();
            }


        }

        private void btnConfirmProd_Click(object sender, EventArgs e)
        {
            if (cmbTipoProd.Text == "Selecione o Tipo")
            {
                MessageBox.Show("Selecione um tipo de Produto antes de confirmar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cmbNomeProd.Text != "Selecione o Produto" && txtQuant.Text != "0" && cmbTipoProd.Enabled == false)
                {
                    cmbNomeProd.Enabled = false;
                    cmbTipoProd.Enabled = true;
                    txtQuant.Enabled = false;
                    cmbNomeProd.SelectedIndex = -1;
                    txtQuant.Text = "";
                    btnConfirmProd.Text = "Confirmar Produto";
                    return;

                }
                else if (cmbNomeProd.Text == "Selecione o Produto")
                {
                    MessageBox.Show("Selecione um Produto, antes de Adicionar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtQuant.Text == "0")
                {
                    MessageBox.Show("Digite uma Quantidade antes de adicionar, antes de Adicionar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            cmbNomeProd.Enabled = true;
            cmbNomeProd.Text = "Selecione o Produto";
            cmbTipoProd.Enabled = false;
            txtQuant.Enabled = true;
            txtQuant.Text = "0";
            btnConfirmProd.Text = "Adicionar Produto";
        }

        // quando ele carregar o form
        private void frm_CadPedido_Load(object sender, EventArgs e)
        {
            cmbTipoProd.SelectedIndex = 0;
        }
    }
}
