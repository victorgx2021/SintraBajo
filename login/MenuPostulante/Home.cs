using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Home : Form
    {
        private string DNI = "";
        private string Nombre = "";
        private string APaterno = "";
        private string AMaterno = "";
        private bool Anulacion = false;
        public Home(string pDNI, string pAPaterno, string pAMaterno, string pNombre, bool pAnulacion, string pApellido)
        {
            InitializeComponent();
            lblNombre.Text = pNombre;
            lblApellidos.Text = pApellido;

            DNI = pDNI;
            Nombre = pNombre;
            APaterno = pAPaterno;
            AMaterno = pAMaterno;
            Anulacion = pAnulacion;
        }

        public string GetDNI()
        {
            return DNI;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetAPaterno()
        {
            return APaterno;
        }
        public string GetAMaterno()
        {
            return AMaterno;
        }
        public bool GetAnulacion()
        {
            return Anulacion;
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            buttonDatos.PerformClick();
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            frmDatosPersonales frm = new frmDatosPersonales(GetDNI(), GetAPaterno(), GetAMaterno(), GetNombre(), GetAnulacion());
            frm.TopLevel = false;//No es un formulario de nivel superior (es formulario dentro de otro)
            //fh.FormBorderStyle = FormBorderStyle.None;
            //frm.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(frm);
            this.panelContenido.Tag = frm;
            frm.Show();
        }

        private void buttonRendirExam_Click(object sender, EventArgs e)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            FormExamenPostulante frm = new FormExamenPostulante("0001",DNI);
            frm.TopLevel = false;//No es un formulario de nivel superior (es formulario dentro de otro)
            //fh.FormBorderStyle = FormBorderStyle.None;
            //frm.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(frm);
            this.panelContenido.Tag = frm;
            frm.Show();
        }
    }
}
