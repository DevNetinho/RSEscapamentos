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
    public partial class FRM_Calcular_Fechamento : Form
    {
        public FRM_Calcular_Fechamento()
        {
            InitializeComponent();
        }

        private void FRM_Calcular_Fechamento_Load(object sender, EventArgs e)
        {
        }

        #region Funções de calculo para os filtros

        //Função que calcula pagamentos á vista.
        private decimal Calcula_Avista()
        {
            //Ligar base de dados.
            SqlCeConnection ligar_base_avista = new SqlCeConnection("Data source = " + Base_Dados.base_dados);
            ligar_base_avista.Open();

            //Calcula apenas apartir da data de início, sem incluir a data final.
            if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == false)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");

                //tipo_cartao = 'Nulo' (Nulo significa Á vista).
                SqlCeDataAdapter adaptador_avista = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_avista FROM finalizados WHERE tipo_cartao = 'Nulo' AND data_final >= '" + data_inicio_convertida + "'", ligar_base_avista);
                DataTable dados_avista = new DataTable();
                adaptador_avista.Fill(dados_avista);
                if (DBNull.Value.Equals(dados_avista.Rows[0]["tot_avista"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_avista = Convert.ToDecimal(dados_avista.Rows[0]["tot_avista"]);

                adaptador_avista.Dispose();
                ligar_base_avista.Close();
                return total_avista;
            }

            //Calcula de data inicio até data final.
            else if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == true)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");

                //tipo_cartao = 'Nulo' (Nulo significa Á vista).
                SqlCeDataAdapter adaptador_avista = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_avista FROM finalizados WHERE tipo_cartao = 'Nulo' AND data_final BETWEEN '" + data_inicio_convertida + "' AND '" + data_final_convertida + "'", ligar_base_avista);
                DataTable dados_avista = new DataTable();
                adaptador_avista.Fill(dados_avista);
                if (DBNull.Value.Equals(dados_avista.Rows[0]["tot_avista"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_avista = Convert.ToDecimal(dados_avista.Rows[0]["tot_avista"]);
                adaptador_avista.Dispose();
                ligar_base_avista.Close();
                return total_avista;
            }

            else if (text_data_inicio.MaskCompleted == false && text_data_final.MaskCompleted == true)
            {
                //Converter datas para formato americano.
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");

                //tipo_cartao = 'Nulo' (Nulo significa Á vista).
                SqlCeDataAdapter adaptador_avista = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_avista FROM finalizados WHERE tipo_cartao = 'Nulo' AND data_final <= '" + data_final_convertida + "'", ligar_base_avista);
                DataTable dados_avista = new DataTable();
                adaptador_avista.Fill(dados_avista);
                if (DBNull.Value.Equals(dados_avista.Rows[0]["tot_avista"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_avista = Convert.ToDecimal(dados_avista.Rows[0]["tot_avista"]);
                adaptador_avista.Dispose();
                ligar_base_avista.Close();
                return total_avista;
            } 
            else
                return 0;
        }

        //Função que calcula pagamentos em cartão débito.
        private decimal Calcula_Debito()
        {
            //Ligar base de dados.
            SqlCeConnection ligar_base_debito = new SqlCeConnection("Data source = " + Base_Dados.base_dados);
            ligar_base_debito.Open();

            //Calcula apenas apartir da data de início, sem incluir a data final.
            if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == false && text_maquina.TextLength <= 1)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_debito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_debito FROM finalizados WHERE tipo_cartao = 'Débito' AND data_final >= '" + data_inicio_convertida + "'", ligar_base_debito);
                DataTable dados_debito = new DataTable();
                adaptador_debito.Fill(dados_debito);
                if (DBNull.Value.Equals(dados_debito.Rows[0]["tot_debito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_debito = Convert.ToDecimal(dados_debito.Rows[0]["tot_debito"]);

                adaptador_debito.Dispose();
                ligar_base_debito.Close();
                return total_debito;
            }

            //Calcula de data inicio até data final.
            else if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == true && text_maquina.TextLength <= 1)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_debito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_debito FROM finalizados WHERE tipo_cartao = 'Débito' AND data_final BETWEEN '" + data_inicio_convertida + "' AND '" + data_final_convertida + "'", ligar_base_debito);
                DataTable dados_debito = new DataTable();
                adaptador_debito.Fill(dados_debito);
                if (DBNull.Value.Equals(dados_debito.Rows[0]["tot_debito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_debito = Convert.ToDecimal(dados_debito.Rows[0]["tot_debito"]);
                adaptador_debito.Dispose();
                ligar_base_debito.Close();
                return total_debito;
            }

            else if (text_data_inicio.MaskCompleted == false && text_data_final.MaskCompleted == true && text_maquina.TextLength <= 1)
            {
                //Converter datas para formato americano.
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_debito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_debito FROM finalizados WHERE tipo_cartao = 'Débito' AND data_final <= '" + data_final_convertida + "'", ligar_base_debito);
                DataTable dados_debito = new DataTable();
                adaptador_debito.Fill(dados_debito);
                if (DBNull.Value.Equals(dados_debito.Rows[0]["tot_debito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_debito = Convert.ToDecimal(dados_debito.Rows[0]["tot_debito"]);
                adaptador_debito.Dispose();
                ligar_base_debito.Close();
                return total_debito;
            }

            else if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == false && text_maquina.TextLength > 1)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_debito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_debito FROM finalizados WHERE tipo_cartao = 'Débito' AND data_final >= '" + data_inicio_convertida + "' AND maquina_cartao = '" + text_maquina.Text + "'", ligar_base_debito);
                DataTable dados_debito = new DataTable();
                adaptador_debito.Fill(dados_debito);
                if (DBNull.Value.Equals(dados_debito.Rows[0]["tot_debito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_debito = Convert.ToDecimal(dados_debito.Rows[0]["tot_debito"]);
                adaptador_debito.Dispose();
                ligar_base_debito.Close();
                return total_debito;
            }

            else if (text_data_inicio.MaskCompleted == false && text_data_final.MaskCompleted == true && text_maquina.TextLength > 1)
            {
                //Converter datas para formato americano.
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");
            
                SqlCeDataAdapter adaptador_debito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_debito FROM finalizados WHERE tipo_cartao = 'Débito' AND data_final <= '" + data_final_convertida + "' AND maquina_cartao = '" + text_maquina.Text + "'", ligar_base_debito);
                DataTable dados_debito = new DataTable();
                adaptador_debito.Fill(dados_debito);
                if (DBNull.Value.Equals(dados_debito.Rows[0]["tot_debito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_debito = Convert.ToDecimal(dados_debito.Rows[0]["tot_debito"]);
                adaptador_debito.Dispose();
                ligar_base_debito.Close();
                return total_debito;
            }
            else
                return 0;
        }

        //Função que calcula pagamentos em cartão crédito.
        private decimal Calcula_Credito()
        {
            //Ligar base de dados.
            SqlCeConnection ligar_base_credito = new SqlCeConnection("Data source = " + Base_Dados.base_dados);
            ligar_base_credito.Open();

            //Calcula apenas apartir da data de início, sem incluir a data final.
            if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == false && text_maquina.TextLength <= 1)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_credito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_credito FROM finalizados WHERE tipo_cartao = 'Crédito' AND data_final >= '" + data_inicio_convertida + "'", ligar_base_credito);
                DataTable dados_credito = new DataTable();
                adaptador_credito.Fill(dados_credito);
                if (DBNull.Value.Equals(dados_credito.Rows[0]["tot_credito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_credito = Convert.ToDecimal(dados_credito.Rows[0]["tot_credito"]);

                adaptador_credito.Dispose();
                ligar_base_credito.Close();
                return total_credito;
            }

            //Calcula de data inicio até data final.
            else if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == true && text_maquina.TextLength <= 1)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_credito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_credito FROM finalizados WHERE tipo_cartao = 'Crédito' AND data_final BETWEEN '" + data_inicio_convertida + "' AND '" + data_final_convertida + "'", ligar_base_credito);
                DataTable dados_credito = new DataTable();
                adaptador_credito.Fill(dados_credito);
                if (DBNull.Value.Equals(dados_credito.Rows[0]["tot_credito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_credito = Convert.ToDecimal(dados_credito.Rows[0]["tot_credito"]);
                adaptador_credito.Dispose();
                ligar_base_credito.Close();
                return total_credito;
            }

            else if (text_data_inicio.MaskCompleted == false && text_data_final.MaskCompleted == true && text_maquina.TextLength <= 1)
            {
                //Converter datas para formato americano.
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_credito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_credito FROM finalizados WHERE tipo_cartao = 'Crédito' AND data_final <= '" + data_final_convertida + "'", ligar_base_credito);
                DataTable dados_credito = new DataTable();
                adaptador_credito.Fill(dados_credito);
                if (DBNull.Value.Equals(dados_credito.Rows[0]["tot_credito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_credito = Convert.ToDecimal(dados_credito.Rows[0]["tot_credito"]);
                adaptador_credito.Dispose();
                ligar_base_credito.Close();
                return total_credito;
            }

            else if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == false && text_maquina.TextLength > 1)
            {
                //Converter datas para formato americano.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                string data_inicio_convertida = data_inicio.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_credito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_credito FROM finalizados WHERE tipo_cartao = 'Crédito' AND data_final >= '" + data_inicio_convertida + "' AND maquina_cartao = '" + text_maquina.Text + "'", ligar_base_credito);
                DataTable dados_credito = new DataTable();
                adaptador_credito.Fill(dados_credito);
                if (DBNull.Value.Equals(dados_credito.Rows[0]["tot_credito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_credito = Convert.ToDecimal(dados_credito.Rows[0]["tot_credito"]);
                adaptador_credito.Dispose();
                ligar_base_credito.Close();
                return total_credito;
            }

            else if (text_data_inicio.MaskCompleted == false && text_data_final.MaskCompleted == true && text_maquina.TextLength > 1)
            {
                //Converter datas para formato americano.
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);
                string data_final_convertida = data_final.ToString("yyyy-MM-dd");

                SqlCeDataAdapter adaptador_credito = new SqlCeDataAdapter("SELECT sum(valor_total) AS tot_credito FROM finalizados WHERE tipo_cartao = 'Crédito' AND data_final <= '" + data_final_convertida + "' AND maquina_cartao = '" + text_maquina.Text + "'", ligar_base_credito);
                DataTable dados_credito = new DataTable();
                adaptador_credito.Fill(dados_credito);
                if (DBNull.Value.Equals(dados_credito.Rows[0]["tot_credito"]))
                {
                    return 0;
                }
                //Converter o total para decimal(apresenta o resultado em formato de moeda).
                decimal total_credito = Convert.ToDecimal(dados_credito.Rows[0]["tot_credito"]);
                adaptador_credito.Dispose();
                ligar_base_credito.Close();
                return total_credito;
            }
            else
                return 0;
        }
        #endregion

        //Verificar a caixa de texto da data inicio.
        private void text_data_inicio_Leave(object sender, EventArgs e)
        {
            //Verifica a se data está correta em text_data
            if (text_data_inicio.MaskCompleted == false)
            {
                text_data_inicio.Text = "";
                return;
            }
            else
            {
                try
                {
                    //Converte o texto digitado na text_data para verificar se data é válida.
                    DateTime convertido = DateTime.Parse(text_data_inicio.Text);
                }
                catch
                {
                    //Se data não é válida, alerte o usuário
                    MessageBox.Show("Insira uma data válida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    text_data_inicio.Focus();
                    return;
                }
            }
        }

        //Verificar a caixa de texto da data final.
        private void text_data_final_Leave(object sender, EventArgs e)
        {
            //Verifica a se data está correta em text_data
            if (text_data_final.MaskCompleted == false)
            {
                text_data_final.Text = "";
                return;
            }
            else
            {
                try
                {
                    //Converte o texto digitado na text_data para verificar se data é válida.
                    DateTime convertido = DateTime.Parse(text_data_final.Text);
                }
                catch
                {
                    //Se data não é válida, alerte o usuário
                    MessageBox.Show("Insira uma data válida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    text_data_final.Focus();
                    return;
                }
            }
        }

        //Calcular os valores
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            #region Validação dos campos de textbox e checkbox
            //Validar texto digitado em text_maquina para não ocorrer SQL INJECTION.
            string texto_validado = text_maquina.Text;
            if (texto_validado.Contains("'") || texto_validado.Contains("=") || texto_validado.Contains("!") || texto_validado.Contains("<") || texto_validado.Contains(">"))
            {
                MessageBox.Show("Caracteres indevidos digitados no campo de maquina de cartão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Verificar campo de datas.
            if (text_data_inicio.MaskCompleted == true && text_data_final.MaskCompleted == true)
            {
                //Converte valor digitado nas caixas de data para verificar-los.
                DateTime data_inicio = Convert.ToDateTime(text_data_inicio.Text);
                DateTime data_final = Convert.ToDateTime(text_data_final.Text);

                //Verifica se data início é maior que data final.
                if (data_inicio > data_final)
                {
                    MessageBox.Show("Data de início tem que ser menor ou igual a data final!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            //Se não houver datas nos campos requeidos.
            else if (text_data_inicio.MaskCompleted == false && text_data_final.MaskCompleted == false)
            {
                MessageBox.Show("Insira ao menos uma data!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            #endregion

            //Se apenas check_avista for preenchida e as demais não forem.
            if (check_avista.Checked == true && check_debito.Checked == false && check_credito.Checked == false)
            {
                if (Calcula_Avista() == 0)
                {
                    MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Zerar labels
                    label_data_inicial.Text = "Data Inicial: ";
                    label_data_final.Text = "Data Final: ";
                    label_forma_pagamento.Text = "Forma de pagamento: ";
                    label_maquina_cartao.Text = "Máquina de cartão: ";
                    label_total.Text = "Valor total do fechamento: ";
                    return;
                }

                //Se houver texto no campo de maquina de cartão, com apenas a check_avista marcada.
                else if (text_maquina.TextLength >= 1)
                {
                    MessageBox.Show("Não pode haver texto no campo Máquina de cartão enquanto apenas o filtro Á vista estiver marcado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    label_total.Text = "Valor total do fechamento: R$" + Calcula_Avista().ToString("N2");
                    MessageBox.Show("Fechamento concluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_forma_pagamento.Text = "Forma de pagamento: " + check_avista.Text; //Indicar forma de pagamento
                    label_data_inicial.Text = "Data Inicial: " + text_data_inicio.Text;
                    label_data_final.Text = "Data Final: " + text_data_final.Text;
                }
            }

            //Verificar se text_maquina possui apenas um caractere.
            else if (text_maquina.TextLength == 1)
            {
                MessageBox.Show("Digite no mínimo dois caracteres no campo Maquina cartão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Se apenas check_debito for preenchida e as demais não forem.
            else if (check_debito.Checked == true && check_avista.Checked == false && check_credito.Checked == false)
            {
                if (Calcula_Debito() == 0)
                {
                    MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Zerar labels
                    label_data_inicial.Text = "Data Inicial: ";
                    label_data_final.Text = "Data Final: ";
                    label_forma_pagamento.Text = "Forma de pagamento: ";
                    label_maquina_cartao.Text = "Máquina de cartão: ";
                    label_total.Text = "Valor total do fechamento: ";
                    return;
                }
                else
                {
                    label_total.Text = "Valor total do fechamento: R$" + Calcula_Debito().ToString("N2");
                    MessageBox.Show("Fechamento concluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_forma_pagamento.Text = "Forma de pagamento: " + check_debito.Text; //Indicar forma de pagamento
                    label_data_inicial.Text = "Data Inicial: " + text_data_inicio.Text;
                    label_data_final.Text = "Data Final: " + text_data_final.Text;
                }
            }

            //Se apenas check_credito for preenchido.
            else if (check_credito.Checked == true && check_avista.Checked == false && check_debito.Checked == false)
            {
                if (Calcula_Credito() == 0)
                {
                    MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Zerar labels
                    label_data_inicial.Text = "Data Inicial: ";
                    label_data_final.Text = "Data Final: ";
                    label_forma_pagamento.Text = "Forma de pagamento: ";
                    label_maquina_cartao.Text = "Máquina de cartão: ";
                    label_total.Text = "Valor total do fechamento: ";
                    return;
                }
                else
                {
                    label_total.Text = "Valor total do fechamento: R$" + Calcula_Credito().ToString("N2");
                    MessageBox.Show("Fechamento concluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_forma_pagamento.Text = "Forma de pagamento: " + check_credito.Text; //Indicar forma de pagamento
                    label_data_inicial.Text = "Data Inicial: " + text_data_inicio.Text;
                    label_data_final.Text = "Data Final: " + text_data_final.Text;
                }
            }

            //Se check_avista e check_debito forem preenchidas.
            else if (check_avista.Checked == true && check_debito.Checked == true && check_credito.Checked == false)
            {
                if (Calcula_Avista() == 0 || Calcula_Debito() == 0)
                {
                    MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Zerar labels
                    label_data_inicial.Text = "Data Inicial: ";
                    label_data_final.Text = "Data Final: ";
                    label_forma_pagamento.Text = "Forma de pagamento: ";
                    label_maquina_cartao.Text = "Máquina de cartão: ";
                    label_total.Text = "Valor total do fechamento: ";
                    return;
                }
                else
                {
                    decimal resultado = Calcula_Debito() + Calcula_Avista();
                    label_total.Text = "Valor total do fechamento: R$" + resultado.ToString("N2");
                    MessageBox.Show("Fechamento concluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_forma_pagamento.Text = "Forma de pagamento: " + check_avista.Text + ", " + check_debito.Text; //Indicar forma de pagamento
                    label_data_inicial.Text = "Data Inicial: " + text_data_inicio.Text;
                    label_data_final.Text = "Data Final: " + text_data_final.Text;
                }
            }

            //Se check_avista e check_credito forem preenchidas.
            else if (check_avista.Checked == true && check_credito.Checked == true && check_debito.Checked == false)
            {
                if (Calcula_Avista() == 0 || Calcula_Credito() == 0)
                {
                    MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Zerar labels
                    label_data_inicial.Text = "Data Inicial: ";
                    label_data_final.Text = "Data Final: ";
                    label_forma_pagamento.Text = "Forma de pagamento: ";
                    label_maquina_cartao.Text = "Máquina de cartão: ";
                    label_total.Text = "Valor total do fechamento: ";
                    return;
                }
                else
                {
                    decimal resultado = Calcula_Credito() + Calcula_Avista();
                    label_total.Text = "Valor total do fechamento: R$" + resultado.ToString("N2");
                    MessageBox.Show("Fechamento concluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_forma_pagamento.Text = "Forma de pagamento: " + check_avista.Text + ", " + check_credito.Text; //Indicar forma de pagamento
                    label_data_inicial.Text = "Data Inicial: " + text_data_inicio.Text;
                    label_data_final.Text = "Data Final: " + text_data_final.Text;
                }
            }

            //Se check_debito e check_credito forem preenchidas.
            else if (check_credito.Checked == true && check_debito.Checked == true && check_avista.Checked == false)
            {
                if (Calcula_Credito() == 0 || Calcula_Debito() == 0)
                {
                    MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Zerar labels
                    label_data_inicial.Text = "Data Inicial: ";
                    label_data_final.Text = "Data Final: ";
                    label_forma_pagamento.Text = "Forma de pagamento: ";
                    label_maquina_cartao.Text = "Máquina de cartão: ";
                    label_total.Text = "Valor total do fechamento: ";
                    return;
                }
                else
                {
                    decimal resultado = Calcula_Debito() + Calcula_Credito();
                    label_total.Text = "Valor total do fechamento: R$" + resultado.ToString("N2");
                    MessageBox.Show("Fechamento concluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_forma_pagamento.Text = "Forma de pagamento: " + check_debito.Text + ", " + check_credito.Text; //Indicar forma de pagamento
                    label_data_inicial.Text = "Data Inicial: " + text_data_inicio.Text;
                    label_data_final.Text = "Data Final: " + text_data_final.Text;
                }
            }

            //Se todas as CheckBox forem preenchidas.
            else if (check_avista.Checked == true && check_debito.Checked == true && check_credito.Checked == true)
            {
                if (Calcula_Avista() == 0 || Calcula_Debito() == 0 || Calcula_Avista() == 0)
                {
                    MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Zerar labels
                    label_data_inicial.Text = "Data Inicial: ";
                    label_data_final.Text = "Data Final: ";
                    label_forma_pagamento.Text = "Forma de pagamento: ";
                    label_maquina_cartao.Text = "Máquina de cartão: ";
                    label_total.Text = "Valor total do fechamento: ";
                    return;
                }
                else
                {
                    decimal resultado = Calcula_Debito() + Calcula_Avista() + Calcula_Avista();
                    label_total.Text = "Valor total do fechamento: R$" + resultado.ToString("N2");
                    MessageBox.Show("Fechamento concluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label_forma_pagamento.Text = "Forma de pagamento: " + check_avista.Text + ", " + check_debito.Text + ", " + check_credito.Text; //Indicar forma de pagamento
                    label_data_inicial.Text = "Data Inicial: " + text_data_inicio.Text;
                    label_data_final.Text = "Data Final: " + text_data_final.Text;
                }
            }

            else if (check_avista.Checked == false && check_debito.Checked == false && check_credito.Checked == false)
            {
                MessageBox.Show("Não foram encontrados dados, tente novamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Zerar labels
                label_data_inicial.Text = "Data Inicial: ";
                label_data_final.Text = "Data Final: ";
                label_forma_pagamento.Text = "Forma de pagamento: ";
                label_maquina_cartao.Text = "Máquina de cartão: ";
                label_total.Text = "Valor total do fechamento: ";
                return;
            }

        }

        //Converter para letras maiúsculas.
        private void text_maquina_TextChanged(object sender, EventArgs e)
        {
            text_maquina.CharacterCasing = CharacterCasing.Upper;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo limpar todos resultados?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;

            //Zerar labels
            label_data_inicial.Text = "Data Inicial: ";
            label_data_final.Text = "Data Final: ";
            label_forma_pagamento.Text = "Forma de pagamento: ";
            label_maquina_cartao.Text = "Máquina de cartão: ";
            label_total.Text = "Valor total do fechamento: ";

        }
    }
}
