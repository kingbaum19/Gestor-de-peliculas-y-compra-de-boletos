using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Prototipo.Modelos;

namespace Prototipo.Controladores
{
    public class UsuarioController : DbController
    {
        public List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT u.*, r.nombre AS rol_nombre 
                                 FROM Usuario u
                                 INNER JOIN Rol r ON u.rol_id = r.id";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Usuario
                        {
                            Id = reader.GetInt64("id"),
                            Nombre = reader.GetString("nombre"),
                            Apellido = reader["apellido"]?.ToString(),
                            Correo = reader.GetString("correo"),
                            Contraseña = reader.GetString("contraseña"),
                            RolId = reader.GetInt64("rol_id"),
                            CreadoEn = reader.GetDateTime("creado_en")
                        });
                    }
                }
            }
            return lista;
        }

        public bool Agregar(Usuario usuario)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Usuario(nombre, apellido, rol_id, correo, contraseña, creado_en)
                                 VALUES(@nombre,@apellido,@rol_id,@correo,@contraseña,@creado_en)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@rol_id", usuario.RolId);
                    cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@creado_en", usuario.CreadoEn);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Actualizar(Usuario usuario)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Usuario 
                                 SET nombre=@nombre, apellido=@apellido, rol_id=@rol_id, correo=@correo, contraseña=@contraseña
                                 WHERE id=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@rol_id", usuario.RolId);
                    cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Eliminar(long id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Usuario WHERE id=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public Usuario Autentificacion(string correo, string contraseña)
        {

            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM usuario WHERE correo LIKE @correo AND contraseña LIKE @CONTRASEÑA AND rol_id = 2";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (var reader = cmd.ExecuteReader())
                    {
                        Usuario usr = null;
                        if (reader.Read())


                            usr = new Usuario();
                        {
                            usr.Id = reader.GetInt64("id");
                            usr.Nombre = reader.GetString("nombre");
                            usr.Apellido = reader.GetString("apellido");
                            usr.Correo = reader.GetString("correo");
                            usr.Contraseña = reader.GetString("contraseña");
                            usr.RolId = reader.GetInt64("rol_id");
                            usr.CreadoEn = reader.GetDateTime("creado_en");
                        };
                        return usr;
                    }
                }
            }
        }

        public string Login(string correo, string password) {

            string respuesta = "";
            Usuario datosUsuario = null;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password)) {
                respuesta = "Por favor llene todos los campos";
            }else
            {
                datosUsuario = this.Autentificacion(correo, password);

                if (datosUsuario == null)
                {
                    respuesta = "Este usuario no existe";
                }
               
            }
            return respuesta;

        }

    }
}

        
    

