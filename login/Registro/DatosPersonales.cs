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
    public partial class DatosPersonales : Form
    {
        private Registrar frmPadre;
        private string dni="";
        public DatosPersonales(Registrar FrmPadre)
        {
            InitializeComponent();
            frmPadre = FrmPadre;
        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            dni=frmPadre.getDNI();
            txtDNI.Text=dni;
        }
    }
}
