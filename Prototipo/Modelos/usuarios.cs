using System;

public class Usuarios
{
    // Propiedades de la clase base
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Rol { get; protected set; } // Protected set para que solo se pueda modificar en la clase base o derivadas
    public string Correo { get; set; }
    public string Contraseña { get; set; } // Nota: En un proyecto real, no almacenes contraseñas en texto plano; usa hashing.

    // Constructor base
    public Usuarios(string nombre, string apellido, string rol, string correo, string contraseña)
    {
        Nombre = nombre;
        Apellido = apellido;
        Rol = rol;
        Correo = correo;
        Contraseña = contraseña;
    }
}