namespace Prototipo.Vistas
{
    partial class VistaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCliente));
            panel1 = new Panel();
            customButton1 = new Prototipo.Custom_Controls.CustomButton();
            pbCaratula1 = new PictureBox();
            pbCaratula2 = new PictureBox();
            pbCaratula3 = new PictureBox();
            pbcaratula4 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaratula1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbcaratula4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Controls.Add(customButton1);
            panel1.Location = new Point(-3, -1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 38);
            panel1.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.BlueViolet;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Image = (Image)resources.GetObject("customButton1.Image");
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(708, -2);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 0;
            customButton1.Text = "Iniciar sesión";
            customButton1.TextAlign = ContentAlignment.MiddleRight;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // pbCaratula1
            // 
            pbCaratula1.BackColor = SystemColors.ActiveCaption;
            pbCaratula1.Cursor = Cursors.Hand;
            pbCaratula1.Location = new Point(37, 131);
            pbCaratula1.Name = "pbCaratula1";
            pbCaratula1.Size = new Size(139, 204);
            pbCaratula1.TabIndex = 1;
            pbCaratula1.TabStop = false;
            pbCaratula1.Tag = "";
            // 
            // pbCaratula2
            // 
            pbCaratula2.BackColor = SystemColors.ActiveCaption;
            pbCaratula2.Cursor = Cursors.Hand;
            pbCaratula2.Location = new Point(252, 131);
            pbCaratula2.Name = "pbCaratula2";
            pbCaratula2.Size = new Size(139, 204);
            pbCaratula2.TabIndex = 2;
            pbCaratula2.TabStop = false;
            // 
            // pbCaratula3
            // 
            pbCaratula3.BackColor = SystemColors.ActiveCaption;
            pbCaratula3.Cursor = Cursors.Hand;
            pbCaratula3.Location = new Point(468, 131);
            pbCaratula3.Name = "pbCaratula3";
            pbCaratula3.Size = new Size(139, 204);
            pbCaratula3.TabIndex = 3;
            pbCaratula3.TabStop = false;
            // 
            // pbcaratula4
            // 
            pbcaratula4.BackColor = SystemColors.ActiveCaption;
            pbcaratula4.Cursor = Cursors.Hand;
            pbcaratula4.Location = new Point(680, 131);
            pbcaratula4.Name = "pbcaratula4";
            pbcaratula4.Size = new Size(139, 204);
            pbcaratula4.TabIndex = 4;
            pbcaratula4.TabStop = false;
            pbcaratula4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 88);
            label1.Name = "label1";
            label1.Size = new Size(213, 23);
            label1.TabIndex = 5;
            label1.Text = "Peliculas en cartelera";
            // 
            // VistaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(854, 789);
            Controls.Add(label1);
            Controls.Add(pbcaratula4);
            Controls.Add(pbCaratula3);
            Controls.Add(pbCaratula2);
            Controls.Add(pbCaratula1);
            Controls.Add(panel1);
            Name = "VistaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += VistaCliente_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCaratula1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbcaratula4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbCaratula1;
        private PictureBox pbCaratula2;
        private PictureBox pbCaratula3;
        private PictureBox pbcaratula4;
        private Label label1;
        private Custom_Controls.CustomButton customButton1;
    }
}