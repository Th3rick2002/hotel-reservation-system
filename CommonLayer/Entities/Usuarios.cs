namespace CommonLayer.Entities
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public Rol oRol { get; set; }
        public string Usuario {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }


    }
}
