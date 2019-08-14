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
    public partial class FRM_Cadastrar_Cliente : Form
    {
        int id_cliente;
        //Mudará para true se algum cadastro for atualizado, para atualizar tabela das pesquisas.
        public bool AtualizarClientes { get; set; }

        public FRM_Cadastrar_Cliente()
        {
            InitializeComponent();
            //Mascarar textBox em formato de data.
            text_data.Mask = "00/00/0000";
        }

        private void FRM_Cadastrar_Cliente_Load(object sender, EventArgs e)
        {
            Construir_Grelha_Cliente();
            comboBox1.Items.Add("Celular");
            comboBox1.Items.Add("Telefone");
            label_count.Text = "Número de cadastros: " + grelha_cliente.Rows.Count.ToString();

            //Destivar componentes.
            text_pesquisa.Enabled = false;
            btn_remover.Enabled = false;
            text_telefone.Enabled = false;
        }

        //Verificações da combobox, conserte isto...
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Telefone")
            {
                text_telefone.Enabled = true;
                text_telefone.Mask = "(99) 9999-9999";
            }

            else if (comboBox1.Text == "Celular")
            {
                text_telefone.Enabled = true;
                text_telefone.Mask = "(99) 99999-9999";
            }
        }
        
        //Button para cadastrar clientes.
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string texto_data = text_data.Text;

            #region Verificacoes dos campos de texto

            //Verificações
            if (text_telefone.Enabled == true && text_telefone.MaskFull == false && text_data.MaskFull == false)
            {
                MessageBox.Show("Preencha uma data e um telefone válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (text_data.Enabled == false && text_telefone.Enabled == true && text_telefone.MaskFull == false)
            {
                MessageBox.Show("Preencha um telefone válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (text_data.MaskCompleted == false && checkBox1.Checked == false)
            {
                MessageBox.Show("Preencha uma data válida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (checkBox1.Checked == true)
            {
                texto_data = "NÃO MENCIONADA!";
            }

            if (text_telefone.Text == "" || comboBox1.Text == null)
            {
                text_telefone.Text = " -   -   -  -";
            }
            #endregion

            //Liga a base de dados
            SqlCeConnection ligar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar.Open();

            //Busca o maior valor da base
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT max(id_cliente) AS max_id FROM clientes", ligar);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //Verifica se o valor é null, se sim, adiciona o primeiro id da tabela.
            if (DBNull.Value.Equals(dados.Rows[0][0]))
            {
                id_cliente = 1;
            }
            else  //Se não for nulo, simplesmente soma o maior id + 1.
            {
                id_cliente = Convert.ToInt16(dados.Rows[0][0]) + 1;
            }

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = ligar;
            
            //Parametros para não haver SqlInjection e facilitar na hora de passar os valores para a base de dados.
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@veiculo", text_veiculo.Text);
            comando.Parameters.AddWithValue("@placa", text_placa.Text);
            comando.Parameters.AddWithValue("@data", texto_data);
            comando.Parameters.AddWithValue("@cliente", text_cliente.Text);
            comando.Parameters.AddWithValue("@telefone", text_telefone.Text);

            comando.CommandText = "INSERT INTO clientes VALUES" +
                 "(@id_cliente, @veiculo, @placa, @cliente, @telefone, @data)";

            adaptador = new SqlCeDataAdapter();
            dados = new DataTable();
            adaptador.SelectCommand = comando;
            adaptador.Fill(dados);

            text_pesquisa.Text = "";
            radio_cliente.Checked = false;
            radio_data.Checked = false;
            radio_placa.Checked = false;
            radio_veiculo.Checked = false;
            text_pesquisa.Enabled = false;

            Construir_Grelha_Cliente();

            label_count.Text = "Número de cadastros: " + grelha_cliente.Rows.Count.ToString();
            MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Exibir a coluna id_cliente, para a variável indice_ativo fazer a contagem.
            //ATENÇÃO: EXCLUIR ESSA PARTE DO CÓDIGO PODE GERAR ERROS DE COMPILAÇÃO.
            grelha_cliente.Columns["id_cliente"].Visible = true;

            /*Variável indice_ativo >> Faz uma contagem do número total de registros do datagridview, subtrai -1.
            para selecionar o indice ativo, após o cadastro.*/
            int indice_ativo = grelha_cliente.Rows.Count - 1;
            grelha_cliente.CurrentCell = grelha_cliente.Rows[indice_ativo].Cells[0];
            grelha_cliente.Rows[indice_ativo].Selected = true;
            
            //Esconde a coluna
            grelha_cliente.Columns["id_cliente"].Visible = false;

            //Zera todas caixas de texto depois de cadastrar.
            text_cliente.Text = "";
            text_data.Text= "";
            text_placa.Text = "";
            text_veiculo.Text = "";
            text_telefone.Text = "";
            text_telefone.Enabled = false;
            comboBox1.Text = null;
            text_cliente.Focus();

            comando.Dispose();
            adaptador.Dispose();
            ligar.Dispose();

            //Indicar para FRM_Inicio atualizar a tabela de pesquisas.
            AtualizarClientes = true;
        }

        //Constrói tabela de clientes.
        public void Construir_Grelha_Cliente()
        {
            try
            {
                SqlCeConnection ligar_grelha = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
                ligar_grelha.Open();

                string query = "SELECT * FROM clientes";
                if (text_pesquisa.Text != "")//Se atender esta estrutura if, a query será alterada.
                {
                    //Filtro de Veículos.
                    if (radio_veiculo.Checked == true)
                        query = "SELECT * FROM clientes WHERE " +
                            "Veículo LIKE @item";

                    //Filtro de Placas.
                    else if (radio_placa.Checked == true)
                        query = "SELECT * FROM clientes WHERE " +
                            "Placa LIKE @item";

                    //Filtro de Clientes.
                    else if (radio_cliente.Checked == true)
                        query = "SELECT * FROM clientes WHERE " +
                            "Cliente LIKE @item";

                    //Filtro de Datas.
                    else if (radio_data.Checked == true)
                        query = "SELECT * FROM clientes WHERE " +
                            "Data_entrada LIKE @item";
                }

                SqlCeCommand comando = new SqlCeCommand();
                comando.Parameters.AddWithValue("@item", "%" + text_pesquisa.Text + "%");
                comando.CommandText = query;
                comando.Connection = ligar_grelha;

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
                adaptador.SelectCommand = comando;

                DataTable dados = new DataTable();
                adaptador.Fill(dados);
                //Código responsável por ordenar as linhas do DataGridView de acordo com seu id_cliente, em ordem crescente.
                DataView dt = dados.AsDataView();
                dt.Sort = "id_cliente";

                //Comando para apresentar os dados na tabela dos clientes
                grelha_cliente.DataSource = dt;

                //Exibir a coluna id_cliente.
                grelha_cliente.Columns["id_cliente"].Visible = false;


                ligar_grelha.Dispose();
                adaptador.Dispose();
            }
            catch
            {
                MessageBox.Show("Erro interno no programa, fechando o programa, se persistir o erro contate o desenvolvedor Ricardo Júnior. ", "Erro interno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                text_data.Enabled = false;
            }
            else
                text_data.Enabled = true;
        }

        //Define o id_cliente quando clicado duas vezes.
        private void grelha_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
                id_cliente = Convert.ToInt16(grelha_cliente.Rows[e.RowIndex].Cells["id_cliente"].Value);

            SqlCeConnection ligar_base = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_base.Open();
            //Fará uma busca na base de dados para verificar se o cadastro já não foi finalizado.
            SqlCeDataAdapter adaptador_busca = new SqlCeDataAdapter("SELECT * FROM finalizados WHERE id_cliente = " + id_cliente, ligar_base);
            DataTable dados_busca = new DataTable();
            adaptador_busca.Fill(dados_busca);
            if (dados_busca.Rows.Count == 0) //Faz a contagem de linhas da tabela, se for igual a 0, abre FRM_Servicos.
            {
                FRM_Servicos servicos = new FRM_Servicos(id_cliente);
                servicos.ShowDialog();
            }
            else
            {
                FRM_Detalhes detalhes = new FRM_Detalhes(id_cliente);
                detalhes.ShowDialog();
            }
        }

        //Selecionar id_cliente, quando ouver click em alguma linha de grelha_cliente.
        private void grelha_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
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
                id_cliente = Convert.ToInt16(grelha_cliente.Rows[e.RowIndex].Cells["id_cliente"].Value);
        }

        //Remover cliente.
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o cadastro? ", "Deseja remover cadastro?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            FRM_Admin adm = new FRM_Admin(id_cliente, "FRM_Cadastrar_Cliente_Deletar");
            adm.ShowDialog();
            if (adm.Cancelar == true) //Se usuário cancelou a ação, não execute a linha de código abaixo.
                return;

            text_pesquisa.Text = "";
            radio_cliente.Checked = false;
            radio_data.Checked = false;
            radio_placa.Checked = false;
            radio_veiculo.Checked = false;
            text_pesquisa.Enabled = false;
            Construir_Grelha_Cliente();

            //id_cliente ficará = 0, para o btn_remover ficar desabilitado.
            id_cliente = 0;

            if (id_cliente == 0)
            {
                btn_remover.Enabled = false;
            }
            label_count.Text = "Número de cadastros: " + grelha_cliente.Rows.Count.ToString();
            //Indicar para FRM_Inicio para atualizar tabela atualizada.
            AtualizarClientes = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //REMOVE ESSA MERDA DE EVENTO SEU MANÉ.
        }

        private void grelha_cliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Construir_Grelha_Cliente();
        }

        private void grelha_cliente_CellEnter(object sender, DataGridViewCellEventArgs e)
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
                id_cliente = Convert.ToInt16(grelha_cliente.Rows[e.RowIndex].Cells["id_cliente"].Value);
        }

        private void radio_veiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_veiculo.Checked == true)
            {
                text_pesquisa.Text = "";
                text_pesquisa.Enabled = true;
                text_pesquisa.Focus();
            }
        }

        private void radio_placa_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_placa.Checked == true)
            {
                text_pesquisa.Text = "";
                text_pesquisa.Enabled = true;
                text_pesquisa.Focus();
            }
        }

        private void radio_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_cliente.Checked == true)
            {
                text_pesquisa.Text = "";
                text_pesquisa.Enabled = true;
                text_pesquisa.Focus();
            }
        }

        private void radio_data_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_data.Checked == true)
            {
                text_pesquisa.Text = "";
                text_pesquisa.Enabled = true;
                text_pesquisa.Focus();
            }
        }

        private void text_pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (text_pesquisa.Text == "")
            {
                Construir_Grelha_Cliente();
            }
            else
                Construir_Grelha_Cliente();
        }

        private void text_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Construir_Grelha_Cliente();
        }

        private void text_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            Construir_Grelha_Cliente();
        }

        private void text_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            Construir_Grelha_Cliente();
        }
    }
}
