using MySql.Data.MySqlClient;
using Prototipo.Clases;
using Prototipo.Vistas;
using System;
using System.Windows.Forms;
namespace Prototipo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            MySqlConnection conn = CConexion.establecerConexion();
            conn.Open();
           

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

        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
            
        }
    }
}
