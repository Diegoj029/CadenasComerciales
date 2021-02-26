using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenasComerciales {
    public partial class Form1 : Form {
        //Variables de la Clase
        GestorBD.GestorBD GestorBD;

        public Form1() {
            InitializeComponent();
        }

        //Acciones iniciales al cargar la forma.
        private void Form1_Load(object sender, EventArgs e) {
            //Crear la conexión a la base de datos
            GestorBD = new GestorBD.GestorBD("SQLNCLI11", "PC-DIEGO", "sa", "adminadmin", "CadenasComerciales");
        }

        //Termina la ejecución al presionar el botón "Salir"
        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //Abre la Form FrmConsultas con el constructor con parametros:
        //Un entero que identifica el botón pulsado [0,1,2,3] para realizar la consulta.
        //GestorBD conectado a la base de datos
        private void cadenasToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultas frmCon = new FrmConsultas(0,GestorBD);
            frmCon.Show();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultas frmCon = new FrmConsultas(1,GestorBD);
            frmCon.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultas frmCon = new FrmConsultas(2,GestorBD);
            frmCon.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmConsultas frmCon = new FrmConsultas(3,GestorBD);
            frmCon.Show();
        }

        private void verComprasDelClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmClienteCompra frmclicom = new FrmClienteCompra(GestorBD);
            frmclicom.Show();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e) {
            RegistraCompra rgc = new RegistraCompra(GestorBD);
            rgc.ShowDialog();
        }
    }
}
