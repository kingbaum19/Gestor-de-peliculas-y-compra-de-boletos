using System;

public class SuperUsuario : Usuarios
{
    // Constructor que fija el rol como "administrador"
    public SuperUsuario(string nombre, string apellido, string correo, string contraseña)
        : base(nombre, apellido, "administrador", correo, contraseña)
    {
        // Aquí puedes agregar lógica adicional si es necesario para super usuarios
    }
}
