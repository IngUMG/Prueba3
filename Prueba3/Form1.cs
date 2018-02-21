using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconexion;
using AdministradorDeReportes;

namespace Prueba3
{
    public partial class Form1 : Form
    {
        private static short numeroAplicacion =3000;
        

        public Form1()
        {
            InitializeComponent();
            navegador1.IdApp = 2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navegador1.VistaReporte = 1;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navegador1.VistaReporte = 0;
        }

        private void mantenimientoDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorDeReportes.Objetos.dbConexion.dbName = "reporte2";
            AdministradorDeReportes.Objetos.dbConexion.dbServer = "localhost";
            AdministradorDeReportes.Objetos.dbConexion.dbUser = "root";
            AdministradorDeReportes.Objetos.dbConexion.dbPass = "12345";

            Mantenimiento rMante = new Mantenimiento();
            rMante.Show();


        }

        private void listadoDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              
                dllconexion.gReport.establecerParametrosDB("localhost", "root", "reporte2", "12345");
                dllconexion.seleccionPath rLista = new dllconexion.seleccionPath(navegador1.IdApp, 0);
                rLista.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Reportes"); }
        }

        private void listadoDeReportesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {

                dllconexion.gReport.establecerParametrosDB("localhost", "root", "reporte2", "12345");
                dllconexion.seleccionPath rLista = new dllconexion.seleccionPath(navegador1.IdApp, 0);
                rLista.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Reportes"); }

        }
    }
}
