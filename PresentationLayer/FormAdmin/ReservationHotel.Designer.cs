namespace PresentationLayer.FormAdmin
{
    partial class reservationHotel
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
            formReservationGroupBox = new GroupBox();
            priceResultLabel = new Label();
            priceLabel = new Label();
            button2 = new Button();
            btnEditarReserva = new Button();
            roomNumberLabel = new Label();
            endDateLabel = new Label();
            dateInitLabel = new Label();
            nameClientTextBox = new TextBox();
            nameClientLabel = new Label();
            reservationButton = new Button();
            roomNumbercomboBox = new ComboBox();
            endDateTimePicker = new DateTimePicker();
            dateInitDateTimePicker = new DateTimePicker();
            listReservationDataGridView = new DataGridView();
            toolTip1 = new ToolTip(components);
            backMenuButton = new Button();
            formReservationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listReservationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // formReservationGroupBox
            // 
            formReservationGroupBox.Controls.Add(priceResultLabel);
            formReservationGroupBox.Controls.Add(priceLabel);
            formReservationGroupBox.Controls.Add(button2);
            formReservationGroupBox.Controls.Add(btnEditarReserva);
            formReservationGroupBox.Controls.Add(roomNumberLabel);
            formReservationGroupBox.Controls.Add(endDateLabel);
            formReservationGroupBox.Controls.Add(dateInitLabel);
            formReservationGroupBox.Controls.Add(nameClientTextBox);
            formReservationGroupBox.Controls.Add(nameClientLabel);
            formReservationGroupBox.Controls.Add(reservationButton);
            formReservationGroupBox.Controls.Add(roomNumbercomboBox);
            formReservationGroupBox.Controls.Add(endDateTimePicker);
            formReservationGroupBox.Controls.Add(dateInitDateTimePicker);
            formReservationGroupBox.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formReservationGroupBox.Location = new Point(31, 13);
            formReservationGroupBox.Margin = new Padding(1, 1, 1, 1);
            formReservationGroupBox.Name = "formReservationGroupBox";
            formReservationGroupBox.Padding = new Padding(1, 1, 1, 1);
            formReservationGroupBox.Size = new Size(512, 353);
            formReservationGroupBox.TabIndex = 2;
            formReservationGroupBox.TabStop = false;
            formReservationGroupBox.Text = "Formulario";
            // 
            // priceResultLabel
            // 
            priceResultLabel.AutoSize = true;
            priceResultLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceResultLabel.Location = new Point(227, 233);
            priceResultLabel.Margin = new Padding(1, 0, 1, 0);
            priceResultLabel.Name = "priceResultLabel";
            priceResultLabel.Size = new Size(16, 18);
            priceResultLabel.TabIndex = 15;
            priceResultLabel.Text = "$";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(26, 233);
            priceLabel.Margin = new Padding(1, 0, 1, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(149, 18);
            priceLabel.TabIndex = 14;
            priceLabel.Text = "Precio de Habitación:";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(342, 281);
            button2.Margin = new Padding(1, 1, 1, 1);
            button2.Name = "button2";
            button2.Size = new Size(154, 38);
            button2.TabIndex = 13;
            button2.Text = "Eliminar Reserva";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnEditarReserva
            // 
            btnEditarReserva.BackColor = Color.DodgerBlue;
            btnEditarReserva.FlatStyle = FlatStyle.Popup;
            btnEditarReserva.ForeColor = Color.White;
            btnEditarReserva.Location = new Point(182, 281);
            btnEditarReserva.Margin = new Padding(1, 1, 1, 1);
            btnEditarReserva.Name = "btnEditarReserva";
            btnEditarReserva.Size = new Size(144, 38);
            btnEditarReserva.TabIndex = 12;
            btnEditarReserva.Text = "Editar Reserva";
            btnEditarReserva.UseVisualStyleBackColor = false;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomNumberLabel.Location = new Point(12, 179);
            roomNumberLabel.Margin = new Padding(1, 0, 1, 0);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(160, 18);
            roomNumberLabel.TabIndex = 11;
            roomNumberLabel.Text = "Numero de Habitación:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLabel.Location = new Point(22, 130);
            endDateLabel.Margin = new Padding(1, 0, 1, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(155, 18);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "Fecha de Finalización:";
            // 
            // dateInitLabel
            // 
            dateInitLabel.AutoSize = true;
            dateInitLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateInitLabel.Location = new Point(70, 79);
            dateInitLabel.Margin = new Padding(1, 0, 1, 0);
            dateInitLabel.Name = "dateInitLabel";
            dateInitLabel.Size = new Size(111, 18);
            dateInitLabel.TabIndex = 9;
            dateInitLabel.Text = "Fecha de inicio:";
            // 
            // nameClientTextBox
            // 
            nameClientTextBox.Location = new Point(227, 31);
            nameClientTextBox.Margin = new Padding(1, 1, 1, 1);
            nameClientTextBox.Name = "nameClientTextBox";
            nameClientTextBox.Size = new Size(262, 24);
            nameClientTextBox.TabIndex = 8;
            // 
            // nameClientLabel
            // 
            nameClientLabel.AutoSize = true;
            nameClientLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameClientLabel.Location = new Point(38, 31);
            nameClientLabel.Margin = new Padding(1, 0, 1, 0);
            nameClientLabel.Name = "nameClientLabel";
            nameClientLabel.Size = new Size(139, 18);
            nameClientLabel.TabIndex = 7;
            nameClientLabel.Text = "Nombre de Cliente: ";
            // 
            // reservationButton
            // 
            reservationButton.BackColor = Color.FromArgb(0, 192, 0);
            reservationButton.FlatStyle = FlatStyle.Popup;
            reservationButton.ForeColor = Color.White;
            reservationButton.Location = new Point(26, 281);
            reservationButton.Margin = new Padding(1, 1, 1, 1);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(138, 38);
            reservationButton.TabIndex = 6;
            reservationButton.Text = "Reservar";
            reservationButton.UseVisualStyleBackColor = false;
            // 
            // roomNumbercomboBox
            // 
            roomNumbercomboBox.FormattingEnabled = true;
            roomNumbercomboBox.Location = new Point(227, 179);
            roomNumbercomboBox.Margin = new Padding(1, 1, 1, 1);
            roomNumbercomboBox.Name = "roomNumbercomboBox";
            roomNumbercomboBox.Size = new Size(262, 26);
            roomNumbercomboBox.TabIndex = 5;
            roomNumbercomboBox.SelectedIndexChanged += roomNumbercomboBox_SelectedIndexChanged;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(227, 130);
            endDateTimePicker.Margin = new Padding(1, 1, 1, 1);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(262, 24);
            endDateTimePicker.TabIndex = 3;
            endDateTimePicker.ValueChanged += endDateTimePicker_ValueChanged;
            // 
            // dateInitDateTimePicker
            // 
            dateInitDateTimePicker.Location = new Point(227, 79);
            dateInitDateTimePicker.Margin = new Padding(1, 1, 1, 1);
            dateInitDateTimePicker.Name = "dateInitDateTimePicker";
            dateInitDateTimePicker.Size = new Size(262, 24);
            dateInitDateTimePicker.TabIndex = 2;
            dateInitDateTimePicker.ValueChanged += dateInitDateTimePicker_ValueChanged;
            // 
            // listReservationDataGridView
            // 
            listReservationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listReservationDataGridView.Location = new Point(555, 21);
            listReservationDataGridView.Margin = new Padding(1, 1, 1, 1);
            listReservationDataGridView.Name = "listReservationDataGridView";
            listReservationDataGridView.RowHeadersWidth = 62;
            listReservationDataGridView.Size = new Size(664, 346);
            listReservationDataGridView.TabIndex = 15;
            // 
            // backMenuButton
            // 
            backMenuButton.BackColor = Color.Orange;
            backMenuButton.FlatStyle = FlatStyle.Popup;
            backMenuButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backMenuButton.ForeColor = Color.White;
            backMenuButton.Location = new Point(31, 383);
            backMenuButton.Margin = new Padding(2, 2, 2, 2);
            backMenuButton.Name = "backMenuButton";
            backMenuButton.Size = new Size(139, 44);
            backMenuButton.TabIndex = 16;
            backMenuButton.Text = "Regresar a Menú";
            backMenuButton.UseVisualStyleBackColor = false;
            // 
            // reservationHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 442);
            Controls.Add(backMenuButton);
            Controls.Add(listReservationDataGridView);
            Controls.Add(formReservationGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1, 1, 1, 1);
            Name = "reservationHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Reservaciones";
            formReservationGroupBox.ResumeLayout(false);
            formReservationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listReservationDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox formReservationGroupBox;
        private Button button2;
        private Button btnEditarReserva;
        private Label roomNumberLabel;
        private Label endDateLabel;
        private Label dateInitLabel;
        private TextBox nameClientTextBox;
        private Label nameClientLabel;
        private Button reservationButton;
        private ComboBox roomNumbercomboBox;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker dateInitDateTimePicker;
        private DataGridView listReservationDataGridView;
        private ToolTip toolTip1;
        private Label priceResultLabel;
        private Label priceLabel;
        private Button backMenuButton;
    }
}