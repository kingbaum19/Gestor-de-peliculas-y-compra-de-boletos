using System;
using System.Windows.Forms;
namespace Prototipo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerConexion();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Placeholder winAdmin = new Placeholder();
            winAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego", "Despedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtCorreo.Texto + txtContraseña.Texto);
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            Placeholder winAdmin = new Placeholder();
            winAdmin.Show();
        }
    }
}
