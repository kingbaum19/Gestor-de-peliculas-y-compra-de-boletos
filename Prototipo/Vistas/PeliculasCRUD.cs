using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class PeliculasCRUD : Form
    {
        public PeliculasCRUD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaDePeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PeliculasCRUD_Load(object sender, EventArgs e)
        {
            label2.Parent = panel1;
            label2.BackColor = Color.Transparent;
            label3.Parent = panel1;
            label3.BackColor = Color.Transparent;
            label4.Parent = panel1;
            label4.BackColor = Color.Transparent;
            label5.Parent = panel1;
            label5.BackColor = Color.Transparent;
            label6.Parent = panel1;
            label6.BackColor = Color.Transparent;
            label7.Parent = panel1;
            label7.BackColor = Color.Transparent;
            label8.Parent = panel1;
            label8.BackColor = Color.Transparent;
            label9.Parent = panel1;
            label9.BackColor = Color.Transparent;
            label10.Parent = panel1;
            label10.BackColor = Color.Transparent;
            label11.Parent = panel1;
            label11.BackColor = Color.Transparent;
            btnRegresar.Parent = panel1;
            btnRegresar.BackColor = Color.Transparent;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Placeholder panelAdmin = new Placeholder();
            panelAdmin.Show();
            this.Close();
        }
    }
}
