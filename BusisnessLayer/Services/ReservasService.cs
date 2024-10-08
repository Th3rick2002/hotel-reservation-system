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
    public class ReservasService
    {
        private ReservasRepositories _reservasrepositories;

        public ReservasService()
        {
            _reservasrepositories = new ReservasRepositories();
        }

        public DataTable GetReservas()
        {
            return _reservasrepositories.GetAllReservas();
        }

        public void UpdateUsuarios(Reservas reservas)
        {
            _reservasrepositories.EditReservas(reservas);
        }

        public void DeleteReservas(int idReserva)
        {
            _reservasrepositories.DeleteReservas(idReserva);
        }
    }
}
