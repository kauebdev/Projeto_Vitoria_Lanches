using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vitoria_lanches
{
    public partial class frm_index : Form
    {
        // str de conexão com o banco de dados
        string str_con_vitoria_lanches = System.Configuration.ConfigurationManager.ConnectionStrings["vitoria_lanches_conection"].ConnectionString;

        public frm_index()
        {
            InitializeComponent();
        }

        // clique login

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmailUser.Text, password = txtSenhaUser.Text;

        }

        // clique cadastrar usuario

        private void btnCadUser_Click(object sender, EventArgs e)
        {

        }
        
        // clique sair

        private void BtnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
