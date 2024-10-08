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
            SuspendLayout();
            // 
            // clientButton
            // 
            clientButton.Location = new Point(79, 54);
            clientButton.Name = "clientButton";
            clientButton.Size = new Size(112, 62);
            clientButton.TabIndex = 0;
            clientButton.Text = "Cliente";
            clientButton.UseVisualStyleBackColor = true;
            // 
            // reservationButton
            // 
            reservationButton.Location = new Point(547, 60);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(199, 51);
            reservationButton.TabIndex = 1;
            reservationButton.Text = "Reservaciones";
            reservationButton.UseVisualStyleBackColor = true;
            // 
            // roomButton
            // 
            roomButton.Location = new Point(301, 54);
            roomButton.Name = "roomButton";
            roomButton.Size = new Size(164, 61);
            roomButton.TabIndex = 2;
            roomButton.Text = "Habitaciones";
            roomButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(287, 175);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(190, 48);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Cerrar Sesion";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 259);
            Controls.Add(logoutButton);
            Controls.Add(roomButton);
            Controls.Add(reservationButton);
            Controls.Add(clientButton);
            Name = "FormAdministration";
            Text = "Ventana Administrador";
            ResumeLayout(false);
        }

        #endregion

        private Button clientButton;
        private Button reservationButton;
        private Button roomButton;
        private Button logoutButton;
    }
}