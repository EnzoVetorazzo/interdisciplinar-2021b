using System;
using System.Data.SqlClient;
using Athletica.Models;
using Athletica.Repositories;
using System.Collections.Generic;

namespace Athletica.Repositories
{
    public class ServicosRepository : BDContext, IServicosRepository
    {
        public void Create(Servicos model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

       public List<Servicos> Read()
        {
            List<Servicos> Servicos = new List<Servicos>();            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Servicos";

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Servicos servico = new Servicos()
                {
                    Id = (int) reader["id"],
                    //Fgk_servicos = (int) reader["fgk_servicos"],
                    Duracao = (string) reader["duracao"],
                    Dias = (string) reader["dias"],
                    Horarios = (string) reader["horarios"],
                    Nome = (string) reader["nome"]
                    /*Hora_inicio = (DateTime) reader["hora_inicio"],
                    Hora_fim = (DateTime) reader["hora_fim"]*/
                };

                Servicos.Add(servico);

            }


            return Servicos;
        }

        public void Update(int id, Servicos model)
        {
            throw new System.NotImplementedException();
        }
    }
}