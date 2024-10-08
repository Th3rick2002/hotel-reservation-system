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

        public void UpdateUsuarios(Usuario usuarios)
        {
            _usuariosrepositories.EditUsuarios(usuarios);
        }

        public void DeleteUsuarios(int IdUsuario)
        {
            _usuariosrepositories.DeleteUsuario(IdUsuario);
        }

    }
}
