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
            dgvHabitaciones = new DataGridView();
            lbllistahabitaciones = new Label();
            gbHabitacion = new GroupBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            btnEditar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            label1 = new Label();
            pcMinimizar = new PictureBox();
            pbSalir = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            gbHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).BeginInit();
            SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Location = new Point(452, 111);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.RowHeadersWidth = 51;
            dgvHabitaciones.Size = new Size(796, 461);
            dgvHabitaciones.TabIndex = 0;
            // 
            // lbllistahabitaciones
            // 
            lbllistahabitaciones.BackColor = SystemColors.ActiveBorder;
            lbllistahabitaciones.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbllistahabitaciones.ForeColor = Color.White;
            lbllistahabitaciones.Location = new Point(0, 20);
            lbllistahabitaciones.Name = "lbllistahabitaciones";
            lbllistahabitaciones.Size = new Size(418, 46);
            lbllistahabitaciones.TabIndex = 1;
            lbllistahabitaciones.Text = "Lista De Habitaciones";
            // 
            // gbHabitacion
            // 
            gbHabitacion.Controls.Add(btnEliminar);
            gbHabitacion.Controls.Add(textBox2);
            gbHabitacion.Controls.Add(btnEditar);
            gbHabitacion.Controls.Add(label2);
            gbHabitacion.Controls.Add(btnGuardar);
            gbHabitacion.Controls.Add(textBox1);
            gbHabitacion.Controls.Add(label1);
            gbHabitacion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbHabitacion.Location = new Point(14, 99);
            gbHabitacion.Name = "gbHabitacion";
            gbHabitacion.Size = new Size(418, 473);
            gbHabitacion.TabIndex = 2;
            gbHabitacion.TabStop = false;
            gbHabitacion.Text = "Añadir Habitacion:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 22;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(34, 383);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(207, 29);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 32);
            textBox2.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 22;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(34, 348);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(207, 29);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 191);
            label2.Name = "label2";
            label2.Size = new Size(196, 23);
            label2.TabIndex = 2;
            label2.Text = "Precion Por Noche:";
            label2.Click += label2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 22;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(34, 313);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(207, 29);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Añadir";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 32);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 74);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 0;
            label1.Text = "Tipo:";
            // 
            // pcMinimizar
            // 
            pcMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pcMinimizar.BackColor = Color.Transparent;
            pcMinimizar.Cursor = Cursors.Hand;
            pcMinimizar.Image = Properties.Resources.negative_sign_icon_icons_com_70439;
            pcMinimizar.Location = new Point(1170, 12);
            pcMinimizar.Name = "pcMinimizar";
            pcMinimizar.Size = new Size(36, 33);
            pcMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pcMinimizar.TabIndex = 19;
            pcMinimizar.TabStop = false;
            pcMinimizar.Click += pcMinimizar_Click;
            pcMinimizar.MouseHover += pcMinimizar_MouseHover;
            // 
            // pbSalir
            // 
            pbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbSalir.BackColor = Color.Transparent;
            pbSalir.Cursor = Cursors.Hand;
            pbSalir.Image = Properties.Resources.close_remove_delete_icon_148989;
            pbSalir.Location = new Point(1212, 12);
            pbSalir.Name = "pbSalir";
            pbSalir.Size = new Size(36, 33);
            pbSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pbSalir.TabIndex = 18;
            pbSalir.TabStop = false;
            pbSalir.Click += pbSalir_Click;
            pbSalir.MouseHover += pbSalir_MouseHover;
            // 
            // RoomHotel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 602);
            Controls.Add(pcMinimizar);
            Controls.Add(pbSalir);
            Controls.Add(gbHabitacion);
            Controls.Add(lbllistahabitaciones);
            Controls.Add(dgvHabitaciones);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RoomHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomHotel";
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            gbHabitacion.ResumeLayout(false);
            gbHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHabitaciones;
        private Label lbllistahabitaciones;
        private GroupBox gbHabitacion;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private PictureBox pcMinimizar;
        private PictureBox pbSalir;
        private ToolTip toolTip1;
    }
}