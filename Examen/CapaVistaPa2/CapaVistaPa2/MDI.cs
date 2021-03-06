﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaDiseno;

namespace CapaVistaPa2
{
    public partial class MDI : Form
    {
        private int childFormNumber = 0;
        sentencia sn = new sentencia();
        string usuarioact;

        public MDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(LblUsuario.Text);
            seguridad.lbl_nombreUsuario.Text = LblUsuario.Text;
            seguridad.ShowDialog();
            sn.insertarBitacora(LblUsuario.Text, "Ingreso ", "Usuarios");
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();

            LblUsuario.Text = login.obtenerNombreUsuario();
            usuarioact = LblUsuario.Text;

        }

        private void MantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento1 frm = new Mantenimiento1(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantnimientoCursos frm = new MantnimientoCursos(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimeintosSeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoSecciones frm = new MantenimientoSecciones(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoDeMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MantenimientoMaestros frm = new MantenimientoMaestros(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void AsignarCursoAAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proceso1 frm = new Proceso1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoFacultadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoFacultades frm = new MantenimientoFacultades(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCarrera frm = new MantenimientoCarrera(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoAula frm = new MantenimientoAula(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoJornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        MantenimientoJornada frm = new MantenimientoJornada(LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoSedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MantenimientoSede  frm = new MantenimientoSede (LblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
