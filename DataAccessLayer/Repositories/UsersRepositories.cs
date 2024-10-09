using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class UsersRepositories
    {
        private SqlDataAccess _dbConnection;

        public UsersRepositories()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetAllUsuarios()
        {
            DataTable usuariosTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT u.IdUsuario, u.Usuario, r.IdRol, r.rol,  CONCAT(u.Nombre, ' ' , u.Apellido) AS NombreCompleto , u.Clave, u.Email, u.Telefono,  u.FechaRegistro FROM Usuario u
                                INNER JOIN Rol r ON r.IdRol = u.IdRol";

                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        usuariosTable.Load(reader);
                    }
                }
            }

            return usuariosTable;
        }

        public void AddUsuarios(Users usuarios)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Usuario(IdRol, Usuario, Clave, Nombre, Apellido, Email, Telefono)
                                VALUES(@IdRol, @User, @Password, @Name, @LastName, @Email, @Telephone)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdRol", usuarios.oRol.IdRol);
                command.Parameters.AddWithValue("@User", usuarios.User);
                command.Parameters.AddWithValue("@Password", usuarios.Password);
                command.Parameters.AddWithValue("@Name", usuarios.Name);
                command.Parameters.AddWithValue("@LastName", usuarios.LastName);
                command.Parameters.AddWithValue("@Email", usuarios.Email);
                command.Parameters.AddWithValue("@Telephone", usuarios.Telephone);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void EditUsuarios(Users usuarios)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Usuario SET " +
                                "Usuario = @User" +
                                "Clave = @Password" +
                                "Nombre = @Name" +
                                "Apellido = @LastName" +
                                "Email = @Email" +
                                "Telefono = @Telephone " +
                                "WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", usuarios.Name);
                command.Parameters.AddWithValue("@Password", usuarios.Password);
                command.Parameters.AddWithValue("@User", usuarios.User);
                command.Parameters.AddWithValue("@LastName", usuarios.LastName);
                command.Parameters.AddWithValue("@Email", usuarios.Email);
                command.Parameters.AddWithValue("@Telephone", usuarios.Telephone);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void DeleteUsuario(int IdUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", IdUser);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    }
}
