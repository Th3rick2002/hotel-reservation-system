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
            txtUsuario.Text = "";
            txtClave.Text = "";
            this.Show();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbSalir_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbSalir, "Salir");
        }

        private void pcMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcMinimizar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pcMinimizar, "Minimizar");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable usuariosTable = new UsuariosServices().GetUsuarios();

            DataRow ousuarioRow = usuariosTable.AsEnumerable().FirstOrDefault(u =>
                u.Field<string>("Usuario") == txtUsuario.Text &&
                u.Field<string>("Clave") == txtClave.Text);

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

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formuser formuser = new Formuser();

            formuser.FormClosed += (s, args) => this.Show();
            formuser.Show();
        }
    }

}
