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
        private RoomServices _habitacionesService;
        public RoomHotel()
        {
            InitializeComponent();
            _habitacionesService = new RoomServices();
            LoadHabitaciones();

            listRoomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadHabitaciones()
        {
            listRoomDataGridView.DataSource = _habitacionesService.GetHabitacion();
        }

    }
}
