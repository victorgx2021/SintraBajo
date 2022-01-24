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
            //*
            
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("SELECT DNIdigitador, Contraseña, Nombres, ApellidoPaterno, ApellidoMaterno  FROM DIGITADOR_UNSAAC WHERE DNIdigitador = @vusuario AND PWDCOMPARE( @Vcontrasena, Contraseña)=1;", coneccion);
                comando.Parameters.AddWithValue("@vusuario", txt1.Text);
                comando.Parameters.AddWithValue("@Vcontrasena", txt2.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    String Nombre = lector.GetString(2);
                    String Apellidos = lector.GetString(3) + " " + lector.GetString(4);
                    coneccion.Close();
                    HomeDigitador pantalla = new HomeDigitador(Nombre, Apellidos);
                    //pantalla.Show();
                    this.Hide();
                    pantalla.ShowDialog();
                    return;
                }
                else
                {
                    coneccion.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("SELECT DNIpostulante, Contraseña, Nombres, ApellidoPaterno, ApellidoMaterno FROM POSTULANTE WHERE DNIpostulante = @vusuario AND PWDCOMPARE( @Vcontrasena, Contraseña)=1;", coneccion);
                comando.Parameters.AddWithValue("@vusuario", txt1.Text);
                comando.Parameters.AddWithValue("@Vcontrasena", txt2.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    String Nombre = lector.GetString(2);
                    String Apellidos = lector.GetString(3) +" "+ lector.GetString(4);
                    coneccion.Close();
                    Home pantalla = new Home(Nombre,Apellidos);
                    //pantalla.Show();
                    this.Hide();
                    pantalla.ShowDialog();
                }
                
                else
                {
                    coneccion.Close();
                    MessageBox.Show("Ingrese usuario y contraseña correctos.", "Datos incorrectos");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//*/
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void labelRegistrarse_Click(object sender, EventArgs e)
        {
            Registrar pantalla = new Registrar();
            this.Hide();
            pantalla.Show();
        }

        private void labelRegistrarse_MouseMove(object sender, MouseEventArgs e)
        {
            labelRegistrarse.Font = new Font(labelRegistrarse.Font.Name, labelRegistrarse.Font.Size, FontStyle.Bold | FontStyle.Underline);
        }

        private void labelRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            labelRegistrarse.Font = new Font(labelRegistrarse.Font.Name, labelRegistrarse.Font.Size, FontStyle.Bold);
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
