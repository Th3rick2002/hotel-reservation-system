using CommonLayer.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer.FormLogin;
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
    public partial class FormAdministration : Form
    {
        public FormAdministration(Usuarios ousuario)
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            RoomHotel roomHotel = new RoomHotel();
            this.Hide();
            roomHotel.Show();
            roomHotel.FormClosed += (s, args) => this.Show();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.Show();
            users.FormClosed += (s, args) => this.Show();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            reservationHotel reservationHotel = new reservationHotel();
            this.Hide();
            reservationHotel.Show();
            reservationHotel.FormClosed += (s, args) => this.Show();
        }
    }
}
