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
        public Registrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection coneccion = new SqlConnection("server=DESKTOP-FPQPC13 ; database = bdAdmision ; INTEGRATED SECURITY = true");
        private void button2_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            SqlCommand comando = new SqlCommand("SELECT NroRecibo, DNIpostulante FROM Recibo WHERE NroRecibo  = @vNroRecibo AND DNIpostulante = @VDniPostulante", coneccion);
            comando.Parameters.AddWithValue("@vNroRecibo", txtNroRecibo.Text);
            comando.Parameters.AddWithValue("@DniPostulante", txtDni.Text);

            SqlDataReader dr = comando.ExecuteReader();
            int contador = 0;
            while (dr.Read())
            {
                contador++;
            }
            dr.Close();

            if (contador == 1)
            {
    
            }
            else
            {

            }


        }
    }
}
