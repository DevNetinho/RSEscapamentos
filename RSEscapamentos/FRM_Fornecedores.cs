using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSEscapamentos
{
    public partial class FRM_Fornecedores : Form
    {
        int id_fornecedor;

        //Mudará para true se algum cadastro for atualizado, para atualizar tabela das pesquisas.
        public bool AtualizarFornecedores { get; set; }

        public FRM_Fornecedores()
        {
            InitializeComponent();
        }

        private void FRM_Fornecedores_Load(object sender, EventArgs e)
        {
            //Construir tabela de fornecedores cadastrados.
            Construir_Grelha_Fornecedor();
        }

        private void Construir_Grelha_Fornecedor()
        {
            try
            {
                SqlCeConnection ligar_grelha_estoque = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
                ligar_grelha_estoque.Open();

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM fornecedores", ligar_grelha_estoque);
                DataTable dados_estoque = new DataTable();
                adaptador.Fill(dados_estoque);
                //Código responsável por ordenar as linhas do DataGridView de acordo com seu id_fornecedor, em ordem crescente.
                DataView dt = dados_estoque.AsDataView();
                dt.Sort = "id_fornecedor";

                //Comando para apresentar os dados na tabela dos clientes
                grelha_fornecedores.DataSource = dt;


                //Desativar botões
                btn_remover.Enabled = false;

                //Não exibir a coluna id_fornecedor.
                grelha_fornecedores.Columns["id_fornecedor"].Visible = false;

                ligar_grelha_estoque.Dispose();
                adaptador.Dispose();

                label_count.Text = "Fornecedores cadastrados: " + grelha_fornecedores.Rows.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Erro interno no programa, fechando o programa, se persistir o erro contate o desenvolvedor Ricardo Júnior. ", "Erro interno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            #region Verificações das caixas de texto

            if (text_nome.TextLength <= 2)
            {
                MessageBox.Show("O campo Nome deve conter no mínimo 3 caracteres!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            //Liga a base de dados
            SqlCeConnection ligar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar.Open();

            //Busca o maior valor da base
            SqlCeDataAdapter adaptador_fornecedores = new SqlCeDataAdapter("SELECT max(id_fornecedor) AS max_id FROM fornecedores", ligar);
            DataTable dados_fornecedores = new DataTable();
            adaptador_fornecedores.Fill(dados_fornecedores);

            //Verifica se o valor é null, se sim, adiciona o primeiro id da tabela.
            if (DBNull.Value.Equals(dados_fornecedores.Rows[0][0]))
            {
                id_fornecedor = 1;
            }
            else  //Se não for nulo, simplesmente soma o maior id + 1.
            {
                id_fornecedor = Convert.ToInt16(dados_fornecedores.Rows[0][0]) + 1;
            }

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = ligar;

            comando.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
            comando.Parameters.AddWithValue("@nome", text_nome.Text);
            comando.Parameters.AddWithValue("@telefone1", text_telefone1.Text);
            comando.Parameters.AddWithValue("@telefone2", text_telefone2.Text);
            comando.Parameters.AddWithValue("@cnpj", text_cnpj.Text);
            comando.Parameters.AddWithValue("@endereco", text_endereço.Text);
            comando.Parameters.AddWithValue("@cep", text_cep.Text);
            comando.Parameters.AddWithValue("@descricao", text_descricao.Text);

            comando.CommandText = "INSERT INTO fornecedores VALUES" +
                "(@id_fornecedor, @nome, @telefone1, @telefone2, @cnpj, @endereco, @cep, @descricao )";

            //Executar a query indicada acima.
            comando.ExecuteNonQuery();

            //TextBoxes ficarão vazias após cadastro.
            text_nome.Text = "";
            text_telefone1.Text = "";
            text_telefone2.Text = "";
            text_endereço.Text = "";
            text_cnpj.Text = "";
            text_cep.Text = "";
            text_descricao.Text = "";

            //Reconstruir tabela.
            Construir_Grelha_Fornecedor();

            //Exibir a coluna id_produto, para a variável indice_ativo fazer a contagem.
            //ATENÇÃO: EXCLUIR ESSA PARTE DO CÓDIGO PODE GERAR ERROS DE COMPILAÇÃO.
            grelha_fornecedores.Columns["id_fornecedor"].Visible = true;

            /*Variável indice_ativo >> Faz uma contagem do número total de registros do datagridview, subtrai -1.
            para selecionar o indice ativo, após o cadastro.*/
            int indice_ativo = grelha_fornecedores.Rows.Count - 1;
            grelha_fornecedores.CurrentCell = grelha_fornecedores.Rows[indice_ativo].Cells[0];
            grelha_fornecedores.Rows[indice_ativo].Selected = true;

            //Esconde a coluna
            grelha_fornecedores.Columns["id_fornecedor"].Visible = false;

            MessageBox.Show("Cadastro concluído com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Indicar para FRM_Inicio para atualizar tabela atualizada.
            AtualizarFornecedores = true;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o fornecedor cadastrado? ", "Deseja remover cadastro?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            FRM_Admin adm = new FRM_Admin(id_fornecedor, "FRM_Fornecedor_Remover");
            adm.ShowDialog();
            if (adm.Cancelar == true) //Se usuário cancelou a ação, não execute o código abaixo.
                return;
            Construir_Grelha_Fornecedor();
            btn_remover.Enabled = false;
            //Indicar para FRM_Inicio para atualizar tabela atualizada.
            AtualizarFornecedores = true;
        }

        private void grelha_fornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                btn_remover.Enabled = true;
            }
            //Define o id_fornecedor quando clicado uma vez.
            //Condição para não dar erro.
            if (e.RowIndex < 0)
            {
                return;
            }
            else
                id_fornecedor = Convert.ToInt16(grelha_fornecedores.Rows[e.RowIndex].Cells["id_fornecedor"].Value);
        }

        private void grelha_fornecedores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Construir_Grelha_Fornecedor();
        }

        private void grelha_fornecedores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                btn_remover.Enabled = true;
            }
            //Define o id_fornecedor quando clicado uma vez.
            //Condição para não dar erro.
            if (e.RowIndex < 0)
            {
                return;
            }
            else
                id_fornecedor = Convert.ToInt16(grelha_fornecedores.Rows[e.RowIndex].Cells["id_fornecedor"].Value);
        }
    }
}
