using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProyecto
{
    class CtrlProductos : conexion
    {
        private SqlDataReader LeerFilas;
        private SqlCommand comando;

        public DataTable listaClases()
        {
            MySqlConnection conexionBD = base.Conexion();
            DataTable tabla = new DataTable();
            comando.CommandText = "SELECT * FROM clases ORDER BY nombre ASC";
            LeerFilas = comando.ExecuteNonQuery();
        }
    }
}
