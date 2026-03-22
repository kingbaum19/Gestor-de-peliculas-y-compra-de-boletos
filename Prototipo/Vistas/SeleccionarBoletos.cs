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

    public partial class SeleccionarBoletos : Form
    {
        public int boletosMaximos = 10;
        int i; //Contador cantidad de boletos para adultos seleccionados
        int j; //Contador cantidad de boletos para niños seleccionados
        int k; //Contador cantidad de boletos para jubilados seleccionados
        public static int boletosSeleccionados;
        public static double precioTransaccion;
        public SeleccionarBoletos()
        {
            InitializeComponent();
            boletosSeleccionados = 0;
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Aumenta la cantidad de boletos para adultos seleccionados
        private void btnAumentarAdulto_Click(object sender, EventArgs e)
        {
            if (i >= boletosMaximos || i + j + k >= boletosMaximos)
            {
                MessageBox.Show("Cantidad máxima de boletos alcanzada");
            }
            else
            {
                i++;
                boletosSeleccionados++;
                lblTicketAdulto.Text = i.ToString();
                precioTransaccion = precioTransaccion + 7.00;
                lblPrecio.Text = String.Format("B/. {0:0.##}", precioTransaccion.ToString());


            }



        }

        //Reduce la cantidad de boletos para adultos seleccionados
        private void btnReducirAdulto_Click(object sender, EventArgs e)
        {
            if (i <= 0)
            {
                MessageBox.Show("No puede comprar negativa cantidad de boletos");
            }
            else
            {
                i--;
                boletosSeleccionados--;
                precioTransaccion = precioTransaccion - 7.00;
                lblTicketAdulto.Text = i.ToString();
                lblPrecio.Text = String.Format("B/. {0:0.##}", precioTransaccion.ToString());
            }
        }

        //Aumenta la cantidad de boletos para niños seleccionados
        private void btnAumentarNiño_Click(object sender, EventArgs e)
        {
            if (j >= boletosMaximos || i + j + k >= boletosMaximos)
            {
                MessageBox.Show("Cantidad máxima de boletos alcanzada");
            }
            else
            {
                j++;
                boletosSeleccionados++;
                lblTicketNiño.Text = j.ToString();
                precioTransaccion = precioTransaccion + 5.75;
                lblPrecio.Text = String.Format("B/. {0:0.##}", precioTransaccion.ToString());

            }

        }

        //Reduce la cantidad de boletos para niños seleccionados
        private void btnReducirNiño_Click(object sender, EventArgs e)
        {
            if (j <= 0)
            {
                MessageBox.Show("No puede comprar negativa cantidad de boletos");
            }
            else
            {
                j--;
                boletosSeleccionados--;
                lblTicketNiño.Text = j.ToString();
                precioTransaccion = precioTransaccion - 5.75;
                lblPrecio.Text = String.Format("B/. {0:0.##}", precioTransaccion.ToString());

            }
        }

        //Aumenta la cantidad de boletos para jubilados seleccionados
        private void btnAumentarJubilado_Click(object sender, EventArgs e)
        {
            if (k >= boletosMaximos || i + j + k >= boletosMaximos)
            {
                MessageBox.Show("Cantidad máxima de boletos alcanzada");
            }
            else
            {
                k++;
                boletosSeleccionados++;
                lblTicketJubilado.Text = k.ToString();
                precioTransaccion = precioTransaccion + 3.50;
                lblPrecio.Text = String.Format("B/. {0:0.##}", precioTransaccion.ToString());

            }

        }

        //Reduce la cantidad de boletos para jubilados seleccionados
        private void btnReducirJubilado_Click(object sender, EventArgs e)
        {
            if (k <= 0)
            {
                MessageBox.Show("No puede comprar negativa cantidad de boletos");
            }
            else
            {
                k--;
                boletosSeleccionados--;
                lblTicketJubilado.Text = k.ToString();
                precioTransaccion = precioTransaccion - 3.50;
                lblPrecio.Text = String.Format("B/. {0:0.##}", precioTransaccion.ToString());

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           DetallesPelicula form1 = new DetallesPelicula();
           form1.Show();
           this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (boletosSeleccionados == 0)
            {
                MessageBox.Show("Seleccione boletos antes de continuar", "Error al seleccionar boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserInput.Cantidad_boletos = boletosSeleccionados;
                UserInput.Precio = precioTransaccion.ToString();
                ReservarAsientos form2 = new ReservarAsientos();
                form2.Show();
                this.Close();
            }

        }
    }
}
