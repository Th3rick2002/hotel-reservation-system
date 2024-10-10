using BusisnessLayer.Services;
using CommonLayer.Entities;
using PresentationLayer.Validations;
using System.Windows.Forms;

namespace PresentationLayer.FormAdmin
{
    public partial class RoomHotel : Form
    {
        private RoomServices _roomsService;
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
            string characteristic = "";

            var errorProvider = new ErrorProvider();
            errorProvider.Clear();

            if(string.IsNullOrEmpty(priceText) || !priceText.All(char.IsDigit))
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
                    //case "Characteristic":
                    //    errorProvider.SetError(characteristicRoomTextBox, error.ErrorMessage);
                    //    break;
                }
            }

            if(results.IsValid)
            {
                _roomsService.AddRoom(room);
                LoadRooms();
            }
            
        }

        private void listRoomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haga clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén el valor de las celdas correspondientes
                var typeValue = listRoomDataGridView.Rows[e.RowIndex].Cells["Tipo"].Value; // Cambia "Tipo" por el nombre real de la columna
                var priceValue = listRoomDataGridView.Rows[e.RowIndex].Cells["PrecioNoche"].Value; // Cambia "PrecioNoche" por el nombre real de la columna
                var characteristicValue = listRoomDataGridView.Rows[e.RowIndex].Cells["Caracteristicas"].Value; // Cambia "Caracteristicas" por el nombre real de la columna

                // Asigna los valores a los TextBox correspondientes
                typeRoomTextBox.Text = typeValue?.ToString();
                priceRoomTextBox.Text = priceValue?.ToString();
                //characteristicRoomTextBox.Text = characteristicValue?.ToString(); // Asegúrate de tener un TextBox para características
            }
        }
    }
}
