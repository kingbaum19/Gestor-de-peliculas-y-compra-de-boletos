using MySql.Data.MySqlClient;
using Prototipo.Custom_Controls;
using Prototipo.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Prototipo.Controladores
{
    public class PeliculaController : DbController
    {
        public List<Pelicula> ObtenerTodas(DataGridView tablaPeliculas)
        {
            
            var lista = new List<Pelicula>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Pelicula;";
                using (var cmd = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    cmd.Fill(dt);
                    tablaPeliculas.DataSource = dt;
                }
            }
            return lista;
        }

        public bool Agregar(Pelicula p)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Pelicula(nombre, descripcion, fecha_estreno, salida_cartelera, duracion, categoria, clasificacion, portada, idioma, estatus)
                                 VALUES (@nombre,@descripcion,@fecha_estreno, @salida_cartelera,@duracion,@categoria,@clasificacion,@portada, @idioma, @estatus)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@fecha_estreno", p.FechaEstreno);
                    cmd.Parameters.AddWithValue("@salida_cartelera", p.SalidaCartelera);
                    cmd.Parameters.AddWithValue("@duracion", p.Duracion);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@clasificacion", p.Clasificacion);
                    cmd.Parameters.AddWithValue("@portada", p.Portada);
                    cmd.Parameters.AddWithValue("@idioma", p.Idioma);
                    cmd.Parameters.AddWithValue("@estatus", p.Estado);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Actualizar(Pelicula p)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Pelicula 
                                SET nombre=@nombre, descripcion=@descripcion, fecha_estreno=@fecha_estreno, salida_cartelera=@salida_cartelera, 
                                duracion=@duracion, categoria=@categoria, clasificacion=@clasificacion, portada=@portada, idioma=@idioma, estatus=@estatus
                                WHERE id_pelicula=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.IdPelicula);
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@fecha_estreno", p.FechaEstreno);
                    cmd.Parameters.AddWithValue("@salida_cartelera", p.SalidaCartelera);
                    cmd.Parameters.AddWithValue("@duracion", p.Duracion);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@clasificacion", p.Clasificacion);
                    cmd.Parameters.AddWithValue("@portada", p.Portada);
                    cmd.Parameters.AddWithValue("@idioma", p.Idioma);
                    cmd.Parameters.AddWithValue("@estatus", p.Estado);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public void seleccionarPeliculas(DataGridView tablaPeliculas, CustomTextbox txtNombre, CustomTextbox txtDuracion, DateTimePicker FechaEstreno,
            DateTimePicker FechaSalida, CustomTextbox txtDescripcion, ComboBox genero, ComboBox Clasificacion, ComboBox Idioma, ComboBox Estatus, PictureBox caratula)
        {

            try
            {
                txtNombre.Texto = tablaPeliculas.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Texto = tablaPeliculas.CurrentRow.Cells[2].Value.ToString();
                FechaEstreno.Value = Convert.ToDateTime(tablaPeliculas.CurrentRow.Cells[3].Value.ToString());
                FechaSalida.Value = Convert.ToDateTime(tablaPeliculas.CurrentRow.Cells[4].Value.ToString());
                txtDuracion.Texto = tablaPeliculas.CurrentRow.Cells[5].Value.ToString();
                genero.SelectedItem = tablaPeliculas.CurrentRow.Cells[6].Value.ToString();
                Clasificacion.SelectedItem = tablaPeliculas.CurrentRow.Cells[7].Value.ToString();
                caratula.Image = Image.FromFile(tablaPeliculas.CurrentRow.Cells[8].Value.ToString());
                Idioma.SelectedItem = tablaPeliculas.CurrentRow.Cells[9].Value.ToString();
                Estatus.SelectedItem = tablaPeliculas.CurrentRow.Cells[10].Value.ToString();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al seleccionar dato");
            }
        }

        public void mostrarPelicula(PictureBox p, long id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT portada FROM pelicula WHERE id_pelicula = @id;";
                using (var cmd = new MySqlCommand(query, conn))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        p.ImageLocation = reader[0] + "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al cargar imagen");
                    }  
            }
        }


        public bool mostrarInformacion(Pelicula p, long id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT nombre, duracion, idioma, categoria, descripcion FROM pelicula WHERE id_pelicula = @id;";
                using (var cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.IdPelicula);
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@fecha_estreno", p.FechaEstreno);
                    cmd.Parameters.AddWithValue("@salida_cartelera", p.SalidaCartelera);
                    cmd.Parameters.AddWithValue("@duracion", p.Duracion);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@clasificacion", p.Clasificacion);
                    cmd.Parameters.AddWithValue("@portada", p.Portada);
                    cmd.Parameters.AddWithValue("@idioma", p.Idioma);
                    cmd.Parameters.AddWithValue("@estatus", p.Estado);
                    
                    return cmd.ExecuteNonQuery() > 0;

                }

            }
        }

        public void mostrarTitulo(Label lbl1, Label lbl2, Label lbl3, Label lbl4, TextBox lbl5, PictureBox p, long id)
        {
            using (var conn = GetConnection())
            {
                //string query = "SELECT * FROM pelicula WHERE id_pelicula";
                // string query = "SELECT * FROM pelicula WHERE id_pelicula = 22;";// Query que si funciona
                //string query = "SELECT * FROM pelicula WHERE id_pelicula = @id";
                string query = "SELECT id_pelicula, nombre, duracion, clasificacion, idioma, descripcion, portada FROM pelicula WHERE id_pelicula = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        
                        lbl1.Text = reader.GetString("nombre");
                        lbl2.Text = reader.GetInt32("duracion").ToString() + " minutos";
                        lbl3.Text = reader.GetString("clasificacion");
                        lbl4.Text = reader.GetString("idioma");
                        lbl5.Text = reader.GetString("descripcion");
                        p.ImageLocation = reader.GetString("portada");

                    }
                }
                
            }
        }


        public bool Eliminar(long id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM pelicula WHERE id_pelicula=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
