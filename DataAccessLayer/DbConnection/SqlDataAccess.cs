using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
<<<<<<< HEAD
            _connectionString = "Data Source=DESKTOP-JDM7JV2\\MSSQLSERVER01;Initial Catalog=Reservamiento_HotTel;Integrated Security=True;Trust Server Certificate=True";
=======
            _connectionString = "Data Source=DESKTOP-8QOS74N\\SQLEXPRESS;Initial Catalog=Reservamiento_HotTel;Integrated Security=True;Encrypt=False";
>>>>>>> 5eeb3f02558e14b235ac9bbf801b2062f595326b
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
