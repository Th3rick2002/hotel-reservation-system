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
    public class HabitacionesServices
    {
        private HabitacionesRepositories _habitacionesrepositories;

        public HabitacionesServices()
        {
            _habitacionesrepositories = new HabitacionesRepositories();
        }

        public DataTable GetHabitacion()
        {
            return _habitacionesrepositories.GetAllHabitaciones();
        }

        public void AddHabitaciones(Habitacion habitacion)
        {
            _habitacionesrepositories.AddHabitaciones(habitacion);
        }

        public void UpdateHabitaciones(Habitacion habitacion)
        {
            _habitacionesrepositories.EditHabitaciones(habitacion);
        }

        public void DeleteHabitacion(int IdHabitacion)
        {
            _habitacionesrepositories.DeleteHabitaciones(IdHabitacion);
        }
    }
}
