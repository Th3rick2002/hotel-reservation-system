using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System.Data;

namespace BusisnessLayer.Services
{
    public class RoomServices
    {
        private RoomRepositories _habitacionesrepositories;

        public RoomServices()
        {
            _habitacionesrepositories = new RoomRepositories();
        }

        public DataTable GetRooms()
        {
            return _habitacionesrepositories.GetAllRooms();
        }

        public void AddRoom(Room habitacion)
        {
            _habitacionesrepositories.AddRoom(habitacion);
        }

        public void UpdateRoom(Room habitacion)
        {
            _habitacionesrepositories.UpdateRoom(habitacion);
        }

        public void DeleteRoomn(int IdHabitacion)
        {
            _habitacionesrepositories.DeleteRoom(IdHabitacion);
        }
    }
}
