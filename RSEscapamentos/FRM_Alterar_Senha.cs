using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSEscapamentos
{
    public partial class FRM_Alterar_Senha : Form
    {
        public FRM_Alterar_Senha()
        {
            InitializeComponent();
        }

        private void FRM_Alterar_Senha_Load(object sender, EventArgs e)
        {
            //Esconder caracteres de senha.
            text_nova_senha.PasswordChar = '*';
            text_confirmar_senha.PasswordChar = '*';
        }

        private void check_visualizar_CheckedChanged(object sender, EventArgs e)
        {
            //Se clicar na CheckBox, caracteres são revelados.
            text_nova_senha.PasswordChar = check_visualizar.Checked ? '\0' : '*';
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if(text_nova_senha.TextLength <= 4)
            {
                MessageBox.Show("A senha deve conter no mínimo 5 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Verifica se as senhas coincidem uma com a outra.
            if(text_nova_senha.Text == text_confirmar_senha.Text)
            {
                //Ligar base de dados.
                SqlCeConnection ligar = new SqlCeConnection("Data source =" + Base_Dados.base_dados);
                ligar.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligar;
                comando.Parameters.AddWithValue("@nova_senha", Encriptar_Senha(text_confirmar_senha.Text));
                comando.CommandText = "UPDATE usuarios SET " +
                    "senha = @nova_senha "; /* Como o sistema não terá mais que um usuário, será alterada a senha de 
                todos registros da base de dados. ATENÇÃO: Se futuramente o sistema conter mais de um usuário, não se 
                esqueça de modificar esta query que está sendo executada. */
                comando.ExecuteNonQuery();

                ligar.Dispose();
                MessageBox.Show("A senha foi alterada com sucesso!", "Senha alterada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Ops! As senhas não coincidem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        //Função responsável pela encriptação da senha.
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
    }
}
