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
            formGroupBox = new GroupBox();
            passwordTextBox = new TextBox();
            userTextBox = new TextBox();
            passwordLabel = new Label();
            userLabel = new Label();
            numerPhoneTexBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            saveButton = new Button();
            numberPhoneLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            nameLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            formGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formGroupBox
            // 
            formGroupBox.Controls.Add(button2);
            formGroupBox.Controls.Add(button1);
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
            formGroupBox.Location = new Point(44, 85);
            formGroupBox.Name = "formGroupBox";
            formGroupBox.Size = new Size(771, 696);
            formGroupBox.TabIndex = 2;
            formGroupBox.TabStop = false;
            formGroupBox.Text = "Formulario";
            
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(248, 106);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(445, 31);
            passwordTextBox.TabIndex = 12;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(248, 44);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(445, 31);
            userTextBox.TabIndex = 11;
            userTextBox.Text = "Ej. Aramndo093";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Britannic Bold", 11F);
            passwordLabel.Location = new Point(85, 106);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(135, 25);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Contraseña: ";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Britannic Bold", 11F);
            userLabel.Location = new Point(120, 47);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(92, 25);
            userLabel.TabIndex = 9;
            userLabel.Text = "Usuario:";
            // 
            // numerPhoneTexBox
            // 
            numerPhoneTexBox.Location = new Point(248, 394);
            numerPhoneTexBox.Name = "numerPhoneTexBox";
            numerPhoneTexBox.Size = new Size(445, 31);
            numerPhoneTexBox.TabIndex = 8;
            numerPhoneTexBox.Text = "Ej. 76764532";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(248, 321);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(445, 31);
            emailTextBox.TabIndex = 7;
            emailTextBox.Text = "Ej. juanAguirre@correo.com";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(248, 242);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(445, 31);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.Text = "Ej. Aguirre Romero";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(248, 178);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(445, 31);
            nameTextBox.TabIndex = 5;
            nameTextBox.Text = "Ej. Juan Armando";
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(91, 505);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(129, 40);
            saveButton.TabIndex = 4;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new Font("Britannic Bold", 11F);
            numberPhoneLabel.Location = new Point(8, 394);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(212, 25);
            numberPhoneLabel.TabIndex = 3;
            numberPhoneLabel.Text = "Numero de Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Britannic Bold", 11F);
            emailLabel.Location = new Point(15, 324);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(200, 25);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Correo Electronico:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Britannic Bold", 11F);
            lastNameLabel.Location = new Point(120, 248);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Apellido:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Britannic Bold", 11F);
            nameLabel.Location = new Point(120, 178);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre: ";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(285, 505);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 13;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(459, 505);
            button2.Name = "button2";
            button2.Size = new Size(129, 40);
            button2.TabIndex = 14;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(835, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(954, 684);
            dataGridView1.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(44, 12);
            button3.Name = "button3";
            button3.Size = new Size(129, 40);
            button3.TabIndex = 15;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 819);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(formGroupBox);
            Name = "Users";
            Text = "Lista de Usuarios";
            formGroupBox.ResumeLayout(false);
            formGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox formGroupBox;
        private TextBox passwordTextBox;
        private TextBox userTextBox;
        private Label passwordLabel;
        private Label userLabel;
        private TextBox numerPhoneTexBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private TextBox nameTextBox;
        private Button saveButton;
        private Label numberPhoneLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label nameLabel;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
    }
}