using BusisnessLayer.Services;
using CommonLayer.Entities;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.FormAdmin
{
    public partial class reservationHotel : Form
    {
        private RoomServices _habitacionesServices;
        private ReservationServices _reservasservice;
        bool Editing = false;

        public reservationHotel()
        {
            InitializeComponent();
            _reservasservice = new ReservationServices();
            _habitacionesServices = new RoomServices();
            LoadReservas();
            LoadEstados();
            listReservationDataGridView.CellClick += dataGridView1_CellClick;
        }

        public void LoadEstados()
        {
            List<string> estados = new List<string>
            {
                "Activo",
                "Desactivo"
            };
            StatesComboBox.DataSource = estados;
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

        private void reservationButton_Click(object sender, EventArgs e)
        {
            if (Editing)
            {
                int IdReservation = int.Parse(listReservationDataGridView.CurrentRow.Cells["IdReserva"].Value.ToString());
                string ffin = listReservationDataGridView.CurrentRow.Cells["ffin"].Value.ToString();
                string fnit = listReservationDataGridView.CurrentRow.Cells["fnit"].Value.ToString();
                int IdRoom = Convert.ToInt32(listReservationDataGridView.CurrentRow.Cells[3].Value);
                int IdUser = Convert.ToInt32(listReservationDataGridView.CurrentRow.Cells[4].Value);
                int PrecioNoche = Convert.ToInt32(priceResultLabel.Text);
                string Estados = listReservationDataGridView.CurrentRow.Cells["States"].Value.ToString();



                Reservation reservation = new Reservation();
                reservation.idReservation = IdReservation;
                reservation.StartDate = Convert.ToDateTime(ffin);
                reservation.EndDate = Convert.ToDateTime(fnit);
                reservation.IdRoom = IdRoom;
                reservation.IdUser = IdUser;
                reservation.Price = PrecioNoche;
                reservation.State = Estados;


                _reservasservice.UpdateReservas(reservation);
                LoadReservas();
                LoadEstados();

            }
            else
            {
                string ffin = listReservationDataGridView.CurrentRow.Cells["ffin"].Value.ToString();
                string fnit = listReservationDataGridView.CurrentRow.Cells["fnit"].Value.ToString();
                int IdRoom = Convert.ToInt32(listReservationDataGridView.CurrentRow.Cells[3].Value);
                int IdUser = Convert.ToInt32(listReservationDataGridView.CurrentRow.Cells[4].Value);
                decimal PrecioNoche = Convert.ToDecimal(priceResultLabel.Text.Replace("$", "").Trim());
                string Estados = listReservationDataGridView.CurrentRow.Cells["Estado"].Value.ToString();



                Reservation reservation = new Reservation();
                reservation.StartDate = Convert.ToDateTime(ffin);
                reservation.EndDate = Convert.ToDateTime(fnit);
                reservation.IdRoom = IdRoom;
                reservation.IdUser = IdUser;
                reservation.Price = PrecioNoche;
                reservation.State = Estados;



                _reservasservice.AddReserva(reservation);
                LoadReservas();
                LoadEstados();
            }
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            if (listReservationDataGridView.SelectedRows.Count > 0)
            {
                nameClientTextBox.Text = listReservationDataGridView.CurrentRow.Cells[3].Value.ToString();
                dateInitDateTimePicker.Text = listReservationDataGridView.CurrentRow.Cells["ffin"].Value.ToString();
                endDateTimePicker.Text = listReservationDataGridView.CurrentRow.Cells["fnit"].Value.ToString();
                roomNumbercomboBox.Text = listReservationDataGridView.CurrentRow.Cells["IdUsuario"].Value.ToString();
                priceResultLabel.Text = listReservationDataGridView.CurrentRow.Cells["Price"].Value.ToString();
                StatesComboBox.Text = listReservationDataGridView.CurrentRow.Cells["Estado"].Value.ToString();

                Editing = true;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listReservationDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var EliminarConfirmar = new DialogResult();

                EliminarConfirmar = MessageBox.Show("Esta seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (EliminarConfirmar == DialogResult.Yes)
                {
                    int IdReservation = int.Parse(listReservationDataGridView.CurrentRow.Cells["IdReserva"].Value.ToString());
                    _reservasservice.DeleteReservas(IdReservation);

                    LoadEstados();
                    LoadReservas();
                }
            }
        }
    }
}
