using System;
using System.Collections.Generic;
using Athletica.Models;
using System.Data.SqlClient;
using System.Data;
using Athletica.Repositories;

namespace Athletica.Repositories
{
    public class ClienteRepository : BDContext, IClienteRepository
    {
        public void Create(Cliente model)
        {
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "cadastrarcliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nome", model.Nome);
                cmd.Parameters.AddWithValue("@telefone", model.Telefone);
                cmd.Parameters.AddWithValue("@senha", model.Senha);
                cmd.Parameters.AddWithValue("@email", model.Email);

                cmd.ExecuteNonQuery();

            }catch(Exception ex) {
                // Armazenar a exceção em um log.
                Console.WriteLine(ex.Message);
            }
            finally {
                Dispose();
            }
        }

        public Cliente ReadCheck(string nome, string senha)
        {

            Cliente objCliente = new Cliente();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select * from Usuario where nome = @nome and senha = @senha;";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    objCliente.Id = Convert.ToInt16(dr["usuario_id"]);
                    objCliente.Nome = dr["nome"].ToString();
                    objCliente.Telefone = dr["telefone"].ToString();
                    objCliente.Senha = dr["senha"].ToString();
                }
                
                dr.Close();
                Dispose();
                return objCliente;
            }
            catch(Exception ex) 
            {               
                // Armazenar a exceção em um log.
                Console.WriteLine(ex.Message);
                return objCliente;
            }            
            
        }

        public Cliente Read(string nome, string senha)
        {
            return null;
        }
        public void Update(int id, Cliente model)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
