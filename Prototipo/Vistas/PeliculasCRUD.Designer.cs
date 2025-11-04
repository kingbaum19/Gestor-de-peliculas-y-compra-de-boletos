namespace Prototipo
{
    partial class Form2
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
            txtFechaSalida = new TextBox();
            txtFechaEstreno = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cmbEstatus = new ComboBox();
            label9 = new Label();
            btnEliminarDatos = new Button();
            btnModificarDatos = new Button();
            dgvPeliculas = new DataGridView();
            btnGuardarPelicula = new Button();
            btnSubirCaratula = new Button();
            pbCaratula = new PictureBox();
            label8 = new Label();
            txtDescripcion = new TextBox();
            label7 = new Label();
            cmbGenero = new ComboBox();
            label6 = new Label();
            cmbIdioma = new ComboBox();
            label5 = new Label();
            cmbClasificacion = new ComboBox();
            label4 = new Label();
            txtDuracion = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            ediciónDePelículasToolStripMenuItem = new ToolStripMenuItem();
            añadirPelículaToolStripMenuItem = new ToolStripMenuItem();
            modificarPelículaToolStripMenuItem = new ToolStripMenuItem();
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
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtFechaSalida);
            panel1.Controls.Add(txtFechaEstreno);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cmbEstatus);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnEliminarDatos);
            panel1.Controls.Add(btnModificarDatos);
            panel1.Controls.Add(dgvPeliculas);
            panel1.Controls.Add(btnGuardarPelicula);
            panel1.Controls.Add(btnSubirCaratula);
            panel1.Controls.Add(pbCaratula);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbIdioma);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbClasificacion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDuracion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 952);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtFechaSalida
            // 
            txtFechaSalida.Location = new Point(156, 352);
            txtFechaSalida.Name = "txtFechaSalida";
            txtFechaSalida.Size = new Size(100, 23);
            txtFechaSalida.TabIndex = 28;
            // 
            // txtFechaEstreno
            // 
            txtFechaEstreno.Location = new Point(156, 310);
            txtFechaEstreno.Name = "txtFechaEstreno";
            txtFechaEstreno.Size = new Size(100, 23);
            txtFechaEstreno.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 352);
            label11.Name = "label11";
            label11.Size = new Size(124, 23);
            label11.TabIndex = 26;
            label11.Text = "Fecha de Salida";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 310);
            label10.Name = "label10";
            label10.Size = new Size(133, 23);
            label10.TabIndex = 25;
            label10.Text = "Fecha de estreno";
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Location = new Point(131, 450);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(95, 23);
            cmbEstatus.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 446);
            label9.Name = "label9";
            label9.Size = new Size(60, 23);
            label9.TabIndex = 23;
            label9.Text = "Estatus";
            // 
            // btnEliminarDatos
            // 
            btnEliminarDatos.Location = new Point(634, 603);
            btnEliminarDatos.Name = "btnEliminarDatos";
            btnEliminarDatos.Size = new Size(157, 23);
            btnEliminarDatos.TabIndex = 22;
            btnEliminarDatos.Text = "Eliminar datos";
            btnEliminarDatos.UseVisualStyleBackColor = true;
            // 
            // btnModificarDatos
            // 
            btnModificarDatos.Location = new Point(634, 555);
            btnModificarDatos.Name = "btnModificarDatos";
            btnModificarDatos.Size = new Size(157, 23);
            btnModificarDatos.TabIndex = 21;
            btnModificarDatos.Text = "Modificar datos";
            btnModificarDatos.UseVisualStyleBackColor = true;
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
            // btnGuardarPelicula
            // 
            btnGuardarPelicula.Location = new Point(634, 510);
            btnGuardarPelicula.Name = "btnGuardarPelicula";
            btnGuardarPelicula.Size = new Size(157, 23);
            btnGuardarPelicula.TabIndex = 18;
            btnGuardarPelicula.Text = "Guardar película";
            btnGuardarPelicula.UseVisualStyleBackColor = true;
            // 
            // btnSubirCaratula
            // 
            btnSubirCaratula.Location = new Point(652, 351);
            btnSubirCaratula.Name = "btnSubirCaratula";
            btnSubirCaratula.Size = new Size(139, 23);
            btnSubirCaratula.TabIndex = 17;
            btnSubirCaratula.Text = "Subir carátula";
            btnSubirCaratula.UseVisualStyleBackColor = true;
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
            label8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(683, 115);
            label8.Name = "label8";
            label8.Size = new Size(68, 23);
            label8.TabIndex = 15;
            label8.Text = "Carátula";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(116, 510);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(375, 130);
            txtDescripcion.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 506);
            label7.Name = "label7";
            label7.Size = new Size(92, 23);
            label7.TabIndex = 13;
            label7.Text = "Descripción";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(131, 399);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(95, 23);
            cmbGenero.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 395);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 11;
            label6.Text = "Género";
            // 
            // cmbIdioma
            // 
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(131, 264);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(121, 23);
            cmbIdioma.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 264);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 9;
            label5.Text = "Idioma";
            // 
            // cmbClasificacion
            // 
            cmbClasificacion.FormattingEnabled = true;
            cmbClasificacion.Location = new Point(131, 214);
            cmbClasificacion.Name = "cmbClasificacion";
            cmbClasificacion.Size = new Size(80, 23);
            cmbClasificacion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 214);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 7;
            label4.Text = "Clasificación";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(131, 167);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(80, 23);
            txtDuracion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 167);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 5;
            label3.Text = "Duración";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(303, 23);
            txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 113);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(14, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 40);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(13, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 32);
            label1.TabIndex = 1;
            label1.Text = "Edición de películas";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Purple;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ediciónDePelículasToolStripMenuItem, listaDePeliculasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ediciónDePelículasToolStripMenuItem
            // 
            ediciónDePelículasToolStripMenuItem.BackColor = Color.LavenderBlush;
            ediciónDePelículasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { añadirPelículaToolStripMenuItem, modificarPelículaToolStripMenuItem });
            ediciónDePelículasToolStripMenuItem.Name = "ediciónDePelículasToolStripMenuItem";
            ediciónDePelículasToolStripMenuItem.Size = new Size(123, 20);
            ediciónDePelículasToolStripMenuItem.Text = "Edición de películas";
            // 
            // añadirPelículaToolStripMenuItem
            // 
            añadirPelículaToolStripMenuItem.Name = "añadirPelículaToolStripMenuItem";
            añadirPelículaToolStripMenuItem.Size = new Size(169, 22);
            añadirPelículaToolStripMenuItem.Text = "Añadir película";
            // 
            // modificarPelículaToolStripMenuItem
            // 
            modificarPelículaToolStripMenuItem.Name = "modificarPelículaToolStripMenuItem";
            modificarPelículaToolStripMenuItem.Size = new Size(169, 22);
            modificarPelículaToolStripMenuItem.Text = "Modificar película";
            // 
            // listaDePeliculasToolStripMenuItem
            // 
            listaDePeliculasToolStripMenuItem.BackColor = Color.LavenderBlush;
            listaDePeliculasToolStripMenuItem.Name = "listaDePeliculasToolStripMenuItem";
            listaDePeliculasToolStripMenuItem.Size = new Size(108, 20);
            listaDePeliculasToolStripMenuItem.Text = "Lista de Peliculas";
            listaDePeliculasToolStripMenuItem.Click += listaDePeliculasToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 949);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
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
        private TextBox txtDuracion;
        private Label label3;
        private TextBox txtNombre;
        private Label label8;
        private TextBox txtDescripcion;
        private Label label7;
        private ComboBox cmbGenero;
        private Label label6;
        private ComboBox cmbIdioma;
        private Label label5;
        private ComboBox cmbClasificacion;
        private Button btnSubirCaratula;
        private PictureBox pbCaratula;
        private Button btnGuardarPelicula;
        private ToolStripMenuItem añadirPelículaToolStripMenuItem;
        private ToolStripMenuItem modificarPelículaToolStripMenuItem;
        private DataGridView dgvPeliculas;
        private Button btnEliminarDatos;
        private Button btnModificarDatos;
        private Label label11;
        private Label label10;
        private ComboBox cmbEstatus;
        private Label label9;
        private TextBox txtFechaEstreno;
        private TextBox txtFechaSalida;
    }
}