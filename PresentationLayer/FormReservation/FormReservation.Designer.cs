namespace PresentationLayer.FormReservation
{
    partial class FormReservation
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
            priceResultLabel = new Label();
            priceLabel = new Label();
            roomNumberLabel = new Label();
            endDateLabel = new Label();
            dateInitLabel = new Label();
            nameClientTextBox = new TextBox();
            nameClientLabel = new Label();
            reservationButton = new Button();
            roomNumbercomboBox = new ComboBox();
            endDateTimePicker = new DateTimePicker();
            dateInitDateTimePicker = new DateTimePicker();
            pictureBox1 = new PictureBox();
            formReservationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(579, 27);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(295, 26);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Reservación de Habitaciones";
            // 
            // formReservationGroupBox
            // 
            formReservationGroupBox.Controls.Add(priceResultLabel);
            formReservationGroupBox.Controls.Add(priceLabel);
            formReservationGroupBox.Controls.Add(roomNumberLabel);
            formReservationGroupBox.Controls.Add(endDateLabel);
            formReservationGroupBox.Controls.Add(dateInitLabel);
            formReservationGroupBox.Controls.Add(nameClientTextBox);
            formReservationGroupBox.Controls.Add(nameClientLabel);
            formReservationGroupBox.Controls.Add(reservationButton);
            formReservationGroupBox.Controls.Add(roomNumbercomboBox);
            formReservationGroupBox.Controls.Add(endDateTimePicker);
            formReservationGroupBox.Controls.Add(dateInitDateTimePicker);
            formReservationGroupBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formReservationGroupBox.Location = new Point(492, 80);
            formReservationGroupBox.Margin = new Padding(2);
            formReservationGroupBox.Name = "formReservationGroupBox";
            formReservationGroupBox.Padding = new Padding(2);
            formReservationGroupBox.Size = new Size(512, 362);
            formReservationGroupBox.TabIndex = 1;
            formReservationGroupBox.TabStop = false;
            formReservationGroupBox.Text = "Formulario";
            // 
            // priceResultLabel
            // 
            priceResultLabel.AutoSize = true;
            priceResultLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceResultLabel.Location = new Point(227, 254);
            priceResultLabel.Margin = new Padding(2, 0, 2, 0);
            priceResultLabel.Name = "priceResultLabel";
            priceResultLabel.Size = new Size(16, 18);
            priceResultLabel.TabIndex = 13;
            priceResultLabel.Text = "$";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(30, 254);
            priceLabel.Margin = new Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(149, 18);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Precio de Habitación:";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomNumberLabel.Location = new Point(22, 209);
            roomNumberLabel.Margin = new Padding(2, 0, 2, 0);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(160, 18);
            roomNumberLabel.TabIndex = 11;
            roomNumberLabel.Text = "Numero de Habitación:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLabel.Location = new Point(26, 152);
            endDateLabel.Margin = new Padding(2, 0, 2, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(155, 18);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "Fecha de Finalización:";
            // 
            // dateInitLabel
            // 
            dateInitLabel.AutoSize = true;
            dateInitLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateInitLabel.Location = new Point(70, 106);
            dateInitLabel.Margin = new Padding(2, 0, 2, 0);
            dateInitLabel.Name = "dateInitLabel";
            dateInitLabel.Size = new Size(111, 18);
            dateInitLabel.TabIndex = 9;
            dateInitLabel.Text = "Fecha de inicio:";
            // 
            // nameClientTextBox
            // 
            nameClientTextBox.Location = new Point(227, 51);
            nameClientTextBox.Margin = new Padding(2);
            nameClientTextBox.Name = "nameClientTextBox";
            nameClientTextBox.Size = new Size(211, 21);
            nameClientTextBox.TabIndex = 8;
            // 
            // nameClientLabel
            // 
            nameClientLabel.AutoSize = true;
            nameClientLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameClientLabel.Location = new Point(38, 52);
            nameClientLabel.Margin = new Padding(2, 0, 2, 0);
            nameClientLabel.Name = "nameClientLabel";
            nameClientLabel.Size = new Size(139, 18);
            nameClientLabel.TabIndex = 7;
            nameClientLabel.Text = "Nombre de Cliente: ";
            // 
            // reservationButton
            // 
            reservationButton.BackColor = Color.SteelBlue;
            reservationButton.FlatStyle = FlatStyle.Popup;
            reservationButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reservationButton.ForeColor = Color.White;
            reservationButton.Location = new Point(121, 300);
            reservationButton.Margin = new Padding(2);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(279, 37);
            reservationButton.TabIndex = 6;
            reservationButton.Text = "Reservar";
            reservationButton.UseVisualStyleBackColor = false;
            reservationButton.Click += reservationButton_Click;
            // 
            // roomNumbercomboBox
            // 
            roomNumbercomboBox.FormattingEnabled = true;
            roomNumbercomboBox.Location = new Point(227, 208);
            roomNumbercomboBox.Margin = new Padding(2);
            roomNumbercomboBox.Name = "roomNumbercomboBox";
            roomNumbercomboBox.Size = new Size(211, 23);
            roomNumbercomboBox.TabIndex = 5;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(227, 149);
            endDateTimePicker.Margin = new Padding(2);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(211, 21);
            endDateTimePicker.TabIndex = 3;
            // 
            // dateInitDateTimePicker
            // 
            dateInitDateTimePicker.Location = new Point(227, 103);
            dateInitDateTimePicker.Margin = new Padding(2);
            dateInitDateTimePicker.Name = "dateInitDateTimePicker";
            dateInitDateTimePicker.Size = new Size(211, 21);
            dateInitDateTimePicker.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1600w_GCXVaOYK_Vw__1_;
            pictureBox1.Location = new Point(9, 52);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 350);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1024, 465);
            Controls.Add(pictureBox1);
            Controls.Add(formReservationGroupBox);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "FormReservation";
            Load += FormReservation_Load;
            formReservationGroupBox.ResumeLayout(false);
            formReservationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label priceResultLabel;
        private Label priceLabel;
    }
}