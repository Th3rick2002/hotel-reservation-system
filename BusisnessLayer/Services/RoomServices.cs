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
    public class RoomServices
    {
        private RoomRepositories _habitacionesrepositories;

        public RoomServices()
        {
            _habitacionesrepositories = new RoomRepositories();
        }

        public DataTable GetHabitacion()
        {
            return _habitacionesrepositories.GetAllHabitaciones();
        }

        public void AddHabitaciones(Room habitacion)
        {
            _habitacionesrepositories.AddHabitaciones(habitacion);
        }

        public void UpdateHabitaciones(Room habitacion)
        {
            _habitacionesrepositories.EditHabitaciones(habitacion);
        }

        public void DeleteHabitacion(int IdHabitacion)
        {
            _habitacionesrepositories.DeleteHabitaciones(IdHabitacion);
        }
    }
}
