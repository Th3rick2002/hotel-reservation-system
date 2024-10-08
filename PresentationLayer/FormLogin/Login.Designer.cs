namespace PresentationLayer.FormLogin
{
    partial class Login
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
            label1 = new Label();
            userLabel = new Label();
            passwordLabel = new Label();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            logInButton = new Button();
            newUserButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 19);
            label1.Name = "label1";
            label1.Size = new Size(254, 44);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(132, 155);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(135, 33);
            userLabel.TabIndex = 1;
            userLabel.Text = "Usuario: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(94, 262);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(173, 33);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Contraseña:";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(273, 155);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(379, 31);
            userTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(273, 266);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(379, 31);
            passwordTextBox.TabIndex = 4;
            // 
            // logInButton
            // 
            logInButton.FlatStyle = FlatStyle.System;
            logInButton.Location = new Point(132, 356);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(219, 57);
            logInButton.TabIndex = 5;
            logInButton.Text = "Iniciar sesión";
            logInButton.UseVisualStyleBackColor = true;
            // 
            // newUserButton
            // 
            newUserButton.FlatStyle = FlatStyle.System;
            newUserButton.Location = new Point(443, 356);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(219, 57);
            newUserButton.TabIndex = 6;
            newUserButton.Text = "No tengo Cuenta";
            newUserButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(newUserButton);
            Controls.Add(logInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userLabel);
            Controls.Add(label1);
            Name = "Login";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userLabel;
        private Label passwordLabel;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button logInButton;
        private Button newUserButton;
    }
}