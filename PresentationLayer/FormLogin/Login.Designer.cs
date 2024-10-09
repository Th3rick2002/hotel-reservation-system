using FontAwesome.Sharp;

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
            components = new System.ComponentModel.Container();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            toolTip1 = new ToolTip(components);
            newCountTextBox = new IconButton();
            loginButton = new IconButton();
            titleLabel = new Label();
            hotelPictureBox = new PictureBox();
            userPictureBox = new PictureBox();
            passwordPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hotelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // userTextBox
            // 
            userTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userTextBox.Location = new Point(701, 199);
            userTextBox.Margin = new Padding(2);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(275, 31);
            userTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(701, 294);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(275, 31);
            passwordTextBox.TabIndex = 4;
            // 
            // newCountTextBox
            // 
            newCountTextBox.BackColor = Color.DimGray;
            newCountTextBox.Cursor = Cursors.Hand;
            newCountTextBox.FlatStyle = FlatStyle.Flat;
            newCountTextBox.Font = new Font("Century Gothic", 9F);
            newCountTextBox.ForeColor = Color.White;
            newCountTextBox.IconChar = IconChar.PlusSquare;
            newCountTextBox.IconColor = Color.White;
            newCountTextBox.IconFont = IconFont.Auto;
            newCountTextBox.IconSize = 38;
            newCountTextBox.ImageAlign = ContentAlignment.MiddleLeft;
            newCountTextBox.Location = new Point(603, 560);
            newCountTextBox.Margin = new Padding(4);
            newCountTextBox.Name = "newCountTextBox";
            newCountTextBox.Size = new Size(413, 58);
            newCountTextBox.TabIndex = 8;
            newCountTextBox.Text = "Crear cuenta";
            newCountTextBox.UseVisualStyleBackColor = false;
            newCountTextBox.Click += btnCrearCuenta_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.ForestGreen;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.IconChar = IconChar.LockOpen;
            loginButton.IconColor = Color.White;
            loginButton.IconFont = IconFont.Auto;
            loginButton.IconSize = 38;
            loginButton.ImageAlign = ContentAlignment.MiddleLeft;
            loginButton.Location = new Point(603, 461);
            loginButton.Margin = new Padding(4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(413, 58);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += btnLogin_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(637, 52);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(326, 55);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "INICIO SESION";
            // 
            // hotelPictureBox
            // 
            hotelPictureBox.Image = Properties.Resources.hoteles_Grand_Velas_Resorts_e1596047698604;
            hotelPictureBox.Location = new Point(1, -2);
            hotelPictureBox.Name = "hotelPictureBox";
            hotelPictureBox.Size = new Size(524, 655);
            hotelPictureBox.TabIndex = 9;
            hotelPictureBox.TabStop = false;
            // 
            // userPictureBox
            // 
            userPictureBox.Image = Properties.Resources.usuario__1_;
            userPictureBox.Location = new Point(613, 176);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(67, 63);
            userPictureBox.TabIndex = 10;
            userPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = Properties.Resources.candado;
            passwordPictureBox.Location = new Point(613, 278);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(77, 64);
            passwordPictureBox.TabIndex = 11;
            passwordPictureBox.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1056, 654);
            Controls.Add(passwordPictureBox);
            Controls.Add(userPictureBox);
            Controls.Add(hotelPictureBox);
            Controls.Add(newCountTextBox);
            Controls.Add(titleLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)hotelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label userLabel;
        private Label passwordLabel;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button logInButton;
        private Button newUserButton;
        private ToolTip toolTip1;
        private GroupBox gbLogin;
        private IconButton loginButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton newCountTextBox;
        private Panel panel1;
        private Label titleLabel;
        private PictureBox hotelPictureBox;
        private PictureBox userPictureBox;
        private PictureBox passwordPictureBox;
    }
}