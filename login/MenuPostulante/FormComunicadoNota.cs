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
    public partial class FormComunicadoNota : Form
    {
        int nota=-1;
        public FormComunicadoNota(int pNota)
        {
            InitializeComponent();
            nota = pNota;
            if (nota<0)
            {
                lblnota.Visible = false;
            }
            else
            {
                lblnota.Text = nota.ToString();
                lblComunicado.Text = "Su calificación es de:";
            }
        }

        private void FormComunicadoNota_Load(object sender, EventArgs e)
        {
        }
    }
}
