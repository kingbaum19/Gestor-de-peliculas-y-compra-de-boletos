using Prototipo.Controladores;
using Prototipo.Modelos;
using Prototipo.Properties;
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
            pbDuracion.Image = Properties.Resources.Duracion;
            pbGenero.Image = Properties.Resources.Genero;
            pbIdioma.Image = Properties.Resources.Doblaje;
            Pelicula p = new Pelicula();
            PeliculaController objetoPelicula = new PeliculaController();
            try
            {
                objetoPelicula.mostrarDetalles(lblTitulo,lblDuracion, lblClasificacion, lblIdioma, lblGenero, txtDescripcion, pbCaratula, UserInput.Id_pelicula);
                UserInput.Nombre_pelicula = lblTitulo.Text.ToString();
                if (lblClasificacion.Text == "A")
                {
                    pbRating.Image = Properties.Resources.clas_A;
                }
                else if (lblClasificacion.Text == "B")
                {
                    pbRating.Image = Properties.Resources.clas_B;
                }
                else if (lblClasificacion.Text == "C")
                {
                    pbRating.Image = Properties.Resources.clas_C;
                }

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

        private void btnComprarBoletos_Click(object sender, EventArgs e)
        {
            SeleccionarBoletos form2 = new SeleccionarBoletos();
            form2.Show();
            this.Hide();
        }
    }
}
