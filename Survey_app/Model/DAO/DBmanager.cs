using System.Data.SqlClient;
using System.Configuration;

namespace Survey_app
{
    public class DBmanager
    {

        public string connectionString;
        public SqlConnection conn { get; set; }
        public DBmanager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["devConnection"].ConnectionString;
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
        }
        public SqlConnection openConnection()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public SqlConnection closeConnection()
        {
            conn.Close();
            return conn;
        }
    }
}