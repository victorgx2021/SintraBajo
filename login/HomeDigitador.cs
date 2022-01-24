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
    }
}
