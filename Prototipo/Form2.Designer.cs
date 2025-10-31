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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            comboBox4 = new ComboBox();
            label9 = new Label();
            button5 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            ediciónDePelículasToolStripMenuItem = new ToolStripMenuItem();
            añadirPelículaToolStripMenuItem = new ToolStripMenuItem();
            modificarPelículaToolStripMenuItem = new ToolStripMenuItem();
            listaDePeliculasToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 952);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(156, 352);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 310);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 27;
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
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(131, 450);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(95, 23);
            comboBox4.TabIndex = 24;
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
            // button5
            // 
            button5.Location = new Point(634, 603);
            button5.Name = "button5";
            button5.Size = new Size(157, 23);
            button5.TabIndex = 22;
            button5.Text = "Eliminar datos";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(634, 555);
            button4.Name = "button4";
            button4.Size = new Size(157, 23);
            button4.TabIndex = 21;
            button4.Text = "Modificar datos";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 646);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(801, 292);
            dataGridView1.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(634, 510);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 18;
            button2.Text = "Guardar película";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(652, 351);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 17;
            button1.Text = "Subir carátula";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(651, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 204);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            // textBox3
            // 
            textBox3.Location = new Point(116, 510);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 130);
            textBox3.TabIndex = 14;
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(131, 399);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(95, 23);
            comboBox3.TabIndex = 12;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(131, 264);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 23);
            comboBox1.TabIndex = 8;
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
            // textBox2
            // 
            textBox2.Location = new Point(131, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(80, 23);
            textBox2.TabIndex = 6;
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
            // textBox1
            // 
            textBox1.Location = new Point(131, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private ToolStripMenuItem añadirPelículaToolStripMenuItem;
        private ToolStripMenuItem modificarPelículaToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Label label11;
        private Label label10;
        private ComboBox comboBox4;
        private Label label9;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}