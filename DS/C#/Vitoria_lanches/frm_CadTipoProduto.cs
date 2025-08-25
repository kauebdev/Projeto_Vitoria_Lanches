using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Security;

namespace Vitoria_lanches
{
    public partial class frm_tipo : Form
    {
        // criando a conexão com o banco de dados
        string str_con_vitoria_lanches = ConfigurationManager.ConnectionStrings["vitoria_lanches_conection"].ConnectionString;

        // quando carrega 
        private void frm_tipo_Load(object sender, EventArgs e)
        {
         Querys.DgvTipoProd(str_con_vitoria_lanches, dgvTipoProd);
        }

        public frm_tipo()
        {
            InitializeComponent();
        }

        // clique cadastrar
        private void btnCad_Click_1(object sender, EventArgs e)
        {
            try
            {
                // declarando variaveis
                MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con_vitoria_lanches);
                int cod_tipo = 0; // complemtar com BD 
                string nm_tipo = txtNome.Text;

                if (Tratamentos.notValido(new string[] {nm_tipo}))
                {
                    MessageBox.Show("ATENÇÃO AOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }  
                    // CADASTRA DADOS
                    string insert_desc_tipo = @"INSERT INTO tb_tipo_produto 
                                    (TB_TIPO_PRODUTO_DESC) 
                                    VALUES 
                                    (@TB_TIPO_PRODUTO_DESC)";
                    MySqlCommand cmd_insert_desc_tipo = new MySqlCommand(insert_desc_tipo, con_vitoria_lanches);
                    
                    cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_TIPO_PRODUTO_DESC", nm_tipo);
                    con_vitoria_lanches.Open();
                    cmd_insert_desc_tipo.ExecuteNonQuery(); // executa o comando de inserção
                    con_vitoria_lanches.Close(); // fecha a conexão

                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Querys.DgvTipoProd(str_con_vitoria_lanches, dgvTipoProd);
                    txtNome.Text = ""; // limpa o campo de texto após o cadastro

            }
            catch (FormatException ex)
            {
                string erro = ex.Message;
                MessageBox.Show("ATENÇÃO AOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(erro, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // tirar depois de testar
            }
        }

        // clique excluir
        private void btnExc_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("quer mesmo excluir os itens", "CONFIRMAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (Confirm == DialogResult.OK)
            {
                // excloi            
            }
            else
            {
                // nao excloi
            }
        }

        // clique atualizar
        private void btnAtt_Click(object sender, EventArgs e)
        {

        }

        // clique sair
        public void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
