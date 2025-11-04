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
            PeliculasCRUD winAdmin = new PeliculasCRUD();
            winAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
