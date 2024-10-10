using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusisnessLayer.Services
{
    public class ReservationServices
    {
        private ReservationRepositories _reservasrepositories;

        public ReservationServices()
        {
            _reservasrepositories = new ReservationRepositories();
        }

        public DataTable GetReservas()
        {
            return _reservasrepositories.GetAllReservas();
        }

        public void AddReserva(Reservation reservation)
        {
            _reservasrepositories.AddReservas(reservation);
        }

        public void UpdateReservas(Reservation reservas)
        {
            _reservasrepositories.EditReservas(reservas);
        }

        public void DeleteReservas(int IdReservation)
        {
            _reservasrepositories.DeleteReservas(IdReservation);
        }
    }
}
