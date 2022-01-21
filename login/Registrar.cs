using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Registrar : Form
    {
        private string dni="";
        
        public Registrar()
        {
            InitializeComponent();
      

        }

        SqlConnection coneccion = new SqlConnection("server=DESKTOP-FPQPC13 ; database = bdAdmision ; INTEGRATED SECURITY = true");

        public void setDNI(string Dni)
        {
            dni = Dni;
        }
        public string getDNI() { return dni; }
        public void AbrirDatosPersonales()
        {
            DatosPersonales frm = new DatosPersonales(this);
            frm.TopLevel = false;
            this.paneDatos.Controls.Add(frm);
            this.paneDatos.Tag = frm;
            frm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            VerificarRecibo frm = new VerificarRecibo(this);
            frm.TopLevel = false;
            this.paneDatos.Controls.Add(frm);
            this.paneDatos.Tag = frm;
            frm.Show();
        }

        private void Registrar_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void paneDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
