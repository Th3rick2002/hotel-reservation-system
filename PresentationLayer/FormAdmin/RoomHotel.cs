using BusisnessLayer.Services;
using CommonLayer.Entities;
using PresentationLayer.Validations;
using System.Windows.Forms;

namespace PresentationLayer.FormAdmin
{
    public partial class RoomHotel : Form
    {
        private RoomServices _roomsService;
        private int selectedRoomId;
        public RoomHotel()
        {
            InitializeComponent();
            _roomsService = new RoomServices();
            listRoomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listRoomDataGridView.CellClick += listRoomDataGridView_CellClick;
        }

        private void LoadRooms()
        {
            listRoomDataGridView.DataSource = _roomsService.GetRooms();
        }

        private void RoomHotel_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void saveRoomButton_Click(object sender, EventArgs e)
        {
            string type = typeRoomTextBox.Text;
            string priceText = priceRoomTextBox.Text;
            string characteristic = characteristicRoomTextBox.Text;

            var errorProvider = new ErrorProvider();
            errorProvider.Clear();

            if (string.IsNullOrEmpty(priceText) || !priceText.All(char.IsDigit))
            {
                errorProvider.SetError(priceRoomTextBox, "El precio de la habitación debe ser un número.");
                return;
            }

            int priceNight = Convert.ToInt32(priceText);

            Room room = new Room()
            {
                Type = type,
                PriceNight = priceNight,
                Characteristic = characteristic
            };

            ValidationRoom validation = new ValidationRoom();
            FluentValidation.Results.ValidationResult results = validation.Validate(room);

            foreach (var error in results.Errors)
            {
                switch (error.PropertyName)
                {
                    case "Type":
                        errorProvider.SetError(typeRoomTextBox, error.ErrorMessage);
                        break;
                    case "PriceNight":
                        errorProvider.SetError(priceRoomTextBox, error.ErrorMessage);
                        break;
                    case "Characteristic":
                        errorProvider.SetError(characteristicRoomTextBox, error.ErrorMessage);
                        break;
                }
            }

            if (results.IsValid)
            {
                _roomsService.AddRoom(room);
                LoadRooms();
            }
        }

        private void listRoomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedRoomId = Convert.ToInt32(listRoomDataGridView.Rows[e.RowIndex].Cells["IdHabitacion"].Value);
                var typeValue = listRoomDataGridView.Rows[e.RowIndex].Cells["Tipo"].Value;
                var priceValue = listRoomDataGridView.Rows[e.RowIndex].Cells["PrecioNoche"].Value;
                var characteristicValue = listRoomDataGridView.Rows[e.RowIndex].Cells["Caracteristicas"].Value;

                typeRoomTextBox.Text = typeValue?.ToString();
                priceRoomTextBox.Text = priceValue?.ToString();
                characteristicRoomTextBox.Text = characteristicValue?.ToString();
            }
        }

        private void editRoomButton_Click(object sender, EventArgs e)
        {
            string type = typeRoomTextBox.Text;
            string priceText = priceRoomTextBox.Text;
            string characteristic = characteristicRoomTextBox.Text;

            var errorProvider = new ErrorProvider();
            errorProvider.Clear();

            if (string.IsNullOrEmpty(priceText) || !priceText.All(char.IsDigit))
            {
                errorProvider.SetError(priceRoomTextBox, "El precio de la habitación debe ser un número.");
                return;
            }

            int priceNight = Convert.ToInt32(priceText);

            Room room = new Room()
            {
                IdRoom = selectedRoomId,
                Type = type,
                PriceNight = priceNight,
                Characteristic = characteristic
            };

            ValidationRoom validation = new ValidationRoom();
            FluentValidation.Results.ValidationResult results = validation.Validate(room);

            foreach (var error in results.Errors)
            {
                switch (error.PropertyName)
                {
                    case "Type":
                        errorProvider.SetError(typeRoomTextBox, error.ErrorMessage);
                        break;
                    case "PriceNight":
                        errorProvider.SetError(priceRoomTextBox, error.ErrorMessage);
                        break;
                    case "Characteristic":
                        errorProvider.SetError(characteristicRoomTextBox, error.ErrorMessage);
                        break;
                }
            }

            if (results.IsValid)
            {
                _roomsService.UpdateRoom(room);
                LoadRooms();
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == 0)
            {
                MessageBox.Show("Por favor, selecciona una habitación para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta habitación?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                _roomsService.DeleteRoom(selectedRoomId);
                LoadRooms();
                selectedRoomId = 0;
            }
        }

    }
}
