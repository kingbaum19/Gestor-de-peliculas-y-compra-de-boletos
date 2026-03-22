using MySql.Data.MySqlClient;
using Prototipo.Clases;
using Prototipo.Controladores;
using Prototipo.Vistas;

using System;
using System.Windows.Forms;
namespace Prototipo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            UsuarioController controller = new UsuarioController();


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
            string correo = txtCorreo.Texto;
            string contraseña = txtContraseña.Texto;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor llene todos los datos");
            }
            else
            {
                try
                {
                    UsuarioController usuarioCon = new UsuarioController();
                    string respuesta = usuarioCon.Login(correo, contraseña);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usted ha iniciado sesión correctamente", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Placeholder vistaAdmin = new Placeholder();
                        vistaAdmin.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al iniciar sesión #3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
