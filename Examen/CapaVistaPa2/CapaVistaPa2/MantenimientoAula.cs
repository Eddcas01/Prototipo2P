﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaPa2
{
    public partial class MantenimientoAula : Form
    {
        string usuario = "";

        public MantenimientoAula(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "COD AULA","NOMBRE","ESTADO" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
       
            navegador1.asignarTabla("aulas");
            navegador1.asignarNombreForm("");

        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
