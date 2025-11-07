namespace Prototipo.Vistas
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            btnRegresar = new Button();
            btnCrearUsuario = new Prototipo.Custom_Controls.CustomButton();
            txtContraseña = new Prototipo.Custom_Controls.CustomTextbox();
            txtCorreo = new Prototipo.Custom_Controls.CustomTextbox();
            txtApellido = new Prototipo.Custom_Controls.CustomTextbox();
            txtNombre = new Prototipo.Custom_Controls.CustomTextbox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtConfirmarContraseña = new Prototipo.Custom_Controls.CustomTextbox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtConfirmarContraseña);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnCrearUsuario);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 564);
            panel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.None;
            btnRegresar.Location = new Point(810, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(44, 43);
            btnRegresar.TabIndex = 39;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.DarkOrchid;
            btnCrearUsuario.FlatAppearance.BorderSize = 0;
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearUsuario.ForeColor = Color.White;
            btnCrearUsuario.Location = new Point(492, 474);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(150, 40);
            btnCrearUsuario.TabIndex = 21;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.Window;
            txtContraseña.BorderColor = Color.DarkOrchid;
            txtContraseña.BorderFocusColor = Color.SkyBlue;
            txtContraseña.BorderRadius = 0;
            txtContraseña.BorderSize = 2;
            txtContraseña.Font = new Font("Segoe UI", 10F);
            txtContraseña.ForeColor = SystemColors.GrayText;
            txtContraseña.Location = new Point(436, 334);
            txtContraseña.MaxLength = 32767;
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(7);
            txtContraseña.PasswordChar = true;
            txtContraseña.PlaceholderColor = Color.DarkGray;
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(250, 34);
            txtContraseña.TabIndex = 20;
            txtContraseña.Texto = "";
            txtContraseña.UnderlinedStyle = true;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.Window;
            txtCorreo.BorderColor = Color.DarkOrchid;
            txtCorreo.BorderFocusColor = Color.SkyBlue;
            txtCorreo.BorderRadius = 0;
            txtCorreo.BorderSize = 2;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.ForeColor = SystemColors.GrayText;
            txtCorreo.Location = new Point(436, 258);
            txtCorreo.MaxLength = 32767;
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(7);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderColor = Color.DarkGray;
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(250, 34);
            txtCorreo.TabIndex = 19;
            txtCorreo.Texto = "";
            txtCorreo.UnderlinedStyle = true;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.Window;
            txtApellido.BorderColor = Color.DarkOrchid;
            txtApellido.BorderFocusColor = Color.SkyBlue;
            txtApellido.BorderRadius = 0;
            txtApellido.BorderSize = 2;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.ForeColor = SystemColors.GrayText;
            txtApellido.Location = new Point(436, 192);
            txtApellido.MaxLength = 32767;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Padding = new Padding(7);
            txtApellido.PasswordChar = false;
            txtApellido.PlaceholderColor = Color.DarkGray;
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(250, 34);
            txtApellido.TabIndex = 18;
            txtApellido.Texto = "";
            txtApellido.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.BorderColor = Color.DarkOrchid;
            txtNombre.BorderFocusColor = Color.SkyBlue;
            txtNombre.BorderRadius = 0;
            txtNombre.BorderSize = 2;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = SystemColors.GrayText;
            txtNombre.Location = new Point(436, 130);
            txtNombre.MaxLength = 32767;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.DarkGray;
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(250, 34);
            txtNombre.TabIndex = 17;
            txtNombre.Texto = "";
            txtNombre.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 72);
            label1.Name = "label1";
            label1.Size = new Size(531, 32);
            label1.TabIndex = 16;
            label1.Text = "Registro de creación de administrador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 561);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.BackColor = SystemColors.Window;
            txtConfirmarContraseña.BorderColor = Color.DarkOrchid;
            txtConfirmarContraseña.BorderFocusColor = Color.SkyBlue;
            txtConfirmarContraseña.BorderRadius = 0;
            txtConfirmarContraseña.BorderSize = 2;
            txtConfirmarContraseña.Font = new Font("Segoe UI", 10F);
            txtConfirmarContraseña.ForeColor = SystemColors.GrayText;
            txtConfirmarContraseña.Location = new Point(436, 404);
            txtConfirmarContraseña.MaxLength = 32767;
            txtConfirmarContraseña.Multiline = false;
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Padding = new Padding(7);
            txtConfirmarContraseña.PasswordChar = true;
            txtConfirmarContraseña.PlaceholderColor = Color.DarkGray;
            txtConfirmarContraseña.PlaceholderText = "Confirmar contraseña";
            txtConfirmarContraseña.Size = new Size(250, 34);
            txtConfirmarContraseña.TabIndex = 41;
            txtConfirmarContraseña.Texto = "";
            txtConfirmarContraseña.UnderlinedStyle = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 561);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Custom_Controls.CustomButton btnCrearUsuario;
        private Custom_Controls.CustomTextbox txtContraseña;
        private Custom_Controls.CustomTextbox txtCorreo;
        private Custom_Controls.CustomTextbox txtApellido;
        private Custom_Controls.CustomTextbox txtNombre;
        private Button btnRegresar;
        private PictureBox pictureBox1;
        private Custom_Controls.CustomTextbox txtConfirmarContraseña;
    }
}