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
using Mysqlx;


namespace Vitoria_lanches
{
    public partial class frm_CadProduto : Form
    {

        // criando a string conexão com o banco de dados
        string str_con_vitoria_lanches = ConfigurationManager.ConnectionStrings["vitoria_lanches_conection"].ConnectionString;

        public frm_CadProduto()
        {
            InitializeComponent();
        }

        // CARREGA FORM
        private void frm_CadProduto_Load(object sender, EventArgs e)
        {
            
            Querys.CmbCadProd(str_con_vitoria_lanches, cmbTipo); // carrega o combobox com os tipos de produtos
            Querys.DgvProd(str_con_vitoria_lanches, dgvProd);  // atualiza o datagridview
            txtCod.Text = "0";
        }

        // quando clicar para selcionar cmb 
        private void cmbTipo_DropDown(object sender, EventArgs e)

        {
            Querys.CmbCadProd(str_con_vitoria_lanches, cmbTipo); // carrega o combobox com os tipos de produtos
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
            try
            {
                // variaveis
                MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con_vitoria_lanches);
                string nm_prod = txtNome.Text;
                string tipo_prod = cmbTipo.Text;
                float preco_prod = float.Parse(txtPrecUn.Text);
                string desc_prod = rtxDesc.Text;

                // ve se os campos estão certos
                if (Tratamentos.notValido(new string[] { nm_prod, tipo_prod }))
                {
                    MessageBox.Show("ATENÇÃO AOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cod_prod = int.Parse(txtCod.Text);
                int cod_tipo_prod = int.Parse(cmbTipo.SelectedValue.ToString()); // pega o id para cadasro com base no nome ja padronizado para evitar erros
                // ve se o id ja existe
                if (Tratamentos.idExitis(str_con_vitoria_lanches, cod_prod))
                {
                    MessageBox.Show("PRODUTO JA EXISTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // cadastra dados
                string insert_desc_tipo = @"INSERT INTO TB_PRODUTO 
                                    (TB_PRODUTO_NOME,
                                    TB_PRODUTO_TIPO_PRODUTO_ID,
                                    TB_PRODUTO_DESC,
                                    TB_PRODUTO_PREC_UNIT) 
                                    VALUES 
                                    (@TB_PRODUTO_NOME,
                                    @TB_PRODUTO_TIPO_PRODUTO_ID,
                                    @TB_PRODUTO_DESC,
                                    @TB_PRODUTO_PREC_UNIT)";
                MySqlCommand cmd_insert_desc_tipo = new MySqlCommand(insert_desc_tipo, con_vitoria_lanches);

                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_PRODUTO_NOME", nm_prod);
                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_PRODUTO_TIPO_PRODUTO_ID", cod_tipo_prod);
                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_PRODUTO_DESC", desc_prod);
                cmd_insert_desc_tipo.Parameters.AddWithValue("@TB_PRODUTO_PREC_UNIT", preco_prod);
                con_vitoria_lanches.Open();
                cmd_insert_desc_tipo.ExecuteNonQuery(); // executa o comando de inserção
                con_vitoria_lanches.Close(); // fecha a conexão

                Querys.DgvProd(str_con_vitoria_lanches, dgvProd);  // atualiza o datagridview
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); // limpa o campo de texto após o cadastro
                cmbTipo.SelectedItem = null;
                txtPrecUn.Clear();
                rtxDesc.Clear();
                txtCod.Text = "0";


            }
            catch (FormatException ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // tirar depois de testar
            }
        }
        // clique excluir
        private void btnExc_Click(object sender, EventArgs e)
        {
            try
            {
                // variaveis
                MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con_vitoria_lanches);
                string nm_prod = txtNome.Text;
                string tipo_prod = cmbTipo.Text;
                float preco_prod = float.Parse(txtPrecUn.Text);
                string desc_prod = rtxDesc.Text;

                // ve se os campos estão certos
                if (Tratamentos.notValido(new string[] { nm_prod, tipo_prod }))
                {
                    MessageBox.Show("ATENÇÃO AOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cod_prod = int.Parse(txtCod.Text);
                int cod_tipo_prod = int.Parse(cmbTipo.SelectedValue.ToString()); // pega o id para cadasro com base no nome ja padronizado para evitar erros
                // ve se o id ja existe
                if (Tratamentos.idExitis(str_con_vitoria_lanches, cod_prod))
                {

                    DialogResult Confirm = MessageBox.Show("quer mesmo excluir o item", "CONFIRMAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (Confirm == DialogResult.OK)
                    {
                        Deletes.DeleteProd(str_con_vitoria_lanches, cod_prod);
                        Querys.DgvProd(str_con_vitoria_lanches, dgvProd);
                        txtNome.Clear(); // limpa o campo de texto após o cadastro
                        cmbTipo.Text = null;
                        txtPrecUn.Clear();
                        rtxDesc.Clear();
                        txtCod.Text = "0";

                        MessageBox.Show("Produto Deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // tirar depois de testar
                    }
                    return;
                }

                MessageBox.Show("PRODUTO NÃO EXISTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // tirar depois de testar
            }
        }        

        // clique atualizar
        private void btnAtt_Click(object sender, EventArgs e)
        {
            try
            {
                // variaveis
                MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con_vitoria_lanches);
                string nm_prod = txtNome.Text;
                string tipo_prod = cmbTipo.Text;
                float preco_prod = float.Parse(txtPrecUn.Text);
                string desc_prod = rtxDesc.Text;

                // ve se os campos estão certos
                if (Tratamentos.notValido(new string[] { nm_prod, tipo_prod }))
                {
                    MessageBox.Show("ATENÇÃO AOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int cod_prod = int.Parse(txtCod.Text);
                int cod_tipo_prod = int.Parse(cmbTipo.SelectedValue.ToString()); // pega o id para cadasro com base no nome ja padronizado para evitar erros
                // ve se o id ja existe
                if (Tratamentos.idExitis(str_con_vitoria_lanches, cod_prod))
                {
                    // atualiza os dados
                    string update_prod = @"update TB_PRODUTO
                                                SET TB_PRODUTO_NOME = @TB_PRODUTO_NOME,
	                                                TB_PRODUTO_TIPO_PRODUTO_ID = @TB_PRODUTO_TIPO_PRODUTO_ID,
	                                                TB_PRODUTO_DESC =  @TB_PRODUTO_DESC,
	                                                TB_PRODUTO_PREC_UNIT = @TB_PRODUTO_PREC_UNIT
                                                WHERE TB_PRODUTO_ID = @TB_PRODUTO_ID;";
                    MySqlCommand cmd_update_prod = new MySqlCommand(update_prod, con_vitoria_lanches);

                    cmd_update_prod.Parameters.AddWithValue("@TB_PRODUTO_ID", cod_prod);
                    cmd_update_prod.Parameters.AddWithValue("@TB_PRODUTO_NOME", nm_prod);
                    cmd_update_prod.Parameters.AddWithValue("@TB_PRODUTO_TIPO_PRODUTO_ID", cod_tipo_prod);
                    cmd_update_prod.Parameters.AddWithValue("@TB_PRODUTO_DESC", desc_prod);
                    cmd_update_prod.Parameters.AddWithValue("@TB_PRODUTO_PREC_UNIT", preco_prod);
                    con_vitoria_lanches.Open();
                    cmd_update_prod.ExecuteNonQuery(); // executa o comando de inserção
                    con_vitoria_lanches.Close(); // fecha a conexão

                    Querys.DgvProd(str_con_vitoria_lanches, dgvProd);  // atualiza o datagridview
                    MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Clear(); // limpa o campo de texto após o cadastro
                    cmbTipo.SelectedItem = null;
                    txtPrecUn.Clear();
                    rtxDesc.Clear();
                    txtCod.Text = "0";

                    return;
                }

                MessageBox.Show("PRODUTO NÃO EXISTE!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (FormatException ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // tirar depois de testar
            }
        }
        
        // clique selecionar prod
        private void dgvProd_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
          Popular.PopularProd(dgvProd, txtCod, txtNome, txtPrecUn, rtxDesc, cmbTipo);
        }

        // clique sair
        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
