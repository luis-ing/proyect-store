using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace store
{
    class Class_conectar_bd
    {
        public static SqlConnection Conectar()
        {
            string servidor = "127.0.0.1";
            string puerto = "3308";
            string usuario = "root";
            string pass = "12345";
            string base_datos = "tienda";

            SqlConnection conexion = new SqlConnection("server="+servidor+"; port="+puerto+"; Uid="+usuario+"; pass="+pass+"; databse="+base_datos";");
            conexion.Open();
            return conexion;
        }
    }
}
