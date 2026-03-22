namespace Prototipo.Vistas
{
    partial class CompraBoletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraBoletos));
            panel1 = new Panel();
            btnComprar = new Prototipo.Custom_Controls.CustomButton();
            lblPrecioTotal = new Label();
            lblBoletos = new Label();
            lblSeleccionPelicula = new Label();
            cmbPago = new ComboBox();
            txtEmail = new Prototipo.Custom_Controls.CustomTextbox();
            txtApellido = new Prototipo.Custom_Controls.CustomTextbox();
            txtNombre = new Prototipo.Custom_Controls.CustomTextbox();
            label1 = new Label();
            panel2 = new Panel();
            btnRegresar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(btnComprar);
            panel1.Controls.Add(lblPrecioTotal);
            panel1.Controls.Add(lblBoletos);
            panel1.Controls.Add(lblSeleccionPelicula);
            panel1.Controls.Add(cmbPago);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 794);
            panel1.TabIndex = 0;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.DarkOrchid;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.ForeColor = Color.White;
            btnComprar.Image = (Image)resources.GetObject("btnComprar.Image");
            btnComprar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprar.Location = new Point(334, 529);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(166, 40);
            btnComprar.TabIndex = 13;
            btnComprar.Text = "Comprar Boleto";
            btnComprar.TextAlign = ContentAlignment.MiddleRight;
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioTotal.Location = new Point(73, 439);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(93, 20);
            lblPrecioTotal.TabIndex = 12;
            lblPrecioTotal.Text = "Precio total:";
            // 
            // lblBoletos
            // 
            lblBoletos.AutoSize = true;
            lblBoletos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoletos.Location = new Point(73, 387);
            lblBoletos.Name = "lblBoletos";
            lblBoletos.Size = new Size(166, 20);
            lblBoletos.TabIndex = 11;
            lblBoletos.Text = "Boletos seleccionados:";
            lblBoletos.Click += lblBoletos_Click;
            // 
            // lblSeleccionPelicula
            // 
            lblSeleccionPelicula.AutoSize = true;
            lblSeleccionPelicula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccionPelicula.Location = new Point(73, 335);
            lblSeleccionPelicula.Name = "lblSeleccionPelicula";
            lblSeleccionPelicula.Size = new Size(162, 20);
            lblSeleccionPelicula.TabIndex = 10;
            lblSeleccionPelicula.Text = "Pelicula seleccionada: ";
            // 
            // cmbPago
            // 
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.FormattingEnabled = true;
            cmbPago.Items.AddRange(new object[] { "Tarjeta de crédito", "Tarjeta de débito", "VISA", "Mastercard" });
            cmbPago.Location = new Point(512, 257);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(269, 23);
            cmbPago.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.DarkOrchid;
            txtEmail.BorderFocusColor = Color.SkyBlue;
            txtEmail.BorderRadius = 0;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = SystemColors.GrayText;
            txtEmail.Location = new Point(73, 246);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "Correo electronico";
            txtEmail.Size = new Size(250, 34);
            txtEmail.TabIndex = 8;
            txtEmail.Texto = "";
            txtEmail.UnderlinedStyle = true;
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
            txtApellido.Location = new Point(512, 166);
            txtApellido.MaxLength = 32767;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Padding = new Padding(7);
            txtApellido.PasswordChar = false;
            txtApellido.PlaceholderColor = Color.DarkGray;
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(269, 34);
            txtApellido.TabIndex = 7;
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
            txtNombre.Location = new Point(73, 166);
            txtNombre.MaxLength = 32767;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.DarkGray;
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(250, 34);
            txtNombre.TabIndex = 6;
            txtNombre.Texto = "";
            txtNombre.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 95);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 5;
            label1.Text = "Información personal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.Controls.Add(btnRegresar);
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 38);
            panel2.TabIndex = 4;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(-2, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(41, 42);
            btnRegresar.TabIndex = 6;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // CompraBoletos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(854, 789);
            Controls.Add(panel1);
            Name = "CompraBoletos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompraBoletos";
            Load += CompraBoletos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRegresar;
        private Label label1;
        private Custom_Controls.CustomTextbox txtNombre;
        private Custom_Controls.CustomTextbox txtEmail;
        private Custom_Controls.CustomTextbox txtApellido;
        private ComboBox cmbPago;
        private Custom_Controls.CustomButton btnComprar;
        private Label lblPrecioTotal;
        private Label lblBoletos;
        private Label lblSeleccionPelicula;
    }
}