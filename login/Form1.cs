using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection coneccion = new SqlConnection("server=DESKTOP-FPQPC13 ; database = Tutorial ; INTEGRATED SECURITY = true");

        private void btn_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASENA FROM PERSONA WHERE USUARIO = @vusuario AND CONTRASENA = @Vcontrasena", coneccion);
            comando.Parameters.AddWithValue("@vusuario",txt1.Text);
            comando.Parameters.AddWithValue("@Vcontrasena", txt2.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if(lector.Read())
            {
                coneccion.Close();
                Home pantalla=new Home();
                pantalla.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar pantalla = new Registrar();
            pantalla.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }
    }
}
