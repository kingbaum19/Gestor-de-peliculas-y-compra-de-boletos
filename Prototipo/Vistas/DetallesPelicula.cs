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
    public partial class DetallesPelicula : Form
    {
        public DetallesPelicula()
        {
            InitializeComponent();
            Pelicula p = new Pelicula();
            PeliculaController objetoPelicula = new PeliculaController();
            try
            {
                objetoPelicula.mostrarTitulo(lblTitulo, lblDuracion, lblClasificacion, lblIdioma, txtDescripcion, pbCaratula, 22);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al mostrar datos");
                lblTitulo.Text = "ERRoR";
                lblDuracion.Text = "Error";
                lblClasificacion.Text = "Error";
                lblIdioma.Text = "Error";
                txtDescripcion.Text = ex.Message;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbCaratula_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VistaCliente form1 = new VistaCliente();
            form1.Show();
            this.Hide();
        }
    }
}
