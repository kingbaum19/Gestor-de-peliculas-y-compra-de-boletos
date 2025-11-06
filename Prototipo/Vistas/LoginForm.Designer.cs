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
            label2 = new Label();
            lblRegister = new Label();
            lblRecuperarContraseña = new Label();
            btnSalir = new Button();
            txtCorreo = new Prototipo.Custom_Controls.CustomTextbox();
            txtContraseña = new Prototipo.Custom_Controls.CustomTextbox();
            btnIniciarSesion = new Prototipo.Custom_Controls.CustomButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.ForeColor = Color.RoyalBlue;
            lblRegister.Location = new Point(499, 334);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(163, 15);
            lblRegister.TabIndex = 7;
            lblRegister.Text = "¿Eres nuevo? Crea una cuenta";
            // 
            // lblRecuperarContraseña
            // 
            lblRecuperarContraseña.AutoSize = true;
            lblRecuperarContraseña.ForeColor = Color.RoyalBlue;
            lblRecuperarContraseña.Location = new Point(496, 412);
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
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.Window;
            txtCorreo.BorderColor = Color.DarkViolet;
            txtCorreo.BorderFocusColor = SystemColors.MenuHighlight;
            txtCorreo.BorderRadius = 0;
            txtCorreo.BorderSize = 2;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.ForeColor = SystemColors.WindowText;
            txtCorreo.Location = new Point(345, 182);
            txtCorreo.MaxLength = 32767;
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(7);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderColor = Color.DarkGray;
            txtCorreo.PlaceholderText = "Correo electrónico";
            txtCorreo.Size = new Size(457, 34);
            txtCorreo.TabIndex = 10;
            txtCorreo.Texto = "";
            txtCorreo.UnderlinedStyle = true;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.Window;
            txtContraseña.BorderColor = Color.DarkOrchid;
            txtContraseña.BorderFocusColor = SystemColors.MenuHighlight;
            txtContraseña.BorderRadius = 0;
            txtContraseña.BorderSize = 2;
            txtContraseña.Font = new Font("Segoe UI", 10F);
            txtContraseña.ForeColor = SystemColors.WindowText;
            txtContraseña.Location = new Point(345, 261);
            txtContraseña.MaxLength = 32767;
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(7);
            txtContraseña.PasswordChar = true;
            txtContraseña.PlaceholderColor = Color.DarkGray;
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(457, 34);
            txtContraseña.TabIndex = 12;
            txtContraseña.Texto = "";
            txtContraseña.UnderlinedStyle = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.BlueViolet;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(499, 361);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(163, 40);
            btnIniciarSesion.TabIndex = 13;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += customButton1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 561);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(854, 561);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(btnSalir);
            Controls.Add(lblRecuperarContraseña);
            Controls.Add(lblRegister);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label lblRegister;
        private Label lblRecuperarContraseña;
        private Button btnSalir;
        private Custom_Controls.CustomTextbox txtCorreo;
        private Custom_Controls.CustomTextbox txtContraseña;
        private Custom_Controls.CustomButton btnIniciarSesion;
        private PictureBox pictureBox1;
    }
}
