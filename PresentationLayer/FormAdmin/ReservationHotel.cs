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
    public partial class reservationHotel : Form
    {
        private RoomServices _habitacionesServices;
        private ReservationServices _reservasservice;

        public reservationHotel()
        {
            InitializeComponent();
            _reservasservice = new ReservationServices();
            _habitacionesServices = new RoomServices();
            LoadReservas();
        }

        private void LoadReservas()
        {
            listReservationDataGridView.DataSource = _reservasservice.GetReservas();

            listReservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

                priceResultLabel.Text = costoTotal.ToString("C");
            }
            else
            {
                priceResultLabel.Text = string.Empty;
            }
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

    }
}
