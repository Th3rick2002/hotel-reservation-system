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
        public FormAdministration(Usuario ousuario)
        {
            InitializeComponent();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            RoomHotel roomHotel = new RoomHotel();
            this.Hide();
            roomHotel.Show();
            roomHotel.FormClosed += (s, args) => this.Show();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.Show();
            users.FormClosed += (s, args) => this.Show();
        }

        private void btnReservaciones_Click_1(object sender, EventArgs e)
        {
            ReservationHotel reservationHotel = new ReservationHotel();
            this.Hide();
            reservationHotel.Show();
            reservationHotel.FormClosed += (s, args) => this.Show();

        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
