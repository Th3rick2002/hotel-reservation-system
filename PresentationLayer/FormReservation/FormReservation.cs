using BusisnessLayer.Services;
using CommonLayer.Entities;
using System.Data;

namespace PresentationLayer.FormReservation
{
    public partial class FormReservation : Form
    {
        private RoomServices roomServices;
        private readonly int idUser;
        public FormReservation(int IdUser)
        {
            InitializeComponent();
            this.idUser = IdUser;
            this.roomServices = new RoomServices();
            LoadRooms();
        }

        private void LoadRooms()
        {

            DataTable roomsTable = roomServices.GetRooms();

            List<Room> rooms = new List<Room>();

            foreach (DataRow row in roomsTable.Rows)
            {
                Room room = new Room
                {
                    IdRoom = (int)row["IdHabitacion"]
                };
                rooms.Add(room);
            }

            roomNumbercomboBox.DataSource = rooms;
            roomNumbercomboBox.DisplayMember = "Number";
            roomNumbercomboBox.ValueMember = "IdRoom";
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            string NameClient = nameClientTextBox.Text;
            DateTime DateIn = dateInitDateTimePicker.Value;
            DateTime DateOut = endDateTimePicker.Value;
            int IdRoom = (int)roomNumbercomboBox.SelectedValue;
            int IdUser = idUser;
            bool State = true;
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }
    }
}
