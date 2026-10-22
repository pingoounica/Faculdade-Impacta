using Empresa.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
namespace Empresa.Db
{
    public class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {
            string sql = "INSERT INTO Cliente(Id, Nome, Email, Telefone) VALUES (@Id, @Nome, @Email, @Telefone)";
            string conexao = Db.Conexao;

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                SqlCommand command = new SqlCommand(sql, connect);
                command.Connection = connect;

                command.Parameters.AddWithValue("@Id", cliente.Id);
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@Email", cliente.Email);

                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
        }
        public void Alterar(Cliente cliente)
        {
            string sql = @"UPDATE Cliente SET Nome=@Nome, Email=@Email, Telefone=@Telefone WHERE Id=@Id";
            string conexao = Db.Conexao;

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                SqlCommand command = new SqlCommand(sql, connect);
                command.Connection = connect;

                command.Parameters.AddWithValue("@Id", cliente.Id);
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@Email", cliente.Email);

                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
        }

        public void Excluir(int Id)
        {
            string sql = @"DELETE Cliente WHERE Id=@Id";
            string conexao = Db.Conexao;

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                SqlCommand command = new SqlCommand(sql, connect);
                command.Connection = connect;

                command.Parameters.AddWithValue("@Id", Id);
               
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
        }
        public Cliente ObterPorId(int id)
        {
            string conexao = Db.Conexao;

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                string sql = @"SELECT Id, Nome, Telefone, Email FROM Cliente WHERE Id=@Id";
                SqlCommand command = new SqlCommand(sql, connect);
                command.Parameters.AddWithValue("@Id", id);

                Cliente cliente = null;

                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = reader["Nome"].ToString();
                    cliente.Telefone = reader["Telefone"].ToString();
                    cliente.Email = reader["Email"].ToString();

                    
                }
                // Fechamos o leitor após terminar a leitura.
                reader.Close();
                connect.Close();
                // A conexão será liberada automaticamente pelo using.
                return cliente;
            }
        }

        public List<Cliente> Listar()
        {
            string conexao = Db.Conexao;

            using (SqlConnection connect = new SqlConnection(conexao))
            {
                string sql = "SELECT Id, Nome, Telefone, Email FROM Cliente";
                SqlCommand command = new SqlCommand(sql, connect);

                List<Cliente> lista = new List<Cliente>();
                
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = reader["Nome"].ToString();
                    cliente.Telefone = reader["Telefone"].ToString();
                    cliente.Email= reader["Email"].ToString();

                    lista.Add(cliente); 
                }

                // Fechamos o leitor após terminar a leitura.
                reader.Close();
                connect.Close();
                // A conexão será liberada automaticamente pelo using.
                return lista;
            }
        }
    }
}
