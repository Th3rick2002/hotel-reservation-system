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
    public class ReservasRepositories
    {
        private SqlDataAccess _dbConnection;

        public ReservasRepositories()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetAllReservas()
        {
            DataTable reservasTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.idReserva, h.IdHabitacion, u.IdUsuario, r.estado  FROM reserva r
                                INNER JOIN Habitacion h ON h.IdHabitacion = r.idHabitacion
                                INNER JOIN Usuario u ON u.IdUsuario = r.IdUsuario";

                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        reservasTable.Load(reader);
                    }
                }
            }

            return reservasTable;

        }
        public void AddReservas(Reservas reservas)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO reserva(IdHabitacion, IdUsuario, Estado)
                                VALUES(@IdHabitacion, @IdUsuario, @Estado)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdHabitacion", reservas.IdHabitacion);
                command.Parameters.AddWithValue("@IdUsuario", reservas.IdUsuario);
                command.Parameters.AddWithValue("@Estado", reservas.Estado);

            }
        }

        public void EditReservas(Reservas reservas)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE reserva SET " +
                                "idReserva = @idReserva" +
                                "IdHabitacion = @IdHabitacion" +
                                "IdUsuario = @IdUsuario" +
                                "Estado = @Estado " +
                                "WHERE idReserva = @idReserva";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idReserva", reservas.idReserva);
                command.Parameters.AddWithValue("@IdHabitacion", reservas.IdHabitacion);
                command.Parameters.AddWithValue("@IdUsuario", reservas.IdUsuario);
                command.Parameters.AddWithValue("@Estado", reservas.Estado);

            }
        }

        public void DeleteReservas(int idReserva)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM reserva WHERE idReserva = @idReserva";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idReserva", idReserva);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

    }
}
