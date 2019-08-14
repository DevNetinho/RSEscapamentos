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
    public partial class FRM_Visulizar : Form
    {
        int id_pendente;
        public FRM_Visulizar(int id_pendente)
        {
            InitializeComponent();
            this.id_pendente = id_pendente;
        }

        private void FRM_Visulizar_Load(object sender, EventArgs e)
        {
            SqlCeConnection ligar_base_pendente = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            ligar_base_pendente.Open();
            SqlCeDataAdapter adaptador_pendentes = new SqlCeDataAdapter("SELECT * FROM pendentes WHERE id_pendente = " + id_pendente, ligar_base_pendente);
            DataTable dados = new DataTable();
            adaptador_pendentes.Fill(dados);

            //Converter data em formato americano para formato brasileiro.
            DateTime data_final = Convert.ToDateTime(dados.Rows[0]["Data_Final"].ToString());
            string conversor = Convert.ToString(data_final.ToString("dd/MM/yyyy"));


            label_cliente.Text = dados.Rows[0]["Cliente"].ToString();
            label_veiculo.Text = dados.Rows[0]["Veículo"].ToString();
            label_placa.Text = dados.Rows[0]["Placa"].ToString();
            label_descricao.Text = dados.Rows[0]["Descrição"].ToString();
            label_celular.Text = dados.Rows[0]["Celular_Telefone"].ToString();
            label_inicio.Text = dados.Rows[0]["Data_Inicio"].ToString();
            label_vencimento.Text = conversor; //Apresenta a data convertida na label.
            label_valor.Text = dados.Rows[0]["Valor"].ToString();
        }

        private void label_cliente_Click(object sender, EventArgs e)
        {

        }

        private void label_descricao_Click(object sender, EventArgs e)
        {

        }

        private void label_veiculo_Click(object sender, EventArgs e)
        {

        }

        private void label_vencimento_Click(object sender, EventArgs e)
        {

        }

        private void label_valor_Click(object sender, EventArgs e)
        {

        }

        private void label_inicio_Click(object sender, EventArgs e)
        {

        }

        private void label_celular_Click(object sender, EventArgs e)
        {

        }

        private void label_placa_Click(object sender, EventArgs e)
        {

        }
    }
}
