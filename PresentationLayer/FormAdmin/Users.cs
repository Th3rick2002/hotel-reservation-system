using BusisnessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.FormAdmin
{
    public partial class Users : Form
    {
        private UsuariosServices _usuariosServices;
        public Users()
        {
            InitializeComponent();
            _usuariosServices = new UsuariosServices();
            LoadData();
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void LoadData()
        {
            dgvUsuarios.DataSource = _usuariosServices.GetUsuarios();

            dgvUsuarios.Columns["IdUsuario"].Visible = false;
            dgvUsuarios.Columns["IdRol"].Visible = false;

            dgvUsuarios.Columns["rol"].HeaderText = "Rol";

            dgvUsuarios.Columns["rol"].Visible = true;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
