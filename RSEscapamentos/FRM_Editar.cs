using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace RSEscapamentos
{
    public partial class FRM_Editar : Form
    {
        public bool Editar_Cancelado { get; set; }
        int id_produto;
        string valor_lista = "Padrão"; //Valor padrão atribuído a variável para não ser null e ocorrer bugs na lista.
        public FRM_Editar(int id_produto = -1)
        {
            InitializeComponent();
            this.id_produto = id_produto;
        }

        private void FRM_Editar_Load(object sender, EventArgs e)
        {
            Lista_Fornecedores();

            text_codigo.Focus();

            #region Carregar os dados nas caixas de texto, de acordo com seu id_produto
            //Ligar base de dados.
            SqlCeConnection ligar = new SqlCeConnection("Data source = " + Base_Dados.base_dados);

            //Faz uma soma da tabela "Preço".
            SqlCeDataAdapter adaptador_busca = new SqlCeDataAdapter("SELECT * FROM estoque WHERE id_produto = " + id_produto, ligar);
            DataTable dados_busca = new DataTable();
            adaptador_busca.Fill(dados_busca);

            //Exibe os dados nas caixas de texto.
            text_codigo.Text = dados_busca.Rows[0]["Código"].ToString();
            text_produto.Text = dados_busca.Rows[0]["Produto"].ToString();
            quantidade.Value = Convert.ToInt16(dados_busca.Rows[0]["Quantidade"]);
            text_valor_real.Text = Convert.ToDecimal(dados_busca.Rows[0]["Valor_Real"]).ToString();
            text_valor_venda.Text = Convert.ToDecimal(dados_busca.Rows[0]["Valor_Venda"]).ToString();

            //Converter os valores que estão nas caixas de texto para o formato de moeda.
            decimal texto_real = decimal.Parse(text_valor_real.Text);
            decimal texto_venda = decimal.Parse(text_valor_venda.Text);
            text_valor_real.Text = String.Format("{0:n}", texto_real);
            text_valor_venda.Text = String.Format("{0:n}", texto_venda);


            #endregion
        }

        //Responsável por criar e formatar lista de fornecedores.
        public string Lista_Fornecedores()
        {
            SqlCeConnection ligar_fornecedor = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_fornecedor.Open();

            SqlCeDataAdapter adaptador_fornecedores = new SqlCeDataAdapter("SELECT * FROM fornecedores", ligar_fornecedor);
            DataTable dados_fornecedores = new DataTable();
            adaptador_fornecedores.Fill(dados_fornecedores);

            if (dados_fornecedores.Rows.Count == 0)
            {
                //Fechar conexão com a base de dados.
                ligar_fornecedor.Close();
                lista_fornecedor.Enabled = false;
                check_lista.Enabled = false;
                return "Nulo";
            }
            else
            {
                //Adicionar linhas da coluna Nome na lista.
                foreach (DataRow linhas in dados_fornecedores.Rows)
                {
                    lista_fornecedor.Items.Add(linhas["Nome"].ToString());
                }
                //Fechar conexão com a base de dados.
                ligar_fornecedor.Close();

                //Valor selecionado pelo usuário.
                return valor_lista;
            }
        }

        //Botão Cancelar.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar_Cancelado = true; //Indica para FRM_Admin que a edição foi cancelada.
            Close();
        }

        //Botão Concluir.
        private void btn_concluir_Click(object sender, EventArgs e)
        {
            #region Verificações das caixas de texto.
            if (text_valor_real.Text == "" || text_valor_venda.Text == "")
            {
                MessageBox.Show("Campos de Preço não podem ficar vazios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (text_produto.Text == "")
            {
                MessageBox.Show("Campos de Produto/Peça não pode ficar vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            #endregion
            //Ligar base de dados;
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + Base_Dados.base_dados);
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = ligacao;

            //Verificar o estado da checkbox para registrar o fornecedor
            if (check_lista.Checked == true || valor_lista == "Padrão")
            {
                comando.Parameters.AddWithValue("@fornecedor", "- - - - ");
            }
            //Verifica se usuário escolheu item na lista_fornecedores.
            else if (valor_lista == null && check_lista.Checked == false)
            {
                MessageBox.Show("Escolha um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
                comando.Parameters.AddWithValue("@fornecedor", valor_lista);

            //Parâmetros
            comando.Parameters.AddWithValue("@id_produto", id_produto);
            comando.Parameters.AddWithValue("@codigo", text_codigo.Text);
            comando.Parameters.AddWithValue("@produto", text_produto.Text);
            comando.Parameters.AddWithValue("@quantidade", quantidade.Value);
            comando.Parameters.AddWithValue("@valor_real", text_valor_real.Text);
            comando.Parameters.AddWithValue("@valor_venda", text_valor_venda.Text);


            //Verifica se já existe registro com mesmo código.
            DataTable dados = new DataTable();
            comando.CommandText = "SELECT * FROM estoque WHERE Código = @codigo AND id_produto <> @id_produto";
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(dados);
            if (dados.Rows.Count != 0)
            {
                MessageBox.Show("Código já existente em outro cadastro, tente novamente alterando o campo de Código.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Atualizar contato na base de dados
            comando.CommandText = "UPDATE estoque SET " +
                         "Código = @codigo, " +
                         "Produto = @produto, " +
                         "Fornecedor = @fornecedor, " +
                         "Quantidade = @quantidade, " +
                         "Valor_Real = @valor_real, " +
                         "Valor_Venda = @valor_venda " +
                         "WHERE id_produto = @id_produto";
            //OBS >>>>>  Se não utilizar a clausula WHERE, todos registros serão atualizados. 

            comando.ExecuteNonQuery();

            //Em seguida da edição dos registros, o formulário é fechado.
            this.Close();
        }

        private void text_valor_real_Leave(object sender, EventArgs e)
        {
            //Trecho responsável pela formatação da textBox.
            if (text_valor_real.Text == "")
            {
                return;
            }
            try
            {
                float texto = float.Parse(text_valor_real.Text);
                text_valor_real.Text = String.Format("{0:n}", texto);//Formatar o texto que está na caixa de texto.
            }
            catch
            {
                MessageBox.Show("Preço incorreto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                text_valor_real.Focus();
                text_valor_real.Text = "";
                return;
            }
        }

        private void text_valor_venda_Leave(object sender, EventArgs e)
        {
            //Trecho responsável pela formatação da textBox.
            if (text_valor_venda.Text == "")
            {
                return;
            }
            try
            {
                float texto = float.Parse(text_valor_venda.Text);
                text_valor_venda.Text = String.Format("{0:n}", texto); //Formatar o texto que está na caixa de texto.
            }
            catch
            {
                MessageBox.Show("Preço incorreto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                text_valor_venda.Focus();
                text_valor_venda.Text = "";
                return;
            }
        }

        private void text_valor_real_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_valor_venda_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_lista_CheckedChanged(object sender, EventArgs e)
        {
            if (check_lista.Checked == true)
                lista_fornecedor.Enabled = false;
            else
            {
                lista_fornecedor.Enabled = true;
            }
        }

        private void lista_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Quando cliente selecionar um item da lista, este item é passado para 
            * variável valor_lista na função Lista_Fornecedores() */
            if (lista_fornecedor.SelectedItem == null)
            {
                lista_fornecedor.SelectedIndex = 0;
            }
            else
            {
                //Localizar item através do índice selecionado.
                int i = lista_fornecedor.SelectedIndex;
                lista_fornecedor.SelectedIndex = i;
                valor_lista = lista_fornecedor.Text;
            }
        }
    }
}
