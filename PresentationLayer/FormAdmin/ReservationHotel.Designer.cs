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
            label1 = new Label();
            StatesComboBox = new ComboBox();
            priceResultLabel = new Label();
            priceLabel = new Label();
            DeleteButton = new Button();
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
            formReservationGroupBox.Controls.Add(label1);
            formReservationGroupBox.Controls.Add(StatesComboBox);
            formReservationGroupBox.Controls.Add(priceResultLabel);
            formReservationGroupBox.Controls.Add(priceLabel);
            formReservationGroupBox.Controls.Add(DeleteButton);
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
            formReservationGroupBox.Location = new Point(35, 17);
            formReservationGroupBox.Margin = new Padding(1);
            formReservationGroupBox.Name = "formReservationGroupBox";
            formReservationGroupBox.Padding = new Padding(1);
            formReservationGroupBox.Size = new Size(585, 471);
            formReservationGroupBox.TabIndex = 2;
            formReservationGroupBox.TabStop = false;
            formReservationGroupBox.Text = "Formulario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 286);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 17;
            label1.Text = "Estado:";
            // 
            // StatesComboBox
            // 
            StatesComboBox.FormattingEnabled = true;
            StatesComboBox.Location = new Point(259, 280);
            StatesComboBox.Margin = new Padding(1);
            StatesComboBox.Name = "StatesComboBox";
            StatesComboBox.Size = new Size(299, 30);
            StatesComboBox.TabIndex = 16;
            // 
            // priceResultLabel
            // 
            priceResultLabel.AutoSize = true;
            priceResultLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceResultLabel.Location = new Point(258, 327);
            priceResultLabel.Margin = new Padding(1, 0, 1, 0);
            priceResultLabel.Name = "priceResultLabel";
            priceResultLabel.Size = new Size(20, 24);
            priceResultLabel.TabIndex = 15;
            priceResultLabel.Text = "$";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(29, 327);
            priceLabel.Margin = new Padding(1, 0, 1, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(190, 24);
            priceLabel.TabIndex = 14;
            priceLabel.Text = "Precio de Habitación:";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(391, 375);
            DeleteButton.Margin = new Padding(1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(176, 51);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Eliminar Reserva";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // btnEditarReserva
            // 
            btnEditarReserva.BackColor = Color.DodgerBlue;
            btnEditarReserva.FlatStyle = FlatStyle.Popup;
            btnEditarReserva.ForeColor = Color.White;
            btnEditarReserva.Location = new Point(208, 375);
            btnEditarReserva.Margin = new Padding(1);
            btnEditarReserva.Name = "btnEditarReserva";
            btnEditarReserva.Size = new Size(165, 51);
            btnEditarReserva.TabIndex = 12;
            btnEditarReserva.Text = "Editar Reserva";
            btnEditarReserva.UseVisualStyleBackColor = false;
            btnEditarReserva.Click += btnEditarReserva_Click;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomNumberLabel.Location = new Point(14, 228);
            roomNumberLabel.Margin = new Padding(1, 0, 1, 0);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(205, 24);
            roomNumberLabel.TabIndex = 11;
            roomNumberLabel.Text = "Numero de Habitación:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLabel.Location = new Point(25, 173);
            endDateLabel.Margin = new Padding(1, 0, 1, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(201, 24);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "Fecha de Finalización:";
            // 
            // dateInitLabel
            // 
            dateInitLabel.AutoSize = true;
            dateInitLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateInitLabel.Location = new Point(80, 105);
            dateInitLabel.Margin = new Padding(1, 0, 1, 0);
            dateInitLabel.Name = "dateInitLabel";
            dateInitLabel.Size = new Size(145, 24);
            dateInitLabel.TabIndex = 9;
            dateInitLabel.Text = "Fecha de inicio:";
            // 
            // nameClientTextBox
            // 
            nameClientTextBox.Location = new Point(259, 41);
            nameClientTextBox.Margin = new Padding(1);
            nameClientTextBox.Name = "nameClientTextBox";
            nameClientTextBox.Size = new Size(299, 28);
            nameClientTextBox.TabIndex = 8;
            // 
            // nameClientLabel
            // 
            nameClientLabel.AutoSize = true;
            nameClientLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameClientLabel.Location = new Point(43, 41);
            nameClientLabel.Margin = new Padding(1, 0, 1, 0);
            nameClientLabel.Name = "nameClientLabel";
            nameClientLabel.Size = new Size(179, 24);
            nameClientLabel.TabIndex = 7;
            nameClientLabel.Text = "Nombre de Cliente: ";
            // 
            // reservationButton
            // 
            reservationButton.BackColor = Color.FromArgb(0, 192, 0);
            reservationButton.FlatStyle = FlatStyle.Popup;
            reservationButton.ForeColor = Color.White;
            reservationButton.Location = new Point(30, 375);
            reservationButton.Margin = new Padding(1);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(158, 51);
            reservationButton.TabIndex = 6;
            reservationButton.Text = "Reservar";
            reservationButton.UseVisualStyleBackColor = false;
            reservationButton.Click += reservationButton_Click;
            // 
            // roomNumbercomboBox
            // 
            roomNumbercomboBox.FormattingEnabled = true;
            roomNumbercomboBox.Location = new Point(259, 228);
            roomNumbercomboBox.Margin = new Padding(1);
            roomNumbercomboBox.Name = "roomNumbercomboBox";
            roomNumbercomboBox.Size = new Size(299, 30);
            roomNumbercomboBox.TabIndex = 5;
            roomNumbercomboBox.SelectedIndexChanged += roomNumbercomboBox_SelectedIndexChanged;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(259, 173);
            endDateTimePicker.Margin = new Padding(1);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(299, 28);
            endDateTimePicker.TabIndex = 3;
            endDateTimePicker.ValueChanged += endDateTimePicker_ValueChanged;
            // 
            // dateInitDateTimePicker
            // 
            dateInitDateTimePicker.Location = new Point(259, 105);
            dateInitDateTimePicker.Margin = new Padding(1);
            dateInitDateTimePicker.Name = "dateInitDateTimePicker";
            dateInitDateTimePicker.Size = new Size(299, 28);
            dateInitDateTimePicker.TabIndex = 2;
            dateInitDateTimePicker.ValueChanged += dateInitDateTimePicker_ValueChanged;
            // 
            // listReservationDataGridView
            // 
            listReservationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listReservationDataGridView.Location = new Point(634, 28);
            listReservationDataGridView.Margin = new Padding(1);
            listReservationDataGridView.Name = "listReservationDataGridView";
            listReservationDataGridView.RowHeadersWidth = 62;
            listReservationDataGridView.Size = new Size(759, 461);
            listReservationDataGridView.TabIndex = 15;
            // 
            // backMenuButton
            // 
            backMenuButton.BackColor = Color.Orange;
            backMenuButton.FlatStyle = FlatStyle.Popup;
            backMenuButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backMenuButton.ForeColor = Color.White;
            backMenuButton.Location = new Point(35, 511);
            backMenuButton.Margin = new Padding(2, 3, 2, 3);
            backMenuButton.Name = "backMenuButton";
            backMenuButton.Size = new Size(159, 59);
            backMenuButton.TabIndex = 16;
            backMenuButton.Text = "Regresar a Menú";
            backMenuButton.UseVisualStyleBackColor = false;
            // 
            // reservationHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 589);
            Controls.Add(backMenuButton);
            Controls.Add(listReservationDataGridView);
            Controls.Add(formReservationGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1);
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
        private Button DeleteButton;
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
        private Label label1;
        private ComboBox StatesComboBox;
    }
}