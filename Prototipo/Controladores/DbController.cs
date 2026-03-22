using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Prototipo.Controladores
{
    public abstract class DbController
    {
        protected string connectionString = "server=127.0.0.1;database=cine;user=root;password=root;";
        //Necesita cambiar los datos de user y password a su propia información para conectarse a la base de datos 

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
