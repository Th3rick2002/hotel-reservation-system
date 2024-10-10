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
    public class UsuariosRepositories
    {
        private SqlDataAccess _dbConnection;

        public UsuariosRepositories()
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

        public void AddUsuarios(Usuarios usuarios)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Usuario(IdRol, Usuario, Clave, Nombre, Apellido, Email, Telefono)
                                VALUES(@IdRol, @Usuario, @Clave, @Nombre, @Apellido, @Email, @Telefono)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdRol", usuarios.oRol.IdRol);
                command.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                command.Parameters.AddWithValue("@Clave", usuarios.Clave);
                command.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
                command.Parameters.AddWithValue("@Apellido", usuarios.Apellido);
                command.Parameters.AddWithValue("@Email", usuarios.Email);
                command.Parameters.AddWithValue("@Telefono", usuarios.Telefono);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void EditUsuarios(Usuarios usuarios)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Usuario SET " +
                                "Usuario = @Usuario" +
                                "Nombre = @Nombre" +
                                "Apellido = @Apellido" +
                                "Email = @Email" +
                                "Telefono = @Telefono " +
                                "WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
                command.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                command.Parameters.AddWithValue("@Apellido", usuarios.Apellido);
                command.Parameters.AddWithValue("@Email", usuarios.Email);
                command.Parameters.AddWithValue("@Telefono", usuarios.Telefono);

            }
        }

        public void DeleteUsuario(int IdUsuario)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public int? GetUsuarioAndClave(string Usuario, string Clave)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT IdUsuario FROM Usuario WHERE Usuario = @Usuario AND Clave = @Clave";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", Usuario);
                command.Parameters.AddWithValue("@Clave", Clave);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return null;
        }

        public DataTable GetUsuarioById(int IdUser)
        {
            DataTable usuariosTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Usuario, Clave, Nombre, Apellido, Email, Telefono FROM Usuario WHERE IdUsuario = @IdUsuario ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", IdUser);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                usuariosTable.Load(reader);
            }

            return usuariosTable;
        }
    }
}
