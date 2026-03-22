using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Modelos
{
    public class Boletos
    {
        public long id_boletos { get; set; }
        public string nombre_cliente { get; set; }
        public string apellido_cliente { get; set; }
        public string correo_cliente { get; set; }
        public string metodo_pago { get; set; }
        public double precio { get; set; }
        public long id_pelicula { get; set; }

        public DateTime FechaCompra { get; set; }


    }
}
