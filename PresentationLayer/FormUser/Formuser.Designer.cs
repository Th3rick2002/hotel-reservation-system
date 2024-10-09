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
            components = new System.ComponentModel.Container();
            titleLabel = new Label();
            formGroupBox = new GroupBox();
            saveButton = new FontAwesome.Sharp.IconButton();
            passwordTextBox = new TextBox();
            userTextBox = new TextBox();
            passwordLabel = new Label();
            userLabel = new Label();
            numerPhoneTexBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            numberPhoneLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            nameLabel = new Label();
            toolTip1 = new ToolTip(components);
            hotelPictureBox = new PictureBox();
            formGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hotelPictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(770, 20);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(395, 55);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Registra tus datos";
            // 
            // formGroupBox
            // 
            formGroupBox.Controls.Add(saveButton);
            formGroupBox.Controls.Add(passwordTextBox);
            formGroupBox.Controls.Add(userTextBox);
            formGroupBox.Controls.Add(passwordLabel);
            formGroupBox.Controls.Add(userLabel);
            formGroupBox.Controls.Add(numerPhoneTexBox);
            formGroupBox.Controls.Add(emailTextBox);
            formGroupBox.Controls.Add(lastNameTextBox);
            formGroupBox.Controls.Add(nameTextBox);
            formGroupBox.Controls.Add(numberPhoneLabel);
            formGroupBox.Controls.Add(emailLabel);
            formGroupBox.Controls.Add(lastNameLabel);
            formGroupBox.Controls.Add(nameLabel);
            formGroupBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formGroupBox.Location = new Point(554, 86);
            formGroupBox.Margin = new Padding(2);
            formGroupBox.Name = "formGroupBox";
            formGroupBox.Padding = new Padding(2);
            formGroupBox.Size = new Size(790, 694);
            formGroupBox.TabIndex = 1;
            formGroupBox.TabStop = false;
            formGroupBox.Text = "Formulario";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderColor = Color.Black;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveButton.IconColor = Color.White;
            saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveButton.IconSize = 45;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(255, 592);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(410, 67);
            saveButton.TabIndex = 24;
            saveButton.Text = "Crear cuenta";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(327, 174);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(435, 34);
            passwordTextBox.TabIndex = 12;
            // 
            // userTextBox
            // 
            userTextBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextBox.Location = new Point(327, 104);
            userTextBox.Margin = new Padding(2);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(435, 34);
            userTextBox.TabIndex = 11;
            userTextBox.Text = "Ej. Aramndo093";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(130, 173);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(166, 30);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Contraseña: ";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(181, 103);
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(106, 30);
            userLabel.TabIndex = 9;
            userLabel.Text = "Usuario:";
            // 
            // numerPhoneTexBox
            // 
            numerPhoneTexBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numerPhoneTexBox.Location = new Point(327, 502);
            numerPhoneTexBox.Margin = new Padding(2);
            numerPhoneTexBox.Name = "numerPhoneTexBox";
            numerPhoneTexBox.Size = new Size(435, 34);
            numerPhoneTexBox.TabIndex = 8;
            numerPhoneTexBox.Text = "Ej. 76764532";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(327, 412);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(435, 34);
            emailTextBox.TabIndex = 7;
            emailTextBox.Text = "Ej. juanAguirre@correo.com";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(327, 324);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(435, 34);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.Text = "Ej. Aguirre Romero";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(327, 245);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(435, 34);
            nameTextBox.TabIndex = 5;
            nameTextBox.Text = "Ej. Juan Armando";
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberPhoneLabel.Location = new Point(30, 501);
            numberPhoneLabel.Margin = new Padding(2, 0, 2, 0);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(266, 30);
            numberPhoneLabel.TabIndex = 3;
            numberPhoneLabel.Text = "Numero de Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(45, 412);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(251, 30);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Correo Electronico: ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(168, 328);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(119, 30);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellido:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(163, 244);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(124, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre: ";
            // 
            // hotelPictureBox
            // 
            hotelPictureBox.Image = Properties.Resources.THEME_HOTEL_SIGN_FIVE_STARS_FACADE_BUILDING_GettyImages_1320779330_3__3_;
            hotelPictureBox.Location = new Point(-103, 113);
            hotelPictureBox.Name = "hotelPictureBox";
            hotelPictureBox.Size = new Size(643, 588);
            hotelPictureBox.TabIndex = 2;
            hotelPictureBox.TabStop = false;
            // 
            // Formuser
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1384, 792);
            Controls.Add(hotelPictureBox);
            Controls.Add(formGroupBox);
            Controls.Add(titleLabel);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Formuser";
            StartPosition = FormStartPosition.CenterScreen;
            formGroupBox.ResumeLayout(false);
            formGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hotelPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private GroupBox formGroupBox;
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
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton saveButton;
        private PictureBox hotelPictureBox;
    }
}