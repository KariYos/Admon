using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace refrescar
{
    class conexion
    {
        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=karinaa");
            conectar.Open();
            return conectar;
        }
    }
}
