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
            userTextBox.Location = new Point(561, 159);
            userTextBox.Margin = new Padding(1);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(221, 27);
            userTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(561, 235);
            passwordTextBox.Margin = new Padding(1);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(221, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // newCountTextBox
            // 
            newCountTextBox.BackColor = Color.DimGray;
            newCountTextBox.Cursor = Cursors.Hand;
            newCountTextBox.FlatStyle = FlatStyle.Flat;
            newCountTextBox.Font = new Font("Microsoft Sans Serif", 9F);
            newCountTextBox.ForeColor = Color.White;
            newCountTextBox.IconChar = IconChar.PlusSquare;
            newCountTextBox.IconColor = Color.White;
            newCountTextBox.IconFont = IconFont.Auto;
            newCountTextBox.IconSize = 38;
            newCountTextBox.ImageAlign = ContentAlignment.MiddleLeft;
            newCountTextBox.Location = new Point(482, 448);
            newCountTextBox.Name = "newCountTextBox";
            newCountTextBox.Size = new Size(330, 47);
            newCountTextBox.TabIndex = 8;
            newCountTextBox.Text = "Crear cuenta";
            newCountTextBox.UseVisualStyleBackColor = false;
            newCountTextBox.Click += newCountTextBox_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.ForestGreen;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.IconChar = IconChar.LockOpen;
            loginButton.IconColor = Color.White;
            loginButton.IconFont = IconFont.Auto;
            loginButton.IconSize = 38;
            loginButton.ImageAlign = ContentAlignment.MiddleLeft;
            loginButton.Location = new Point(482, 369);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(330, 47);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(510, 41);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(278, 42);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "INICIO SESION";
            // 
            // hotelPictureBox
            // 
            hotelPictureBox.Image = Properties.Resources.hoteles_Grand_Velas_Resorts_e1596047698604;
            hotelPictureBox.Location = new Point(1, -1);
            hotelPictureBox.Margin = new Padding(2, 3, 2, 3);
            hotelPictureBox.Name = "hotelPictureBox";
            hotelPictureBox.Size = new Size(419, 524);
            hotelPictureBox.TabIndex = 9;
            hotelPictureBox.TabStop = false;
            // 
            // userPictureBox
            // 
            userPictureBox.Image = Properties.Resources.usuario__1_;
            userPictureBox.Location = new Point(490, 141);
            userPictureBox.Margin = new Padding(2, 3, 2, 3);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(54, 51);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 10;
            userPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = Properties.Resources.candado;
            passwordPictureBox.Location = new Point(490, 223);
            passwordPictureBox.Margin = new Padding(2, 3, 2, 3);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(62, 51);
            passwordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            passwordPictureBox.TabIndex = 11;
            passwordPictureBox.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(845, 523);
            Controls.Add(passwordPictureBox);
            Controls.Add(userPictureBox);
            Controls.Add(hotelPictureBox);
            Controls.Add(newCountTextBox);
            Controls.Add(titleLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1);
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