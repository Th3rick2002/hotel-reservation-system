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
            dgvHabitaciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Location = new Point(527, 115);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.RowHeadersWidth = 51;
            dgvHabitaciones.Size = new Size(523, 306);
            dgvHabitaciones.TabIndex = 0;
            // 
            // RoomHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 602);
            Controls.Add(dgvHabitaciones);
            Margin = new Padding(2);
            Name = "RoomHotel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RoomHotel";
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHabitaciones;
    }
}