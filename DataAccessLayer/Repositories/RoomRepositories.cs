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
    public class RoomRepositories
    {
        private SqlDataAccess _dbConnection;

        public RoomRepositories()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetAllHabitaciones()
        {
            DataTable habitacionesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT IdHabitacion,Tipo, PrecioNoche, Caracteristicas FROM Habitacion";

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

        public void AddHabitaciones(Room habitacion)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Usuario(IdHabitacion,Tipo, PrecioNoche, Caracteristicas)
                                VALUES(@IdRoom, @Type, @PriceNight, @Characteristic)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdRoom", habitacion.IdRoom);
                command.Parameters.AddWithValue("@Type", habitacion.Type);
                command.Parameters.AddWithValue("@PriceNight", habitacion.PriceNight);
                command.Parameters.AddWithValue("@Characteristic", habitacion.Characteristic);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditHabitaciones(Room habitacion)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Habitacion SET " +
                                "Tipo = @Type" +
                                "PrecioNoche = @PriceNight" +
                                "Caracteristicas = @Characteristic " +
                                "WHERE IdHabitacion = @IdHabitacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Type", habitacion.Type);
                command.Parameters.AddWithValue("@PriceNight", habitacion.PriceNight);
                command.Parameters.AddWithValue("@Characteristic", habitacion.Characteristic);

                connection.Open();
                command.ExecuteNonQuery();
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
