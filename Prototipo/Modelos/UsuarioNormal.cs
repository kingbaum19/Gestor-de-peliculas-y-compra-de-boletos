using System;

public class UsuarioNormal : Usuarios
{
    // Constructor que fija el rol como "normal"
    public UsuarioNormal(string nombre, string apellido, string correo, string contraseña)
        : base(nombre, apellido, "normal", correo, contraseña)
    {
        // Aquí puedes agregar lógica adicional si es necesario para usuarios normales
    }
}