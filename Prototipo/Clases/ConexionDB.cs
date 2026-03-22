using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    public class ConexionDB
    {
        private readonly string _connectionString =
            "server=127.0.0.1;port=3306;user ID=root;password=root;database=cine;";
        //Necesita cambiar los datos de user y password a su propia información para conectarse a la base de datos

        public MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            try
            {
                
                conn.Open();
                MessageBox.Show("Conexión exitosa a la base de datos");
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la conexión");

            }
            return conn;
      
        }
    }
}
