namespace PresentationLayer.FormReservation
{
    partial class Reservation
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
            formReservationGroupBox = new GroupBox();
            dateInitDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            roomNumbercomboBox = new ComboBox();
            reservationButton = new Button();
            nameClientLabel = new Label();
            nameClientTextBox = new TextBox();
            dateInitLabel = new Label();
            endDateLabel = new Label();
            roomNumberLabel = new Label();
            formReservationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(223, 29);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(399, 39);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Reservación de Habitaciones";
            // 
            // formReservationGroupBox
            // 
            formReservationGroupBox.Controls.Add(roomNumberLabel);
            formReservationGroupBox.Controls.Add(endDateLabel);
            formReservationGroupBox.Controls.Add(dateInitLabel);
            formReservationGroupBox.Controls.Add(nameClientTextBox);
            formReservationGroupBox.Controls.Add(nameClientLabel);
            formReservationGroupBox.Controls.Add(reservationButton);
            formReservationGroupBox.Controls.Add(roomNumbercomboBox);
            formReservationGroupBox.Controls.Add(endDateTimePicker);
            formReservationGroupBox.Controls.Add(dateInitDateTimePicker);
            formReservationGroupBox.Location = new Point(57, 130);
            formReservationGroupBox.Name = "formReservationGroupBox";
            formReservationGroupBox.Size = new Size(731, 589);
            formReservationGroupBox.TabIndex = 1;
            formReservationGroupBox.TabStop = false;
            formReservationGroupBox.Text = "Formulario";
            // 
            // dateInitDateTimePicker
            // 
            dateInitDateTimePicker.Location = new Point(324, 171);
            dateInitDateTimePicker.Name = "dateInitDateTimePicker";
            dateInitDateTimePicker.Size = new Size(300, 31);
            dateInitDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(324, 249);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(300, 31);
            endDateTimePicker.TabIndex = 3;
            // 
            // roomNumbercomboBox
            // 
            roomNumbercomboBox.FormattingEnabled = true;
            roomNumbercomboBox.Location = new Point(324, 347);
            roomNumbercomboBox.Name = "roomNumbercomboBox";
            roomNumbercomboBox.Size = new Size(300, 33);
            roomNumbercomboBox.TabIndex = 5;
            // 
            // reservationButton
            // 
            reservationButton.Location = new Point(280, 450);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(179, 51);
            reservationButton.TabIndex = 6;
            reservationButton.Text = "Reservar";
            reservationButton.UseVisualStyleBackColor = true;
            // 
            // nameClientLabel
            // 
            nameClientLabel.AutoSize = true;
            nameClientLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameClientLabel.Location = new Point(55, 87);
            nameClientLabel.Name = "nameClientLabel";
            nameClientLabel.Size = new Size(225, 26);
            nameClientLabel.TabIndex = 7;
            nameClientLabel.Text = "Nombre de Cliente: ";
            // 
            // nameClientTextBox
            // 
            nameClientTextBox.Location = new Point(324, 85);
            nameClientTextBox.Name = "nameClientTextBox";
            nameClientTextBox.Size = new Size(300, 31);
            nameClientTextBox.TabIndex = 8;
            // 
            // dateInitLabel
            // 
            dateInitLabel.AutoSize = true;
            dateInitLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateInitLabel.Location = new Point(100, 176);
            dateInitLabel.Name = "dateInitLabel";
            dateInitLabel.Size = new Size(180, 26);
            dateInitLabel.TabIndex = 9;
            dateInitLabel.Text = "Fecha de inicio:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLabel.Location = new Point(31, 254);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(249, 26);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "Fecha de Finalización:";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomNumberLabel.Location = new Point(31, 349);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(259, 26);
            roomNumberLabel.TabIndex = 11;
            roomNumberLabel.Text = "Numero de Habitación:";
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 775);
            Controls.Add(formReservationGroupBox);
            Controls.Add(titleLabel);
            Name = "Reservation";
            Text = "Reservación";
            formReservationGroupBox.ResumeLayout(false);
            formReservationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private GroupBox formReservationGroupBox;
        private ComboBox roomNumbercomboBox;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker dateInitDateTimePicker;
        private Button reservationButton;
        private Label dateInitLabel;
        private TextBox nameClientTextBox;
        private Label nameClientLabel;
        private Label endDateLabel;
        private Label roomNumberLabel;
    }
}