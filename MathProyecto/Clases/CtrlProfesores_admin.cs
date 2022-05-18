using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProyecto
{
    class CtrlProfesores_admin: conexion
    {
        public List<object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM profesores;";
            }
            else
            {
                sql = "SELECT * FROM profesores WHERE nombre LIKE '%"+dato+"%' OR a_paterno LIKE '%"+dato+"%' OR a_materno LIKE '%"+dato+"%' OR tel_casa LIKE '%"+dato+"%' OR tel_cel LIKE '%"+dato+"%' OR e_mail LIKE '%"+dato+"%' OR red_social LIKE '%"+dato+"%' OR perfil_red LIKE '%"+dato+"%';";
            }

            try
            {
                MySqlConnection conexionBD = base.Conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    profesores_admin_a _reg = new profesores_admin_a();
                    _reg.Id = int.Parse(reader.GetString(0));
                    _reg.Nombre = reader.GetString(1);
                    _reg.A_paterno = reader.GetString(2);
                    _reg.A_materno = reader.GetString(3);
                    _reg.Tel_casa = reader.GetString(4);
                    _reg.Tel_cel = reader.GetString(5);
                    _reg.E_mail = reader.GetString(6);
                    _reg.Red = reader.GetString(7);
                    _reg.Perfil = reader.GetString(8);
                    lista.Add(_reg);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(profesores_admin_a datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO profesores (nombre, a_paterno, a_materno, tel_casa, tel_cel, e_mail, red_social, perfil_red) VALUES ('"+datos.Nombre+"','"+datos.A_paterno+"','"+datos.A_materno+"','"+datos.Tel_casa+"','"+datos.Tel_cel+"','"+datos.E_mail+"','"+datos.Red+"','"+datos.Perfil+"');";

            try
            {
                MySqlConnection conexionBD = base.Conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }

        public bool actualizar(profesores_admin_a datos)
        {
            bool bandera = false;

            string sql = "UPDATE profesores SET nombre='"+datos.Nombre+"', a_paterno='"+datos.A_paterno+"', a_materno='"+datos.A_materno+"', tel_casa='"+datos.Tel_casa+"', tel_cel='"+datos.Tel_cel+"', e_mail='"+datos.E_mail+"', red_social='"+datos.Red+"', perfil_red='"+datos.Perfil+"' WHERE id_profesor='"+datos.Id+"'";

            try
            {
                MySqlConnection conexionBD = base.Conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }

        public bool eliminar(int id)
        {
            bool bandera = false;

            string sql = "DELETE FROM profesores WHERE id_profesor='"+id+"'";

            try
            {
                MySqlConnection conexionBD = base.Conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return bandera;
        }
    }
}
