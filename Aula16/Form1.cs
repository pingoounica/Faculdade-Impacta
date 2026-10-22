using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método criado para exibir mensagens no ListBox.
        // Assim, podemos reutilizar esse código em diferentes botões.
        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void ConectarButton_Click(object sender, EventArgs e)
        {
            // Sql Server
            // É o sistema gerenciador de banco de dados.

            // SqlConnection
            // Representa a conexão entre o programa C# e o banco.

            //  ConnectionString
            // Define o servidor, o banco de dados e a autenticação.

            //  ()open
            // Abre a conexão com o banco de dados.

            //  ()close
            // Fecha a conexão com o banco de dados.

            // SqlCommand
            // Representa um comando SQL que será executado no banco.

            //  Connection
            // Indica qual conexão o comando deve utilizar.

            //  ExecuteReader()
            // Executa consultas que retornam registros, como SELECT.

            //  ExecuteNonQuery
            // Executa comandos como INSERT, UPDATE e DELETE,
            // que normalmente não retornam uma lista de registros.

            //  ExecuteScalar()
            // Retorna um único valor, como a quantidade de clientes.

            // SqlDataReader
            // Permite ler os registros retornados por uma consulta SQL.

            string conexao =
                @"Server=(localdb)\MSSQLLocalDB;Database=EmpresaDB;Integrated Security=True;";

            // Criamos a conexão usando a string definida acima.
            using (SqlConnection connect = new SqlConnection(conexao))
            {
                // Open(): abre a conexão.
                connect.Open();
                Mensagem("Conexão Aberta");

                // Close(): fecha a conexão manualmente.
                connect.Close();
                Mensagem("Conexão Fechada");
            }
            // O using também garante a liberação dos recursos
            // quando o bloco termina.
        }

        private void CommandButton_Click(object sender, EventArgs e)
        {
            // Sql Server
            // Banco de dados ao qual queremos enviar comandos SQL.

            // SqlConnection
            // Objeto responsável pela conexão com o banco.

            string conexao =
                @"Server=(localdb)\MSSQLLocalDB;Database=EmpresaDB;Integrated Security=True;";

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                // SqlCommand
                // Criamos um objeto para montar e executar o comando SQL.
                SqlCommand command = new SqlCommand();

                // Connection
                // Associamos o comando à conexão que criamos.
                command.Connection = connect;

                // CommandText
                // Definimos a consulta que queremos executar.
                command.CommandText = "SELECT Nome FROM Cliente";

                // Open()
                // Abrimos a conexão antes de executar a consulta.
                connect.Open();

                // SqlDataReader
                // ExecuteReader() executa o SELECT e disponibiliza
                // os registros encontrados para leitura.
                SqlDataReader reader = command.ExecuteReader();

                // Read()
                // Avança para o próximo registro.
                // O while continua enquanto houver registros.
                while (reader.Read())
                {
                    // Acessamos a coluna Nome do registro atual.
                    // ToString() converte o valor para texto.
                    // Mensagem() exibe o nome no ListBox.
                    string nome = reader["Nome"].ToString();
                    listBox1.Items.Add(nome);
                }

                // Fechamos o leitor após terminar a leitura.
                reader.Close();
                connect.Close();
                // A conexão será liberada automaticamente pelo using.
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string conexao =
               @"Server=(localdb)\MSSQLLocalDB;Database=EmpresaDB;Integrated Security=True;";

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                // SqlCommand
                // Criamos um objeto para montar e executar o comando SQL.
                SqlCommand command = new SqlCommand();

                // Connection
                // Associamos o comando à conexão que criamos.
                command.Connection = connect;

                // CommandText
                // Definimos a consulta que queremos executar.
                command.CommandText = "INSERT INTO Cliente(Id, Nome, Email, Telefone) VALUES (@Id, @Nome, @Email, @Telefone)";
                command.Parameters.AddWithValue("@Id", 25);
                command.Parameters.AddWithValue("@Nome", "Joaquim Alterado da Silva");
                command.Parameters.AddWithValue("@Telefone", "55++ (11) 5855-5555");
                command.Parameters.AddWithValue("@Email", "joaquim@teste.com.br");

                connect.Open();
                int total = command.ExecuteNonQuery();
                Mensagem("Registro Incluido com sucesso");
                connect.Close();
                Mensagem("Conexão Fechada");

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            string conexao =
               @"Server=(localdb)\MSSQLLocalDB;Database=EmpresaDB;Integrated Security=True;";

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                // SqlCommand
                // Criamos um objeto para montar e executar o comando SQL.
                SqlCommand command = new SqlCommand();

                // Connection
                // Associamos o comando à conexão que criamos.
                command.Connection = connect;

                // CommandText
                // Definimos a consulta que queremos executar.
                command.CommandText = "UPDATE Cliente SET Nome=@Nome WHERE Id=@Id";
                command.Parameters.AddWithValue("@Id", 25);
                command.Parameters.AddWithValue("@Nome", "Joaquim Alterado da Silva");


                connect.Open();
                int total = command.ExecuteNonQuery();

                connect.Close();
                Mensagem("Registro alterado com sucesso");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao =
               @"Server=(localdb)\MSSQLLocalDB;Database=EmpresaDB;Integrated Security=True;";

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                // SqlCommand
                // Criamos um objeto para montar e executar o comando SQL.
                SqlCommand command = new SqlCommand();

                // Connection
                // Associamos o comando à conexão que criamos.
                command.Connection = connect;

                // CommandText
                // Definimos a consulta que queremos executar.
                command.CommandText = "DELETE Cliente WHERE Id=@Id";
                command.Parameters.AddWithValue("@Id", 25);

                connect.Open();
                int total = command.ExecuteNonQuery();

                connect.Close();
                Mensagem("Registro EXCLUIDO com sucesso");
            }
        }
    }
}