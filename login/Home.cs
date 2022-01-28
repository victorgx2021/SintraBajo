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
        public Home(string pNombre, string pApellido)
        {
            InitializeComponent();
            lblNombre.Text = pNombre;
            lblApellidos.Text = pApellido;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDatos_MouseMove(object sender, MouseEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRendirExam_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void buttonVerNota_Click(object sender, EventArgs e)
        {

        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
