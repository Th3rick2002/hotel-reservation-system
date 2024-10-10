using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=DESKTOP-JDM7JV2\\MSSQLSERVER01;Initial Catalog=Reservamiento_HotTel;Integrated Security=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
