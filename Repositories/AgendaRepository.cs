using System;
using System.Data.SqlClient;
using Athletica.Models;
using Athletica.Repositories;

namespace Athletica.Repositories
{
    public class AgendaRepository : BDContext, IAgendaRepository
    {
        public void Create(Agenda model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Agenda Read(string email, string senha)
        {
            Agenda serv = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Usuario WHERE Email = @email AND Senha = @senha";

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            SqlDataReader reader = cmd.ExecuteReader();

            return serv;
        }

        public void Update(int id, Agenda model)
        {
            throw new System.NotImplementedException();
        }
    }
}