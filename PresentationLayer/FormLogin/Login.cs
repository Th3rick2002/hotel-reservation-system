using BusisnessLayer.Services;
using PresentationLayer.FormAdmin;
using PresentationLayer.FormCliente;
using PresentationLayer.FormReservation;
using System.Data;

namespace PresentationLayer.FormLogin
{
    public partial class Login : Form
    {
        private UsersServices _usersServices;
        public Login()
        {
            InitializeComponent();
            this._usersServices = new UsersServices();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = userTextBox.Text;
            string password = passwordTextBox.Text;
            DataTable usuariosTable = new UsersServices().GetAllUsuarios();

            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();

            if (string.IsNullOrEmpty(user) && (string.IsNullOrEmpty(password)))
            {
                errorProvider.SetError(userTextBox, "El campo usuario y contraseña es requerido.");
                return;
            }
            else
            {
                UsersServices usuariosServices = new UsersServices();
                var existUser = usuariosServices.GetUsuarioAndClave(user, password);

                if (existUser != null)
                {
                    if (GetUserRoleById((int)existUser) == "ADMINISTRADOR")
                    {
                        userTextBox.Clear();
                        passwordTextBox.Clear();
                        this.Hide();
                        int IdUser = (int)existUser;
                        FormAdministration formAdministration = new FormAdministration(IdUser);
                        formAdministration.FormClosed += (s, args) => this.Show();
                        formAdministration.Show();
                    }

                    else if (GetUserRoleById((int)existUser) == "CLIENTE")
                    {
                        userTextBox.Clear();
                        passwordTextBox.Clear();
                        this.Hide();
                        int IdUser = (int)existUser;
                        FormReservation.FormReservation formReservation = new FormReservation.FormReservation(IdUser);
                        formReservation.FormClosed += (s, args) => this.Show();
                        formReservation.Show();
                    }

                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void newCountTextBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formuser formuser = new Formuser();

            formuser.FormClosed += (s, args) => this.Show();
            formuser.Show();
        }

        private string GetUserRoleById(int userId)
        {
            DataTable usuariosTable = _usersServices.GetAllUsuarios();
            DataRow userRow = usuariosTable.AsEnumerable()
                    .FirstOrDefault(u => u.Field<int>("IdUsuario") == userId);

            return userRow != null ? userRow.Field<string>("rol") : string.Empty;
        }
    }
}
