using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSEscapamentos
{
    public partial class FRM_Admin : Form
    {
        //Propriedade que será false por padrão, irá verificar se o usuário cancelou a ação. 
        public bool Cancelar { get; set; } 
        int id_mod;
        string acao;
        //Cada string passada como parâmetro, corresponde a uma ação, ações:
        //FRM_Cadastrar_Cliente_Deletar >> Deleta cliente no banco de dados de clientes.
        //FRM_Pendentes_Pago >> Muda a cor da célula para verde, indica que valor está pago.
        //FRM_Servicos_Remover >> Deleta o serviço cadastrado.
        public FRM_Admin(int id, string acao)
        {
            InitializeComponent();

            //Id da linha que será modificada.
            this.id_mod = id;
            this.acao = acao;
            //Mascarar a senha com asterísco(*)
            text_senha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Verificar login e senha
            //Chave mestre do software, caso o usuário esqueça a senha.
            if (text_senha.Text != "4d1m1n1str4d0r#@#@SBA5444")
            {
                //Ligar base de dados.
                SqlCeConnection ligar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
                ligar.Open();

                //Inserção de dados para verificação de senha.
                DataTable dados = new DataTable();
                //Verifica se usuario e senha existem na base de dados:
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM usuarios WHERE @usuario = usuario AND @senha = senha", ligar);
                adaptador.SelectCommand.Parameters.AddWithValue(@"usuario", text_usuario.Text);
                adaptador.SelectCommand.Parameters.AddWithValue(@"senha", Encriptar_Senha(text_senha.Text));
                adaptador.Fill(dados);
                adaptador.Dispose();
                ligar.Dispose();

                //Se usuario e senha não forem achados:
                if (dados.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou senha incorreto(s)!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion
            }
            //Chave mestre do software, caso o usuário esqueça a senha.
            else if (text_senha.Text == "4d1m1n1str4d0r#@#@SBA5444")
            {

            }

            //Ligar base de dados.
            SqlCeConnection conectar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
            conectar.Open();

            #region FRM_Cadastrar_Cliente_Deletar
            if (acao == "FRM_Cadastrar_Cliente_Deletar")
            {
                //Buscar na base de dados o id_cliente e deletá-lo, se o login estiver correto.
                //Ligar base de dados
                SqlCeDataAdapter adaptador_cliente = new SqlCeDataAdapter("DELETE FROM clientes WHERE id_cliente = " + id_mod, conectar);
                DataTable dados_cliente = new DataTable();
                adaptador_cliente.Fill(dados_cliente);
                adaptador_cliente.Dispose();
                conectar.Dispose();

                //Caixa de mensagem.
                MessageBox.Show("Cliente removido com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            #endregion

            #region FRM_Pendentes_Pago
            if (acao == "FRM_Pendentes_Pago")
            {
                //Atualizar coluna "Pendente" para o valor inteiro 1 de acordo com id_pendente.
                SqlCeCommand query_update = new SqlCeCommand("UPDATE pendentes SET Pendente = 1 WHERE id_pendente = " + id_mod, conectar);
                query_update.ExecuteNonQuery();

                query_update.Dispose();
                conectar.Dispose();
                this.Close();

                MessageBox.Show("Cliente marcado como pago!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
            
            #region FRM_Pendentes_Remover
            if (acao == "FRM_Pendentes_Remover")
            {
                //Buscar na base de dados o id_pendente e deletá-lo, se o login estiver correto.
                //Ligar base de dados
                SqlCeDataAdapter adaptador_pendente = new SqlCeDataAdapter("DELETE FROM pendentes WHERE id_pendente = " + id_mod, conectar);
                DataTable dados_pendente = new DataTable();
                adaptador_pendente.Fill(dados_pendente);
                

                //Caixa de mensagem.
                MessageBox.Show("Cadastro removido com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adaptador_pendente.Dispose();
                conectar.Dispose();
                Close();

            }
            #endregion

            #region FRM_Servicos_Remover
            if (acao == "FRM_Servicos_Remover")
            {
                //Buscar na base de dados o id_servico e deletá-lo, se o login estiver correto.
                //Ligar base de dados
                SqlCeDataAdapter adaptador_servico = new SqlCeDataAdapter("DELETE FROM servicos WHERE id_servico = " + id_mod, conectar);
                DataTable dados_servico = new DataTable();
                adaptador_servico.Fill(dados_servico);


                //Caixa de mensagem.
                MessageBox.Show("Cadastro de serviço removido com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adaptador_servico.Dispose();
                conectar.Dispose();
                Close();
            }
            #endregion

            #region FRM_Estoque_Remover
            if (acao == "FRM_Estoque_Remover")
            {
                //Buscar na base de dados o id_estoque e deletá-lo, se o login estiver correto.
                //Ligar base de dados
                SqlCeDataAdapter adaptador_estoque = new SqlCeDataAdapter("DELETE FROM estoque WHERE id_produto = " + id_mod, conectar);
                DataTable dados_estoque = new DataTable();
                adaptador_estoque.Fill(dados_estoque);


                //Caixa de mensagem.
                MessageBox.Show("Produto removido com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adaptador_estoque.Dispose();
                conectar.Dispose();
                Close();
            }
            #endregion

            #region FRM_Alterar_Senha

            if(acao == "FRM_Alterar_Senha")
            {
                FRM_Alterar_Senha alterar_senha = new FRM_Alterar_Senha();
                alterar_senha.ShowDialog();
                Close();
            }

            #endregion

            //Abre o formulário para edição do cadastro do produto.
            #region FRM_Estoque_Editar
            if(acao == "FRM_Estoque_Editar")
            {
                FRM_Editar editar = new FRM_Editar(id_mod);
                editar.ShowDialog();
                if (editar.Editar_Cancelado == true)
                {
                    Cancelar = true; //Indica para o formulário FRM_Estoque que a edição foi cancelada.
                    Close();
                }
                Close();
            }
            #endregion

            #region FRM_Fornecedor_Remover
            if (acao == "FRM_Fornecedor_Remover")
            {
                //Buscar na base de dados o id_fornecedor e deletá-lo, se o login estiver correto.
                //Ligar base de dados
                SqlCeDataAdapter adaptador_fornecedor = new SqlCeDataAdapter("DELETE FROM fornecedores WHERE id_fornecedor = " + id_mod, conectar);
                DataTable dados_fornecedor = new DataTable();
                adaptador_fornecedor.Fill(dados_fornecedor);


                //Caixa de mensagem.
                MessageBox.Show("Fornecedor removido com sucesso!", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adaptador_fornecedor.Dispose();
                conectar.Dispose();
                Close();
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private string Encriptar_Senha(string senha)
        {
            //Criptografar senha no banco de dados
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                MD5 md5Hash = MD5.Create();
                //Converter a String para array de bytes, que é como a biblioteca trabalha.
                byte[] data = md5Hash.ComputeHash(Encoding.ASCII.GetBytes(senha));

                //Cria-se um StringBuilder para recompôr a string.
                StringBuilder sBuilder = new StringBuilder();

                //Loop para formatar cada byte como uma String em hexadecimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        private void text_usuario_TextChanged(object sender, EventArgs e)
        {
            text_usuario.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
