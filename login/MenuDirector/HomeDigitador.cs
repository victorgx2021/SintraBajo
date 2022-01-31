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
    public partial class HomeDigitador : Form
    {
        public HomeDigitador(String pNombre, String pApellido)
        {
            InitializeComponent();
            lblApellidos.Text = pApellido;
            lblNombre.Text = pNombre;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            if (this.pnlContenido.Controls.Count > 0)
                this.pnlContenido.Controls.RemoveAt(0);
            frmListarPostulantes frm = new frmListarPostulantes();
            frm.TopLevel = false;//No es un formulario de nivel superior (es formulario dentro de otro)
            //fh.FormBorderStyle = FormBorderStyle.None;
            //frm.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(frm);
            this.pnlContenido.Tag = frm;
            frm.Show();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVerNota_Click(object sender, EventArgs e)
        {
            if (this.pnlContenido.Controls.Count > 0)
                this.pnlContenido.Controls.RemoveAt(0);
            frmExamen frm = new frmExamen();
            frm.TopLevel = false;//No es un formulario de nivel superior (es formulario dentro de otro)
            //fh.FormBorderStyle = FormBorderStyle.None;
            //frm.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(frm);
            this.pnlContenido.Tag = frm;
            frm.Show();
        }
    }
}
