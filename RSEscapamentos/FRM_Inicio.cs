using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSEscapamentos
{
    public partial class FRM_Inicio : Form
    {
        string text_usuario;
        public FRM_Inicio(string text_usuario)
        {
            InitializeComponent();
            //Deixar a variável text_usuario como variável global.
            this.text_usuario = text_usuario;
            this.FormClosing += new FormClosingEventHandler(FRM_Inicio_FormClosing);
        }

        private void FRM_Inicio_Load(object sender, EventArgs e)
        {
            label_mensagem.Text = "Bem vindo(a) " + text_usuario;
            //Mensagem de boas vindas.
            MessageBox.Show("Bem vindo(a) " + text_usuario + "!", "Bem Vindo(a)!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Verificar se há pagamentos pendentes no Banco de dados
            Base_Dados.Verificar_Pendentes();

            radio_clientes.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificar se usuário deseja sair.
            if (MessageBox.Show("Deseja mesmo sair do programa " + text_usuario + " ?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //Fechar programa.
            Application.Exit();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            text_pesquisa.Text = "";

            //Abrir novo formulário.
            FRM_Cadastrar_Cliente cadastro = new FRM_Cadastrar_Cliente();
            cadastro.ShowDialog();
            //Atualizar valores da grelha_pesquisa.
            if (cadastro.AtualizarClientes == true && radio_clientes.Checked == true)
                Tabelas("clientes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_pesquisa.Text = "";
            //Abrir formulário de serviços pendentes
            FRM_Pendentes pendentes = new FRM_Pendentes();
            pendentes.ShowDialog();
        }

        //Impedir que janela de confirmação abra duas vezes.
        private void FRM_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Toda essa engenhoca(gambiarra), para a janela de confirmação não abrir duas vezes kkkkkkkkkkk.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Se o usuario presionar "Não" na MessageBox, executa esse if, para a MessageBox não abrir duas vezes.
                if (e.Cancel == true)
                {
                    return;
                }

                //Verificar se usuário deseja sair.
                if (MessageBox.Show("Deseja mesmo sair do programa " + text_usuario + " ?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {

                    e.Cancel = true;
                    return;
                }
                else //Fechar programa.
                    Application.Exit();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text_pesquisa.Text = "";
            FRM_Estoque estoque = new FRM_Estoque();
            estoque.ShowDialog();
            if (estoque.AtualizarEstoque == true && radio_estoque.Checked == true)
                Tabelas("estoque");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text_pesquisa.Text = "";
            FRM_Fornecedores fornecedores = new FRM_Fornecedores();
            fornecedores.ShowDialog();

            if (fornecedores.AtualizarFornecedores == true && radio_fornecedores.Checked == true)
                Tabelas("fornecedores");
        }

        private void btn_fechamento_Click(object sender, EventArgs e)
        {
            text_pesquisa.Text = "";
            FRM_Calcular_Fechamento fechamento = new FRM_Calcular_Fechamento();
            fechamento.ShowDialog();
        }

        private void Tabelas(string tabela)
        {
            //Liga a base de dados
            SqlCeConnection ligar_tabela = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_tabela.Open();

            //Busca o maior valor da base
            SqlCeDataAdapter adaptador_tabela = new SqlCeDataAdapter("SELECT * FROM " + tabela, ligar_tabela);
            DataTable dados_tabela = new DataTable();
            adaptador_tabela.Fill(dados_tabela);

            //Código responsável por ordenar as linhas do DataGridView de acordo com o id, em ordem crescente.
            DataView dt = dados_tabela.AsDataView();

            //Determina a organização da tabela de acordo com o id da tabela que foi declarada no parametro "tabela".
            if (tabela == "clientes")
                dt.Sort = "id_cliente";
            else if (tabela == "estoque")
                dt.Sort = "id_produto";
            else if (tabela == "fornecedores")
                dt.Sort = "id_fornecedor";

            //Comando para apresentar os dados na tabela de pesquisa.
            grelha_pesquisa.DataSource = dt;

            //Esconder colunas apenas se estiverem visíveis.
            if (tabela == "clientes")
            {
                if (grelha_pesquisa.Columns["id_cliente"].Visible == true)
                    grelha_pesquisa.Columns["id_cliente"].Visible = false;
            }
            else if (tabela == "fornecedores")
            {
                if (grelha_pesquisa.Columns["id_fornecedor"].Visible == true)
                    grelha_pesquisa.Columns["id_fornecedor"].Visible = false;
            }
            else if (tabela == "estoque")
            {
                if (grelha_pesquisa.Columns["id_produto"].Visible == true)
                    grelha_pesquisa.Columns["id_produto"].Visible = false;
            }

            ligar_tabela.Dispose();
            adaptador_tabela.Dispose();
        }

        private void PesquisarTudo(string filtro)
        {
            SqlCeConnection ligar_bd = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_bd.Open();

            string query = ""; //Se atender esta estrutura if, a query será alterada.
            if (text_pesquisa.Text != "")
            {
                //Se o filtro corresponder ao cliente.
                if (filtro == "clientes")
                {
                    query = "SELECT * FROM clientes WHERE Veículo LIKE @item OR " +
                        "Placa LIKE @item OR Cliente LIKE @item OR Celular_Telefone LIKE @item OR Data_Entrada LIKE @item";
                }
                else if (filtro == "fornecedores")
                {
                    query = "SELECT * FROM fornecedores WHERE Nome LIKE @item OR Telefone1 LIKE @item OR " +
                        "Telefone2 LIKE @item OR CNPJ LIKE @item OR Endereço LIKE @item OR CEP LIKE @item OR " +
                        "Descrição LIKE @item";
                }
                else if (filtro == "estoque")
                {
                    query = "SELECT * FROM estoque WHERE Código LIKE @item OR Produto LIKE @item OR " +
                        "Fornecedor LIKE @item ";
                }
            }
            else //Se nenhuma das condições forem atendidas, verifica os radioButtons checados.
            {
                if (radio_clientes.Checked == true)
                {
                    Tabelas("clientes");
                    return;
                }
                else if (radio_estoque.Checked == true)
                {
                    Tabelas("estoque");
                    return;
                }
                else if (radio_fornecedores.Checked == true)
                {
                    Tabelas("fornecedores");
                    return;
                }
            }

            SqlCeCommand comando_pesquisa = new SqlCeCommand();
            comando_pesquisa.Parameters.AddWithValue("@item", "%" + text_pesquisa.Text + "%");
            comando_pesquisa.CommandText = query;
            comando_pesquisa.Connection = ligar_bd;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando_pesquisa;

            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            
            //Comando para apresentar os dados na tabela de pesquisa.
            grelha_pesquisa.DataSource = dados;

            //Esconder colunas apenas se estiverem visíveis.
            if (filtro == "clientes")
                if (grelha_pesquisa.Columns["id_cliente"].Visible == true)
                    grelha_pesquisa.Columns["id_cliente"].Visible = false;

            else if (filtro == "fornecedores")
                if(grelha_pesquisa.Columns["id_fornecedor"].Visible == true)
                    grelha_pesquisa.Columns["id_fornecedor"].Visible = false;

            else if (filtro == "estoque")
                if (grelha_pesquisa.Columns["id_fornecedor"].Visible == true)
                    grelha_pesquisa.Columns["id_produto"].Visible = false;

            ligar_bd.Dispose();
            adaptador.Dispose();
        }

        #region Verificação de checagem das checkBoxes

        private void radio_clientes_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_clientes.Checked == true)
            {
                //Construir tabela dos clientes.
                Tabelas("clientes");
                text_pesquisa.Text = "";
            }
        }

        private void radio_estoque_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_estoque.Checked == true)
            {
                //Construir tabela de estoques.
                Tabelas("estoque");
                text_pesquisa.Text = "";
            }
        }

        private void radio_fornecedores_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_fornecedores.Checked == true)
            {
                //Construir tabela dos fornecedores.
                Tabelas("fornecedores");
                text_pesquisa.Text = "";
            }
        }

        #endregion

        //Pesquisar enquanto o texto é digitado
        private void text_pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (radio_clientes.Checked == true)
            {
                //Pesquisar tudo da tabela clientes.
                PesquisarTudo("clientes");
            }
            else if (radio_estoque.Checked == true)
            {
                //Pesquisar tudo da tabela estoque
                PesquisarTudo("estoque");
            }
            else if (radio_fornecedores.Checked == true)
            {
                //Pesquisar tudo da tabela fornecedores
                PesquisarTudo("fornecedores");
            }
        }

        private void btn_alterar_senha_Click(object sender, EventArgs e)
        {
            FRM_Admin admin = new FRM_Admin(0, "FRM_Alterar_Senha");
            admin.ShowDialog();

        }
    }
}
