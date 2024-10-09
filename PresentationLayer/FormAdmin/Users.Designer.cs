namespace PresentationLayer.FormAdmin
{
    partial class Users
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
            formGroupBox = new GroupBox();
            deleteButton = new Button();
            editButton = new Button();
            passwordTextBox = new TextBox();
            userTextBox = new TextBox();
            passwordLabel = new Label();
            userLabel = new Label();
            numberPhoneTexBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            saveButton = new Button();
            numberPhoneLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            nameLabel = new Label();
            listUserDataGridView = new DataGridView();
            toolTip1 = new ToolTip(components);
            backMenuButton = new Button();
            formGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listUserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // formGroupBox
            // 
            formGroupBox.Controls.Add(deleteButton);
            formGroupBox.Controls.Add(editButton);
            formGroupBox.Controls.Add(passwordTextBox);
            formGroupBox.Controls.Add(userTextBox);
            formGroupBox.Controls.Add(passwordLabel);
            formGroupBox.Controls.Add(userLabel);
            formGroupBox.Controls.Add(numberPhoneTexBox);
            formGroupBox.Controls.Add(emailTextBox);
            formGroupBox.Controls.Add(lastNameTextBox);
            formGroupBox.Controls.Add(nameTextBox);
            formGroupBox.Controls.Add(saveButton);
            formGroupBox.Controls.Add(numberPhoneLabel);
            formGroupBox.Controls.Add(emailLabel);
            formGroupBox.Controls.Add(lastNameLabel);
            formGroupBox.Controls.Add(nameLabel);
            formGroupBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formGroupBox.Location = new Point(44, 36);
            formGroupBox.Margin = new Padding(2);
            formGroupBox.Name = "formGroupBox";
            formGroupBox.Padding = new Padding(2);
            formGroupBox.Size = new Size(771, 696);
            formGroupBox.TabIndex = 2;
            formGroupBox.TabStop = false;
            formGroupBox.Text = "Formulario";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(540, 566);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(168, 64);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.SteelBlue;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(299, 566);
            editButton.Margin = new Padding(2);
            editButton.Name = "editButton";
            editButton.Size = new Size(179, 64);
            editButton.TabIndex = 13;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(263, 124);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(445, 34);
            passwordTextBox.TabIndex = 12;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(263, 45);
            userTextBox.Margin = new Padding(2);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(445, 34);
            userTextBox.TabIndex = 11;
            userTextBox.Text = "Ej. Aramndo093";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(92, 133);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(150, 25);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Contraseña: ";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(137, 48);
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(95, 25);
            userLabel.TabIndex = 9;
            userLabel.Text = "Usuario:";
            // 
            // numberPhoneTexBox
            // 
            numberPhoneTexBox.Location = new Point(263, 441);
            numberPhoneTexBox.Margin = new Padding(2);
            numberPhoneTexBox.Name = "numberPhoneTexBox";
            numberPhoneTexBox.Size = new Size(445, 34);
            numberPhoneTexBox.TabIndex = 8;
            numberPhoneTexBox.Text = "Ej. 76764532";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(263, 356);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(445, 34);
            emailTextBox.TabIndex = 7;
            emailTextBox.Text = "Ej. juanAguirre@correo.com";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(263, 273);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(445, 34);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.Text = "Ej. Aguirre Romero";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(263, 199);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(445, 34);
            nameTextBox.TabIndex = 5;
            nameTextBox.Text = "Ej. Juan Armando";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.ForeColor = SystemColors.ButtonHighlight;
            saveButton.Location = new Point(68, 566);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(183, 64);
            saveButton.TabIndex = 4;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberPhoneLabel.Location = new Point(4, 444);
            numberPhoneLabel.Margin = new Padding(2, 0, 2, 0);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(238, 25);
            numberPhoneLabel.TabIndex = 3;
            numberPhoneLabel.Text = "Numero de Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(17, 365);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(218, 25);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Correo Electronico:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(123, 273);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(109, 25);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellido:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(123, 199);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(112, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre: ";
            // 
            // listUserDataGridView
            // 
            listUserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listUserDataGridView.Location = new Point(843, 36);
            listUserDataGridView.Margin = new Padding(2);
            listUserDataGridView.Name = "listUserDataGridView";
            listUserDataGridView.RowHeadersWidth = 62;
            listUserDataGridView.Size = new Size(954, 684);
            listUserDataGridView.TabIndex = 3;
            // 
            // backMenuButton
            // 
            backMenuButton.BackColor = Color.Orange;
            backMenuButton.FlatStyle = FlatStyle.Popup;
            backMenuButton.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backMenuButton.ForeColor = Color.White;
            backMenuButton.Location = new Point(23, 761);
            backMenuButton.Name = "backMenuButton";
            backMenuButton.Size = new Size(199, 74);
            backMenuButton.TabIndex = 4;
            backMenuButton.Text = "Regresar a Menú";
            backMenuButton.UseVisualStyleBackColor = false;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 847);
            Controls.Add(backMenuButton);
            Controls.Add(listUserDataGridView);
            Controls.Add(formGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Users";
            Text = "Lista de Usuarios";
            formGroupBox.ResumeLayout(false);
            formGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listUserDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox formGroupBox;
        private TextBox passwordTextBox;
        private TextBox userTextBox;
        private Label passwordLabel;
        private Label userLabel;
        private TextBox numberPhoneTexBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private TextBox nameTextBox;
        private Button saveButton;
        private Label numberPhoneLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label nameLabel;
        private Button deleteButton;
        private Button editButton;
        private DataGridView listUserDataGridView;
        private ToolTip toolTip1;
        private Button backMenuButton;
    }
}