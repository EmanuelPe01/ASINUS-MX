using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProyecto
{
    class conexion
    {
        public MySqlConnection Conexion()
        {
            string servidor = "localhost";
            string bd = "sistema";
            string usuario = "root";
            string password = "server";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
