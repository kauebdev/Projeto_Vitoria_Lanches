using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vitoria_lanches
{
    public static class Tratamentos
    {
        public static bool notValido(Array itens)
        {
            foreach (String item in itens)
            {
                if (String.IsNullOrEmpty(item) || String.IsNullOrWhiteSpace(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool idExitis(String str_con,int id)
        {
            MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con);
            string select_prod_id = @"SELECT * FROM TB_PRODUTO 
                                        WHERE TB_PRODUTO_ID = @TB_PRODUTO_ID;";
            MySqlCommand cmd_select_prod_id = new MySqlCommand(select_prod_id, con_vitoria_lanches);

            cmd_select_prod_id.Parameters.AddWithValue("@TB_PRODUTO_ID", id);

            con_vitoria_lanches.Open();
            cmd_select_prod_id.ExecuteNonQuery();
            DataTable tb_prod_id = new DataTable();
            MySqlDataAdapter da_prod_id = new MySqlDataAdapter(cmd_select_prod_id);
            da_prod_id.Fill(tb_prod_id);
            con_vitoria_lanches.Close();

            // verifica se tem pelo menos uma linha com aquele id ou seja se existe
            if (tb_prod_id.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    public static class Querys
    {
        public static void DgvTipoProd(String str_con, DataGridView dgv) {
            MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con);
            string select_tipo_prod = "SELECT * FROM TB_TIPO_PRODUTO";
            MySqlCommand cmd_select_tipo_prod = new MySqlCommand(select_tipo_prod, con_vitoria_lanches);

            con_vitoria_lanches.Open();

            cmd_select_tipo_prod.ExecuteNonQuery(); 

            DataTable tb_tipo_prod = new DataTable();

            MySqlDataAdapter da_tipo_prod = new MySqlDataAdapter(cmd_select_tipo_prod);

            da_tipo_prod.Fill(tb_tipo_prod);

            con_vitoria_lanches.Close();
            dgv.DataSource = tb_tipo_prod;
            dgv.Columns["TB_TIPO_PRODUTO_DESC"].HeaderText = "TIPO PRODUTO"; // renomeia a coluna de ID
            dgv.Columns["TB_TIPO_PRODUTO_ID"].Visible = false; // oculta a coluna de ID

        }
        public static void CmbCadProd(string str_con, ComboBox cmb)
        {
            MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con);
            string select_prod = @"SELECT * 
                                        FROM TB_TIPO_PRODUTO
                                        ORDER BY TB_TIPO_PRODUTO_DESC ASC";
            MySqlCommand cmd_select_prod = new MySqlCommand(select_prod, con_vitoria_lanches);

            con_vitoria_lanches.Open();

            cmd_select_prod.ExecuteNonQuery();

            DataTable tb_prod = new DataTable();

            MySqlDataAdapter da_tipo_prod = new MySqlDataAdapter(cmd_select_prod);

            da_tipo_prod.Fill(tb_prod);

            con_vitoria_lanches.Close();

            cmb.DataSource = tb_prod;
            cmb.DisplayMember = "TB_TIPO_PRODUTO_DESC";  // nome do campo que vai aparecer no combobox
            cmb.ValueMember = "TB_TIPO_PRODUTO_id"; // nome do campo que vai ser o valor do combobox
            cmb.DropDownStyle = ComboBoxStyle.DropDownList; // deixa o combobox como lista suspensa
            
        }

        public static void DgvProd(String str_con, DataGridView dgv)
        {
            MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con);
            string select_prod = @"select tb_produto.tb_produto_id, tb_produto.tb_produto_nome,tb_tipo_produto.tb_tipo_produto_desc, tb_produto.tb_produto_desc, tb_produto.tb_produto_prec_unit  
                                from tb_produto
                                INNER JOIN tb_tipo_produto
                                on tb_produto.TB_PRODUTO_TIPO_PRODUTO_ID = tb_tipo_produto.TB_TIPO_PRODUTO_ID
                                order by tb_tipo_produto.tb_tipo_produto_desc ASC;";
            MySqlCommand cmd_select_prod = new MySqlCommand(select_prod, con_vitoria_lanches);

            con_vitoria_lanches.Open();

            cmd_select_prod.ExecuteNonQuery();

            DataTable tb_prod = new DataTable();

            MySqlDataAdapter da_tipo_prod = new MySqlDataAdapter(cmd_select_prod);

            da_tipo_prod.Fill(tb_prod);

            con_vitoria_lanches.Close();

            dgv.DataSource = tb_prod;
            dgv.Columns["TB_PRODUTO_id"].HeaderText = "id";
            dgv.Columns["TB_PRODUTO_id"].Visible = false;
            dgv.Columns["TB_PRODUTO_NOME"].HeaderText = "Produto";
            dgv.Columns["TB_TIPO_PRODUTO_DESC"].HeaderText = "Tipo de Produto";
            dgv.Columns["TB_PRODUTO_DESC"].HeaderText = "Descrição";
            dgv.Columns["TB_PRODUTO_PREC_UNIT"].HeaderText = "Preço Unitário";

        }

        public static void DgvClie(String str_con, DataGridView dgv)
        {
            MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con);
            string select_clie = @"select * from tb_cliente";
            MySqlCommand cmd_select_clie = new MySqlCommand(select_clie, con_vitoria_lanches);

            con_vitoria_lanches.Open();

            cmd_select_clie.ExecuteNonQuery();

            DataTable tb_clie = new DataTable();

            MySqlDataAdapter da_tipo_prod = new MySqlDataAdapter(cmd_select_clie);

            da_tipo_prod.Fill(tb_clie);

            con_vitoria_lanches.Close();

            dgv.DataSource = tb_clie;

            dgv.Columns["TB_CLIENTE_NOME"].HeaderText = "Nome";
            dgv.Columns["TB_CLIENTE_TEL"].HeaderText = "Telefone";
            dgv.Columns["TB_CLIENTE_ENDEREÇO"].HeaderText = "Endereço";
            dgv.Columns["TB_CLIENTE_ENDEREÇO_NUm"].HeaderText = "End.Numero";

        }

    }
    public static class Popular {
        public static void PopularProd(DataGridView dgv, TextBox txtCod, TextBox txtNome, TextBox txtPrecUn, RichTextBox rtxDesc, ComboBox cmbTipo)
        {
            var cod_prod = dgv.CurrentRow.Cells["TB_PRODUTO_id"].Value.ToString();
            var nm_prod = dgv.CurrentRow.Cells["TB_PRODUTO_nome"].Value.ToString();
            var desc_prod = dgv.CurrentRow.Cells["TB_PRODUTO_desc"].Value.ToString();
            var tipo_prod = dgv.CurrentRow.Cells["TB_TIPO_PRODUTO_DESC"].Value.ToString();
            var preco_prod = dgv.CurrentRow.Cells["TB_PRODUTO_PREC_UNIT"].Value.ToString();
            txtCod.Text = cod_prod;
            txtNome.Text = nm_prod;
            cmbTipo.Text = tipo_prod;
            txtPrecUn.Text = preco_prod;
            rtxDesc.Text = desc_prod;
        }
    }
    public static class Deletes {
        public static void DeleteProd(string str_con, int id)
        {
            MySqlConnection con_vitoria_lanches = new MySqlConnection(str_con);
            string delete_produto = "DELETE FROM TB_PRODUTO WHERE TB_PRODUTO_ID = @TB_PRODUTO_ID";

            MySqlCommand cmd_delete_prod = new MySqlCommand(delete_produto, con_vitoria_lanches);
            cmd_delete_prod.Parameters.AddWithValue("@TB_PRODUTO_ID", id);

            con_vitoria_lanches.Open();
            cmd_delete_prod.ExecuteNonQuery();
            con_vitoria_lanches.Close();

        }

    }

}

