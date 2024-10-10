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
    public class ReservationRepositories
    {
        private SqlDataAccess _dbConnection;

        public ReservationRepositories()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetAllReservas()
        {
            DataTable reservasTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.ffin, r.fnit, r.idReserva, h.IdHabitacion, u.IdUsuario, r.estado, r.precio  FROM reserva r
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
        public void AddReservas(Reservation reservas)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO reserva(fnit, ffin, IdHabitacion, IdUsuario, Estado, precio)
                                VALUES(@fnit, @ffin, @IdRoom, @IdUser, @State, @Price)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdRoom", reservas.IdRoom);
                command.Parameters.AddWithValue("@fnit", reservas.StartDate);
                command.Parameters.AddWithValue("@ffin", reservas.EndDate);
                command.Parameters.AddWithValue("@IdUser", reservas.IdUser);
                command.Parameters.AddWithValue("@State", reservas.State);
                command.Parameters.AddWithValue("@Price", reservas.Price);


                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void EditReservas(Reservation reservas)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE reserva SET " +
                                "idReserva = @IdRoom" +
                                "fnit = @fnit" +
                                "ffin = @ffin" +
                                "IdHabitacion = @IdUser" +
                                "IdUsuario = @IdUsuario" +
                                "Estado = @State" +
                                "Price = @Price " +
                                "WHERE idReserva = @idReserva";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdRoom", reservas.IdRoom);
                command.Parameters.AddWithValue("@IdUser", reservas.IdUser);
                command.Parameters.AddWithValue("@fnit", reservas.StartDate);
                command.Parameters.AddWithValue("@ffin", reservas.EndDate);
                command.Parameters.AddWithValue("@State", reservas.State);
                command.Parameters.AddWithValue("@Price", reservas.Price);


                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void DeleteReservas(int IdReservation)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM reserva WHERE idReserva = @idReserva";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idReserva", IdReservation);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

    }
}
