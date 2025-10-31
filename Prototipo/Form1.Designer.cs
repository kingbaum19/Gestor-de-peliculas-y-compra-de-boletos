namespace Prototipo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtEmail = new TextBox();
            textBox1 = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
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
            // textBox1
            // 
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(348, 272);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(427, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Contraseña";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(481, 337);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 7;
            label3.Text = "¿Eres nuevo? Crea una cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(478, 406);
            label4.Name = "label4";
            label4.Size = new Size(166, 15);
            label4.TabIndex = 8;
            label4.Text = "¿Se le ha olvido la contraseña?";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(748, 0);
            button2.Name = "button2";
            button2.Size = new Size(106, 39);
            button2.TabIndex = 9;
            button2.Text = "Salir";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(854, 561);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button btnLogin;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
