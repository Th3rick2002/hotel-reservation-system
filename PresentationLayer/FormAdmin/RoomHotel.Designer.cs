namespace PresentationLayer.FormAdmin
{
    partial class RoomHotel
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
            listRoomDataGridView = new DataGridView();
            roomGroupBox = new GroupBox();
            deleteRoomButton = new FontAwesome.Sharp.IconButton();
            priceRoomTextBox = new TextBox();
            editRoomButton = new FontAwesome.Sharp.IconButton();
            priceRoomLabel = new Label();
            saveRoomButton = new FontAwesome.Sharp.IconButton();
            typeRoomTextBox = new TextBox();
            typeRoomLabel = new Label();
            toolTip1 = new ToolTip(components);
            backMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)listRoomDataGridView).BeginInit();
            roomGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // listRoomDataGridView
            // 
            listRoomDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listRoomDataGridView.Location = new Point(652, 65);
            listRoomDataGridView.Name = "listRoomDataGridView";
            listRoomDataGridView.RowHeadersWidth = 51;
            listRoomDataGridView.Size = new Size(796, 517);
            listRoomDataGridView.TabIndex = 0;
            // 
            // roomGroupBox
            // 
            roomGroupBox.Controls.Add(deleteRoomButton);
            roomGroupBox.Controls.Add(priceRoomTextBox);
            roomGroupBox.Controls.Add(editRoomButton);
            roomGroupBox.Controls.Add(priceRoomLabel);
            roomGroupBox.Controls.Add(saveRoomButton);
            roomGroupBox.Controls.Add(typeRoomTextBox);
            roomGroupBox.Controls.Add(typeRoomLabel);
            roomGroupBox.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomGroupBox.Location = new Point(23, 65);
            roomGroupBox.Name = "roomGroupBox";
            roomGroupBox.Size = new Size(610, 517);
            roomGroupBox.TabIndex = 2;
            roomGroupBox.TabStop = false;
            roomGroupBox.Text = "Añadir Habitacion:";
            // 
            // deleteRoomButton
            // 
            deleteRoomButton.BackColor = Color.Red;
            deleteRoomButton.Cursor = Cursors.Hand;
            deleteRoomButton.FlatAppearance.BorderColor = Color.Black;
            deleteRoomButton.FlatStyle = FlatStyle.Popup;
            deleteRoomButton.ForeColor = Color.White;
            deleteRoomButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            deleteRoomButton.IconColor = Color.White;
            deleteRoomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteRoomButton.IconSize = 30;
            deleteRoomButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteRoomButton.Location = new Point(426, 412);
            deleteRoomButton.Name = "deleteRoomButton";
            deleteRoomButton.Size = new Size(159, 50);
            deleteRoomButton.TabIndex = 25;
            deleteRoomButton.Text = "Eliminar";
            deleteRoomButton.UseVisualStyleBackColor = false;
            // 
            // priceRoomTextBox
            // 
            priceRoomTextBox.Location = new Point(72, 289);
            priceRoomTextBox.Name = "priceRoomTextBox";
            priceRoomTextBox.Size = new Size(444, 24);
            priceRoomTextBox.TabIndex = 3;
            // 
            // editRoomButton
            // 
            editRoomButton.BackColor = Color.DodgerBlue;
            editRoomButton.Cursor = Cursors.Hand;
            editRoomButton.FlatAppearance.BorderColor = Color.Black;
            editRoomButton.FlatStyle = FlatStyle.Popup;
            editRoomButton.ForeColor = Color.White;
            editRoomButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editRoomButton.IconColor = Color.White;
            editRoomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editRoomButton.IconSize = 30;
            editRoomButton.ImageAlign = ContentAlignment.MiddleLeft;
            editRoomButton.Location = new Point(231, 412);
            editRoomButton.Name = "editRoomButton";
            editRoomButton.Size = new Size(155, 50);
            editRoomButton.TabIndex = 24;
            editRoomButton.Text = "Editar";
            editRoomButton.UseVisualStyleBackColor = false;
            // 
            // priceRoomLabel
            // 
            priceRoomLabel.AutoSize = true;
            priceRoomLabel.Location = new Point(72, 249);
            priceRoomLabel.Name = "priceRoomLabel";
            priceRoomLabel.Size = new Size(139, 18);
            priceRoomLabel.TabIndex = 2;
            priceRoomLabel.Text = "Precion Por Noche:";
            // 
            // saveRoomButton
            // 
            saveRoomButton.BackColor = Color.FromArgb(0, 192, 0);
            saveRoomButton.Cursor = Cursors.Hand;
            saveRoomButton.FlatAppearance.BorderColor = Color.Black;
            saveRoomButton.FlatStyle = FlatStyle.Popup;
            saveRoomButton.ForeColor = Color.White;
            saveRoomButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveRoomButton.IconColor = Color.White;
            saveRoomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveRoomButton.IconSize = 30;
            saveRoomButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveRoomButton.Location = new Point(41, 412);
            saveRoomButton.Name = "saveRoomButton";
            saveRoomButton.Size = new Size(158, 50);
            saveRoomButton.TabIndex = 23;
            saveRoomButton.Text = "Agregar";
            saveRoomButton.UseVisualStyleBackColor = false;
            saveRoomButton.Click += saveRoomButton_Click;
            // 
            // typeRoomTextBox
            // 
            typeRoomTextBox.Location = new Point(71, 160);
            typeRoomTextBox.Name = "typeRoomTextBox";
            typeRoomTextBox.Size = new Size(445, 24);
            typeRoomTextBox.TabIndex = 1;
            // 
            // typeRoomLabel
            // 
            typeRoomLabel.AutoSize = true;
            typeRoomLabel.Location = new Point(72, 110);
            typeRoomLabel.Name = "typeRoomLabel";
            typeRoomLabel.Size = new Size(41, 18);
            typeRoomLabel.TabIndex = 0;
            typeRoomLabel.Text = "Tipo:";
            // 
            // backMenuButton
            // 
            backMenuButton.BackColor = Color.Orange;
            backMenuButton.FlatStyle = FlatStyle.Popup;
            backMenuButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backMenuButton.ForeColor = Color.White;
            backMenuButton.Location = new Point(23, 642);
            backMenuButton.Name = "backMenuButton";
            backMenuButton.Size = new Size(199, 51);
            backMenuButton.TabIndex = 17;
            backMenuButton.Text = "Regresar a Menú";
            backMenuButton.UseVisualStyleBackColor = false;
            // 
            // RoomHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1471, 729);
            Controls.Add(backMenuButton);
            Controls.Add(roomGroupBox);
            Controls.Add(listRoomDataGridView);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "RoomHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Habitaciones ";
            Load += RoomHotel_Load;
            ((System.ComponentModel.ISupportInitialize)listRoomDataGridView).EndInit();
            roomGroupBox.ResumeLayout(false);
            roomGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listRoomDataGridView;
        private Label lbllistahabitaciones;
        private GroupBox roomGroupBox;
        private TextBox typeRoomTextBox;
        private Label typeRoomLabel;
        private TextBox priceRoomTextBox;
        private Label priceRoomLabel;
        private FontAwesome.Sharp.IconButton deleteRoomButton;
        private FontAwesome.Sharp.IconButton editRoomButton;
        private FontAwesome.Sharp.IconButton saveRoomButton;
        private ToolTip toolTip1;
        private Button backMenuButton;
    }
}