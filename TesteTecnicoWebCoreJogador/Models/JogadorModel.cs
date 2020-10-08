using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TesteTecnicoWebCoreJogador.Models
{
    public class JogadorModel : IDisposable
    {
        private SqlConnection sqlConnection;

        public JogadorModel()
        {
            try
            {
                string strConn = "Data Source=localhost;Initial Catalog=BDJogador;Integrated Security=true";
                sqlConnection = new SqlConnection(strConn);
                sqlConnection.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Dispose()
        {
            sqlConnection.Close();
        }

        public void Create(Jogador jogador)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = @"INSERT INTO Jogador VALUES (@nome, @idade, @numeroCamisa, @golsMarcados)";

            cmd.Parameters.AddWithValue("@nome", jogador.Nome);
            cmd.Parameters.AddWithValue("@idade", jogador.Idade);
            cmd.Parameters.AddWithValue("@numeroCamisa", jogador.NumeroCamisa);
            cmd.Parameters.AddWithValue("@golsMarcados", jogador.GolsMarcados);


            cmd.ExecuteNonQuery();
        }

        public Jogador GetJogador(int? id)
        {
            Jogador jogador = new Jogador();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = @"SELECT * FROM Jogador WHERE IdJogador= " + id;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {               
                jogador.IdJogador = (int)reader["IdJogador"];
                jogador.Nome = (string)reader["Nome"];
                jogador.Idade = (int)reader["Idade"];
                jogador.NumeroCamisa = (int)reader["NumeroCamisa"];
                jogador.GolsMarcados = (int)reader["GolsMarcados"];                
            }

            return jogador;
        }

        public List<Jogador> Read()
        {
            List<Jogador> elenco = new List<Jogador>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = @"SELECT * FROM Jogador";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Jogador jogador = new Jogador();
                jogador.IdJogador = (int)reader["IdJogador"];
                jogador.Nome = (string)reader["Nome"];
                jogador.Idade = (int)reader["Idade"];
                jogador.NumeroCamisa = (int)reader["NumeroCamisa"];
                jogador.GolsMarcados = (int)reader["GolsMarcados"];

                elenco.Add(jogador);
            }

            return elenco;
        }

        public void Update(Jogador jogador)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = @"UPDATE Jogador SET Nome=@nome, Idade=@idade, NumeroCamisa=@numeroCamisa, GolsMarcados=@golsMarcados WHERE IdJogador=@id";

            cmd.Parameters.AddWithValue("@nome", jogador.Nome);
            cmd.Parameters.AddWithValue("@idade", jogador.Idade);
            cmd.Parameters.AddWithValue("@numeroCamisa", jogador.NumeroCamisa);
            cmd.Parameters.AddWithValue("@golsMarcados", jogador.GolsMarcados);
            cmd.Parameters.AddWithValue("@id", jogador.IdJogador);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int? id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = @"DELETE FROM Jogador WHERE IdJogador=@id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
