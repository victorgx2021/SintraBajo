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


        //SqlConnection coneccion = new SqlConnection("server=DESKTOP-AGNSDTC/SQLEXPRESS ; database = bdAdmision ; INTEGRATED SECURITY = true");
       
        SqlConnection coneccion = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bdAdmision; Integrated Security = true ");
        private void btn_Click(object sender, EventArgs e)
        {
            
            if(labeluser.Text == "POSTULANTE")
            {
                try
                {
                    coneccion.Open();
                    SqlCommand comando = new SqlCommand("SELECT DNIpostulante, Contraseña FROM POSTULANTE WHERE DNIpostulante = @vusuario AND PWDCOMPARE( @Vcontrasena, Contraseña)=1;", coneccion);
                    comando.Parameters.AddWithValue("@vusuario", txt1.Text);
                    comando.Parameters.AddWithValue("@Vcontrasena", txt2.Text);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        coneccion.Close();
                        Home pantalla = new Home();
                        pantalla.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese usuario y contraseña correctos.", "Datos incorrectos");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    coneccion.Open();
                    SqlCommand comando = new SqlCommand("SELECT DNIdigitador, Contraseña FROM DIGITADOR_UNSAAC WHERE DNIdigitador = @vusuario AND PWDCOMPARE( @Vcontrasena, Contraseña)=1;", coneccion);
                    comando.Parameters.AddWithValue("@vusuario", txt1.Text);
                    comando.Parameters.AddWithValue("@Vcontrasena", txt2.Text);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        coneccion.Close();
                        HomeDigitador pantalla = new HomeDigitador();
                        pantalla.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese usuario y contraseña correctos.", "Datos incorrectos");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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

        private void label4_Click(object sender, EventArgs e)
        {
            if(labeluser.Text=="POSTULANTE")
            {
                labeluser.Text = "DIGITADOR";

            }
            else { labeluser.Text = "POSTULANTE"; }
        }
    }
}
