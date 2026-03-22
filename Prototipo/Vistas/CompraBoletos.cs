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
    public partial class CompraBoletos : Form
    {
        private string detallesTransacción;
        public CompraBoletos()
        {
            InitializeComponent();
            lblSeleccionPelicula.Text = "Película seleccionada: " + UserInput.Nombre_pelicula;
            lblBoletos.Text = "Cantidad de boletos: " + UserInput.Cantidad_boletos;
            lblPrecioTotal.Text = "Precio total: B/." + UserInput.Precio;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            Boletos B = new Boletos();
            BoletoController objetoBoleto = new BoletoController();
            VistaCliente form1 = new VistaCliente();
            //Condición para verificar que los textbox ni combobox estén vacíos
            if (String.IsNullOrEmpty(txtNombre.Texto) || String.IsNullOrEmpty(txtApellido.Texto) || String.IsNullOrEmpty(txtEmail.Texto) || cmbPago.SelectedIndex == -1)
            {
                btnComprar.BackColor = Color.Silver;
                MessageBox.Show("Por favor llene todos los campos para terminar la transacción", "Error de transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else
            {
                try
                {
                    B.nombre_cliente = txtNombre.Texto;
                    B.apellido_cliente = txtApellido.Texto;
                    B.correo_cliente = txtEmail.Texto;
                    B.precio = SeleccionarBoletos.precioTransaccion;
                    B.metodo_pago = cmbPago.GetItemText(cmbPago.SelectedItem);
                    B.FechaCompra = DateTime.Now;
                    B.id_pelicula = UserInput.Id_pelicula;
                    objetoBoleto.GenerarBoleto(B);

                    //Mensaje de transacción
                    detallesTransacción = "Detalles de su compra \n" +
                        "Nombre:" + B.nombre_cliente + " " + B.apellido_cliente + "\n" +
                        "Correo electrónico: " + B.correo_cliente + "\n " +
                        "Pelicula seleccionada: " + UserInput.Nombre_pelicula + "\n" +
                        "Cantidad de boletos: " + UserInput.Cantidad_boletos + "\n" +
                        "Asientos seleccionados: " + string.Join(",", UserInput.pilaBotones) + "\n" +
                        "Precio total: B/. " + UserInput.Precio + "\n";

                    MessageBox.Show("La compra de su boleto se ha realizado con éxito \n"
                    + detallesTransacción, "Compra exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form1.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al realizar la transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void lblBoletos_Click(object sender, EventArgs e)
        {

        }

        private void CompraBoletos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ReservarAsientos form1 = new ReservarAsientos();
            form1.Show();
            this.Hide();
        }
    }
}
