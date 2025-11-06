namespace Prototipo
{
    partial class PeliculasCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeliculasCRUD));
            panel1 = new Panel();
            btnRegresar = new Button();
            txtDescripcion = new Prototipo.Custom_Controls.CustomTextbox();
            txtFechaSalida = new Prototipo.Custom_Controls.CustomTextbox();
            txtFechaEstreno = new Prototipo.Custom_Controls.CustomTextbox();
            txtDuracion = new Prototipo.Custom_Controls.CustomTextbox();
            txtNombre = new Prototipo.Custom_Controls.CustomTextbox();
            btnSubirCaratula = new Prototipo.Custom_Controls.CustomButton();
            btnEliminar = new Prototipo.Custom_Controls.CustomButton();
            btnModificar = new Prototipo.Custom_Controls.CustomButton();
            btnGuardar = new Prototipo.Custom_Controls.CustomButton();
            label11 = new Label();
            label10 = new Label();
            cmbEstatus = new ComboBox();
            label9 = new Label();
            dgvPeliculas = new DataGridView();
            pbCaratula = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            cmbGenero = new ComboBox();
            label6 = new Label();
            cmbIdioma = new ComboBox();
            label5 = new Label();
            cmbClasificacion = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            ediciónDePelículasToolStripMenuItem = new ToolStripMenuItem();
            listaDePeliculasToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtFechaSalida);
            panel1.Controls.Add(txtFechaEstreno);
            panel1.Controls.Add(txtDuracion);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnSubirCaratula);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cmbEstatus);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dgvPeliculas);
            panel1.Controls.Add(pbCaratula);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbIdioma);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbClasificacion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 954);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.None;
            btnRegresar.Location = new Point(812, 25);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(44, 43);
            btnRegresar.TabIndex = 38;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Window;
            txtDescripcion.BorderColor = Color.BlueViolet;
            txtDescripcion.BorderFocusColor = SystemColors.MenuHighlight;
            txtDescripcion.BorderRadius = 20;
            txtDescripcion.BorderSize = 2;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = SystemColors.GrayText;
            txtDescripcion.Location = new Point(156, 483);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(7);
            txtDescripcion.PasswordChar = false;
            txtDescripcion.PlaceholderColor = Color.DarkGray;
            txtDescripcion.PlaceholderText = "¿De qué va la película?";
            txtDescripcion.Size = new Size(403, 130);
            txtDescripcion.TabIndex = 37;
            txtDescripcion.Texto = "";
            txtDescripcion.UnderlinedStyle = false;
            // 
            // txtFechaSalida
            // 
            txtFechaSalida.BackColor = SystemColors.Window;
            txtFechaSalida.BorderColor = Color.BlueViolet;
            txtFechaSalida.BorderFocusColor = SystemColors.MenuHighlight;
            txtFechaSalida.BorderRadius = 20;
            txtFechaSalida.BorderSize = 2;
            txtFechaSalida.Font = new Font("Segoe UI", 10F);
            txtFechaSalida.ForeColor = SystemColors.GrayText;
            txtFechaSalida.Location = new Point(156, 349);
            txtFechaSalida.MaxLength = 32767;
            txtFechaSalida.Multiline = false;
            txtFechaSalida.Name = "txtFechaSalida";
            txtFechaSalida.Padding = new Padding(7);
            txtFechaSalida.PasswordChar = false;
            txtFechaSalida.PlaceholderColor = Color.DarkGray;
            txtFechaSalida.PlaceholderText = "dd/mm/yyyy";
            txtFechaSalida.Size = new Size(250, 34);
            txtFechaSalida.TabIndex = 36;
            txtFechaSalida.Texto = "";
            txtFechaSalida.UnderlinedStyle = false;
            // 
            // txtFechaEstreno
            // 
            txtFechaEstreno.BackColor = SystemColors.Window;
            txtFechaEstreno.BorderColor = Color.BlueViolet;
            txtFechaEstreno.BorderFocusColor = SystemColors.MenuHighlight;
            txtFechaEstreno.BorderRadius = 20;
            txtFechaEstreno.BorderSize = 2;
            txtFechaEstreno.Font = new Font("Segoe UI", 10F);
            txtFechaEstreno.ForeColor = SystemColors.GrayText;
            txtFechaEstreno.Location = new Point(156, 298);
            txtFechaEstreno.MaxLength = 32767;
            txtFechaEstreno.Multiline = true;
            txtFechaEstreno.Name = "txtFechaEstreno";
            txtFechaEstreno.Padding = new Padding(7);
            txtFechaEstreno.PasswordChar = false;
            txtFechaEstreno.PlaceholderColor = Color.DarkGray;
            txtFechaEstreno.PlaceholderText = "dd/mm/yyyy";
            txtFechaEstreno.Size = new Size(250, 34);
            txtFechaEstreno.TabIndex = 35;
            txtFechaEstreno.Texto = "";
            txtFechaEstreno.UnderlinedStyle = false;
            // 
            // txtDuracion
            // 
            txtDuracion.BackColor = SystemColors.Window;
            txtDuracion.BorderColor = Color.BlueViolet;
            txtDuracion.BorderFocusColor = SystemColors.MenuHighlight;
            txtDuracion.BorderRadius = 20;
            txtDuracion.BorderSize = 2;
            txtDuracion.Font = new Font("Segoe UI", 10F);
            txtDuracion.ForeColor = SystemColors.GrayText;
            txtDuracion.Location = new Point(156, 152);
            txtDuracion.MaxLength = 32767;
            txtDuracion.Multiline = false;
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Padding = new Padding(7);
            txtDuracion.PasswordChar = false;
            txtDuracion.PlaceholderColor = Color.DarkGray;
            txtDuracion.PlaceholderText = "¿Cuánto dura la película?";
            txtDuracion.Size = new Size(250, 34);
            txtDuracion.TabIndex = 34;
            txtDuracion.Texto = "";
            txtDuracion.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.BorderColor = Color.BlueViolet;
            txtNombre.BorderFocusColor = SystemColors.MenuHighlight;
            txtNombre.BorderRadius = 20;
            txtNombre.BorderSize = 2;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = SystemColors.GrayText;
            txtNombre.Location = new Point(156, 100);
            txtNombre.MaxLength = 32767;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.DarkGray;
            txtNombre.PlaceholderText = "Nombre de la película";
            txtNombre.Size = new Size(250, 34);
            txtNombre.TabIndex = 33;
            txtNombre.Texto = "";
            txtNombre.UnderlinedStyle = false;
            // 
            // btnSubirCaratula
            // 
            btnSubirCaratula.BackColor = Color.BlueViolet;
            btnSubirCaratula.FlatAppearance.BorderSize = 0;
            btnSubirCaratula.FlatStyle = FlatStyle.Flat;
            btnSubirCaratula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirCaratula.ForeColor = Color.White;
            btnSubirCaratula.Image = (Image)resources.GetObject("btnSubirCaratula.Image");
            btnSubirCaratula.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubirCaratula.Location = new Point(642, 352);
            btnSubirCaratula.Name = "btnSubirCaratula";
            btnSubirCaratula.Size = new Size(160, 43);
            btnSubirCaratula.TabIndex = 32;
            btnSubirCaratula.Text = "Subir carátula";
            btnSubirCaratula.TextAlign = ContentAlignment.MiddleRight;
            btnSubirCaratula.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.BlueViolet;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(642, 559);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 43);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar datos";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.BlueViolet;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(642, 500);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(165, 43);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar datos";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.BlueViolet;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(642, 440);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 43);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar películas";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 349);
            label11.Name = "label11";
            label11.Size = new Size(122, 19);
            label11.TabIndex = 26;
            label11.Text = "Fecha de Salida";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 298);
            label10.Name = "label10";
            label10.Size = new Size(130, 19);
            label10.TabIndex = 25;
            label10.Text = "Fecha de estreno";
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Location = new Point(156, 435);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(95, 23);
            cmbEstatus.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 435);
            label9.Name = "label9";
            label9.Size = new Size(62, 19);
            label9.TabIndex = 23;
            label9.Text = "Estatus";
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.AllowUserToOrderColumns = true;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(29, 646);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.Size = new Size(801, 292);
            dgvPeliculas.TabIndex = 20;
            // 
            // pbCaratula
            // 
            pbCaratula.BackColor = SystemColors.ButtonShadow;
            pbCaratula.Location = new Point(651, 142);
            pbCaratula.Name = "pbCaratula";
            pbCaratula.Size = new Size(139, 204);
            pbCaratula.TabIndex = 16;
            pbCaratula.TabStop = false;
            pbCaratula.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(674, 115);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 15;
            label8.Text = "Carátula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 483);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 13;
            label7.Text = "Descripción";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(156, 394);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(95, 23);
            cmbGenero.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 394);
            label6.Name = "label6";
            label6.Size = new Size(60, 19);
            label6.TabIndex = 11;
            label6.Text = "Género";
            // 
            // cmbIdioma
            // 
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(156, 252);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(121, 23);
            cmbIdioma.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 256);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 9;
            label5.Text = "Idioma";
            // 
            // cmbClasificacion
            // 
            cmbClasificacion.FormattingEnabled = true;
            cmbClasificacion.Location = new Point(156, 213);
            cmbClasificacion.Name = "cmbClasificacion";
            cmbClasificacion.Size = new Size(80, 23);
            cmbClasificacion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 7;
            label4.Text = "Clasificación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 152);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 5;
            label3.Text = "Duración";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.BlueViolet;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(0, 25);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 40);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 32);
            label1.TabIndex = 1;
            label1.Text = "Edición de películas";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ediciónDePelículasToolStripMenuItem, listaDePeliculasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ediciónDePelículasToolStripMenuItem
            // 
            ediciónDePelículasToolStripMenuItem.BackColor = Color.MediumPurple;
            ediciónDePelículasToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ediciónDePelículasToolStripMenuItem.ForeColor = Color.White;
            ediciónDePelículasToolStripMenuItem.Image = (Image)resources.GetObject("ediciónDePelículasToolStripMenuItem.Image");
            ediciónDePelículasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            ediciónDePelículasToolStripMenuItem.Name = "ediciónDePelículasToolStripMenuItem";
            ediciónDePelículasToolStripMenuItem.Size = new Size(151, 21);
            ediciónDePelículasToolStripMenuItem.Text = "Edición de películas";
            ediciónDePelículasToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // listaDePeliculasToolStripMenuItem
            // 
            listaDePeliculasToolStripMenuItem.BackColor = Color.MediumPurple;
            listaDePeliculasToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaDePeliculasToolStripMenuItem.ForeColor = Color.White;
            listaDePeliculasToolStripMenuItem.Image = (Image)resources.GetObject("listaDePeliculasToolStripMenuItem.Image");
            listaDePeliculasToolStripMenuItem.Name = "listaDePeliculasToolStripMenuItem";
            listaDePeliculasToolStripMenuItem.Size = new Size(134, 21);
            listaDePeliculasToolStripMenuItem.Text = "Lista de Peliculas";
            listaDePeliculasToolStripMenuItem.Click += listaDePeliculasToolStripMenuItem_Click;
            // 
            // PeliculasCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 949);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "PeliculasCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += PeliculasCRUD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaratula).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ediciónDePelículasToolStripMenuItem;
        private ToolStripMenuItem listaDePeliculasToolStripMenuItem;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private ComboBox cmbGenero;
        private Label label6;
        private ComboBox cmbIdioma;
        private Label label5;
        private ComboBox cmbClasificacion;
        private PictureBox pbCaratula;
        private DataGridView dgvPeliculas;
        private Label label11;
        private Label label10;
        private ComboBox cmbEstatus;
        private Label label9;
        private Custom_Controls.CustomButton btnGuardar;
        private Custom_Controls.CustomButton btnModificar;
        private Custom_Controls.CustomButton btnEliminar;
        private Custom_Controls.CustomButton btnSubirCaratula;
        private Custom_Controls.CustomTextbox txtNombre;
        private Custom_Controls.CustomTextbox txtDescripcion;
        private Custom_Controls.CustomTextbox txtFechaSalida;
        private Custom_Controls.CustomTextbox txtFechaEstreno;
        private Custom_Controls.CustomTextbox txtDuracion;
        private Button btnRegresar;
    }
}