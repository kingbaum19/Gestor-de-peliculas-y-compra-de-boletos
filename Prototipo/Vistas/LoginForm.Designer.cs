namespace Prototipo
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            btnLogin = new Button();
            lblRegister = new Label();
            lblRecuperarContraseña = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 124);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 561);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 124);
            label2.Name = "label2";
            label2.Size = new Size(525, 32);
            label2.TabIndex = 3;
            label2.Text = "Bienvenido al portal de administrador";
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(348, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(427, 23);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "Correo electrónico";
            // 
            // txtContraseña
            // 
            txtContraseña.ForeColor = Color.DarkGray;
            txtContraseña.Location = new Point(348, 272);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(427, 23);
            txtContraseña.TabIndex = 5;
            txtContraseña.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(502, 365);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.ForeColor = Color.RoyalBlue;
            lblRegister.Location = new Point(481, 337);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(163, 15);
            lblRegister.TabIndex = 7;
            lblRegister.Text = "¿Eres nuevo? Crea una cuenta";
            // 
            // lblRecuperarContraseña
            // 
            lblRecuperarContraseña.AutoSize = true;
            lblRecuperarContraseña.ForeColor = Color.RoyalBlue;
            lblRecuperarContraseña.Location = new Point(478, 406);
            lblRecuperarContraseña.Name = "lblRecuperarContraseña";
            lblRecuperarContraseña.Size = new Size(166, 15);
            lblRecuperarContraseña.TabIndex = 8;
            lblRecuperarContraseña.Text = "¿Se le ha olvido la contraseña?";
            lblRecuperarContraseña.Click += label4_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(748, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(106, 39);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(854, 561);
            Controls.Add(btnSalir);
            Controls.Add(lblRecuperarContraseña);
            Controls.Add(lblRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Button btnLogin;
        private Label lblRegister;
        private Label lblRecuperarContraseña;
        private Button btnSalir;
    }
}
