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
            btnCliente = new Button();
            btnReservaciones = new Button();
            btnHabitaciones = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            pcMinimizar = new PictureBox();
            Bienvenida = new Label();
            pbSalir = new PictureBox();
            lblUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).BeginInit();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.MediumTurquoise;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Century Gothic", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(340, 133);
            btnCliente.Margin = new Padding(2);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(315, 50);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click_1;
            // 
            // btnReservaciones
            // 
            btnReservaciones.BackColor = Color.MediumTurquoise;
            btnReservaciones.FlatAppearance.BorderSize = 0;
            btnReservaciones.FlatStyle = FlatStyle.Flat;
            btnReservaciones.Font = new Font("Century Gothic", 12F);
            btnReservaciones.ForeColor = Color.White;
            btnReservaciones.Location = new Point(340, 187);
            btnReservaciones.Margin = new Padding(2);
            btnReservaciones.Name = "btnReservaciones";
            btnReservaciones.Size = new Size(315, 49);
            btnReservaciones.TabIndex = 1;
            btnReservaciones.Text = "Reservaciones";
            btnReservaciones.UseVisualStyleBackColor = false;
            btnReservaciones.Click += btnReservaciones_Click_1;
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.BackColor = Color.MediumTurquoise;
            btnHabitaciones.FlatAppearance.BorderSize = 0;
            btnHabitaciones.FlatStyle = FlatStyle.Flat;
            btnHabitaciones.Font = new Font("Century Gothic", 12F);
            btnHabitaciones.ForeColor = Color.White;
            btnHabitaciones.Location = new Point(340, 240);
            btnHabitaciones.Margin = new Padding(2);
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(315, 49);
            btnHabitaciones.TabIndex = 2;
            btnHabitaciones.Text = "Habitaciones";
            btnHabitaciones.UseVisualStyleBackColor = false;
            btnHabitaciones.Click += btnHabitaciones_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumTurquoise;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(340, 293);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(315, 49);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pcMinimizar);
            panel1.Controls.Add(Bienvenida);
            panel1.Controls.Add(pbSalir);
            panel1.Controls.Add(lblUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Century Gothic", 9F);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 44);
            panel1.TabIndex = 4;
            // 
            // pcMinimizar
            // 
            pcMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pcMinimizar.BackColor = Color.Transparent;
            pcMinimizar.Cursor = Cursors.Hand;
            pcMinimizar.Image = Properties.Resources.negative_sign_icon_icons_com_70439;
            pcMinimizar.Location = new Point(902, 8);
            pcMinimizar.Name = "pcMinimizar";
            pcMinimizar.Size = new Size(36, 33);
            pcMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pcMinimizar.TabIndex = 10;
            pcMinimizar.TabStop = false;
            pcMinimizar.Click += pcMinimizar_Click;
            // 
            // Bienvenida
            // 
            Bienvenida.AutoSize = true;
            Bienvenida.Location = new Point(2, 9);
            Bienvenida.Name = "Bienvenida";
            Bienvenida.Size = new Size(92, 20);
            Bienvenida.TabIndex = 1;
            Bienvenida.Text = "Bienvenido";
            // 
            // pbSalir
            // 
            pbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbSalir.BackColor = Color.Transparent;
            pbSalir.Cursor = Cursors.Hand;
            pbSalir.Image = Properties.Resources.close_remove_delete_icon_148989;
            pbSalir.Location = new Point(944, 8);
            pbSalir.Name = "pbSalir";
            pbSalir.Size = new Size(36, 33);
            pbSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pbSalir.TabIndex = 9;
            pbSalir.TabStop = false;
            pbSalir.Click += pbSalir_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(91, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "lblUsuario";
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 418);
            Controls.Add(panel1);
            Controls.Add(btnLogout);
            Controls.Add(btnHabitaciones);
            Controls.Add(btnReservaciones);
            Controls.Add(btnCliente);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormAdministration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnReservaciones;
        private Button btnHabitaciones;
        private Button btnLogout;
        private Panel panel1;
        private Label Bienvenida;
        private Label lblUsuario;
        private PictureBox pcMinimizar;
        private PictureBox pbSalir;
    }
}