using BusisnessLayer.Services;
using CommonLayer.Entities;
using PresentationLayer.FormAdmin;
using PresentationLayer.FormCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.FormLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            DataTable usuariosTable = new UsuariosServices().GetUsuarios();

            DataRow ousuarioRow = usuariosTable.AsEnumerable().FirstOrDefault(u =>
                u.Field<string>("Nombre") == txtUsuario.Text &&
                u.Field<string>("Clave") == txtClave.Text);

            if (ousuarioRow != null)
            {
                Usuario ousuario = new Usuario()
                {
                    IdUsuario = ousuarioRow.Field<int>("IdUsuario"),
                    Nombre = ousuarioRow.Field<string>("Nombre"),
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
                u.Field<string>("Nombre") == txtUsuario.Text &&
                u.Field<string>("Clave") == txtClave.Text);

            if (ousuarioRow != null)
            {
                Usuario ousuario = new Usuario()
                {
                    IdUsuario = ousuarioRow.Field<int>("IdUsuario"),
                    Nombre = ousuarioRow.Field<string>("Nombre"),
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
