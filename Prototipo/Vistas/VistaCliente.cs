using Prototipo.Controladores;
using Prototipo.Modelos;
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
        private long id_pelicula;
        public VistaCliente()
        {
            InitializeComponent();
            PeliculaController objetoPelicula = new PeliculaController();
            objetoPelicula.mostrarPelicula(pbCaratula1, 35);
            objetoPelicula.mostrarPelicula(pbCaratula2, 31);
            objetoPelicula.mostrarPelicula(pbCaratula3, 32);
            objetoPelicula.mostrarPelicula(pbcaratula4, 30);
            pbCaratula1.Click += pb_Click;
            pbCaratula2.Click += pb_Click;
            pbCaratula3.Click += pb_Click;
            pbcaratula4.Click += pb_Click;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            UserInput.Id_pelicula = Convert.ToInt64(pb.Tag);
            DetallesPelicula detalles = new DetallesPelicula();
            detalles.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {
            pbCaratula1.Tag = 35;
            pbCaratula2.Tag = 31;
            pbCaratula3.Tag = 32;
            pbcaratula4.Tag = 30;
        }
    }
}
