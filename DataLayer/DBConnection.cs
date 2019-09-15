using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBConnection
    {
        private string host = "localhost\\TECMANTE";
        private string dbName = "bdtec";
        private string user = "sa";
        private string pass = "sa1234";

        public SqlConnection GetConnection()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = host;
            builder.UserID = user;
            builder.Password = pass;
            builder.InitialCatalog = dbName;

            try
            {
                var connection = new SqlConnection(builder.ConnectionString);

                if (connection.State == ConnectionState.Open)
                    return connection;

                connection.Open();

                return connection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
