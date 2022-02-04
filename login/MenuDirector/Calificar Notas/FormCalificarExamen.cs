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
    public partial class FormCalificarExamen : Form
    {
        private string idExamen;
        public FormCalificarExamen(string pidExamen)
        {
            InitializeComponent();
            idExamen = pidExamen;
            lblID.Text = idExamen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {

        }
    }
}
