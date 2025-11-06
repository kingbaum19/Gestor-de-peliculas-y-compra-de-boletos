

namespace Prototipo
{
    public partial class Placeholder: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placeholder));
            menuStrip1 = new MenuStrip();
            ediciónDePelículasToolStripMenuItem = new ToolStripMenuItem();
            listaDePelículasToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnSalir = new Button();
            lblBienvenida = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DarkSlateBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ediciónDePelículasToolStripMenuItem, listaDePelículasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
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
            ediciónDePelículasToolStripMenuItem.Size = new Size(151, 20);
            ediciónDePelículasToolStripMenuItem.Text = "Edición de películas";
            ediciónDePelículasToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            ediciónDePelículasToolStripMenuItem.Click += ediciónDePelículasToolStripMenuItem_Click;
            // 
            // listaDePelículasToolStripMenuItem
            // 
            listaDePelículasToolStripMenuItem.BackColor = Color.MediumPurple;
            listaDePelículasToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaDePelículasToolStripMenuItem.ForeColor = Color.White;
            listaDePelículasToolStripMenuItem.Image = (Image)resources.GetObject("listaDePelículasToolStripMenuItem.Image");
            listaDePelículasToolStripMenuItem.Name = "listaDePelículasToolStripMenuItem";
            listaDePelículasToolStripMenuItem.Size = new Size(135, 20);
            listaDePelículasToolStripMenuItem.Text = "Lista de películas";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(lblBienvenida);
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(3, 0, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 537);
            panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(734, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 39);
            btnSalir.TabIndex = 10;
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(115, 103);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(584, 29);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Usted está en el portal de administradores";
            // 
            // Placeholder
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Placeholder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Placeholder";
            Load += Placeholder_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ediciónDePelículasToolStripMenuItem;
        private ToolStripMenuItem listaDePelículasToolStripMenuItem;
        private Panel panel1;
        private Label lblBienvenida;
        private Button btnSalir;
    }
}