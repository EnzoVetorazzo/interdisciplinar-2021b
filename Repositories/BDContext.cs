using System;
using System.Data.SqlClient; 


// 3 classes principais do namespace SqlClient:
// SqlConnection (usada para conectar e desconectar com o banco de dados)
// SqlCommand (usada para executar um comando SQL a partir da conexão estabelecida)
// SqlDataReader (usada para percorrer os dados consultados pelo comando SQL)

namespace Athletica.Repositories
{
    public abstract class BDContext
    {
        // Atributo
        protected SqlConnection connection;

        // Construtor
        public BDContext()
        {
            var strConnection = "Data Source = localhost; Integrated Security = True; Initial Catalog = Atletica_BD";
            connection = new SqlConnection(strConnection);
            connection.Open();
            
        }

        public void Dispose()
        {
            connection.Close();
            
        }
    }
}