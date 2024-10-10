using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=LAPTOP-PHCFNULN\\SQLEXPRESS;Initial Catalog=Reservamiento_HotTel;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
