using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloPa2;

namespace CapaVistaPa2
{
    public partial class Proceso1 : Form
    {
        modelo mo = new modelo();
        public Proceso1()
        {
            InitializeComponent();
            cmbcarrera.llenarse("carreras","codigo_carrera","nombre_carrera");
            cmbalumno.llenarse("alumnos","carnet_alumno","nombre_alumno");
            cmbaula.llenarse("aulas","codigo_aula","nombre_aula");
            cmbcurso.llenarse("cursos","codigo_curso","nombre_curso");
            cmbjor.llenarse("jornadas","codigo_jornada","nombre_jornada");
            cmbseccion.llenarse("secciones","codigo_seccion","nombre_seccion");
            cmbsede.llenarse("sedes","codigo_sede","nombre_sede");
            cmbfacultades.llenarse("facultades","codigo_facultad","nombre_facultad");
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            string carrera = cmbcarrera.obtenerP();
            string sede = cmbsede.obtenerP();
            string jornada = cmbjor.obtenerP();
            string seccion = cmbseccion.obtenerP();
            string aula = cmbaula.obtenerP();
            string curso = cmbcurso.obtenerP();
            string alumno = cmbalumno.obtenerP();
            string asigna = Txt_nota.Text;

            Dgb_pedidosEspeciales.Rows.Add(carrera,sede,jornada,seccion,aula,curso,alumno,asigna);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgb_pedidosEspeciales.SelectedRows.Count == 1)
            {


                Dgb_pedidosEspeciales.Rows.RemoveAt(Dgb_pedidosEspeciales.CurrentRow.Index);
            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            

            foreach (DataGridViewRow row in Dgb_pedidosEspeciales.Rows)
            {
                string cadena = "INSERT INTO asignacioncursosalumnos (codigo_carrera, codigo_sede, codigo_jornada, codigo_seccion, codigo_aula, codigo_curso, carnet_alumno, nota_asignacioncursoalumnos) VALUES ('"+ row.Cells[0].Value.ToString() + "','" + row.Cells[1].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[3].Value.ToString() + "','" + row.Cells[4].Value.ToString() + "','" + row.Cells[5].Value.ToString() + "','" + row.Cells[6].Value.ToString() + "','" + row.Cells[7].Value.ToString() + "');";
                mo.insertar(cadena);
            }

            MessageBox.Show("ALUMNO ASIGNADO");
            this.Close();
        }
    }
}
