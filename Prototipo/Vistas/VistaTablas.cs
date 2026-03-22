using Prototipo.Controladores;
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
    public partial class VistaTablas : Form
    {
        public VistaTablas()
        {

            InitializeComponent();
            PeliculaController pcontroller = new PeliculaController();
            pcontroller.ObtenerTodas(dgvTablaPeliculas);
        }
    }
}
