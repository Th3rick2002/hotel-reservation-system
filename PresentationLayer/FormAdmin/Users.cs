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
        private UsersServices _usersServices;
        public Users()
        {
            InitializeComponent();
            _usersServices = new UsersServices();
            LoadData();
            listUserDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void LoadData()
        {
            listUserDataGridView.DataSource = _usersServices.GetAllUsuarios();

            listUserDataGridView.Columns["IdUsuario"].Visible = false;
            listUserDataGridView.Columns["IdRol"].Visible = false;

            listUserDataGridView.Columns["rol"].HeaderText = "Rol";

            listUserDataGridView.Columns["rol"].Visible = true;
        }
    }
}