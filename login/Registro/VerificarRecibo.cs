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
    public partial class VerificarRecibo : Form
    {
        private Registrar frmPadre;
        public VerificarRecibo(Registrar FrmPadre)
        {
            InitializeComponent();
            frmPadre = FrmPadre;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmPadre.setDNI(txtDNI.Text);
            Close();
        }

        private void VerificarRecibo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPadre.AbrirDatosPersonales();
        }
    }
}
