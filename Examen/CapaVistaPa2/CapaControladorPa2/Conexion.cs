﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaControladorPa2
{
    class Conexion
    {

        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=E2");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }


    }
}
