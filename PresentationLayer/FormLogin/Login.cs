using BusisnessLayer.Services;
using PresentationLayer.FormAdmin;
using PresentationLayer.FormCliente;

namespace PresentationLayer.FormLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string user = userTextBox.Text;
            string password = passwordTextBox.Text;
=======
            DataTable usuariosTable = new UsersServices().GetUsuarios();
>>>>>>> 0ed96d551495507942b753dc7be7a44989178fd9

            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.Clear();

            if (string.IsNullOrEmpty(user) && (string.IsNullOrEmpty(password)))
            {
                errorProvider.SetError(userTextBox, "El campo usuario y contraseña es requerido.");
                return;
            }else
            {
                UsuariosServices usuariosServices = new UsuariosServices();
                var existUser = usuariosServices.GetUsuarioAndClave(user, password);

                if (existUser != null)
                {
                    userTextBox.Clear();
                    passwordTextBox.Clear();
                    this.Hide();
                    int IdUser = (int)existUser;
                    FormAdministration formAdministration = new FormAdministration(IdUser);
                    formAdministration.FormClosed += (s, args) => this.Show();
                    formAdministration.Show();
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
    }
}
