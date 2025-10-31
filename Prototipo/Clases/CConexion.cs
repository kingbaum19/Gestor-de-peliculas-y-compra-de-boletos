using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    internal class CConexion
    {
        NpgsqlConnection conn = new NpgsqlConnection();

        static string servidor = "localhost";
        static string bd = "Cinema";
        static string usuario = "postgres";
        static string password = "root";
        static string puerto = "5432";

        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public NpgsqlConnection establecerConexion() {

            try
            {
                conn.ConnectionString = cadenaConexion;
                conn.Open();
                MessageBox.Show("Conexion con la base de datos exitosa", "Conexion con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException e) {
                MessageBox.Show("No se pudo conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
            return conn;
        }
    }
}
