using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSEscapamentos
{
    public partial class FRM_Pendentes : Form
    {
        public bool AtivaNaoPagos { get; set; } //Verifica se usuário selecionou a opção sim da verificação e ativa o radiobutton.
        int id_pendente;
        public FRM_Pendentes()
        {
            InitializeComponent();
        }

        //Construir a tabela de serviços pendentes.
        private void Construir_Grelha_Pendentes(string filtro = "Pendentes")
        {
            #region Montar tabela pendentes
            SqlCeConnection ligar_base = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_base.Open();

            //Query padrão que será executada se nenhum if for atendido.
            string query = "SELECT * FROM pendentes WHERE Pendente = 2"; //Pagamentos pendentes.

            if (filtro == "Não Pagos")
                query = "SELECT * FROM pendentes WHERE Pendente = 0"; //Pagamentos não pagos.
            else if (filtro == "Pagos")
                query = "SELECT * FROM pendentes WHERE Pendente = 1"; //Pagamentos pagos.

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, ligar_base);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            //Código responsável por ordenar as linhas do DataGridView de acordo com seu id_cliente, em ordem crescente.
            DataView dt = dados.AsDataView();
            dt.Sort = "id_pendente";

            //Comando para apresentar os dados na tabela dos clientes
            grelha_pendentes.DataSource = dt;

            //Esconder colunas da tabela dos pendentes.
            grelha_pendentes.Columns["id_pendente"].Visible = false;
            grelha_pendentes.Columns["Pendente"].Visible = false;

            adaptador.Dispose();
            #endregion
        }

        private int ContarCadastros(string tipo = "Pendentes")
        {
            SqlCeConnection ligar_base = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_base.Open();

            //Query padrão que será executada se nenhum if for atendido.
            string query = "SELECT * FROM pendentes WHERE Pendente = 2";

            if (tipo == "Não Pagos")
                query = "SELECT * FROM pendentes WHERE Pendente = 0"; //Pagamentos não pagos.
            else if (tipo == "Pagos")
                query = "SELECT * FROM pendentes WHERE Pendente = 1"; //Pagamentos pagos.

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, ligar_base);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            int contador = dados.Rows.Count;

            ligar_base.Dispose();
            adaptador.Dispose();

            return contador;
        }

        private void FRM_Pendentes_Load(object sender, EventArgs e)
        {
            //Desativar buttons.
            btn_pago.Enabled = false;
            btn_visualizar.Enabled = false;
            btn_remover.Enabled = false;
            //Construir a base de dados dos Pendentes.
            Construir_Grelha_Pendentes();
            //Contar número de cadstros que contém em Pendentes.
            label_count.Text = "Número de cadastros pendentes: " + ContarCadastros();
            //Contar Cadastros Pagos e Não Pagos.
            label_nao_pagos.Text = "Número de cadastros não pagos: " + ContarCadastros("Não Pagos");
            label_pagos.Text = "Número de cadastros pagos: " + ContarCadastros("Pagos");

            grelha_pendentes.Columns["id_pendente"].Visible = true;
            grelha_pendentes.Columns["Pendente"].Visible = true;
            radio_pendentes.Checked = true;

            if (AtivaNaoPagos == true)
            {
                radio_nao_pagos.Checked = true;
                Construir_Grelha_Pendentes("Não Pagos");
            }
                
        }

        //Formatar a caixa de texto dos preços.
        private void text_preco_Leave(object sender, EventArgs e)
        {
            if (text_valor.TextLength == 0)
            {
                text_valor.Text = "";
                return;
            }
            try
            {
                float texto = float.Parse(text_valor.Text);
                text_valor.Text = String.Format("{0:n}", texto);
            }
            catch
            {
                MessageBox.Show("Apenas valores numéricos no campo Valor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                text_valor.Focus();
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            #region Verificação das caixas de texto
            try
            {

                if (text_data1.TextLength == 0)
                {
                    MessageBox.Show("O campo Início não pode estar vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (text_data2.TextLength == 0)
                {
                    MessageBox.Show("O campo Vencimento não pode estar vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Verificações das caixas de texto.
                DateTime convertido1 = DateTime.Parse(text_data1.Text);
                DateTime convertido2 = DateTime.Parse(text_data2.Text);

                if (convertido1 > convertido2)
                {
                    MessageBox.Show("A data de Início não pode ser maior que Vencimento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Os campos de data não podem estar vazios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (text_data1.MaskFull == false && text_data2.MaskFull == false)
            {
                MessageBox.Show("Insira uma data válida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (text_valor.TextLength == 0)
            {
                MessageBox.Show("Insira um valor pendente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            //Ligação da base de dados.
            SqlCeConnection ligar_base_pendentes = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_base_pendentes.Open();

            //Busca o maior valor da base
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT max(id_pendente) AS max_id FROM pendentes", ligar_base_pendentes);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //Verifica se o valor é null, se sim, adiciona o primeiro id da tabela.
            if (DBNull.Value.Equals(dados.Rows[0][0]))
            {
                id_pendente = 1;
            }
            else  //Se não for nulo, simplesmente soma o maior id + 1.
            {
                id_pendente = Convert.ToInt16(dados.Rows[0][0]) + 1;
            }

            adaptador.Dispose();
            dados.Dispose();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = ligar_base_pendentes;

            //Converte para data americana.
            DateTime convertido = DateTime.Parse(text_data2.Text);
            string formatar = convertido.ToString("yyyy-MM-dd");
            if (convertido > DateTime.Now)
                comando.Parameters.AddWithValue("@pendente", 2);// 2 >> Indica que não chegou a data de pagamento
            else
            {
                comando.Parameters.AddWithValue("@pendente", 0); //0 indica que está pendente
                MessageBox.Show("A data final deste cadastro é maior que a data de hoje, este cadastro " +
                    "será cadastrado nos Não pagos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                radio_nao_pagos.Checked = true;
                radio_pagos.Checked = false;
                radio_pendentes.Checked = false;
                Construir_Grelha_Pendentes("Não Pagos");
            }
            //Parametros:
            comando.Parameters.AddWithValue("@id_cliente", id_pendente);
            comando.Parameters.AddWithValue("@cliente", text_cliente.Text);
            comando.Parameters.AddWithValue("@veiculo", text_veiculo.Text);
            comando.Parameters.AddWithValue("@placa", text_placa.Text);
            comando.Parameters.AddWithValue("@descricao", text_desc.Text);
            comando.Parameters.AddWithValue("@telefone", text_telefone.Text);
            comando.Parameters.AddWithValue("@data_inicio", text_data1.Text);
            comando.Parameters.AddWithValue("@data_final", formatar);
            comando.Parameters.AddWithValue("@valor", text_valor.Text);

            //Consulta na base de dados para registrar os dados das caixas de texto.
            comando.CommandText = "INSERT INTO pendentes VALUES" +
                "(@id_cliente, @pendente, @cliente, @veiculo, @placa, @descricao, @telefone, @data_inicio, @data_final, @valor)";

            SqlCeDataAdapter adaptador1 = new SqlCeDataAdapter(comando);
            DataTable dados1 = new DataTable();
            adaptador1.Fill(dados1);

            Construir_Grelha_Pendentes();
            radio_pendentes.Checked = true;

            MessageBox.Show("Cadastrado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            adaptador1.Dispose();
            ligar_base_pendentes.Dispose();

            //Zerar caixas de texto.
            text_cliente.Text = "";
            text_veiculo.Text = "";
            text_placa.Text = "";
            text_desc.Text = "";
            text_telefone.Text = "";
            text_data1.Text = "";
            text_data2.Text = "";
            text_valor.Text = "";

            //Desativar buttons.
            btn_pago.Enabled = false;
            btn_visualizar.Enabled = false;
            btn_remover.Enabled = false;

            //Atualizar número de cadastros pendentes.
            label_count.Text = "Número de cadastros pendentes: " + ContarCadastros();
            //Contar Cadastros Pagos e Não Pagos.
            label_nao_pagos.Text = "Número de cadastros não pagos: " + ContarCadastros("Não Pagos");
            label_pagos.Text = "Número de cadastros pagos: " + ContarCadastros("Pagos");
            
        }

        //Verifica se data de text_data2 está em seu devido formato.
        private void text_data2_Leave(object sender, EventArgs e)
        {
            //Se text_data2, não estiver completa, remover todos os caracteres.
            if (text_data2.MaskCompleted == false)
            {
                text_data2.Text = "";
                return;
            }

            else
            {
                try
                {
                    //Converte o texto digitado na text_data2 para verificar se data é válida.
                    DateTime convertido = DateTime.Parse(text_data2.Text);
                    string formatar = convertido.ToString("yyyy-MM-dd");
                }
                catch
                {
                    MessageBox.Show("Insira uma data válida no campo Vencimento!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    text_data2.Focus();
                    return;
                }
            }
        }

        //Marcar como pago
        private void btn_pago_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que quer marcar como pago?", "Atenção!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;

            FRM_Admin admin = new FRM_Admin(id_pendente, "FRM_Pendentes_Pago");
            admin.ShowDialog();
            radio_pagos.Checked = true;
            label_count.Text = "Número de cadastros pendentes: " + ContarCadastros();
            label_nao_pagos.Text = "Número de cadastros não pagos: " + ContarCadastros("Não Pagos");
            label_pagos.Text = "Número de cadastros pagos: " + ContarCadastros("Pagos");
            Construir_Grelha_Pendentes("Pagos");
        }

        //Define id_pendente quando clicado.
        private void grelha_pendentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SELECIONA UM ÍNDICE NO DATAGRIDVIEW.
            if (e.RowIndex < 0)
            {
                return;
            }
            else
                id_pendente = Convert.ToInt16(grelha_pendentes.Rows[e.RowIndex].Cells["id_pendente"].Value);

            //Só ativa os 
            if (radio_pagos.Checked == true)
            {
                btn_visualizar.Enabled = true;
                btn_pago.Enabled = false;
                btn_remover.Enabled = true;
                return;
            }
            btn_visualizar.Enabled = true;
            btn_pago.Enabled = true;
            btn_remover.Enabled = true;
        }

        //Verifica se data de text_data1 está em seu devido formato.
        private void text_data1_Leave(object sender, EventArgs e)
        {
            //Se text_data1, não estiver completa, remover todos os caracteres digitados.
            if (text_data1.MaskCompleted == false)
            {
                text_data1.Text = "";
                return;
            }

            else
            {
                try
                {
                    //Converte o texto digitado na text_data1 para verificar se data é válida.
                    DateTime convertido = DateTime.Parse(text_data1.Text);
                    string formatar = convertido.ToString("yyyy-MM-dd");
                }
                catch
                {
                    //Se data não é válida, alerte o usuário
                    MessageBox.Show("Insira uma data válida no campo Início!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    text_data1.Focus();
                    return;
                }
            }

        }

        //Abre novo Form para o usuário visualizar informações sobre o cadastro pendente.
        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            FRM_Visulizar visualizar = new FRM_Visulizar(id_pendente);
            visualizar.ShowDialog();
        }

        //Quando clicar no cabeçalho da coluna, reconstruir tabela.
        private void grelha_pendentes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
        }

        //Remover cliente
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o cadastro? ", "Deseja remover cadastro?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            FRM_Admin adm = new FRM_Admin(id_pendente, "FRM_Pendentes_Remover");
            adm.ShowDialog();
            //Verifica se usuário cancelou a ação.
            if (adm.Cancelar == true)
                return;

            Construir_Grelha_Pendentes();

            //Contar Cadastros Pagos, Não Pagos e Pendentes
            label_nao_pagos.Text = "Número de cadastros não pagos: " + ContarCadastros("Não Pagos");
            label_pagos.Text = "Número de cadastros pagos: " + ContarCadastros("Pagos");
            label_count.Text = "Número de cadastros pendentes: " + ContarCadastros();

            if (radio_pendentes.Checked == true)
                Construir_Grelha_Pendentes();
            else if (radio_pagos.Checked == true)
                Construir_Grelha_Pendentes("Pagos");
            else if (radio_nao_pagos.Checked == true)
                Construir_Grelha_Pendentes("Não Pagos");
        }

        #region Checagem das checkboxes
        private void radio_pendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_pendentes.Checked == true)
            {
                Construir_Grelha_Pendentes(); //Exibir tabela apenas com valores pendentes.
                //Desativar buttons.
                btn_pago.Enabled = false;
                btn_visualizar.Enabled = false;
                btn_remover.Enabled = false;
            }
        }

        private void radio_nao_pagos_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nao_pagos.Checked == true)
            {
                Construir_Grelha_Pendentes("Não Pagos");
                //Desativar buttons.
                btn_pago.Enabled = false;
                btn_visualizar.Enabled = false;
                btn_remover.Enabled = false;
            }
        }

        private void radio_pagos_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_pagos.Checked == true)
            {
                Construir_Grelha_Pendentes("Pagos");
                //Desativar buttons.
                btn_pago.Enabled = false;
                btn_visualizar.Enabled = false;
                btn_remover.Enabled = false;
            }
        }
        #endregion

    }
}
