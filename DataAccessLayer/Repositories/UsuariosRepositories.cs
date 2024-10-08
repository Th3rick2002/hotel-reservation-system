﻿using DataAccessLayer.DbConnection;
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
                string query = @"SELECT u.IdUsuario, r.IdRol, r.rol, u.Nombre, u.Apellido, u.Clave, u.Email, u.Telefono,  u.FechaRegistro FROM Usuario u
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

        public void AddUsuarios(Usuario usuarios)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Usuario(IdRol,Nombre, Apellido, Email, Telefono)
                                VALUES(@IdRol, @Nombre, @Apellido, @Email, @Telefono)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdRol", usuarios.oRol.IdRol);
                command.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
                command.Parameters.AddWithValue("@Apellido", usuarios.Apellido);
                command.Parameters.AddWithValue("@Email", usuarios.Email);
                command.Parameters.AddWithValue("@Telefono", usuarios.Telefono);

            }
        }

        public void EditUsuarios(Usuario usuarios)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Usuario SET " +
                                "Nombre = @Nombre" +
                                "Apellido = @Apellido" +
                                "Email = @Email" +
                                "Telefono = @Telefono " +
                                "WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
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
    }
}
