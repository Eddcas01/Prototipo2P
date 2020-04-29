using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaControladorPa2;
using System.Data.Odbc;

namespace CapaModeloPa2
{
    public class modelo
    {



        sentencias sn = new sentencias();

        public DataTable consultaLogica0(string tabla, string campoOrden)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl0(tabla, campoOrden);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica(string tabla)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public int contarCampos(string tabla)
        {
            return sn.contarAlias(tabla);
        }

        public DataTable consultaLogica2(string sql)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl2(sql);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica3(string where)  //obtener datos de la consulta
        {

            OdbcDataAdapter dt = sn.llenaTbl3(where);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    

        public string ObtenerSimple(string tabla, string campo, string condicion, string id)  //obtener datos de la consulta
        {

            string resul = sn.obtenerSimple(tabla, campo, condicion, id);
            return resul;
        }
        public string idmax(string tabla, string dato)
        {



            string idmax = sn.obteneridmax(tabla, dato);
            if (idmax == "")
            {

                idmax = "1";
            }


            return idmax;
        }
        public string consulta(string sql)
        {

            string resultado = sn.consultar(sql);

            return resultado;
        }

        public void insertar(string sql)
        {

            sn.insertar(sql);

        }


        public void updateestados(string tabla, string set, string valorEstado, string WhereCampo, string id)
        {


            sn.updateEstados(tabla, set, valorEstado, WhereCampo, id);

        }

    }
}
