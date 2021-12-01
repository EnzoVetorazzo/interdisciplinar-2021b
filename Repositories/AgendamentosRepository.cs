using System;
using System.Data.SqlClient;
using Athletica.Models;
using Athletica.Repositories;
using System.Collections.Generic;

namespace Athletica.Repositories
{
    public class AgendamentosRepository : BDContext, IAgendamentosRepository
    {
        public Boolean Create (Agendamentos objAgendamentos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "insert into Agendamentos (fgk_servicos, nome_agendamentos, hora_inicio, hora_fim) values (@cod_servico, @nome_agendamentos, @hora_inicio, @hora_fim);";

                cmd.Parameters.Add(new SqlParameter("@cod_servico", objAgendamentos.Fgk_servicos));
                cmd.Parameters.Add(new SqlParameter("@nome_agendamentos", objAgendamentos.Nome));
                cmd.Parameters.Add(new SqlParameter("@hora_inicio", objAgendamentos.Hora_inicio));
                cmd.Parameters.Add(new SqlParameter("@hora_fim", objAgendamentos.Hora_fim));

                cmd.ExecuteNonQuery();
                Dispose();
                return true;
            }
            catch(Exception ex)
            {
                // Armazenar a exceção em um log.
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Agendamentos> Find (string nome)
        {
            List<Agendamentos> lstAgendamentos = new List<Agendamentos>();
            
            try
            {
            
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "select a.id, a.nome_agendamentos, s.nome, a.hora_inicio, a.hora_fim from Agendamentos as a inner join Servicos as s on a.fgk_servicos = s.id where a.nome_agendamentos = @nome";
                
                cmd.Parameters.Add(new SqlParameter("@nome", nome));

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    Agendamentos objAgendamentos = new Agendamentos();

                    objAgendamentos.Id = Convert.ToInt32(dr["id"]);
                    objAgendamentos.Nome = dr["nome_agendamentos"].ToString();
                    objAgendamentos.NomeServico = dr["nome"].ToString();
                    objAgendamentos.Hora_inicio = Convert.ToDateTime(dr["hora_inicio"]);
                    objAgendamentos.Hora_fim = Convert.ToDateTime(dr["hora_fim"]);

                    lstAgendamentos.Add(objAgendamentos);
                }
                    
                    dr.Close();
                    Dispose();
                    return lstAgendamentos;
                }
            catch(Exception ex)
            {
                // Armazenar a exceção em um log.
                Console.WriteLine(ex.Message);
                return lstAgendamentos;
            }
        }    

        public Agendamentos FindById (int id)
        {
            Agendamentos objAgendamentos = new Agendamentos();
            
            try
            {
            
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "select s.id, a.id, a.nome_agendamentos, s.nome, a.hora_inicio, a.hora_fim from Agendamentos as a inner join Servicos as s on a.fgk_servicos = s.id where a.id = @id";
                
                cmd.Parameters.Add(new SqlParameter("@id", id));

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                objAgendamentos.CodServico = Convert.ToInt32(dr[0]);
                objAgendamentos.Id = Convert.ToInt32(dr[1]);
                objAgendamentos.Nome = dr["nome_agendamentos"].ToString();
                objAgendamentos.NomeServico = dr["nome"].ToString();
                objAgendamentos.Hora_inicio = Convert.ToDateTime(dr["hora_inicio"]);
                objAgendamentos.Hora_fim = Convert.ToDateTime(dr["hora_fim"]);

                dr.Close();
                Dispose();
                return objAgendamentos;
            }
            catch(Exception ex)
            {
                // Armazenar a exceção em um log.
                Console.WriteLine(ex.Message);
                return objAgendamentos;
            }
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Agendamentos> Read()
        {
            List<Agendamentos> agendamentos = new List<Agendamentos>();            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Servicos";

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Agendamentos agendamento = new Agendamentos()
                {
                    Id = (int) reader["id"],
                    //Fgk_servicos = (int) reader["fgk_servicos"],
                    Nome = (string) reader["nome"],
                    /*Hora_inicio = (DateTime) reader["hora_inicio"],
                    Hora_fim = (DateTime) reader["hora_fim"]*/
                };

                agendamentos.Add(agendamento);

            }

            reader.Close();
            return agendamentos;
        }

        public Boolean Update(Agendamentos objAgendamentos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "update  Agendamentos set fgk_servicos = @cod_servico, nome_agendamentos = @nome_agendamentos, hora_inicio = @hora_inicio, hora_fim = @hora_fim where id = @id;";

                cmd.Parameters.Add(new SqlParameter("@cod_servico", objAgendamentos.Fgk_servicos));
                cmd.Parameters.Add(new SqlParameter("@nome_agendamentos", objAgendamentos.Nome));
                cmd.Parameters.Add(new SqlParameter("@hora_inicio", objAgendamentos.Hora_inicio));
                cmd.Parameters.Add(new SqlParameter("@hora_fim", objAgendamentos.Hora_fim));
                cmd.Parameters.Add(new SqlParameter("@id", objAgendamentos.Id));

                cmd.ExecuteNonQuery();
                Dispose();
                return true;
            }
            catch(Exception ex)
            {
                // Armazenar a exceção em um log.
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}