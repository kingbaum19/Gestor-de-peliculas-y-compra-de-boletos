using Prototipo.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Vistas
{
    public partial class VistaCliente : Form
    {
        public VistaCliente()
        {
            InitializeComponent();
            PeliculaController objetoPelicula = new PeliculaController();
            objetoPelicula.mostrarPelicula(pbCaratula1, 22);
            objetoPelicula.mostrarPelicula(pbCaratula2, 27);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DetallesPelicula detalles = new DetallesPelicula();
            detalles.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
