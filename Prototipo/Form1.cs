namespace Prototipo
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 winAdmin = new Form2();
            winAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
