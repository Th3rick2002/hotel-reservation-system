using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System.Data;

namespace BusisnessLayer.Services
{
    public class UsersServices
    {
        private UsersRepositories _usuariosrepositories;

        public UsersServices()
        {
            _usuariosrepositories = new UsersRepositories();
        }

        public DataTable GetUsuarios()
        {
            return _usuariosrepositories.GetAllUsuarios();
        }

        public void AddUsuarios(Users usuarios)
        {
            _usuariosrepositories.AddUsuarios(usuarios);
        }

        public void UpdateUsuarios(Users usuarios)
        {
            _usuariosrepositories.EditUsuarios(usuarios);
        }

        public void DeleteUsuarios(int IdUser)
        {
            _usuariosrepositories.DeleteUsuario(IdUser);
        }

    }
}
