namespace PresentationLayer.FormCliente
{
    partial class Formuser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            formGroupBox = new GroupBox();
            numerPhoneTexBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            saveButton = new Button();
            numberPhoneLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            nameLabel = new Label();
            passwordTextBox = new TextBox();
            userTextBox = new TextBox();
            passwordLabel = new Label();
            userLabel = new Label();
            formGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(257, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(444, 68);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Registra tus datos";
            // 
            // formGroupBox
            // 
            formGroupBox.Controls.Add(passwordTextBox);
            formGroupBox.Controls.Add(userTextBox);
            formGroupBox.Controls.Add(passwordLabel);
            formGroupBox.Controls.Add(userLabel);
            formGroupBox.Controls.Add(numerPhoneTexBox);
            formGroupBox.Controls.Add(emailTextBox);
            formGroupBox.Controls.Add(lastNameTextBox);
            formGroupBox.Controls.Add(nameTextBox);
            formGroupBox.Controls.Add(saveButton);
            formGroupBox.Controls.Add(numberPhoneLabel);
            formGroupBox.Controls.Add(emailLabel);
            formGroupBox.Controls.Add(lastNameLabel);
            formGroupBox.Controls.Add(nameLabel);
            formGroupBox.Location = new Point(49, 134);
            formGroupBox.Name = "formGroupBox";
            formGroupBox.Size = new Size(878, 696);
            formGroupBox.TabIndex = 1;
            formGroupBox.TabStop = false;
            formGroupBox.Text = "Formulario";
            // 
            // numerPhoneTexBox
            // 
            numerPhoneTexBox.Location = new Point(339, 519);
            numerPhoneTexBox.Name = "numerPhoneTexBox";
            numerPhoneTexBox.Size = new Size(483, 31);
            numerPhoneTexBox.TabIndex = 8;
            numerPhoneTexBox.Text = "Ej. 76764532";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(339, 423);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(483, 31);
            emailTextBox.TabIndex = 7;
            emailTextBox.Text = "Ej. juanAguirre@correo.com";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(339, 330);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(483, 31);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.Text = "Ej. Aguirre Romero";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(339, 226);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(483, 31);
            nameTextBox.TabIndex = 5;
            nameTextBox.Text = "Ej. Juan Armando";
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(339, 608);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(167, 52);
            saveButton.TabIndex = 4;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberPhoneLabel.Location = new Point(18, 513);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(307, 36);
            numberPhoneLabel.TabIndex = 3;
            numberPhoneLabel.Text = "Numero de Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(41, 423);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(300, 36);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Correo Electronico: ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(190, 324);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(135, 36);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellido:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(190, 220);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(143, 36);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre: ";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(339, 134);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(483, 31);
            passwordTextBox.TabIndex = 12;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(339, 30);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(483, 31);
            userTextBox.TabIndex = 11;
            userTextBox.Text = "Ej. Aramndo093";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(129, 129);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(195, 36);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Contraseña: ";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(181, 24);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(133, 36);
            userLabel.TabIndex = 9;
            userLabel.Text = "Usuario:";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 893);
            Controls.Add(formGroupBox);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCliente";
            Text = "Huesped";
            formGroupBox.ResumeLayout(false);
            formGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private GroupBox formGroupBox;
        private Button saveButton;
        private Label numberPhoneLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label nameLabel;
        private TextBox numerPhoneTexBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private TextBox userTextBox;
        private Label passwordLabel;
        private Label userLabel;
    }
}