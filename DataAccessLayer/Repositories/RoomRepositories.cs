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

        public DataTable GetAllRooms()
        {
            DataTable roomsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT IdHabitacion,Tipo, PrecioNoche, Caracteristicas FROM Habitacion";

                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        roomsTable.Load(reader);
                    }
                }
            }

            return roomsTable;
        }

        public void AddRoom(Room room)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Habitacion (Tipo, PrecioNoche, Caracteristicas)
                                VALUES(@Type, @PriceNight, @Characteristic)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Type", room.Type);
                command.Parameters.AddWithValue("@PriceNight", room.PriceNight);
                command.Parameters.AddWithValue("@Characteristic", room.Characteristic);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateRoom(Room habitacion)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Habitacion SET Tipo = @Type, PrecioNoche = @PriceNight, Caracteristicas = @Characteristic WHERE IdHabitacion = @IdHabitacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdHabitacion", habitacion.IdRoom);
                command.Parameters.AddWithValue("@Type", habitacion.Type);
                command.Parameters.AddWithValue("@PriceNight", habitacion.PriceNight);
                command.Parameters.AddWithValue("@Characteristic", habitacion.Characteristic);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int IdHabitaciones)
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
