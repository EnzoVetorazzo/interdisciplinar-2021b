using System;
using System.Data.SqlClient;
using Athletica.Models;
using Athletica.Repositories;


namespace Athletica.Repositories
{
    public class FuncionarioRepository : BDContext, IFuncionarioRepository
    {
        public void Create(Funcionario model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Funcionario Read(string email, string senha)
        {
            Funcionario func = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Usuario WHERE Email = @email AND Senha = @senha";

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            SqlDataReader reader = cmd.ExecuteReader();

            /*if(reader.Read()) 
            {
                usuario = new Funcionario();
                usuario.Id = reader["Id"] as int?;
                usuario.Nome = (string)reader["Nome"];
                usuario.Email = (string)reader["Email"];
                usuario.Senha = reader["Senha"] as string;
            }*/

            return func;
        }

        public void Update(int id, Funcionario model)
        {
            throw new System.NotImplementedException();
        }
    }
}