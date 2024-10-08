using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public  class UsuariosRepositories
    {
        private SqlDataAccess _dbConnection;

        public UsuariosRepositories()
        {
            _dbConnection = new SqlDataAccess();
        }

        private DataTable GetAllUsuarios()
        {
            DataTable usuariosTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Nombre, Apellido, Email, Telefono, FechaRegistro FROM Usuario";
                
                using(var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using(SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        usuariosTable.Load(reader);
                    }
                }
            }

            return usuariosTable;
        }
    }
}
