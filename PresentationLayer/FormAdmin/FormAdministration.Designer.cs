namespace PresentationLayer.FormAdmin
{
    partial class FormAdministration
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
            clientButton = new Button();
            reservationButton = new Button();
            roomButton = new Button();
            logoutButton = new Button();
            clientPictureBox = new PictureBox();
            datePictureBox = new PictureBox();
            roomPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)clientPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomPictureBox).BeginInit();
            SuspendLayout();
            // 
            // clientButton
            // 
            clientButton.BackColor = Color.DeepSkyBlue;
            clientButton.FlatAppearance.BorderSize = 0;
            clientButton.FlatStyle = FlatStyle.Flat;
            clientButton.Font = new Font("Century Gothic", 12F);
            clientButton.ForeColor = Color.White;
            clientButton.Location = new Point(238, 101);
            clientButton.Margin = new Padding(2);
            clientButton.Name = "clientButton";
            clientButton.Size = new Size(394, 62);
            clientButton.TabIndex = 0;
            clientButton.Text = "Cliente";
            clientButton.UseVisualStyleBackColor = false;
            clientButton.Click += clientButton_Click;
            // 
            // reservationButton
            // 
            reservationButton.BackColor = Color.Crimson;
            reservationButton.FlatAppearance.BorderSize = 0;
            reservationButton.FlatStyle = FlatStyle.Flat;
            reservationButton.Font = new Font("Century Gothic", 12F);
            reservationButton.ForeColor = Color.White;
            reservationButton.Location = new Point(238, 218);
            reservationButton.Margin = new Padding(2);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(394, 61);
            reservationButton.TabIndex = 1;
            reservationButton.Text = "Reservaciones";
            reservationButton.UseVisualStyleBackColor = false;
            reservationButton.Click += reservationButton_Click;
            // 
            // roomButton
            // 
            roomButton.BackColor = Color.Sienna;
            roomButton.FlatAppearance.BorderSize = 0;
            roomButton.FlatStyle = FlatStyle.Flat;
            roomButton.Font = new Font("Century Gothic", 12F);
            roomButton.ForeColor = Color.White;
            roomButton.Location = new Point(238, 343);
            roomButton.Margin = new Padding(2);
            roomButton.Name = "roomButton";
            roomButton.Size = new Size(394, 61);
            roomButton.TabIndex = 2;
            roomButton.Text = "Habitaciones";
            roomButton.UseVisualStyleBackColor = false;
            roomButton.Click += roomButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.MediumSeaGreen;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Century Gothic", 12F);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(110, 462);
            logoutButton.Margin = new Padding(2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(544, 74);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Cerrar Sesion";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // clientPictureBox
            // 
            clientPictureBox.Image = Properties.Resources.usuario__2_;
            clientPictureBox.Location = new Point(151, 88);
            clientPictureBox.Name = "clientPictureBox";
            clientPictureBox.Size = new Size(71, 75);
            clientPictureBox.TabIndex = 4;
            clientPictureBox.TabStop = false;
            // 
            // datePictureBox
            // 
            datePictureBox.Image = Properties.Resources.reserva__1_;
            datePictureBox.Location = new Point(146, 218);
            datePictureBox.Name = "datePictureBox";
            datePictureBox.Size = new Size(76, 75);
            datePictureBox.TabIndex = 5;
            datePictureBox.TabStop = false;
            // 
            // roomPictureBox
            // 
            roomPictureBox.Image = Properties.Resources.cama_individual;
            roomPictureBox.Location = new Point(146, 329);
            roomPictureBox.Name = "roomPictureBox";
            roomPictureBox.Size = new Size(67, 75);
            roomPictureBox.TabIndex = 6;
            roomPictureBox.TabStop = false;
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(773, 595);
            Controls.Add(roomPictureBox);
            Controls.Add(datePictureBox);
            Controls.Add(clientPictureBox);
            Controls.Add(logoutButton);
            Controls.Add(roomButton);
            Controls.Add(reservationButton);
            Controls.Add(clientButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "FormAdministration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)clientPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)datePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button clientButton;
        private Button reservationButton;
        private Button roomButton;
        private Button logoutButton;
        private PictureBox clientPictureBox;
        private PictureBox datePictureBox;
        private PictureBox roomPictureBox;
    }
}