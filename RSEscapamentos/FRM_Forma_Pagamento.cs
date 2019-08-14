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
    public partial class FRM_Forma_Pagamento : Form
    {
        public bool Fechar { get; set; } //Indirá que o usuário clicou em concluír e fechará o formulário FRM_Servicos, se for igual a true.
        int id_cliente; //ID que corresponde ao cliente.
        int id_finalizado; //ID que corresponde a tabela de finalizados.
        decimal valor; //Declarando valor como variável global nesse formulário.

        public FRM_Forma_Pagamento(int id_cliente, decimal valor = 0) //Parâmetro opcional de se usar.
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            this.valor = valor;
            if (valor == 0)
                Close();
        }

        private void FRM_Finalizar_Load(object sender, EventArgs e)
        {
            //Esconder componentes
            comboBox_tipo.Hide();
            label_tipo.Hide();
            label_maquina.Hide();
            text_maquina.Hide();
            label_parcelas.Hide();
            contador_parcelas.Hide();
            label8.Hide();
            label_total.Hide();

            //Elementos do combobox1
            comboBox_tipo.Items.Add("Débito");
            comboBox_tipo.Items.Add("Crédito");
            combo_pagamento.Items.Add("Á vista");
            combo_pagamento.Items.Add("Cartão");

            //Valor da label_total, que é o preço total do serviço.
            label_parcelas.Text = "Valor pago: R$" + String.Format("{0:n}", valor);
        }

        //Verificar comboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verificação dos itens selecionados na combobox.
            if (combo_pagamento.SelectedItem.ToString() == "Cartão")
            {
                //Ativar itens se comboBox for igual a Cartão
                comboBox_tipo.Show();
                label_tipo.Show();
                label_maquina.Hide();
                text_maquina.Hide();
                label_parcelas.Hide();
                label8.Hide();
                contador_parcelas.Hide();
                label_total.Location = new Point(13, 112);
            }
            if (combo_pagamento.SelectedItem.ToString() == "Á vista")
            {
                comboBox_tipo.Hide();
                label_tipo.Hide();
                label_total.Show();
                label_maquina.Hide();
                text_maquina.Hide();
                label_parcelas.Hide();
                label8.Hide();
                contador_parcelas.Hide();
                label_total.Text = "Valor pago: R$" + String.Format("{0:n}", valor); //Atualizar o valor na label_valor. NÃO APAGUE ESTA LINHA, SUJEITO A ERROS.
                //Reposicionar label_valor, quando o item combobox for igual a Á vista.
                label_total.Location = new Point(15, 69);
            }
        }

        //Converter o texto digitado para letras maiúsculas.
        private void text_maquina_TextChanged(object sender, EventArgs e)
        {
            //Converter o texto digitado para letras maiúsculas.
            text_maquina.CharacterCasing = CharacterCasing.Upper;
        }

        //Cancelar, fechar formulário.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Tipo de cartão
        private void comboBox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Esconder contador_parcelas e label8, se for igual a débito.
            if (comboBox_tipo.SelectedItem.ToString() == "Débito")
            {
                contador_parcelas.Hide();
                contador_parcelas.Value = 1;
                label8.Hide();
                label_parcelas.Hide();
                label_total.Show();
                label_maquina.Show();
                text_maquina.Show();
                label_total.Text = "Valor pago: R$" + String.Format("{0:n}", valor);
                label_total.Location = new Point(13, 112);
                label_maquina.Location = new Point(211, 69);
                text_maquina.Location = new Point(355, 69);
            }
            //Mostar contador_parcelas e label8, se for igual a crédito.
            if (comboBox_tipo.SelectedItem.ToString() == "Crédito")
            {
                contador_parcelas.Show();
                contador_parcelas.Value = 1;
                label8.Show();
                label_total.Show();
                label_maquina.Show();
                text_maquina.Show();
                contador_parcelas.Value = 1;
                label_total.Text = "Valor pago: R$" + String.Format("{0:n}", valor);
                label_total.Location = new Point(13, 112);
                label_maquina.Location = new Point(251, 110);
                text_maquina.Location = new Point(402, 108);
            }
        }

        //Verificar o valor do contador_parcelas e fazer a divisão de acordo com o número do contador.
        private void contador_parcelas_ValueChanged(object sender, EventArgs e)
        {
            if (contador_parcelas.Value == 1)
            {
                label_total.Location = new Point(13, 112);
                label_total.Text = "Valor Total: R$" + valor.ToString("N2");
                label_parcelas.Hide();
            }
            if (contador_parcelas.Value == 2)
            {
                label_total.Location = new Point(13, 142);
                label_parcelas.Show();
                decimal resultado = valor / 2;
                label_parcelas.Text = "Valor das parcelas: " + resultado.ToString("N2");
            }
            if (contador_parcelas.Value == 3)
            {
                label_total.Location = new Point(13, 142);
                label_parcelas.Show();
                decimal resultado = valor / 3;
                label_parcelas.Text = "Valor das parcelas: R$" + resultado.ToString("N2");
            }
            if (contador_parcelas.Value == 4)
            {
                label_total.Location = new Point(13, 142);
                label_parcelas.Show();
                decimal resultado = valor / 4;
                label_parcelas.Text = "Valor das parcelas: R$" + resultado.ToString("N2");
            }
            if (contador_parcelas.Value == 5)
            {
                label_total.Location = new Point(13, 142);
                label_parcelas.Show();
                decimal resultado = valor / 5;
                label_parcelas.Text = "Valor das parcelas: R$" + resultado.ToString("N2");
            }
        }

        //Concluir cadastro.
        private void btn_concluir_Click(object sender, EventArgs e)
        {
            #region Verificações de texto
            if (combo_pagamento.Text == "")
            {
                MessageBox.Show("Selecione uma forma de pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Verifica as comboBoxes, se Cartão for selecionado.
            if (combo_pagamento.Text == "Cartão")
            {
                if (comboBox_tipo.Text == "")
                {
                    MessageBox.Show("Selecione o Tipo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (text_maquina.Text == "")
                {
                    MessageBox.Show("É obrigatório selecionar o nome da máquina de cartão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (text_data.MaskCompleted == false)
                {
                    MessageBox.Show("Campo Data Atual vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    text_data.Focus();
                    return;
                }

                //Confimação
                if (MessageBox.Show("Ao clicar em Concluir, o cadastro não poderá mais ser editado, poderá apenas ser consultado." + Environment.NewLine +
                    "Deseja mesmo Concluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;
                #endregion
                //Mudar o estado da propriedade Fechar, indicando que o usuário finalizou o cadastro.
                Fechar = true;

                SqlCeConnection ligar_base = new SqlCeConnection("Data source = " + Base_Dados.base_dados);
                ligar_base.Open();

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT max(id_finalizado) AS max_id FROM finalizados", ligar_base);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //Verifica se o valor é null, se sim, adiciona o primeiro id da tabela.
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    id_finalizado = 1;
                }
                else  //Se não for nulo, simplesmente soma o maior id com 1 >>> id + 1.
                {
                    id_finalizado = Convert.ToInt16(dados.Rows[0][0]) + 1;
                }
                
                SqlCeCommand query = new SqlCeCommand();
                query.Connection = ligar_base;

                //Converte data para formato americano, para poder ser consultada posteriormente na base de dados pelo usuário.
                DateTime converter = DateTime.Parse(text_data.Text);
                string data_formatada = converter.ToString("yyyy-MM-dd");

                //Variáveis que serão criadas para facilitar o entendimento do código e que serão passadas para os parametros abaixo:
                string forma_pagamento = combo_pagamento.SelectedItem.ToString();
                string tipo_cartao = comboBox_tipo.SelectedItem.ToString();
                decimal parcelas = contador_parcelas.Value;
                string maquina_cartao = text_maquina.Text;
                decimal resultado = valor / contador_parcelas.Value; //Valor das parcelas.

                //Buscar os dados do cliente correspondente e pegar a data de entrada para guardar na coluna finalizados.
                SqlCeDataAdapter adaptador_clientes = new SqlCeDataAdapter("SELECT * FROM clientes WHERE id_cliente = " + id_cliente, ligar_base);
                DataTable dados_clientes = new DataTable();
                adaptador_clientes.Fill(dados_clientes);
                    
                //Parâmetros que serão passados para query ser executada
                query.Parameters.AddWithValue("@id_finalizado", id_finalizado);
                query.Parameters.AddWithValue("@id_cliente", id_cliente);
                query.Parameters.AddWithValue("@forma_pagamento", forma_pagamento);
                query.Parameters.AddWithValue("@tipo_cartao", tipo_cartao);
                query.Parameters.AddWithValue("@parcelas", parcelas);
                query.Parameters.AddWithValue("@maquina_cartao", maquina_cartao);
                query.Parameters.AddWithValue("@valor_parcelas", resultado.ToString("N2"));
                query.Parameters.AddWithValue("@valor_total", valor);
                query.Parameters.AddWithValue("@data_final", data_formatada);
                query.Parameters.AddWithValue("@finalizado", 1); //Será cadastrado com valor 1, indicando que o usuário finalizou o cadastro, fazendo assim com que o cadastro não possa mais ser editado

                query.CommandText = "INSERT INTO finalizados VALUES( @id_finalizado, @id_cliente, @forma_pagamento, @tipo_cartao, @parcelas, @maquina_cartao, " +
                    " @valor_parcelas, @valor_total, @data_final, @finalizado )";
                query.ExecuteNonQuery();

                adaptador_clientes.Dispose();
                ligar_base.Dispose();
                adaptador.Dispose();
                dados.Dispose();

                MessageBox.Show("Finalização concluída com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Fechar formulário
                Close();
            }

            //Verifica se o pagamento foi Á vista.
            else if (combo_pagamento.Text == "Á vista")
            {
                //VERIFICAÇÕES DAS CAIXAS DE TEXTO.
                if (text_data.MaskCompleted == false)
                {
                    MessageBox.Show("Campo Data Atual vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    text_data.Focus();
                    return;
                }

                //Confimação
                if (MessageBox.Show("Ao clicar em Concluir, o cadastro não poderá mais ser editado, poderá apenas ser consultado." + Environment.NewLine +
                    "Deseja mesmo Concluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;

                //Mudar o estado da propriedade Fechar, indicando que o usuário finalizou o cadastro.
                Fechar = true;

                SqlCeConnection ligar_base = new SqlCeConnection("Data source = " + Base_Dados.base_dados);
                ligar_base.Open();
                #region Organização dos Índices do DataGridView
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT max(id_finalizado) AS max_id FROM finalizados", ligar_base);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //Verifica se o valor é null, se sim, adiciona o primeiro id da tabela.
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    id_finalizado = 1;
                }
                else  //Se não for nulo, simplesmente soma o maior id com 1 >>> id + 1.
                {
                    id_finalizado = Convert.ToInt16(dados.Rows[0][0]) + 1;
                }

                #endregion

                SqlCeCommand query = new SqlCeCommand();
                query.Connection = ligar_base;

                //Converte data para formato americano, para poder ser consultada posteriormente na base de dados pelo usuário.
                DateTime converter = DateTime.Parse(text_data.Text);
                string data_formatada = converter.ToString("yyyy-MM-dd");

                //Variável responsável por indicar a forma de pagamento que foi escolhida pelo usuário.
                string forma_pagamento = combo_pagamento.SelectedItem.ToString();

                //Buscar os dados do cliente correspondente e pegar a data de entrada para guardar na coluna finalizados.
                SqlCeDataAdapter adaptador_clientes = new SqlCeDataAdapter("SELECT * FROM clientes WHERE id_cliente = " + id_cliente, ligar_base);
                DataTable dados_clientes = new DataTable();
                adaptador_clientes.Fill(dados_clientes);

                //Parâmetros que serão passados para query ser executada
                query.Parameters.AddWithValue("@id_finalizado", id_finalizado);
                query.Parameters.AddWithValue("@id_cliente", id_cliente);
                query.Parameters.AddWithValue("@forma_pagamento", forma_pagamento);
                query.Parameters.AddWithValue("@tipo_cartao", "Nulo"); //null: indica que o valor foi á vista.
                query.Parameters.AddWithValue("@parcelas", 0); //null: indica que não houve parcelas, foi pagamento á vista.
                query.Parameters.AddWithValue("@maquina_cartao", "Nulo");//null: indica que não houve máquina de cartão, pagamento foi Á vista.  
                query.Parameters.AddWithValue("@valor_parcelas", 0);//null: indica que não houve parcelas.
                query.Parameters.AddWithValue("@valor_total", valor);
                query.Parameters.AddWithValue("@data_final", data_formatada);
                query.Parameters.AddWithValue("@finalizado", 1); //Será cadastrado com valor 1, indicando que o usuário finalizou o cadastro, fazendo assim com que o cadastro não possa mais ser editado

                query.CommandText = "INSERT INTO finalizados VALUES( @id_finalizado, @id_cliente, @forma_pagamento, @tipo_cartao, @parcelas, @maquina_cartao, " +
                    " @valor_parcelas, @valor_total, @data_final, @finalizado )";
                query.ExecuteNonQuery();

                adaptador_clientes.Dispose();
                ligar_base.Dispose();
                adaptador.Dispose();
                dados.Dispose();

                MessageBox.Show("Finalização concluída com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Fechar formulário
                Close();
            }
        }

        //Validação da caixa de texto de data.
        private void text_data_Leave(object sender, EventArgs e)
        {
            //Verifica a se data está correta em text_data
            if (text_data.MaskCompleted == false)
            {
                text_data.Text = "";
                return;
            }
            else
            {
                try
                {
                    //Converte o texto digitado na text_data para verificar se data é válida.
                    DateTime convertido = DateTime.Parse(text_data.Text);
                }
                catch
                {
                    //Se data não é válida, alerte o usuário
                    MessageBox.Show("Insira uma data válida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    text_data.Focus();
                    return;
                }
            }
        }
    }
}
