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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }

        // clieue botao cad tipo
        private void btnTipo_Click(object sender, EventArgs e)
        {
            frm_tipo frm_Tipo = new frm_tipo();
            frm_Tipo.ShowDialog();
        }

        // clique cadastrar
        private void btnCad_Click(object sender, EventArgs e)
        {

        }

        // clique excluir
        private void btnExc_Click(object sender, EventArgs e)
        {

        }

        // clique atualizar
        private void btnAtt_Click(object sender, EventArgs e)
        {

        }

        // clique sair
        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // clieue botao cad tipo
        private void btnTipo_Click_1(object sender, EventArgs e)
        {
            frm_tipo frm_Tipo = new frm_tipo();
            frm_Tipo.ShowDialog();
        }

        // clique cadastrar
        private void btnCad_Click_1(object sender, EventArgs e)
        {

        }

        // clique excluir
        private void btnExc_Click_1(object sender, EventArgs e)
        {

        }

        // clique atualizar
        private void btnAtt_Click_1(object sender, EventArgs e)
        {

        }

        // clique sair
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
