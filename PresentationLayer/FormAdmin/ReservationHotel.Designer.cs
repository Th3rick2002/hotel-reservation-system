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
            roomNumberLabel = new Label();
            endDateLabel = new Label();
            dateInitLabel = new Label();
            nameClientTextBox = new TextBox();
            nameClientLabel = new Label();
            reservationButton = new Button();
            roomNumbercomboBox = new ComboBox();
            endDateTimePicker = new DateTimePicker();
            dateInitDateTimePicker = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            formReservationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            formReservationGroupBox.Location = new Point(46, 107);
            formReservationGroupBox.Name = "formReservationGroupBox";
            formReservationGroupBox.Size = new Size(731, 589);
            formReservationGroupBox.TabIndex = 2;
            formReservationGroupBox.TabStop = false;
            formReservationGroupBox.Text = "Formulario";
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
            // nameClientTextBox
            // 
            nameClientTextBox.Location = new Point(324, 85);
            nameClientTextBox.Name = "nameClientTextBox";
            nameClientTextBox.Size = new Size(300, 31);
            nameClientTextBox.TabIndex = 8;
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
            // reservationButton
            // 
            reservationButton.Location = new Point(55, 468);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(179, 51);
            reservationButton.TabIndex = 6;
            reservationButton.Text = "Reservar";
            reservationButton.UseVisualStyleBackColor = true;
            // 
            // roomNumbercomboBox
            // 
            roomNumbercomboBox.FormattingEnabled = true;
            roomNumbercomboBox.Location = new Point(324, 347);
            roomNumbercomboBox.Name = "roomNumbercomboBox";
            roomNumbercomboBox.Size = new Size(300, 33);
            roomNumbercomboBox.TabIndex = 5;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(324, 249);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(300, 31);
            endDateTimePicker.TabIndex = 3;
            // 
            // dateInitDateTimePicker
            // 
            dateInitDateTimePicker.Location = new Point(324, 171);
            dateInitDateTimePicker.Name = "dateInitDateTimePicker";
            dateInitDateTimePicker.Size = new Size(300, 31);
            dateInitDateTimePicker.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(284, 468);
            button1.Name = "button1";
            button1.Size = new Size(179, 51);
            button1.TabIndex = 12;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(506, 468);
            button2.Name = "button2";
            button2.Size = new Size(179, 51);
            button2.TabIndex = 13;
            button2.Text = "Reservar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(46, 35);
            button3.Name = "button3";
            button3.Size = new Size(179, 51);
            button3.TabIndex = 14;
            button3.Text = "Reservar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(809, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(921, 570);
            dataGridView1.TabIndex = 15;
            // 
            // RoomHotel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1769, 736);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(formReservationGroupBox);
            Name = "RoomHotel";
            Text = "RoomHotel";
            formReservationGroupBox.ResumeLayout(false);
            formReservationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}