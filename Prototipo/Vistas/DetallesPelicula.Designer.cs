namespace Prototipo.Vistas
{
    partial class DetallesPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesPelicula));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pbGenero = new PictureBox();
            pbIdioma = new PictureBox();
            pbRating = new PictureBox();
            pbDuracion = new PictureBox();
            lblGenero = new Label();
            btnComprarBoletos = new Prototipo.Custom_Controls.CustomButton();
            txtDescripcion = new TextBox();
            lblIdioma = new Label();
            lblClasificacion = new Label();
            lblDuracion = new Label();
            pbCaratula = new PictureBox();
            lblTitulo = new Label();
            panel2 = new Panel();
            btnRegresar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGenero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIdioma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 793);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbGenero);
            groupBox1.Controls.Add(pbIdioma);
            groupBox1.Controls.Add(pbRating);
            groupBox1.Controls.Add(pbDuracion);
            groupBox1.Controls.Add(lblGenero);
            groupBox1.Controls.Add(btnComprarBoletos);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(lblIdioma);
            groupBox1.Controls.Add(lblClasificacion);
            groupBox1.Controls.Add(lblDuracion);
            groupBox1.Controls.Add(pbCaratula);
            groupBox1.Controls.Add(lblTitulo);
            groupBox1.Location = new Point(24, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 706);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // pbGenero
            // 
            pbGenero.Location = new Point(211, 244);
            pbGenero.Name = "pbGenero";
            pbGenero.Size = new Size(29, 29);
            pbGenero.TabIndex = 11;
            pbGenero.TabStop = false;
            // 
            // pbIdioma
            // 
            pbIdioma.Location = new Point(211, 192);
            pbIdioma.Name = "pbIdioma";
            pbIdioma.Size = new Size(29, 29);
            pbIdioma.TabIndex = 10;
            pbIdioma.TabStop = false;
            // 
            // pbRating
            // 
            pbRating.Location = new Point(211, 145);
            pbRating.Name = "pbRating";
            pbRating.Size = new Size(29, 29);
            pbRating.TabIndex = 9;
            pbRating.TabStop = false;
            // 
            // pbDuracion
            // 
            pbDuracion.Location = new Point(211, 98);
            pbDuracion.Name = "pbDuracion";
            pbDuracion.Size = new Size(29, 29);
            pbDuracion.TabIndex = 8;
            pbDuracion.TabStop = false;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Roboto", 12F);
            lblGenero.Location = new Point(262, 226);
            lblGenero.Name = "lblGenero";
            lblGenero.Padding = new Padding(0, 22, 0, 22);
            lblGenero.Size = new Size(77, 63);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "lblGenero";
            // 
            // btnComprarBoletos
            // 
            btnComprarBoletos.BackColor = Color.DarkOrchid;
            btnComprarBoletos.FlatAppearance.BorderSize = 0;
            btnComprarBoletos.FlatStyle = FlatStyle.Flat;
            btnComprarBoletos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprarBoletos.ForeColor = Color.White;
            btnComprarBoletos.Image = (Image)resources.GetObject("btnComprarBoletos.Image");
            btnComprarBoletos.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprarBoletos.Location = new Point(7, 308);
            btnComprarBoletos.Name = "btnComprarBoletos";
            btnComprarBoletos.Size = new Size(168, 44);
            btnComprarBoletos.TabIndex = 6;
            btnComprarBoletos.Text = "Comprar boletos";
            btnComprarBoletos.TextAlign = ContentAlignment.MiddleRight;
            btnComprarBoletos.UseVisualStyleBackColor = false;
            btnComprarBoletos.Click += btnComprarBoletos_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.GhostWhite;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(262, 292);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(363, 196);
            txtDescripcion.TabIndex = 5;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Font = new Font("Roboto", 12F);
            lblIdioma.Location = new Point(262, 176);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Padding = new Padding(0, 22, 0, 22);
            lblIdioma.Size = new Size(76, 63);
            lblIdioma.TabIndex = 4;
            lblIdioma.Text = "lblIdioma";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Roboto", 12F);
            lblClasificacion.Location = new Point(262, 129);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Padding = new Padding(0, 22, 0, 22);
            lblClasificacion.Size = new Size(117, 63);
            lblClasificacion.TabIndex = 3;
            lblClasificacion.Text = "lblClasificacion";
            lblClasificacion.Click += label3_Click;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Roboto", 12F);
            lblDuracion.Location = new Point(262, 84);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Padding = new Padding(0, 22, 0, 22);
            lblDuracion.Size = new Size(91, 63);
            lblDuracion.TabIndex = 2;
            lblDuracion.Text = "lblDuracion";
            // 
            // pbCaratula
            // 
            pbCaratula.BackColor = SystemColors.AppWorkspace;
            pbCaratula.Location = new Point(18, 98);
            pbCaratula.Name = "pbCaratula";
            pbCaratula.Size = new Size(139, 204);
            pbCaratula.TabIndex = 1;
            pbCaratula.TabStop = false;
            pbCaratula.Click += pbCaratula_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(18, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(17, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.Controls.Add(btnRegresar);
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 38);
            panel2.TabIndex = 1;
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
            // DetallesPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(854, 789);
            Controls.Add(panel1);
            Name = "DetallesPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetallesPelicula";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGenero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIdioma).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label lblTitulo;
        private Panel panel2;
        private PictureBox pbCaratula;
        private Label lblClasificacion;
        private Label lblDuracion;
        private Label lblIdioma;
        private TextBox txtDescripcion;
        private Custom_Controls.CustomButton btnComprarBoletos;
        private Button btnRegresar;
        private Label lblGenero;
        private PictureBox pbGenero;
        private PictureBox pbIdioma;
        private PictureBox pbRating;
        private PictureBox pbDuracion;
    }
}