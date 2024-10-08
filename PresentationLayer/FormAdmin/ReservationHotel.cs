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
        private ReservasService _reservasservice;

        public ReservationHotel()
        {
            InitializeComponent();
            _reservasservice = new ReservasService();
            LoadReservas();
        }

        private void LoadReservas()
        {
            dgvReservas.DataSource = _reservasservice.GetReservas();

        }
    }
}
