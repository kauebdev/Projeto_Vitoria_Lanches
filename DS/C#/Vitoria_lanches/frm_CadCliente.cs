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
    public partial class frm_CadCliente : Form
    {
        // str de conexão com o banco de dados
        string str_con_vitoria_lanches = System.Configuration.ConfigurationManager.ConnectionStrings["vitoria_lanches_conection"].ConnectionString;


        // quando acrreghar a tela
        private void frm_CadCliente_Load(object sender, EventArgs e)
        {
            Querys.DgvClie(str_con_vitoria_lanches, dgvClie); // atualiza o datagridview

        }

        public frm_CadCliente()
        {
            InitializeComponent();
        }

        // clique cadastrar
        private void btnCad_Click(object sender, EventArgs e)
        {
            try
            {
                // DECLARA VARIAVEIS
                MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con_vitoria_lanches);
                int cod_clie = 0; // complemtar com BD 
                string nm_clie = txtNome.Text;
                string tel_clie = txtTel.Text;
                int endNum_clie = int.Parse(txtEndNum.Text);
                string end_clie = txtEnd.Text;
                if (Tratamentos.notValido(new string[] { nm_clie, tel_clie, end_clie }))
                {
                    MessageBox.Show("ATENÇÃO AOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // cadastra dados
                string insert_desc_tipo = @"INSERT INTO TB_CLIENTE  
                                    (TB_CLIENTE_NOME,
                                    TB_CLIENTE_TEL,
                                    TB_CLIENTE_ENDEREÇO,
                                    TB_CLIENTE_ENDEREÇO_NUM) 
                                    VALUES 
                                    (@TB_CLIENTE_NOME,
                                    @TB_CLIENTE_TEL,
                                    @TB_CLIENTE_ENDEREÇO,
                                    @TB_CLIENTE_ENDEREÇO_NUM)";
                MySqlCommand cmd_insert_desc_tipo = new MySqlCommand(insert_desc_tipo, con_vitoria_lanches);

                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_CLIENTE_NOME", nm_clie);
                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_CLIENTE_TEL", tel_clie);
                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_CLIENTE_ENDEREÇO", end_clie);
                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_CLIENTE_ENDEREÇO_NUM", endNum_clie);
                con_vitoria_lanches.Open();
                cmd_insert_desc_tipo.ExecuteNonQuery(); // executa o comando de inserção
                con_vitoria_lanches.Close(); // fecha a conexão

                Querys.DgvClie(str_con_vitoria_lanches, dgvClie); // atualiza o datagridview

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpar os campos após o cadastro
                txtNome.Clear();
                txtTel.Clear();
                txtEnd.Clear();
                txtEndNum.Clear();


            }
            catch (FormatException ex)
            {
                string erro = ex.Message;
                MessageBox.Show("ATENÇÃO AOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(erro, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // clique excluir
        private void btnExc_Click_1(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("quer mesmo excluir o cliente", "CONFIRMAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
