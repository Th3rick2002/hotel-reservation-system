using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System.Data;

namespace BusisnessLayer.Services
{
    public class UsuariosServices
    {
        private UsuariosRepositories _usuariosrepositories;

        public UsuariosServices()
        {
            _usuariosrepositories = new UsuariosRepositories();
        }

        public DataTable GetUsuarios()
        {
            return _usuariosrepositories.GetAllUsuarios();
        }

        public void AddUsuarios(Usuarios usuarios)
        {
            _usuariosrepositories.AddUsuarios(usuarios);
        }

        public void UpdateUsuarios(Usuarios usuarios)
        {
            _usuariosrepositories.EditUsuarios(usuarios);
        }

        public void DeleteUsuarios(int IdUsuario)
        {
            _usuariosrepositories.DeleteUsuario(IdUsuario);
        }

    }
}
