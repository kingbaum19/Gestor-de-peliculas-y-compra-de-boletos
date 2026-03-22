namespace Prototipo.Vistas
{
    partial class VistaTablas
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
            panel1 = new Panel();
            lblTitulo = new Label();
            dgvTablaPeliculas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaPeliculas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(dgvTablaPeliculas);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 955);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(313, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Tabla de peliculas";
            // 
            // dgvTablaPeliculas
            // 
            dgvTablaPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaPeliculas.Location = new Point(14, 94);
            dgvTablaPeliculas.Name = "dgvTablaPeliculas";
            dgvTablaPeliculas.ReadOnly = true;
            dgvTablaPeliculas.Size = new Size(830, 690);
            dgvTablaPeliculas.TabIndex = 0;
            // 
            // VistaTablas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 949);
            Controls.Add(panel1);
            Name = "VistaTablas";
            Text = "VistaTablas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaPeliculas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private DataGridView dgvTablaPeliculas;
    }
}