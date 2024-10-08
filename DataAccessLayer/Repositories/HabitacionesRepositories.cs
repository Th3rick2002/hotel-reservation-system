using CommonLayer.Entities;
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
    public class HabitacionesRepositories
    {
        private SqlDataAccess _dbConnection;

        public HabitacionesRepositories()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetAllHabitaciones()
        {
            DataTable habitacionesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT Tipo, PrecioNoche, Caracteristicas FROM Habitacion";

                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        habitacionesTable.Load(reader);
                    }
                }
            }

            return habitacionesTable;
        }

        public void AddHabitaciones(Habitacion habitacion)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Usuario(IdHabitacion,Tipo, PrecioNoche, Caracteristicas)
                                VALUES(@IdHabitacion, @Tipo, @PrecioNoche, @Caracteristicas)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdHabitacion", habitacion.IdHabitacion);
                command.Parameters.AddWithValue("@Tipo", habitacion.Tipo);
                command.Parameters.AddWithValue("@PrecioNoche", habitacion.PrecioNoche);
                command.Parameters.AddWithValue("@Caracteristicas", habitacion.Caracteristicas);
            }
        }

        public void EditHabitaciones(Habitacion habitacion)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Habitacion SET " +
                                "Tipo = @Tipo" +
                                "PrecioNoche = @PrecioNoche" +
                                "Caracteristicas = @Caracteristicas " +
                                "WHERE IdHabitacion = @IdHabitacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Tipo", habitacion.Tipo);
                command.Parameters.AddWithValue("@PrecioNoche", habitacion.PrecioNoche);
                command.Parameters.AddWithValue("@Caracteristicas", habitacion.Caracteristicas);
            }
        }

        public void DeleteHabitaciones(int IdHabitaciones)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", IdHabitaciones);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    }
}
