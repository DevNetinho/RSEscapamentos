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
    public partial class FRM_Estoque : Form
    {
        int id_produto;
        string valor_lista = "Padrão"; //Valor padrão atribuído a variável para não ser null e ocorrer bugs na lista.
        
        //Mudará para true se algum cadastro for atualizado, para atualizar tabela das pesquisas.
        public bool AtualizarEstoque { get; set; }

        public FRM_Estoque()
        {
            InitializeComponent();
        }

        private void FRM_Estoque_Load(object sender, EventArgs e)
        {
            //Construir tabela.
            Construir_Grelha_Estoque();
            //Contar linhas do grelha_estoque.
            label_count.Text = "Quantidade de produtos/peças cadastrados: " + grelha_estoque.Rows.Count.ToString();

            //Desativar botões do grelha_estoque.
            btn_remover.Enabled = false;
            btn_editar.Enabled = false;

            Lista_Fornecedores();
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

        private void Construir_Grelha_Estoque()
        {
            try
            {
                SqlCeConnection ligar_grelha_estoque = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
                ligar_grelha_estoque.Open();

                string query = "SELECT * FROM estoque";
                if (text_pesquisa.Text != "")//Se atender esta estrutura if, a query será alterada.
                        query = "SELECT * FROM estoque WHERE " +
                            "Código LIKE @item OR Produto LIKE @item OR Fornecedor LIKE @item";

                SqlCeCommand comando_estoque = new SqlCeCommand();
                comando_estoque.Parameters.AddWithValue("@item", "%" + text_pesquisa.Text + "%");
                comando_estoque.CommandText = query;
                comando_estoque.Connection = ligar_grelha_estoque;

                SqlCeDataAdapter adaptador_estoque = new SqlCeDataAdapter();
                adaptador_estoque.SelectCommand = comando_estoque;
                DataTable dados_estoque = new DataTable();
                adaptador_estoque.Fill(dados_estoque);
                //Código responsável por ordenar as linhas do DataGridView de acordo com seu id_fornecedor, em ordem crescente.
                DataView dt = dados_estoque.AsDataView();
                dt.Sort = "id_produto";

                //Comando para apresentar os dados na tabela dos clientes
                grelha_estoque.DataSource = dt;

                //Formatar células de colunas do grelha_estoque.
                grelha_estoque.Columns["Valor_Real"].DefaultCellStyle.Format = "C2";
                grelha_estoque.Columns["Valor_Venda"].DefaultCellStyle.Format = "C2";

                //Desativar botões
                btn_editar.Enabled = false;
                btn_remover.Enabled = false;

                //Não exibir a coluna id_estoque.
                grelha_estoque.Columns["id_produto"].Visible = false;
                ligar_grelha_estoque.Dispose();
                adaptador_estoque.Dispose();

                label_count.Text = "Quantidade de produtos/peças cadastrados: " + grelha_estoque.Rows.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Erro interno no programa, fechando o programa, se persistir o erro contate o desenvolvedor Ricardo Júnior. ", "Erro interno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        //Botão para cadastrar produtos.
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            #region Verificações do texto das textboxes
            if (valor_lista == "Padrão" && check_lista.Checked == true && check_lista.Checked == true) //Padrão indica que o usuário não selecionou um item na lista.
            {
                MessageBox.Show("Selecione um fornecedor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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

            //Liga a base de dados
            SqlCeConnection ligar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar.Open();

            //Busca o maior valor da base
            SqlCeDataAdapter adaptador_estoque = new SqlCeDataAdapter("SELECT max(id_produto) AS max_id FROM estoque", ligar);
            DataTable dados_estoque = new DataTable();
            adaptador_estoque.Fill(dados_estoque);

            //Verifica se o valor é null, se sim, adiciona o primeiro id da tabela.
            if (DBNull.Value.Equals(dados_estoque.Rows[0][0]))
            {
                id_produto = 1;
            }
            else  //Se não for nulo, simplesmente soma o maior id + 1.
            {
                id_produto = Convert.ToInt16(dados_estoque.Rows[0][0]) + 1;
            }

            SqlCeCommand comando_estoque = new SqlCeCommand();
            comando_estoque.Connection = ligar;

            //Verificar o estado da checkbox para registrar o fornecedor
            if (check_lista.Checked == true || valor_lista == "Padrão")
            {
                comando_estoque.Parameters.AddWithValue("@fornecedor", "- - - - ");
            }
            //Verifica se usuário escolheu item na lista_fornecedores.
            else if (valor_lista == null && check_lista.Checked == false)
            {
                MessageBox.Show("Escolha um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
                comando_estoque.Parameters.AddWithValue("@fornecedor", valor_lista);

            //Parametros para não haver SqlInjection e facilitar na hora de passar os valores para a base de dados.
            comando_estoque.Parameters.AddWithValue("@id_produto", id_produto);
            comando_estoque.Parameters.AddWithValue("@codigo",  text_codigo.Text);
            comando_estoque.Parameters.AddWithValue("@produto", text_produto.Text);
            comando_estoque.Parameters.AddWithValue("@quantidade", quantidade.Value);
            comando_estoque.Parameters.AddWithValue("@valor_real", text_valor_real.Text);
            comando_estoque.Parameters.AddWithValue("@valor_venda", text_valor_venda.Text);

            #region Verifica se existe código igual
            DataTable dados_busca = new DataTable();
            comando_estoque.CommandText = "SELECT * FROM estoque WHERE Código = @codigo";
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando_estoque;
            adaptador.Fill(dados_busca);
            if (dados_busca.Rows.Count != 0)
            {
                MessageBox.Show("O código inserido já existe em outro cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            //Query executada para registrar os valores na base de dados.
            comando_estoque.CommandText = "INSERT INTO estoque VALUES" +
                 "(@id_produto, @codigo, @produto, @fornecedor, @quantidade, @valor_real, @valor_venda)";

            adaptador_estoque = new SqlCeDataAdapter();
            dados_estoque = new DataTable();
            adaptador_estoque.SelectCommand = comando_estoque;
            adaptador_estoque.Fill(dados_estoque);

            //Zerar caixas de texto.
            text_codigo.Text = "";
            text_produto.Text = "";
            text_valor_real.Text = "";
            text_valor_venda.Text = "";
            quantidade.Value = 0;

            //Limpar itens da lista para evitar bugs.
            lista_fornecedor.Items.Clear();

            //Reconstruir a lista de fornecedores, se houver cadastros.
            Lista_Fornecedores();

            //Reconstrói a tabela.
            Construir_Grelha_Estoque();

            label_count.Text = "Quantidade de produtos/peças cadastrados: " + grelha_estoque.Rows.Count.ToString();
            MessageBox.Show("Produto/peça cadastrado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Exibir a coluna id_produto, para a variável indice_ativo fazer a contagem.
            //ATENÇÃO: EXCLUIR ESSA PARTE DO CÓDIGO PODE GERAR ERROS DE COMPILAÇÃO.
            grelha_estoque.Columns["id_produto"].Visible = true;

            /*Variável indice_ativo >> Faz uma contagem do número total de registros do datagridview, subtrai -1.
            para selecionar o indice ativo, após o cadastro.*/
            int indice_ativo = grelha_estoque.Rows.Count - 1;
            grelha_estoque.CurrentCell = grelha_estoque.Rows[indice_ativo].Cells[0];
            grelha_estoque.Rows[indice_ativo].Selected = true;

            //Esconde a coluna
            grelha_estoque.Columns["id_produto"].Visible = false;

            adaptador_estoque.Dispose();
            ligar.Dispose();

            //Indicar para FRM_Inicio atualizar a tabela de pesquisas.
            AtualizarEstoque = true;
        }

        //Formatar valor de preço digitado para formato de moeda.
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

        //Formatar valor de preço digitado para formato de moeda.
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

        //Quando clicar no cabeçalho da coluna.
        private void grelha_estoque_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Construir_Grelha_Estoque();
        }

        //Quando clicado em qualquer linha do grelha_estoque.
        private void grelha_estoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 || grelha_estoque.Rows.Count == 1)
            {
                btn_editar.Enabled = true;
                btn_remover.Enabled = true;
            }
            //Define o id_cliente quando clicado uma vez.
            //Condição para não dar erro.
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                id_produto = Convert.ToInt16(grelha_estoque.Rows[e.RowIndex].Cells["id_produto"].Value);

                //Fazer uma busca de acordo com o id_produto, para achar os resultados para preencher as labels.
                SqlCeConnection ligar = new SqlCeConnection("Data source = " + Base_Dados.base_dados);

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM estoque WHERE id_produto = " + id_produto, ligar);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //Converter valores que são retornados da base de dados.
                decimal valor_real = Convert.ToDecimal(dados.Rows[0]["Valor_Real"]);
                decimal valor_venda = Convert.ToDecimal(dados.Rows[0]["Valor_Venda"]);

                //Exibe os dados nas labels, quando usuário selecionar um item da tabela
                label_codigo.Text = "Código: " + dados.Rows[0]["Código"].ToString();
                label_produto.Text = "Produto/Peça: " + dados.Rows[0]["Produto"].ToString();
                label_quantidade.Text = "Quantidade: " + dados.Rows[0]["Quantidade"].ToString();
                label_valor_real.Text = "Preço real: R$" + valor_real.ToString("N2");
                label_valor_venda.Text = "Preço de venda: R$" + valor_venda.ToString("N2");

                //Calcular ganho na venda do produto.
                decimal ganho = valor_venda - valor_real;

                label_ganho.Text = "Ganho na venda: R$" + ganho.ToString("N2");

                ligar.Dispose();
                adaptador.Dispose();
            }
        }

        //Quando a célula é selecionada.
        private void grelha_estoque_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 || grelha_estoque.Rows.Count == 1)
            {
                btn_editar.Enabled = true;
                btn_remover.Enabled = true;
            }
            //Define o id_cliente quando clicado uma vez.
            //Condição para não dar erro.
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                id_produto = Convert.ToInt16(grelha_estoque.Rows[e.RowIndex].Cells["id_produto"].Value);

                //Fazer uma busca de acordo com o id_produto, para achar os resultados para preencher as labels.
                SqlCeConnection ligar = new SqlCeConnection("Data source = " + Base_Dados.base_dados);

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM estoque WHERE id_produto = " + id_produto, ligar);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //Converter valores que são retornados da base de dados.
                decimal valor_real = Convert.ToDecimal(dados.Rows[0]["Valor_Real"]);
                decimal valor_venda = Convert.ToDecimal(dados.Rows[0]["Valor_Venda"]);

                //Exibe os dados nas labels, quando usuário selecionar um item da tabela
                label_codigo.Text = "Código: " + dados.Rows[0]["Código"].ToString();
                label_produto.Text = "Produto/Peça: " + dados.Rows[0]["Produto"].ToString();
                label_quantidade.Text = "Quantidade: " + dados.Rows[0]["Quantidade"].ToString();
                label_valor_real.Text = "Preço real: R$" + valor_real.ToString("N2");
                label_valor_venda.Text = "Preço de venda: R$" + valor_venda.ToString("N2");

                //Calcular ganho na venda do produto.
                decimal ganho = valor_venda - valor_real;

                label_ganho.Text = "Ganho na venda: R$" + ganho.ToString("N2");

                ligar.Dispose();
                adaptador.Dispose();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o produto? ", "Deseja remover produto?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            FRM_Admin adm = new FRM_Admin(id_produto, "FRM_Estoque_Remover");
            adm.ShowDialog();
            if (adm.Cancelar == true) //Se usuário cancelou a ação, não execute o código abaixo.
                return;
            text_pesquisa.Text = ""; //Zerar caixa de pesquisa para não interferir na construção da tabela.
            Construir_Grelha_Estoque();
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;


            label_codigo.Text = "Código: ";
            label_produto.Text = "Produto/Peça: ";
            label_quantidade.Text = "Quantidade: ";
            label_valor_real.Text = "Preço real: R$";
            label_valor_venda.Text = "Preço de venda: R$";
            //Indicar para FRM_Inicio para atualizar tabela atualizada.
            AtualizarEstoque = true;
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
        
        //Lista de fornecedores.
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
        
        //Editar cadastro.
        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Criação do objeto para verificar se edição foi cancelada.
            FRM_Editar editar = new FRM_Editar();

            FRM_Admin adm = new FRM_Admin(id_produto, "FRM_Estoque_Editar");
            adm.ShowDialog();
            if (adm.Cancelar == true || editar.Editar_Cancelado == true) //Se usuário cancelou a ação, não execute o código abaixo.
                return;
            text_pesquisa.Text = "";
            Construir_Grelha_Estoque();
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
            MessageBox.Show("Edição concluída com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void text_pesquisa_TextChanged(object sender, EventArgs e)
        {
            Construir_Grelha_Estoque();
        }
    }
}
