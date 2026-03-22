using Prototipo.Vistas;
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
    public partial class Placeholder : Form
    {
        public Placeholder()
        {
            InitializeComponent();
        }

        private void Placeholder_Load(object sender, EventArgs e)
        {
            lblBienvenida.Parent = panel1;
            lblBienvenida.BackColor = Color.Transparent;
        }

        private void ediciónDePelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculasCRUD panelForm = new PeliculasCRUD();
            panelForm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("La sesión se ha cerrado exitosamente", "Cerrar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }


        }

        private void listaDePelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaTablas form1 = new VistaTablas();
            form1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
