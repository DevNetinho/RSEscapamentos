using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;
using System.Text;
using System.Threading.Tasks;

namespace RSEscapamentos
{
    public static class Base_Dados
    {
        private static string caminho_base_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RS_Programa\";
        private static string arquivo_dados = "RS_dados.sdf";
        public static string base_dados = caminho_base_dados + arquivo_dados;

        public static void Criar_Pastas()
        {
            if (Directory.Exists(caminho_base_dados) == false)
            {
                Directory.CreateDirectory(caminho_base_dados);
            }

            //Insira todas as funções que carregam bases de dados, no if abaixo.
            if (File.Exists(base_dados) == false)
            {
                Construir_Base_Senha();
                Construir_Base_Cadastro();
                Construir_Base_Servicos();
                Construir_Base_Pendentes();
                Construir_Base_Finalizados();
                Construir_Base_Estoque();
                Construir_Base_Fornecedores();
            }
        }

        //Tabela responsável por guardar senhas.
        private static void Construir_Base_Senha()
        {
            #region Criar base de dados e tabela de usuarios
            //Criar base de dados.
            SqlCeEngine criar = new SqlCeEngine("Data source =" + base_dados);
            criar.CreateDatabase();

            //Ligar base de dados.
            SqlCeConnection ligar_senha = new SqlCeConnection("Data source =" + base_dados);
            ligar_senha.Open();

            //Responsável por criar a tabela de usuarios, da base de dados.
            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE usuarios (" +
                "usuario               nvarchar(250) not null primary key," +
                "senha                 nvarchar(250) not null)";

            comando.Connection = ligar_senha;
            comando.ExecuteNonQuery();

            //Condição para ser executada se não houver cadastro de usuários na base de dados.
            DataTable dados = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM usuarios", ligar_senha);
            adaptador.Fill(dados);

            //Se não houver cadastros na base de dados, crie o seguinte cadastro.
            if (dados.Rows.Count == 0)
            {
                adaptador = new SqlCeDataAdapter("INSERT INTO usuarios VALUES ('joelma','827ccb0eea8a706c4c34a16891f84e7b')", ligar_senha);
                dados = new DataTable();
                adaptador.Fill(dados);
            }

            //Fechar base de dados.
            adaptador.Dispose();
            ligar_senha.Dispose();
            comando.Dispose();
            #endregion
        }

        private static void Construir_Base_Fornecedores()
        {
            //Ligar base de dados.
            SqlCeConnection ligar_base_fornecedores = new SqlCeConnection("Data source =" + base_dados);
            ligar_base_fornecedores.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE fornecedores (" +
                "id_fornecedor         int not null primary key," +
                "Nome              nvarchar(100)," +
                "Telefone1          nvarchar(100)," +
                "Telefone2          nvarchar(100)," +
                "CNPJ              nvarchar(25)," +
                "Endereço          nvarchar(150)," +
                "CEP               nvarchar(100)," +
                "Descrição         nvarchar(100))";
            comando.Connection = ligar_base_fornecedores;
            comando.ExecuteNonQuery();

            //Fechar base de dados.
            comando.Dispose();
            ligar_base_fornecedores.Dispose();
        }

        //Tabela responsável por guardar cadastro de produtos.
        private static void Construir_Base_Estoque()
        {
            //Ligar base de dados.
            SqlCeConnection ligar_base_estoque = new SqlCeConnection("Data source =" + base_dados);
            ligar_base_estoque.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE estoque (" +
                "id_produto         int not null primary key," +
                "Código             nvarchar(100)," +
                "Produto            nvarchar(100)," +
                "Fornecedor         nvarchar(100)," +
                "Quantidade         int," +
                "Valor_Real         money," +
                "Valor_Venda        money)";
            comando.Connection = ligar_base_estoque;
            comando.ExecuteNonQuery();

            //Fechar base de dados.
            comando.Dispose();
            ligar_base_estoque.Dispose();
        }

        //Tabela responsável por guardar cadastros.
        private static void Construir_Base_Cadastro()
        {
            //Ligar base de dados.
            SqlCeConnection ligar_base_cadastro = new SqlCeConnection("Data source =" + base_dados);
            ligar_base_cadastro.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE clientes(" +
                "id_cliente             int not null primary key," +
                "Veículo                nvarchar(50)," +
                "Placa                  nvarchar(10)," +
                "Cliente                nvarchar(40)," +
                "Celular_Telefone       nvarchar(20)," +
                "Data_entrada                   nvarchar(20))";
            comando.Connection = ligar_base_cadastro;
            comando.ExecuteNonQuery();

            //Fechar base de dados.
            comando.Dispose();
            ligar_base_cadastro.Dispose();
        }

        //Tabela responsável por guardar serviços cadastrados.
        private static void Construir_Base_Servicos()
        {
            SqlCeConnection ligar_base_servicos = new SqlCeConnection("Data source =" + base_dados);
            ligar_base_servicos.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE servicos (" +
                "id_servico         int not null primary key," +
                "id_cliente         int not null," +
                "Serviço            nvarchar(200)," +
                "Preço              money," +
                "FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE" +
                ")";
            comando.Connection = ligar_base_servicos;
            comando.ExecuteNonQuery();

            //Fechar base de dados.
            ligar_base_servicos.Dispose();
            comando.Dispose();
        }

        //Tabela responsável por guardar serviços finalizados.
        private static void Construir_Base_Finalizados()
        {
            SqlCeConnection ligar_base_finalizados = new SqlCeConnection("Data source =" + base_dados);
            ligar_base_finalizados.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE finalizados (" +
                "id_finalizado      int not null primary key,"+
                "id_cliente         int not null," +
                "forma_pagamento    nvarchar(20)," +
                "tipo_cartao        nvarchar(20)," +
                "parcelas           int," +
                "maquina_cartao     nvarchar(20)," +
                "valor_parcelas     nvarchar(20)," +
                "valor_total        money," +
                "data_final         nvarchar(20)," +
                "finalizado         int," + //Indicará se o servico foi finalizado, com o valor 1.
                "FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE" +
                ")";
            comando.Connection = ligar_base_finalizados;
            comando.ExecuteNonQuery();

            //Fechar base de dados.
            ligar_base_finalizados.Dispose();
            comando.Dispose();
        }

        //Tabela responsável por guardar valores pendentes.
        private static void Construir_Base_Pendentes()
        {
            //Ligar base de dados.
            SqlCeConnection ligar_base_pendentes = new SqlCeConnection("Data source =" + base_dados);
            ligar_base_pendentes.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE pendentes(" +
                "id_pendente            int not null primary key," +
                "Pendente               int,"+
                "Cliente                nvarchar(50)," +
                "Veículo                nvarchar(50)," +
                "Placa                  nvarchar(10)," +
                "Descrição              nvarchar(250)," +
                "Celular_Telefone       nvarchar(20)," +
                "Data_Inicio            nvarchar(20)," +
                "Data_Final             nvarchar(20)," +
                "Valor                  nvarchar(20))";
            comando.Connection = ligar_base_pendentes;
            comando.ExecuteNonQuery();

            //Fechar base de dados.
            comando.Dispose();
            ligar_base_pendentes.Dispose();
        }

        //Método para verificar se há pagamentos pendentes na base de dados.
        public static int Verificar_Pendentes(int valor = 0) //Insira o parâmetro com valor 1 se for abri-lo em FRM_Pendentes e 0 se abri-lo em outro Form.
        {
            //Formato a ser comparado com os formatos da base de dados, que representa a data atual do computador.
            string data_atual = DateTime.Now.ToString("yyyy-MM-dd");
            //Ligar base de dados
            SqlCeConnection ligar_base = new SqlCeConnection("Data source =" + base_dados);
            ligar_base.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@pendente", 0);
            comando.Connection = ligar_base;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM pendentes WHERE Data_Final BETWEEN '1900-01-01' AND " + "'" + data_atual + "'", ligar_base);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //valor == 0 execute o código abaixo
            if (valor == 0)
            {
                if (dados.Rows.Count != 0)
                {
                    //Atualizar todos registros que são iguais a data atual ou menor que a data atual para 0, indicando que o pagamento está pendente.
                    comando.CommandText = "UPDATE pendentes SET " +
                        "Pendente = 0";
                    comando.ExecuteNonQuery();

                    if (MessageBox.Show("Há pagamentos atrasados, verifique em sua lista de Não Pagos. Verificar agora?", "Aviso!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Abre o formulário de pagamentos pendentes.
                        FRM_Pendentes pendentes = new FRM_Pendentes();
                        pendentes.AtivaNaoPagos = true;
                        pendentes.ShowDialog();
                    }
                    int contador = dados.Rows.Count;
                    adaptador.Dispose();
                    ligar_base.Dispose();
                    return contador;
                }
            }
            adaptador.Dispose();
            ligar_base.Dispose();
            return 0;
        }
    }
}