using System;

public class Peliculas
{
    // Propiedades de la clase Peliculas
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaEstreno { get; set; }
    public DateTime? SalidaCartelera { get; set; } // Nullable, en caso de que aún esté en cartelera
    public int Duracion { get; set; } // En minutos, por ejemplo
    public string Clasificacion { get; set; } // Ej: "PG-13", "R", etc.

    // Constructor
    public Peliculas(string nombre, string descripcion, DateTime fechaEstreno, DateTime? salidaCartelera, int duracion, string clasificacion)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        FechaEstreno = fechaEstreno;
        SalidaCartelera = salidaCartelera;
        Duracion = duracion;
        Clasificacion = clasificacion;
    }
}