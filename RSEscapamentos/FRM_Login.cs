using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSEscapamentos
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            text_senha.PasswordChar = '*';
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Método para Encriptar Senha.
        private string Encriptar_Senha(string senha)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                MD5 md5Hash = MD5.Create();
                // Converter a String para array de bytes, que é como a biblioteca trabalha.
                byte[] data = md5Hash.ComputeHash(Encoding.ASCII.GetBytes(senha));

                // Cria-se um StringBuilder para recompôr a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop para formatar cada byte como uma String em hexadecimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            //Chave mestre do software, caso o usuário esqueça a senha.
            if (text_senha.Text == "4d1m1n1str4d0r#@#@SBA5444")
            {
                this.Hide();
                FRM_Inicio inicio = new FRM_Inicio(text_usuario.Text);
                inicio.Closed += (s, args) => this.Close(); //Fechar Formulário de Login, após abrir inicio
                inicio.ShowDialog();
                return;
            }

            try
            {
                //Ligar base de dados.
                SqlCeConnection ligar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
                ligar.Open();

                //Inserção de dados para verificação de senha.
                DataTable dados = new DataTable();
                //Verifica se usuario e senha existem:
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

                string texto_usuario = text_usuario.Text;
                //Usuario e senha corretos, abre formulário.

                this.Hide();
                FRM_Inicio inicio = new FRM_Inicio(texto_usuario);
                inicio.Closed += (s, args) => this.Close(); //Fechar Formulário de Login, após abrir inicio
                inicio.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //Esconde caracteres de senha, se clicar na CheckBox, caracteres são revelados.
            text_senha.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void text_usuario_TextChanged(object sender, EventArgs e)
        {
            text_usuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Se esqueceu sua senha, entre em contato com o desenvolvedor Ricardo Júnior.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
