using System;

namespace Prototipo.Modelos
{
    public class Pelicula
    {
        public long IdPelicula { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string? FechaEstreno { get; set; }
        public string? SalidaCartelera { get; set; }
        public int Duracion { get; set; }
        public string Categoria { get; set; }
        public string Clasificacion { get; set; }
        public string Portada { get; set; }

        public string Estado { get; set; }

        public string Idioma { get; set; }
    }
}
