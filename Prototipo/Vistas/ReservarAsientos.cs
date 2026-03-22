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
    public partial class ReservarAsientos : Form
    {
        Bitmap libre = Properties.Resources.SillaLibre2;
        Bitmap Select = Properties.Resources.SillaSelect;
        int contadorBoton;
        //Stack<Button> pilaBotones = new Stack<Button>();
        Queue<Button> colaBotones = new Queue<Button>();

        public ReservarAsientos()
        {
            InitializeComponent();
            UserInput.pilaBotones.Clear();
            lblBoletoSeleccionado.Text = "Boletos seleccionados: " + UserInput.Cantidad_boletos.ToString();
            A1.Click += button_Click;
            A2.Click += button_Click;
            A3.Click += button_Click;
            A4.Click += button_Click;
            A5.Click += button_Click;
            A6.Click += button_Click;
            A7.Click += button_Click;
            A8.Click += button_Click;
            A9.Click += button_Click;
            B1.Click += button_Click;
            B2.Click += button_Click;
            B3.Click += button_Click;
            B4.Click += button_Click;
            B5.Click += button_Click;
            B6.Click += button_Click;
            B7.Click += button_Click;
            B8.Click += button_Click;
            B9.Click += button_Click;
            C1.Click += button_Click;
            C2.Click += button_Click;
            C3.Click += button_Click;
            C4.Click += button_Click;
            C5.Click += button_Click;
            C6.Click += button_Click;
            C7.Click += button_Click;
            C8.Click += button_Click;
            C9.Click += button_Click;
            D1.Click += button_Click;
            D2.Click += button_Click;
            D3.Click += button_Click;
            D4.Click += button_Click;
            D5.Click += button_Click;
            D6.Click += button_Click;
            D7.Click += button_Click;
            D8.Click += button_Click;
            D9.Click += button_Click;
            E1.Click += button_Click;
            E2.Click += button_Click;
            E3.Click += button_Click;
            E4.Click += button_Click;
            E5.Click += button_Click;
            E6.Click += button_Click;
            E7.Click += button_Click;
            E8.Click += button_Click;
            E9.Click += button_Click;
            F1.Click += button_Click;
            F2.Click += button_Click;
            F3.Click += button_Click;
            F4.Click += button_Click;
            F5.Click += button_Click;
            F6.Click += button_Click;
            F7.Click += button_Click;
            F8.Click += button_Click;
            F9.Click += button_Click;
            G1.Click += button_Click;
            G2.Click += button_Click;
            G3.Click += button_Click;
            G4.Click += button_Click;
            G5.Click += button_Click;
            G6.Click += button_Click;
            G7.Click += button_Click;
            G8.Click += button_Click;
            G9.Click += button_Click;


        }




        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Image == libre)
            {
                button.Image = Select;
                contadorBoton++;
                UserInput.pilaBotones.Push(button.Name.ToString());
                if (contadorBoton > UserInput.Cantidad_boletos )
                {
                    btnSiguiente.BackColor = Color.DarkOrchid;
                    contadorBoton--;
                    button.Image = libre;
                    UserInput.pilaBotones.Pop();
                }
            }
            else
            {
                contadorBoton--;
                button.Image = libre;
                UserInput.pilaBotones.Pop();

            }


        }

        private void ReservarAsientos_Load(object sender, EventArgs e)
        {
            A1.Image = libre;
            A2.Image = libre;
            A3.Image = libre;
            A4.Image = libre;
            A5.Image = libre;
            A6.Image = libre;
            A7.Image = libre;
            A8.Image = libre;
            A9.Image = libre;
            B1.Image = libre;
            B2.Image = libre;
            B3.Image = libre;
            B4.Image = libre;
            B5.Image = libre;
            B6.Image = libre;
            B7.Image = libre;
            B8.Image = libre;
            B9.Image = libre;
            C1.Image = libre;
            C2.Image = libre;
            C3.Image = libre;
            C4.Image = libre;
            C5.Image = libre;
            C6.Image = libre;
            C7.Image = libre;
            C8.Image = libre;
            C9.Image = libre;
            D1.Image = libre;
            D2.Image = libre;
            D3.Image = libre;
            D4.Image = libre;
            D5.Image = libre;
            D6.Image = libre;
            D7.Image = libre;
            D8.Image = libre;
            D9.Image = libre;
            E1.Image = libre;
            E2.Image = libre;
            E3.Image = libre;
            E4.Image = libre;
            E5.Image = libre;
            E6.Image = libre;
            E7.Image = libre;
            E8.Image = libre;
            E9.Image = libre;
            F1.Image = libre;
            F2.Image = libre;
            F3.Image = libre;
            F4.Image = libre;
            F5.Image = libre;
            F6.Image = libre;
            F7.Image = libre;
            F8.Image = libre;
            F9.Image = libre;
            G1.Image = libre;
            G2.Image = libre;
            G3.Image = libre;
            G4.Image = libre;
            G5.Image = libre;
            G6.Image = libre;
            G7.Image = libre;
            G8.Image = libre;
            G9.Image = libre;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (contadorBoton != SeleccionarBoletos.boletosSeleccionados)
            {
                MessageBox.Show("Por favor seleccione todos los asientos antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSiguiente.BackColor = Color.Silver;
            }
            else
            {
                btnSiguiente.BackColor = Color.DarkOrchid;
                CompraBoletos form1 = new CompraBoletos();
                form1.Show();
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeleccionarBoletos form1 = new SeleccionarBoletos();
            form1.Show();
            this.Close();   
        }
    }
}
