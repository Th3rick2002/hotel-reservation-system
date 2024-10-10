using BusisnessLayer.Services;
using CommonLayer.Entities;
using PresentationLayer.Validations;

namespace PresentationLayer.FormCliente
{
    public partial class Formuser : Form
    {
        private UsuariosServices _UsuariosServices;
        
        public Formuser()
        {
            InitializeComponent();
            _UsuariosServices = new UsuariosServices();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string user = userTextBox.Text;
            string password = passwordTextBox.Text;
            string name = nameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string phoneText = numerPhoneTexBox.Text;

            var errorProvider = new ErrorProvider();
            errorProvider.Clear();

            if ((phoneText.Length != 8 && phoneText.Length != 11) || !phoneText.All(char.IsDigit))
            {
                errorProvider.SetError(numerPhoneTexBox, "El número de celular debe tener 8 o 11 números.");
                return;
            }

            int phone = Convert.ToInt32(phoneText);

            Usuarios usuario = new Usuarios()
            {
                oRol = new Rol {IdRol= 2, rol = "Cliente" },
                Usuario = user,
                Clave = password,
                Nombre = name,
                Apellido = lastName,
                Email = email,
                Telefono = phone
            };

            ValidationClient validation = new ValidationClient();
            FluentValidation.Results.ValidationResult results = validation.Validate(usuario);

            foreach (var error in results.Errors)
            {
                switch (error.PropertyName)
                {
                    case "Usuario":
                        errorProvider.SetError(userTextBox, error.ErrorMessage);
                        break;
                    case "Clave":
                        errorProvider.SetError(passwordTextBox, error.ErrorMessage);
                        break;
                    case "Nombre":
                        errorProvider.SetError(nameTextBox, error.ErrorMessage);
                        break;
                    case "Apellido":
                        errorProvider.SetError(lastNameTextBox, error.ErrorMessage);
                        break;
                    case "Email":
                        errorProvider.SetError(emailTextBox, error.ErrorMessage);
                        break;
                }
            }

           
            if (results.IsValid)
            {
                _UsuariosServices.AddUsuarios(usuario);
                MessageBox.Show("Usuario registrado correctamente");
                errorProvider.Clear();
                userTextBox.Clear();
                passwordTextBox.Clear();
                nameTextBox.Clear();
                lastNameTextBox.Clear();
                emailTextBox.Clear();
                numerPhoneTexBox.Clear();
            }
        }
    }
}
