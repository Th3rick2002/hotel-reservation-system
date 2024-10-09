﻿using BusisnessLayer.Services;
using CommonLayer.Entities;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int phone = Convert.ToInt32(numerPhoneTexBox.Text);

            Usuarios usuario = new Usuarios()
            {
                Usuario = user,
                Clave = password,
                Nombre = name,
                Apellido = lastName,
                Email = email,
                Telefono = phone

            };

            ValidationClient validation = new ValidationClient();

            FluentValidation.Results.ValidationResult results = validation.Validate(usuario);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    MessageBox.Show($"Property {failure.PropertyName} failed validation. Error was: {failure.ErrorMessage}");
                }
            }
            else
            {
                _UsuariosServices.AddUsuarios(usuario);
                MessageBox.Show("Usuario registrado correctamente");
            }
        }
    }
}
