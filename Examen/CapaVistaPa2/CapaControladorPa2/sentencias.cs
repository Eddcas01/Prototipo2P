using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaControladorPa2
{
    
    public class sentencias
    {

        Conexion con = new Conexion();

        public OdbcDataAdapter llenaTbl0(string tabla, string campoOrden)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT fecha_limite,cod_orden,cod_opp,estado FROM " + tabla + " WHERE estado=1 ORDER BY " + campoOrden + " ASC ;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenaTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            string[] camposDesc = obtenerCampos(tabla); //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " WHERE estado=1 ORDER BY " + camposDesc[0] + " DESC ;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTbl2(string sql)// metodo  que obtinene el contenio de una tabla
        {

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());

            return dataTable;
        }
        public OdbcDataAdapter llenaTbl3(string where)// lllenar la tabla dependiendo del id pasado
        {

            string sql = "SELECT cod_orden, fecha_orden, fecha_limite, tipo_produccion, estado FROM produccion_encabezados WHERE cod_orden = " + where + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public string[] obtenerCampos(string tabla)//metodo que obtiene la lista de los campos que requiere una tabla
        {
            string[] Campos = new string[30];
            int i = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", con.conexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    i++;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parámetros \n -" + tabla); }
            return Campos;// devuelve un arrgeglo con los campos
        }
        public void updateEstados(string tabla, string set, string valorEstado, string WhereCampo, string id)
        {

            string sql = "UPDATE " + tabla + " SET " + set + " = '" + valorEstado + "' WHERE " + WhereCampo + " = " + id + ";";
            OdbcCommand consulta = new OdbcCommand(sql, con.conexion());
            consulta.ExecuteNonQuery();


        }

        public int contarAlias(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            int Campos = 0;

            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", con.conexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos++;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + tabla.ToUpper() + "\n -"); }
            return Campos;// devuelve un arreglo con los tiposlos campos
        }
        public void insertar(string sql)
        {



            OdbcCommand consulta = new OdbcCommand(sql, con.conexion());
            consulta.ExecuteNonQuery();




        }
        public string obtenerSimple(string tabla, string campo, string condicion, string id)//obtener una simple consulta con condicion
        {
            string resultado = "";
            string sql = "SELECT " + campo + " FROM " + tabla + " WHERE " + condicion + "=" + id + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                resultado = reader.GetValue(0).ToString();
            }
            return resultado;
        }
        public string obteneridmax(string tabla, string dato)// metodo  que obtinene el contenio de una tabla
        {
            string id = "";
            string sql = "SELECT MAX(" + dato + "+1) FROM " + tabla + ";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                id = reader.GetValue(0).ToString();
            }
            return id;
        }

        public string consultar(string sql)// consultar con una cadena sql especifica
        {

            string resultado = " ";

            OdbcCommand consulta = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = consulta.ExecuteReader();

            while (reader.Read())
            {
                resultado = reader.GetValue(0).ToString();

            }

            return resultado;


        }
    }
}
