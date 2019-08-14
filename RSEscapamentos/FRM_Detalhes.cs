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
    public partial class FRM_Detalhes : Form
    {
        int id_cliente;

        public FRM_Detalhes(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void FRM_Detalhes_Load(object sender, EventArgs e)
        {
            #region Buscar dados do cliente
            //Ligar base de dados.
            SqlCeConnection ligar_base = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_base.Open();

            //Fazer uma busca de acordo com o id_cliente, para achar os resultados para preencher as labels.
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM clientes WHERE id_cliente = " + id_cliente, ligar_base);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //Exibe os dados nas labels.
            label_veiculo.Text = dados.Rows[0]["Veículo"].ToString();
            label_placa.Text = dados.Rows[0]["Placa"].ToString();
            label_cliente.Text = dados.Rows[0]["Cliente"].ToString();
            label_telefone.Text = dados.Rows[0]["Celular_Telefone"].ToString();
            label_data.Text = dados.Rows[0]["Data_entrada"].ToString();

            #endregion

            #region Busca informações de pagamento
            DataTable dados_comando = new DataTable();
            SqlCeCommand comando_busca= new SqlCeCommand();
            comando_busca.Connection = ligar_base;
            comando_busca.CommandText = "SELECT * FROM finalizados WHERE id_cliente = " + id_cliente; //Query em busca de valores pagos, para pintar as linhas de verde.
            SqlCeDataAdapter adaptador_comando = new SqlCeDataAdapter();
            adaptador_comando.SelectCommand = comando_busca;
            adaptador_comando.Fill(dados_comando);

            //Converter data para formato brasileiro, para ser apresentada nas labels corretamente.
            DateTime data_final = Convert.ToDateTime(dados_comando.Rows[0]["data_final"].ToString());
            string conversor = Convert.ToString(data_final.ToString("dd/MM/yyyy"));

            //Covnerter preço para ser apresentado com vírgulas
            decimal valor_convertido = Convert.ToDecimal(dados_comando.Rows[0]["valor_total"]);


            label_pagamento.Text = "Forma de pagamento: " + dados_comando.Rows[0]["forma_pagamento"].ToString();
            label_tipo.Text = "Tipo: " + dados_comando.Rows[0]["tipo_cartao"].ToString();
            label_maquina.Text = "Máquina de cartão: " + dados_comando.Rows[0]["maquina_cartao"].ToString();
            label_valor_parcelas.Text = "Valor das Parcelas: " + dados_comando.Rows[0]["valor_parcelas"].ToString();
            label_data_final.Text = "Data Final: " + conversor;
            label_parcelas.Text = "Parcelas: " + dados_comando.Rows[0]["parcelas"].ToString();
            label_total.Text = "Valor total: " + valor_convertido.ToString("N2");

            if (label_tipo.Text == "Tipo: Débito")
            {
                //Esconder resultados irrelevantes, que dificultam o entendimento.
                label_valor_parcelas.Hide();
                label_parcelas.Hide();
                label_total.Location = new Point(20, 117);
            }
            if (label_pagamento.Text == "Forma de pagamento: Á vista")
            {
                //Esconder resultados irrelevantes para o usuário.
                label_valor_parcelas.Hide();
                label_parcelas.Hide();
                label_maquina.Hide();
                label_tipo.Hide();
                label_total.Location = new Point(22, 74);
            }

            adaptador.Dispose();

            #endregion

            #region Exibe dados de serviço

            SqlCeDataAdapter adaptador_servicos= new SqlCeDataAdapter("SELECT * FROM servicos WHERE id_cliente = " + id_cliente, ligar_base);
            DataTable dados_servicos = new DataTable();
            adaptador_servicos.Fill(dados_servicos);

            //Código para apresentar os dados na tabela dos pendentes
            grelha_servicos.DataSource = dados_servicos;

            //Esconder colunas do DataGridView
            grelha_servicos.Columns["id_cliente"].Visible = false;
            grelha_servicos.Columns["id_servico"].Visible = false;

            #endregion

        }
    }
}
