using MySql.Data.MySqlClient;
using Prototipo.Custom_Controls;
using Prototipo.Controladores;
using Prototipo.Modelos;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Controladores
{
    public class BoletoController : DbController
    {
        public bool GenerarBoleto(Boletos B)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO BOLETOS (nombre_cliente, apellido_cliente, correo_cliente, metodo_pago, precio, id_pelicula, fecha_compra) 
                    VALUES (@nombre_cliente, @apellido_cliente, @correo_cliente, @metodo_pago, @precio, @id_pelicula, @fecha_compra)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre_cliente", B.nombre_cliente);
                    cmd.Parameters.AddWithValue("@apellido_cliente", B.apellido_cliente);
                    cmd.Parameters.AddWithValue("@correo_cliente", B.correo_cliente);
                    cmd.Parameters.AddWithValue("@metodo_pago", B.metodo_pago);
                    cmd.Parameters.AddWithValue("@precio", B.precio);
                    cmd.Parameters.AddWithValue("@id_pelicula", B.id_pelicula);
                    cmd.Parameters.AddWithValue("@fecha_compra", B.FechaCompra);
                    return cmd.ExecuteNonQuery() > 0;


                }
            }
        }


        public List<dynamic> ObtenerDetalleBoletos()
        {
            var lista = new List<dynamic>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM v_boletos_detalle";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new
                        {
                            IdBoleto = reader.GetInt64("id_boleto"),
                            Hash = reader.GetString("hash"),
                            FechaCompra = reader.GetDateTime("fecha_compra"),
                            Monto = reader.GetDecimal("monto"),
                            Usuario = reader["usuario_nombre"].ToString(),
                            Pelicula = reader["pelicula_nombre"].ToString(),
                            Sala = reader["sala_nombre"].ToString(),
                            Asiento = reader["asiento_nombre"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}


