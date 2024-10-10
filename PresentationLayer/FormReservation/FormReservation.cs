using BusisnessLayer.Services;
using CommonLayer.Entities;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.FormReservation
{
    public partial class FormReservation : Form
    {
        private RoomServices roomServices;
        private ReservationServices reservationServices;
        private readonly int idUser;
        private List<Reservation> reservations;

        public FormReservation(int IdUser)
        {
            InitializeComponent();
            this.idUser = IdUser;
            this.roomServices = new RoomServices();
            this.reservationServices = new ReservationServices();
            LoadRooms();
            LoadReservations();
        }

        private void LoadRooms()
        {
            DataTable roomsTable = roomServices.GetRooms();
            List<Room> availableRooms = new List<Room>();

            foreach (DataRow row in roomsTable.Rows)
            {
                Room room = new Room
                {
                    IdRoom = (int)row["IdHabitacion"],
                    PriceNight = Convert.ToDecimal(row["PrecioNoche"]),
                    Type = (string)row["Tipo"],
                    Characteristic = (string)row["Caracteristicas"]
                };

                if (!IsRoomReserved(room.IdRoom))
                {
                    availableRooms.Add(room);
                }
            }

            roomNumbercomboBox.DataSource = availableRooms;
            roomNumbercomboBox.DisplayMember = "Type";
            roomNumbercomboBox.ValueMember = "IdRoom";
        }

        private void LoadReservations()
        {
            DataTable reservationsTable = reservationServices.GetReservas();
            reservations = new List<Reservation>();

            foreach (DataRow row in reservationsTable.Rows)
            {
                reservations.Add(new Reservation
                {
                    idReservation = (int)row["idReserva"],
                    StartDate = (DateTime)row["fnit"],
                    EndDate = (DateTime)row["ffin"],
                    IdRoom = (int)row["idHabitacion"],
                    IdUser = (int)row["idUsuario"],
                    Price = (decimal)row["precio"],
                    State = (string)row["estado"]
                });
            }
        }

        private bool IsRoomReserved(int idRoom)
        {
            if (reservations == null)
                return false;

            foreach (var reservation in reservations)
            {
                if (reservation.IdRoom == idRoom &&
                    reservation.StartDate < endDateTimePicker.Value &&
                    reservation.EndDate > dateInitDateTimePicker.Value)
                {
                    return true;
                }
            }
            return false;
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            string NameClient = nameClientTextBox.Text;
            DateTime DateIn = dateInitDateTimePicker.Value;
            DateTime DateOut = endDateTimePicker.Value;
            int IdRoom = (int)roomNumbercomboBox.SelectedValue;

            if (DateOut > DateIn)
            {
                var reservation = new Reservation
                {
                    StartDate = DateIn,
                    EndDate = DateOut,
                    IdRoom = IdRoom,
                    IdUser = idUser,
                    Price = CalculatePrice(DateIn, DateOut),
                    State = "Active"
                };

                reservationServices.AddReserva(reservation);
                MessageBox.Show("Reserva creada exitosamente.");
            }
            else
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada.");
            }
        }

        private decimal CalculatePrice(DateTime startDate, DateTime endDate)
        {
            if (roomNumbercomboBox.SelectedItem is Room selectedRoom)
            {
                decimal tarifaBase = selectedRoom.PriceNight;
                int diasReservados = (endDate - startDate).Days;
                return tarifaBase * diasReservados;
            }
            return 0;
        }


        private void CalcularPrecioTotal()
        {
            if (roomNumbercomboBox.SelectedItem != null)
            {
                var hotelSeleccionadoRow = (DataRowView)roomNumbercomboBox.SelectedItem;

                decimal tarifaBase = Convert.ToDecimal(hotelSeleccionadoRow["PrecioNoche"]);
                DateTime fechaInicio = dateInitDateTimePicker.Value;
                DateTime fechaFin = endDateTimePicker.Value;

                if (fechaFin > fechaInicio)
                {
                    int diasReservados = (fechaFin - fechaInicio).Days;
                    decimal costoTotal = tarifaBase * diasReservados;
                    priceResultLabel.Text = costoTotal.ToString();
                }
                else
                {
                    priceLabel.Text = "Rango de fechas inválido";
                }
            }
            else
            {
                priceLabel.Text = string.Empty;
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

        private void FormReservation_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }
    }
}
