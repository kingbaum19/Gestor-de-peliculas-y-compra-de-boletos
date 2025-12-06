using Prototipo.Controladores;
using Prototipo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class PeliculasCRUD : Form
    {
        string imagePath = "";
        CultureInfo culture = new CultureInfo("en-US");
        public PeliculasCRUD()
        {
            InitializeComponent();
            PeliculaController pcontroller = new PeliculaController();
            pcontroller.ObtenerTodas(dgvPeliculas);
            dgvPeliculas.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvPeliculas.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            dtpFechaEstreno.Value = DateTime.Today;
            dtpFechaSalida.Value = DateTime.Today;
            dtpFechaEstreno.CustomFormat = "dd-MM-yyyy";
            dtpFechaSalida.CustomFormat = "dd-MM-yyyy";
            dtpFechaEstreno.Format = DateTimePickerFormat.Custom;
            dtpFechaSalida.Format = DateTimePickerFormat.Custom;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaDePeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PeliculasCRUD_Load(object sender, EventArgs e)
        {
            label2.Parent = panel1;
            label2.BackColor = Color.Transparent;
            label3.Parent = panel1;
            label3.BackColor = Color.Transparent;
            label4.Parent = panel1;
            label4.BackColor = Color.Transparent;
            label5.Parent = panel1;
            label5.BackColor = Color.Transparent;
            label6.Parent = panel1;
            label6.BackColor = Color.Transparent;
            label7.Parent = panel1;
            label7.BackColor = Color.Transparent;
            label8.Parent = panel1;
            label8.BackColor = Color.Transparent;
            label9.Parent = panel1;
            label9.BackColor = Color.Transparent;
            label10.Parent = panel1;
            label10.BackColor = Color.Transparent;
            label11.Parent = panel1;
            label11.BackColor = Color.Transparent;
            btnRegresar.Parent = panel1;
            btnRegresar.BackColor = Color.Transparent;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Placeholder panelAdmin = new Placeholder();
            panelAdmin.Show();
            this.Close();
        }

        private void limpiarTexto()
        {
            txtNombre.Texto = "";
            txtDuracion.Texto = "";
            cmbIdioma.Text = "";
            cmbGenero.Text = "";
            cmbEstatus.Text = "";
            cmbClasificacion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            PeliculaController controller = new PeliculaController();
            if (string.IsNullOrEmpty(txtNombre.Texto) || string.IsNullOrEmpty(txtDescripcion.Texto) ||
                string.IsNullOrEmpty(imagePath))

            {
                MessageBox.Show("Por favor llene todos los campos para ingresar el dato", "Error al ingresar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                
            }
            try
            {
                pelicula.Nombre = txtNombre.Texto;
                pelicula.Descripcion = txtDescripcion.Texto;
                pelicula.FechaEstreno = dtpFechaEstreno.Value.Date.ToString("yyyy-MM-dd");
                pelicula.SalidaCartelera = dtpFechaSalida.Value.Date.ToString("yyyy-MM-dd");
                pelicula.Duracion = int.Parse(txtDuracion.Texto);
                pelicula.Clasificacion = cmbClasificacion.GetItemText(cmbClasificacion.SelectedItem);
                pelicula.Categoria = cmbGenero.GetItemText(cmbGenero.SelectedItem);
                pelicula.Estado = cmbEstatus.GetItemText(cmbEstatus.SelectedItem);
                pelicula.Idioma = cmbIdioma.GetItemText(cmbIdioma.SelectedItem);
                pelicula.Portada = imagePath;
                controller.Agregar(pelicula);
                controller.ObtenerTodas(dgvPeliculas);
                MessageBox.Show("Película agregada a la base de datos", "Insertar película", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarTexto();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al insertar datos");
            }


        }

        private void btnSubirCaratula_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    pbCaratula.Image = Image.FromFile(imagePath);
                }

            }
        }

        private void dgvPeliculas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PeliculaController controller = new PeliculaController();
            controller.seleccionarPeliculas(dgvPeliculas, txtNombre, txtDuracion, dtpFechaEstreno, dtpFechaSalida, txtDescripcion, cmbGenero, cmbClasificacion, cmbIdioma, cmbEstatus, pbCaratula);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            PeliculaController controller = new PeliculaController();
            try
            {
                pelicula.IdPelicula = Int64.Parse(dgvPeliculas.CurrentRow.Cells[0].Value.ToString());
                pelicula.Nombre = txtNombre.Texto;
                pelicula.Descripcion = txtDescripcion.Texto;
                pelicula.FechaEstreno = dtpFechaEstreno.Value.Date.ToString("yyyy-MM-dd");
                pelicula.SalidaCartelera = dtpFechaSalida.Value.Date.ToString("yyyy-MM-dd");
                pelicula.Duracion = Int32.Parse(dgvPeliculas.CurrentRow.Cells[5].Value.ToString());
                pelicula.Clasificacion = cmbClasificacion.GetItemText(cmbClasificacion.SelectedItem);
                pelicula.Categoria = cmbGenero.GetItemText(cmbGenero.SelectedItem);
                pelicula.Estado = cmbEstatus.GetItemText(cmbEstatus.SelectedItem);
                pelicula.Idioma = cmbIdioma.GetItemText(cmbIdioma.SelectedItem);
                pelicula.Portada = imagePath;
                controller.Actualizar(pelicula);
                MessageBox.Show("Película modificada con datos nuevos", "Modificar película", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.ObtenerTodas(dgvPeliculas);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al querer modificar un dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            PeliculaController controller = new PeliculaController();
            try
            {
                pelicula.IdPelicula = Int64.Parse(dgvPeliculas.CurrentRow.Cells[0].Value.ToString());
                pelicula.Nombre = txtNombre.Texto;
                pelicula.Descripcion = txtDescripcion.Texto;
                pelicula.FechaEstreno = dtpFechaEstreno.Value.Date.ToShortDateString();
                pelicula.SalidaCartelera = dtpFechaSalida.Value.Date.ToShortDateString();
                pelicula.Duracion = Int32.Parse(dgvPeliculas.CurrentRow.Cells[5].Value.ToString());
                pelicula.Clasificacion = cmbClasificacion.GetItemText(cmbClasificacion.SelectedItem);
                pelicula.Categoria = cmbGenero.GetItemText(cmbGenero.SelectedItem);
                pelicula.Estado = cmbEstatus.GetItemText(cmbEstatus.SelectedItem);
                pelicula.Idioma = cmbIdioma.GetItemText(cmbIdioma.SelectedItem);
                pelicula.Portada = imagePath;
                controller.Eliminar(pelicula.IdPelicula);
                MessageBox.Show("Se ha eliminado la película del sistema", "Eliminar película", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.ObtenerTodas(dgvPeliculas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al borrar un dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
