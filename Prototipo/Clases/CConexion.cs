using MySql.Data.MySqlClient;
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

        MySqlConnection conex = new MySqlConnection();

        static string servidor = "127.0.0.1";
        static string bd = "cine";
        static string usuario = "root";
        static string password = "root";
        static string puerto = "3306";

       

        public static MySqlConnection establecerConexion()
        {
  
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                //MessageBox.Show("Acceso correcto a la base de datos", "Conexión a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return conexion;
            

            
        }
    }
}
