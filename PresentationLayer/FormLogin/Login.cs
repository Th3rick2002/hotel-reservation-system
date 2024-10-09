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


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            userTextBox.Text = "";
            passwordTextBox.Text = "";
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataTable usuariosTable = new UsuariosServices().GetUsuarios();

            DataRow ousuarioRow = usuariosTable.AsEnumerable().FirstOrDefault(u =>
                u.Field<string>("Usuario") == userTextBox.Text &&
                u.Field<string>("Clave") == passwordTextBox.Text);

            if (ousuarioRow != null)
            {
                Usuarios ousuario = new Usuarios()
                {
                    IdUsuario = ousuarioRow.Field<int>("IdUsuario"),
                    Nombre = ousuarioRow.Field<string>("Usuario"),
                    Clave = ousuarioRow.Field<string>("Clave"),
                    oRol = new Rol
                    {
                        IdRol = ousuarioRow.Field<int>("IdRol"),
                        rol = ousuarioRow.Field<string>("rol")
                    }
                };

                if (ousuario.oRol.rol == "ADMINISTRADOR")
                {
                    this.Hide();
                    FormAdministration formAdmin = new FormAdministration(ousuario);

                    formAdmin.FormClosed += (s, args) => this.Hide();
                    formAdmin.Show();
                    formAdmin.FormClosing += frm_closing;

                }

                else
                {
                    MessageBox.Show("Rol no reconocido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
