using System;
using System.Data.SqlClient;
using Athletica.Models;
using Athletica.Repositories;


namespace Athletica.Repositories
{
    public class UsuarioRepository : BDContext, IUsuarioRepository
    {
        public void Create(Usuario model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Read(string email, string senha)
        {
            Usuario serv = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Usuario WHERE Email = @email AND Senha = @senha";

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            SqlDataReader reader = cmd.ExecuteReader();

            return serv;
        }

        public void Update(int id, Usuario model)
        {
            throw new System.NotImplementedException();
        }      
    }
}