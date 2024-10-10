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

        public DataTable GetAllUsuarios()
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

        public int? GetUsuarioAndClave(string usuario, string clave)
        {
            return _usuariosrepositories.GetUsuarioAndClave(usuario, clave);
        }

        public DataTable GetUsuarioById(int IdUsuario)
        {
            return _usuariosrepositories.GetUsuarioById(IdUsuario);
        }
    }
}
