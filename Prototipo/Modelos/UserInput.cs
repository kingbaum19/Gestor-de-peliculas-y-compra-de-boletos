using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Modelos
{
    static class UserInput
    {

        public static long Id_pelicula { get; set; }
        public static string Nombre_pelicula { get; set; }
        public static int Cantidad_boletos { get; set; }
        public static string Precio { get; set; }

        public static Stack<String> pilaBotones = new Stack<String>();
    }
}
