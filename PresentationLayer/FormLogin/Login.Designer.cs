using FontAwesome.Sharp;

namespace PresentationLayer.FormLogin
{
    partial class Login
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
            userLabel = new Label();
            passwordLabel = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            pbSalir = new PictureBox();
            pcMinimizar = new PictureBox();
            toolTip1 = new ToolTip(components);
            gbLogin = new GroupBox();
            btnCrearCuenta = new IconButton();
            btnLogin = new IconButton();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).BeginInit();
            gbLogin.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(227, 180);
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(116, 28);
            userLabel.TabIndex = 1;
            userLabel.Text = "Usuario: ";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(227, 270);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(147, 28);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(378, 184);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(311, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Location = new Point(378, 271);
            txtClave.Margin = new Padding(2);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(311, 27);
            txtClave.TabIndex = 4;
            // 
            // pbSalir
            // 
            pbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbSalir.BackColor = Color.White;
            pbSalir.Cursor = Cursors.Hand;
            pbSalir.Image = Properties.Resources.close_remove_delete_icon_148989;
            pbSalir.Location = new Point(928, 12);
            pbSalir.Name = "pbSalir";
            pbSalir.Size = new Size(36, 33);
            pbSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pbSalir.TabIndex = 7;
            pbSalir.TabStop = false;
            pbSalir.Click += pbSalir_Click;
            pbSalir.MouseHover += pbSalir_MouseHover;
            // 
            // pcMinimizar
            // 
            pcMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pcMinimizar.BackColor = Color.White;
            pcMinimizar.Cursor = Cursors.Hand;
            pcMinimizar.Image = Properties.Resources.negative_sign_icon_icons_com_70439;
            pcMinimizar.Location = new Point(864, 12);
            pcMinimizar.Name = "pcMinimizar";
            pcMinimizar.Size = new Size(36, 33);
            pcMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pcMinimizar.TabIndex = 8;
            pcMinimizar.TabStop = false;
            pcMinimizar.Click += pcMinimizar_Click;
            pcMinimizar.MouseHover += pcMinimizar_MouseHover;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(btnCrearCuenta);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Location = new Point(203, 125);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(633, 335);
            gbLogin.TabIndex = 9;
            gbLogin.TabStop = false;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.DimGray;
            btnCrearCuenta.Cursor = Cursors.Hand;
            btnCrearCuenta.FlatStyle = FlatStyle.Flat;
            btnCrearCuenta.Font = new Font("Century Gothic", 9F);
            btnCrearCuenta.ForeColor = Color.White;
            btnCrearCuenta.IconChar = IconChar.PlusSquare;
            btnCrearCuenta.IconColor = Color.White;
            btnCrearCuenta.IconFont = IconFont.Auto;
            btnCrearCuenta.IconSize = 38;
            btnCrearCuenta.Location = new Point(246, 253);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(160, 46);
            btnCrearCuenta.TabIndex = 8;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.IconChar = IconChar.LockOpen;
            btnLogin.IconColor = Color.White;
            btnLogin.IconFont = IconFont.Auto;
            btnLogin.IconSize = 38;
            btnLogin.Location = new Point(246, 201);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 46);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 65);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 46);
            label1.TabIndex = 0;
            label1.Text = "Inicio De Sesion";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 570);
            Controls.Add(pcMinimizar);
            Controls.Add(pbSalir);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(passwordLabel);
            Controls.Add(userLabel);
            Controls.Add(gbLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)pbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcMinimizar).EndInit();
            gbLogin.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label userLabel;
        private Label passwordLabel;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button logInButton;
        private Button newUserButton;
        private PictureBox pbSalir;
        private PictureBox pcMinimizar;
        private ToolTip toolTip1;
        private GroupBox gbLogin;
        private IconButton btnLogin;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCrearCuenta;
        private Panel panel1;
        private Label label1;
    }
}