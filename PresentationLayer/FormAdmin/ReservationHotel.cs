using BusisnessLayer.Services;
using System.Data;
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
            listReservationDataGridView.CellClick += dataGridView1_CellClick;
        }

        private void LoadReservas()
        {
            listReservationDataGridView.DataSource = _reservasservice.GetReservas();

            listReservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            roomNumbercomboBox.DataSource = _habitacionesServices.GetRooms();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haga clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén el valor de la celda en la columna deseada
                var cellValue = listReservationDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                nameClientTextBox.Text = cellValue?.ToString();
            }
        }
    }
}
