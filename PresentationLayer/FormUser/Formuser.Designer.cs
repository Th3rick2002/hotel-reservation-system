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
            btnGuardar = new FontAwesome.Sharp.IconButton();
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
            pcMinimizar = new PictureBox();
            pbSalir = new PictureBox();
            toolTip1 = new ToolTip(components);
            formGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(303, 33);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(304, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Registra tus datos";
            // 
            // formGroupBox
            // 
            formGroupBox.Controls.Add(btnGuardar);
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
            formGroupBox.Location = new Point(92, 121);
            formGroupBox.Margin = new Padding(2);
            formGroupBox.Name = "formGroupBox";
            formGroupBox.Padding = new Padding(2);
            formGroupBox.Size = new Size(790, 694);
            formGroupBox.TabIndex = 1;
            formGroupBox.TabStop = false;
            formGroupBox.Text = "Formulario";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 22;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(255, 592);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(260, 35);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Crear cuenta";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(305, 178);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(435, 21);
            passwordTextBox.TabIndex = 12;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(305, 113);
            userTextBox.Margin = new Padding(2);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(435, 21);
            userTextBox.TabIndex = 11;
            userTextBox.Text = "Ej. Aramndo093";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F);
            passwordLabel.Location = new Point(130, 178);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 20);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Contraseña: ";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F);
            userLabel.Location = new Point(161, 108);
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(68, 20);
            userLabel.TabIndex = 9;
            userLabel.Text = "Usuario:";
            // 
            // numerPhoneTexBox
            // 
            numerPhoneTexBox.Location = new Point(305, 505);
            numerPhoneTexBox.Margin = new Padding(2);
            numerPhoneTexBox.Name = "numerPhoneTexBox";
            numerPhoneTexBox.Size = new Size(435, 21);
            numerPhoneTexBox.TabIndex = 8;
            numerPhoneTexBox.Text = "Ej. 76764532";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(308, 410);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(435, 21);
            emailTextBox.TabIndex = 7;
            emailTextBox.Text = "Ej. juanAguirre@correo.com";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(305, 328);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(435, 21);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.Text = "Ej. Aguirre Romero";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(305, 244);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(435, 21);
            nameTextBox.TabIndex = 5;
            nameTextBox.Text = "Ej. Juan Armando";
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new Font("Microsoft Sans Serif", 12F);
            numberPhoneLabel.Location = new Point(72, 506);
            numberPhoneLabel.Margin = new Padding(2, 0, 2, 0);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(157, 20);
            numberPhoneLabel.TabIndex = 3;
            numberPhoneLabel.Text = "Numero de Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new Point(81, 411);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(148, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Correo Electronico: ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Microsoft Sans Serif", 12F);
            lastNameLabel.Location = new Point(161, 323);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(69, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellido:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F);
            nameLabel.Location = new Point(163, 244);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(73, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre: ";
            // 
            // pcMinimizar
            // 
            pcMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pcMinimizar.BackColor = Color.Transparent;
            pcMinimizar.Cursor = Cursors.Hand;
            pcMinimizar.Image = Properties.Resources.negative_sign_icon_icons_com_70439;
            pcMinimizar.Location = new Point(884, 12);
            pcMinimizar.Name = "pcMinimizar";
            pcMinimizar.Size = new Size(36, 33);
            pcMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pcMinimizar.TabIndex = 21;
            pcMinimizar.TabStop = false;
            pcMinimizar.Click += pcMinimizar_Click;
            pcMinimizar.MouseHover += pcMinimizar_MouseHover;
            // 
            // pbSalir
            // 
            pbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbSalir.BackColor = Color.Transparent;
            pbSalir.Cursor = Cursors.Hand;
            pbSalir.Image = Properties.Resources.close_remove_delete_icon_148989;
            pbSalir.Location = new Point(926, 12);
            pbSalir.Name = "pbSalir";
            pbSalir.Size = new Size(36, 33);
            pbSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pbSalir.TabIndex = 20;
            pbSalir.TabStop = false;
            pbSalir.Click += pbSalir_Click;
            pbSalir.MouseHover += pbSalir_MouseHover;
            // 
            // Formuser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 788);
            Controls.Add(pcMinimizar);
            Controls.Add(pbSalir);
            Controls.Add(formGroupBox);
            Controls.Add(titleLabel);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Formuser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Huesped";
            formGroupBox.ResumeLayout(false);
            formGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).EndInit();
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
        private PictureBox pcMinimizar;
        private PictureBox pbSalir;
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnGuardar;
    }
}