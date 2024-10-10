using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=DESKTOP-8QOS74N\\SQLEXPRESS;Initial Catalog=Reservamiento_HotTel;Integrated Security=True;Encrypt=False";

        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
