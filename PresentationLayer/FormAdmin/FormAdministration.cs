using BusisnessLayer.Services;
using PresentationLayer.FormLogin;
using System.Data;

namespace PresentationLayer.FormAdmin
{
    public partial class FormAdministration : Form
    {
        private UsersServices _usersServices;
        private readonly int idUser;

        public FormAdministration(int IdUser)
        {
            InitializeComponent();
            this.idUser = IdUser;
            this._usersServices = new UsersServices();
        }
        private void clientButton_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.Show();
            users.FormClosed += (s, args) => this.Show();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            RoomHotel roomHotel = new RoomHotel();
            this.Hide();
            roomHotel.Show();
            roomHotel.FormClosed += (s, args) => this.Show();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            reservationHotel reservationHotel = new reservationHotel();
            this.Hide();
            reservationHotel.Show();
            reservationHotel.FormClosed += (s, args) => this.Show();
        }

        private string GetUserRoleById(int userId)
        {
            DataTable usuariosTable = _usersServices.GetAllUsuarios();
            DataRow userRow = usuariosTable.AsEnumerable()
                    .FirstOrDefault(u => u.Field<int>("IdUsuario") == userId);

            return userRow != null ? userRow.Field<string>("rol") : null;
        }
    }
}
