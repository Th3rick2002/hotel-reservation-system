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
    public partial class RoomHotel : Form
    {
        private HabitacionesServices _habitacionesService;
        public RoomHotel()
        {
            InitializeComponent();
            _habitacionesService = new HabitacionesServices();
            LoadHabitaciones();

            dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadHabitaciones()
        {
            dgvHabitaciones.DataSource = _habitacionesService.GetHabitacion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbSalir_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbSalir, "Cerrar ventana");
        }

        private void pcMinimizar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pcMinimizar, "Minimizar ventana");

        }
    }
}
