using BusisnessLayer.Services;
using CommonLayer.Entities;
using PresentationLayer.FormAdmin;
using PresentationLayer.FormCliente;
using System.Data;

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
            DataTable usuariosTable = new UsersServices().GetUsuarios();

            DataRow ousuarioRow = usuariosTable.AsEnumerable().FirstOrDefault(u =>
                u.Field<string>("Usuario") == userTextBox.Text &&
                u.Field<string>("Clave") == passwordTextBox.Text);

            if (ousuarioRow != null)
            {
                FormAdministration formAdministration = new FormAdministration();
                formAdministration.Show();
            }
            else
            {
                MessageBox.Show("No se encontró el usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
