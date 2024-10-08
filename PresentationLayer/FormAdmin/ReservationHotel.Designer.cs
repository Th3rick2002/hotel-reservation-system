namespace PresentationLayer.FormAdmin
{
    partial class ReservationHotel
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
            formReservationGroupBox = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            roomNumberLabel = new Label();
            endDateLabel = new Label();
            dateInitLabel = new Label();
            nameClientTextBox = new TextBox();
            nameClientLabel = new Label();
            reservationButton = new Button();
            roomNumbercomboBox = new ComboBox();
            endDateTimePicker = new DateTimePicker();
            dateInitDateTimePicker = new DateTimePicker();
            button3 = new Button();
            dgvReservas = new DataGridView();
            formReservationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // formReservationGroupBox
            // 
            formReservationGroupBox.Controls.Add(button2);
            formReservationGroupBox.Controls.Add(button1);
            formReservationGroupBox.Controls.Add(roomNumberLabel);
            formReservationGroupBox.Controls.Add(endDateLabel);
            formReservationGroupBox.Controls.Add(dateInitLabel);
            formReservationGroupBox.Controls.Add(nameClientTextBox);
            formReservationGroupBox.Controls.Add(nameClientLabel);
            formReservationGroupBox.Controls.Add(reservationButton);
            formReservationGroupBox.Controls.Add(roomNumbercomboBox);
            formReservationGroupBox.Controls.Add(endDateTimePicker);
            formReservationGroupBox.Controls.Add(dateInitDateTimePicker);
            formReservationGroupBox.Location = new Point(37, 86);
            formReservationGroupBox.Margin = new Padding(2, 2, 2, 2);
            formReservationGroupBox.Name = "formReservationGroupBox";
            formReservationGroupBox.Padding = new Padding(2, 2, 2, 2);
            formReservationGroupBox.Size = new Size(585, 471);
            formReservationGroupBox.TabIndex = 2;
            formReservationGroupBox.TabStop = false;
            formReservationGroupBox.Text = "Formulario";
            // 
            // button2
            // 
            button2.Location = new Point(405, 374);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(143, 41);
            button2.TabIndex = 13;
            button2.Text = "Reservar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(227, 374);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(143, 41);
            button1.TabIndex = 12;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomNumberLabel.Location = new Point(25, 279);
            roomNumberLabel.Margin = new Padding(2, 0, 2, 0);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(219, 22);
            roomNumberLabel.TabIndex = 11;
            roomNumberLabel.Text = "Numero de Habitación:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLabel.Location = new Point(25, 203);
            endDateLabel.Margin = new Padding(2, 0, 2, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(211, 22);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "Fecha de Finalización:";
            // 
            // dateInitLabel
            // 
            dateInitLabel.AutoSize = true;
            dateInitLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateInitLabel.Location = new Point(80, 141);
            dateInitLabel.Margin = new Padding(2, 0, 2, 0);
            dateInitLabel.Name = "dateInitLabel";
            dateInitLabel.Size = new Size(152, 22);
            dateInitLabel.TabIndex = 9;
            dateInitLabel.Text = "Fecha de inicio:";
            // 
            // nameClientTextBox
            // 
            nameClientTextBox.Location = new Point(259, 68);
            nameClientTextBox.Margin = new Padding(2, 2, 2, 2);
            nameClientTextBox.Name = "nameClientTextBox";
            nameClientTextBox.Size = new Size(241, 27);
            nameClientTextBox.TabIndex = 8;
            // 
            // nameClientLabel
            // 
            nameClientLabel.AutoSize = true;
            nameClientLabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameClientLabel.Location = new Point(44, 70);
            nameClientLabel.Margin = new Padding(2, 0, 2, 0);
            nameClientLabel.Name = "nameClientLabel";
            nameClientLabel.Size = new Size(191, 22);
            nameClientLabel.TabIndex = 7;
            nameClientLabel.Text = "Nombre de Cliente: ";
            // 
            // reservationButton
            // 
            reservationButton.Location = new Point(44, 374);
            reservationButton.Margin = new Padding(2, 2, 2, 2);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(143, 41);
            reservationButton.TabIndex = 6;
            reservationButton.Text = "Reservar";
            reservationButton.UseVisualStyleBackColor = true;
            // 
            // roomNumbercomboBox
            // 
            roomNumbercomboBox.FormattingEnabled = true;
            roomNumbercomboBox.Location = new Point(259, 278);
            roomNumbercomboBox.Margin = new Padding(2, 2, 2, 2);
            roomNumbercomboBox.Name = "roomNumbercomboBox";
            roomNumbercomboBox.Size = new Size(241, 28);
            roomNumbercomboBox.TabIndex = 5;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(259, 199);
            endDateTimePicker.Margin = new Padding(2, 2, 2, 2);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(241, 27);
            endDateTimePicker.TabIndex = 3;
            // 
            // dateInitDateTimePicker
            // 
            dateInitDateTimePicker.Location = new Point(259, 137);
            dateInitDateTimePicker.Margin = new Padding(2, 2, 2, 2);
            dateInitDateTimePicker.Name = "dateInitDateTimePicker";
            dateInitDateTimePicker.Size = new Size(241, 27);
            dateInitDateTimePicker.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(37, 28);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(143, 41);
            button3.TabIndex = 14;
            button3.Text = "Reservar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(647, 97);
            dgvReservas.Margin = new Padding(2, 2, 2, 2);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 62;
            dgvReservas.Size = new Size(737, 456);
            dgvReservas.TabIndex = 15;
            // 
            // ReservationHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 589);
            Controls.Add(dgvReservas);
            Controls.Add(button3);
            Controls.Add(formReservationGroupBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ReservationHotel";
            Text = "RoomHotel";
            formReservationGroupBox.ResumeLayout(false);
            formReservationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox formReservationGroupBox;
        private Button button2;
        private Button button1;
        private Label roomNumberLabel;
        private Label endDateLabel;
        private Label dateInitLabel;
        private TextBox nameClientTextBox;
        private Label nameClientLabel;
        private Button reservationButton;
        private ComboBox roomNumbercomboBox;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker dateInitDateTimePicker;
        private Button button3;
        private DataGridView dgvReservas;
    }
}