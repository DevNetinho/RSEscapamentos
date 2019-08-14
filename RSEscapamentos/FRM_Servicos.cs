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
    public partial class FRM_Servicos : Form
    {
        //Variáveis para controle de id.
        int id_cliente;
        int id_servico;
        decimal valor; //Valor total da soma a ser passado para o formulário de forma de pagamento.
        //o tipo decimal, é o melhor jeito de trabalhar com formatos de moeda.

        public FRM_Servicos(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void FRM_Servicos_Load(object sender, EventArgs e)
        {
            //Desativar botão forma de pagamento.
            btn_finalizar.Enabled = false;
            btn_remover.Enabled = false;
            //Ativar o btn_finalizar, se condição for atendida.
            if (label_total.Text != "Valor total: R$0,00")
                btn_finalizar.Enabled = true;

            //Liga a base de dados para busca de dados que preencherão as labels.
            SqlCeConnection ligar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar.Open();

            #region Preencher labels serviço

            //Faz uma soma da tabela "Preço".
            SqlCeDataAdapter adaptador_servicos = new SqlCeDataAdapter("SELECT sum(Preço) AS soma FROM servicos WHERE id_cliente = " + id_cliente, ligar);
            DataTable dados_servicos = new DataTable();
            adaptador_servicos.Fill(dados_servicos);

            //Exibe o valor total da soma na label_total
            label_total.Text = "Valor total: R$" + dados_servicos.Rows[0]["soma"];
            try
            {
                valor = decimal.Parse(dados_servicos.Rows[0]["soma"].ToString()); //A variável valor será o valor total da soma de todos os precos da tabela serviços.
            }
            catch
            {
                if (DBNull.Value.Equals(dados_servicos.Rows[0][0]))
                {
                    label_total.Text = "Valor total: R$0,00";
                }
            }
            #endregion

            #region Preencher labels cliente

            //Fazer uma busca de acordo com o id_cliente, para achar os resultados para preencher as labels.
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM clientes WHERE id_cliente = " + id_cliente, ligar);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //Exibe os dados nas labels.
            label_veiculo.Text = dados.Rows[0]["Veículo"].ToString();
            label_placa.Text = dados.Rows[0]["Placa"].ToString();
            label_cliente.Text = dados.Rows[0]["Cliente"].ToString();
            label_telefone.Text = dados.Rows[0]["Celular_Telefone"].ToString();
            label_data.Text = dados.Rows[0]["Data_entrada"].ToString();

            ligar.Dispose();
            adaptador.Dispose();

            //Constrói tabela de servicos.
            Construir_Grelha_Servicos();
            #endregion
        }

        //Formatar o texto para formato de moeda.
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //Trecho responsável pela formatação da textBox.
            if (text_preco.Text == "")
            {
                return;
            }
            try
            {
                float texto = float.Parse(text_preco.Text);
                text_preco.Text = String.Format("{0:n}", texto);//Formatar o texto que está na caixa de texto.
            }
            catch
            {
                MessageBox.Show("Preço incorreto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                text_preco.Focus();
                return;
            }
        }

        //Construir tabela de serviços
        public void Construir_Grelha_Servicos()
        {
            #region Preencher Tabela
            SqlCeConnection ligar_grelha = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_grelha.Open();

            //Selecionar serviço de acordo com o id_cliente, id_serviço deve ser = id_cliente, então a cada cliente 
            //que ser registrado, você adiciona um id_serviço igual ao id_cliente.
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM servicos WHERE id_cliente =" + id_cliente, ligar_grelha);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //Comando para apresentar os dados na tabela dos serviços
            grelha_servicos.DataSource = dados;

            //Esconder a coluna id_cliente e id_serviço
            grelha_servicos.Columns["id_cliente"].Visible = false;
            grelha_servicos.Columns["id_servico"].Visible = false;

            #endregion
            #region Somar dados da coluna
            //Faz uma soma da tabela "Preço".
            SqlCeDataAdapter adaptador_servicos = new SqlCeDataAdapter("SELECT sum(Preço) AS soma FROM servicos WHERE id_cliente = " + id_cliente, ligar_grelha);
            DataTable dados_servicos = new DataTable();
            adaptador_servicos.Fill(dados_servicos);

            //Exibe o valor total da soma na label_total
            try
            {
                decimal valor_total = Convert.ToDecimal(dados_servicos.Rows[0]["soma"]);
                label_total.Text = "Valor total: R$" + String.Format("{0:n}", valor_total); //Formatar o texto que está na label.
                valor = decimal.Parse(dados_servicos.Rows[0]["soma"].ToString()); //A variável valor será o valor total da soma de todos os precos da tabela serviços.
            }
            catch
            {   //Se haver valor nulo na base de dados.
                if (DBNull.Value.Equals(dados_servicos.Rows[0][0])) 
                {
                    label_total.Text = "Valor total: R$0,00";
                }
            }

            adaptador_servicos.Dispose();
            ligar_grelha.Dispose();
            adaptador.Dispose();
            #endregion
        }   

        //Botão para cadastrar um serviço.
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Ativar o btn_finalizar, se condição for atendida.
            if (label_total.Text != "Valor total: R$0,00")
                btn_finalizar.Enabled = true;

            #region Verificações das textBoxs.
            //Verificações das textBoxs.
            if (text_servico.Text == "")
            {
                MessageBox.Show("Campo Serviço não preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (text_preco.Text == "")
            {
                MessageBox.Show("Campo Preço não preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            //Ligar Base de dados.
            SqlCeConnection ligar_base_servico = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_base_servico.Open();

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT max(id_servico) AS max_id FROM servicos", ligar_base_servico);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            adaptador.Dispose();
            dados.Dispose();

            //Verifica se o valor é null, se sim, adiciona o primeiro id da tabela.
            if (DBNull.Value.Equals(dados.Rows[0][0]))
            {
                id_servico = 1;
            }
            else  //Se não for nulo, simplesmente soma o maior id com 1 >>> id + 1.
            {
                id_servico = Convert.ToInt16(dados.Rows[0][0]) + 1;
            }

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection= ligar_base_servico;
            

            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@id_servico", id_servico);
            comando.Parameters.AddWithValue("@servico", text_servico.Text);
            comando.Parameters.AddWithValue("@preco", text_preco.Text);

            comando.CommandText = "INSERT INTO servicos VALUES( @id_servico, @id_cliente, @servico, @preco )";

            SqlCeDataAdapter adaptador1 = new SqlCeDataAdapter(comando);
            DataTable dados1 = new DataTable();
            adaptador1.Fill(dados1);

            grelha_servicos.DataSource = dados;

            comando.Dispose();
            ligar_base_servico.Dispose();

            //Reconstruir a tabela de serviços.
            Construir_Grelha_Servicos();

            //Zerar caixas de texto após o cadastro.
            text_servico.Text = "";
            text_preco.Text = "";

            MessageBox.Show("Serviço cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Botão para remover um serviço.
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o cadastro? ", "Deseja remover cadastro?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            FRM_Admin adm = new FRM_Admin(id_servico, "FRM_Servicos_Remover");
            adm.ShowDialog();
            if (adm.Cancelar == true) //Se usuário cancelou a ação, não execute o código abaixo.
                return;
            Construir_Grelha_Servicos();
            btn_finalizar.Enabled = false;
            btn_remover.Enabled = false;
        }

        //Abrir formulário para selecionar a forma de pagamento.
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            FRM_Forma_Pagamento finalizar = new FRM_Forma_Pagamento(id_cliente,valor);
            finalizar.ShowDialog();
            if (finalizar.Fechar == true)
                Close();
        }

        //Quando o formulário for ativado.
        private void FRM_Servicos_Activated(object sender, EventArgs e)
        {
            //Ativar o btn_finalizar, se condição for atendida.
            if (label_total.Text != "Valor total: R$0,00")
                btn_finalizar.Enabled = true;
        }

        //Quando alguma célula do datagridview for selecionada.
        private void grelha_servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_remover.Enabled = true;

            if (e.RowIndex > 0)
            {
                btn_remover.Enabled = true;
            }
            //Define o id_cliente quando clicado uma vez.
            //Condição para não dar erro.
            if (e.RowIndex < 0)
            {
                return;
            }
            else
                id_servico = Convert.ToInt16(grelha_servicos.Rows[e.RowIndex].Cells["id_servico"].Value);
        }

        private void grelha_servicos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_remover.Enabled = false;
        }
    }
}
