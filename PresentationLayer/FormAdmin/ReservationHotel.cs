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
    public partial class ReservationHotel : Form
    {
        private HabitacionesServices _habitacionesServices;
        private ReservasService _reservasservice;

        public ReservationHotel()
        {
            InitializeComponent();
            _reservasservice = new ReservasService();
            _habitacionesServices = new HabitacionesServices();
            LoadReservas();
        }

        private void LoadReservas()
        {
            dgvReservas.DataSource = _reservasservice.GetReservas();

            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            roomNumbercomboBox.DataSource = _habitacionesServices.GetHabitacion();

            roomNumbercomboBox.DisplayMember = "Tipo";
            roomNumbercomboBox.ValueMember = "IdHabitacion";


        }

        private void CalcularPrecioTotal()
        {
            if (roomNumbercomboBox.SelectedItem != null && dateInitDateTimePicker.Value < endDateTimePicker.Value)
            {
                var hotelSeleccionadoRow = (DataRowView)roomNumbercomboBox.SelectedItem;

                int tarifaBaseInt = (int)hotelSeleccionadoRow["PrecioNoche"];
                decimal tarifaBase = (decimal)tarifaBaseInt;

                DateTime fechaInicio = dateInitDateTimePicker.Value;
                DateTime fechaFin = endDateTimePicker.Value;

                int diasReservados = (fechaFin - fechaInicio).Days;

                decimal costoTotal = tarifaBase * diasReservados;

                lblTotal.Text = costoTotal.ToString("C");
            }
            else
            {
                lblTotal.Text = string.Empty;
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateInitDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
        }

        private void roomNumbercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecioTotal();
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
