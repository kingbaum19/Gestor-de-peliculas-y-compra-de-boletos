namespace Prototipo.Vistas
{
    partial class SeleccionarBoletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarBoletos));
            panel1 = new Panel();
            lblPrecio = new Label();
            label12 = new Label();
            customButton1 = new Prototipo.Custom_Controls.CustomButton();
            gbBoletos = new GroupBox();
            lblTicketJubilado = new Label();
            lblTicketNiño = new Label();
            lblTicketAdulto = new Label();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnReducirJubilado = new Button();
            btnReducirNiño = new Button();
            btnAumentarJubilado = new Button();
            btnAumentarNiño = new Button();
            btnReducirAdulto = new Button();
            btnAumentarAdulto = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnRegresar = new Button();
            panel1.SuspendLayout();
            gbBoletos.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(customButton1);
            panel1.Controls.Add(gbBoletos);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 792);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(128, 615);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(22, 23);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(57, 615);
            label12.Name = "label12";
            label12.Size = new Size(65, 23);
            label12.TabIndex = 5;
            label12.Text = "Total:";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DarkOrchid;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(677, 668);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 4;
            customButton1.Text = "Continuar";
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // gbBoletos
            // 
            gbBoletos.BackgroundImageLayout = ImageLayout.None;
            gbBoletos.Controls.Add(lblTicketJubilado);
            gbBoletos.Controls.Add(lblTicketNiño);
            gbBoletos.Controls.Add(lblTicketAdulto);
            gbBoletos.Controls.Add(label11);
            gbBoletos.Controls.Add(label9);
            gbBoletos.Controls.Add(label10);
            gbBoletos.Controls.Add(btnReducirJubilado);
            gbBoletos.Controls.Add(btnReducirNiño);
            gbBoletos.Controls.Add(btnAumentarJubilado);
            gbBoletos.Controls.Add(btnAumentarNiño);
            gbBoletos.Controls.Add(btnReducirAdulto);
            gbBoletos.Controls.Add(btnAumentarAdulto);
            gbBoletos.Controls.Add(label8);
            gbBoletos.Controls.Add(label7);
            gbBoletos.Controls.Add(label6);
            gbBoletos.Controls.Add(label5);
            gbBoletos.Controls.Add(label4);
            gbBoletos.Controls.Add(label3);
            gbBoletos.Controls.Add(label2);
            gbBoletos.Controls.Add(label1);
            gbBoletos.FlatStyle = FlatStyle.Flat;
            gbBoletos.Location = new Point(57, 118);
            gbBoletos.Name = "gbBoletos";
            gbBoletos.Size = new Size(744, 383);
            gbBoletos.TabIndex = 3;
            gbBoletos.TabStop = false;
            // 
            // lblTicketJubilado
            // 
            lblTicketJubilado.AutoSize = true;
            lblTicketJubilado.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketJubilado.Location = new Point(586, 264);
            lblTicketJubilado.Name = "lblTicketJubilado";
            lblTicketJubilado.Size = new Size(18, 18);
            lblTicketJubilado.TabIndex = 17;
            lblTicketJubilado.Text = "0";
            // 
            // lblTicketNiño
            // 
            lblTicketNiño.AutoSize = true;
            lblTicketNiño.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketNiño.Location = new Point(586, 196);
            lblTicketNiño.Name = "lblTicketNiño";
            lblTicketNiño.Size = new Size(18, 18);
            lblTicketNiño.TabIndex = 16;
            lblTicketNiño.Text = "0";
            // 
            // lblTicketAdulto
            // 
            lblTicketAdulto.AutoSize = true;
            lblTicketAdulto.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketAdulto.Location = new Point(586, 132);
            lblTicketAdulto.Name = "lblTicketAdulto";
            lblTicketAdulto.Size = new Size(18, 18);
            lblTicketAdulto.TabIndex = 15;
            lblTicketAdulto.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(580, 268);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(580, 200);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 4;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(580, 135);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 5;
            // 
            // btnReducirJubilado
            // 
            btnReducirJubilado.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReducirJubilado.Location = new Point(475, 255);
            btnReducirJubilado.Name = "btnReducirJubilado";
            btnReducirJubilado.Size = new Size(82, 32);
            btnReducirJubilado.TabIndex = 13;
            btnReducirJubilado.Text = "-";
            btnReducirJubilado.UseVisualStyleBackColor = true;
            btnReducirJubilado.Click += btnReducirJubilado_Click;
            // 
            // btnReducirNiño
            // 
            btnReducirNiño.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReducirNiño.Location = new Point(475, 192);
            btnReducirNiño.Name = "btnReducirNiño";
            btnReducirNiño.Size = new Size(82, 32);
            btnReducirNiño.TabIndex = 12;
            btnReducirNiño.Text = "-";
            btnReducirNiño.UseVisualStyleBackColor = true;
            btnReducirNiño.Click += btnReducirNiño_Click;
            // 
            // btnAumentarJubilado
            // 
            btnAumentarJubilado.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAumentarJubilado.Location = new Point(630, 255);
            btnAumentarJubilado.Name = "btnAumentarJubilado";
            btnAumentarJubilado.Size = new Size(82, 32);
            btnAumentarJubilado.TabIndex = 11;
            btnAumentarJubilado.Text = "+";
            btnAumentarJubilado.UseVisualStyleBackColor = true;
            btnAumentarJubilado.Click += btnAumentarJubilado_Click;
            // 
            // btnAumentarNiño
            // 
            btnAumentarNiño.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAumentarNiño.Location = new Point(630, 192);
            btnAumentarNiño.Name = "btnAumentarNiño";
            btnAumentarNiño.Size = new Size(82, 32);
            btnAumentarNiño.TabIndex = 10;
            btnAumentarNiño.Text = "+";
            btnAumentarNiño.UseVisualStyleBackColor = true;
            btnAumentarNiño.Click += btnAumentarNiño_Click;
            // 
            // btnReducirAdulto
            // 
            btnReducirAdulto.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReducirAdulto.Location = new Point(475, 123);
            btnReducirAdulto.Name = "btnReducirAdulto";
            btnReducirAdulto.Size = new Size(82, 32);
            btnReducirAdulto.TabIndex = 9;
            btnReducirAdulto.Text = "-";
            btnReducirAdulto.UseVisualStyleBackColor = true;
            btnReducirAdulto.Click += btnReducirAdulto_Click;
            // 
            // btnAumentarAdulto
            // 
            btnAumentarAdulto.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAumentarAdulto.Location = new Point(630, 123);
            btnAumentarAdulto.Name = "btnAumentarAdulto";
            btnAumentarAdulto.Size = new Size(82, 32);
            btnAumentarAdulto.TabIndex = 8;
            btnAumentarAdulto.Text = "+";
            btnAumentarAdulto.UseVisualStyleBackColor = true;
            btnAumentarAdulto.Click += btnAumentarAdulto_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(336, 260);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 7;
            label8.Text = "B/. 3.50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(336, 192);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 6;
            label7.Text = "B/. 5.75";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(336, 128);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 5;
            label6.Text = "B/. 7.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 260);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 4;
            label5.Text = "Jubilado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 192);
            label4.Name = "label4";
            label4.Size = new Size(176, 23);
            label4.TabIndex = 3;
            label4.Text = "Niño (1-12 años)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 128);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 2;
            label3.Text = "Adulto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 51);
            label2.Name = "label2";
            label2.Size = new Size(403, 16);
            label2.TabIndex = 1;
            label2.Text = "Puede seleccionar un máximo de 10 boletos por transacción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 19);
            label1.Name = "label1";
            label1.Size = new Size(228, 23);
            label1.TabIndex = 0;
            label1.Text = "Seleccione sus boletos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.Controls.Add(btnRegresar);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 38);
            panel2.TabIndex = 2;
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
            // SeleccionarBoletos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(854, 789);
            Controls.Add(panel1);
            Name = "SeleccionarBoletos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompraBoletos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbBoletos.ResumeLayout(false);
            gbBoletos.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRegresar;
        private GroupBox gbBoletos;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnReducirJubilado;
        private Button btnReducirNiño;
        private Button btnAumentarJubilado;
        private Button btnAumentarNiño;
        private Button btnReducirAdulto;
        private Button btnAumentarAdulto;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label10;
        private Custom_Controls.CustomButton customButton1;
        private Label label11;
        private Label lblTicketJubilado;
        private Label lblTicketNiño;
        private Label lblTicketAdulto;
        private Label label12;
        private Label lblPrecio;
    }
}