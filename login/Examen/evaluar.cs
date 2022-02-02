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
namespace login.Examen
{
    public partial class evaluar : Form
    {
        public evaluar()
        {
            InitializeComponent();
        }
        //
        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();
        private void button1_Click(object sender, EventArgs e)
        {
            //consulta de las alternativas 
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=1";
            SqlCommand comando =new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while(reader.Read())
            {
                if(reader.GetValue(1).ToString()!="sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();
                    
                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
                
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=1";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question="";
            while(reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }

            evaluar_v1 ventana1 = new evaluar_v1(alt1,alt2,alt3,alt4,alt5);
            ventana1.Pregunta(question);
            ventana1.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana1);
            ventana1.Show();

            Dato.datos.Insert(0, "1");
            coneccion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=2";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=2";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana2 = new evaluar_v1(alt1,alt2,alt3,alt4,alt5);
            ventana2.Pregunta(question);
            ventana2.MdiParent=this;
            splitContainer1.Panel2.Controls.Add(ventana2);
            ventana2.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "2");
            coneccion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=3";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=3";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana3 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana3.Pregunta(question);
            ventana3.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana3);
            ventana3.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "3");
            coneccion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=4";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=4";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }

            evaluar_v1 ventana4 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana4.Pregunta(question);
            ventana4.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana4);
            ventana4.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "4");
            coneccion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=5";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=5";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana5 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana5.Pregunta(question);
            ventana5.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana5);
            ventana5.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "5");
            coneccion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=6";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=6";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana6 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana6.Pregunta(question);
            ventana6.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana6);
            ventana6.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "6");
            coneccion.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=7";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=7";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana7 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana7.Pregunta(question);
            ventana7.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana7);
            ventana7.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "7");
            coneccion.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=8";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=8";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana8 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana8.Pregunta(question);
            ventana8.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana8);
            ventana8.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "8");
            coneccion.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=9";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=9";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana9 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana9.Pregunta(question);
            ventana9.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana9);
            ventana9.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "9");
            coneccion.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            coneccion.Open();
            string query = "select * from viAlternativas2 where NroPregunta=10";
            SqlCommand comando = new SqlCommand(query, coneccion);
            SqlDataReader reader = comando.ExecuteReader();
            string alt1 = "";
            string alt2 = "";
            string alt3 = "";
            string alt4 = "";
            string alt5 = "";

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() != "sinalternativa")
                {
                    alt1 = reader.GetValue(1).ToString();

                }
                if (reader.GetValue(2).ToString() != "sinalternativa")
                {
                    alt2 = reader.GetValue(2).ToString();

                }
                if (reader.GetValue(3).ToString() != "sinalternativa")
                {
                    alt3 = reader.GetValue(3).ToString();

                }
                if (reader.GetValue(4).ToString() != "sinalternativa")
                {
                    alt4 = reader.GetValue(4).ToString();

                }
                if (reader.GetValue(5).ToString() != "sinalternativa")
                {
                    alt5 = reader.GetValue(5).ToString();

                }
            }
            reader.Close();
            //consulta de las preguntas
            string query1 = "select Formulacion from CUESTIONARIO where NroPregunta=10";
            SqlCommand comando1 = new SqlCommand(query1, coneccion);
            SqlDataReader reader1 = comando1.ExecuteReader();
            string question = "";
            while (reader1.Read())
            {
                question = reader1.GetValue(0).ToString();
            }
            evaluar_v1 ventana10 = new evaluar_v1(alt1, alt2, alt3, alt4, alt5);
            ventana10.Pregunta(question);
            ventana10.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(ventana10);
            ventana10.Show();
            Dato.datos.Remove(Dato.datos[0]);
            Dato.datos.Insert(0, "10");
            coneccion.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection coneccion = new SqlConnection("Data Source = PC; Initial Catalog = bdAdmision; Integrated Security = true ");

             

                string query = "INSERT INTO RESPUESTA_POSTULANTE values(@Nropregunta,@respuesta,@Dnipostulante,@idprueba)";
                coneccion.Open();
                SqlCommand comando = new SqlCommand(query, coneccion);
                comando.Parameters.AddWithValue("@Nropregunta", Dato.pregunta1[0]);
                comando.Parameters.AddWithValue("@respuesta", Dato.pregunta1[1]);
                comando.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta1[2]);
                comando.Parameters.AddWithValue("@idprueba", Dato.pregunta1[3]);
                comando.ExecuteNonQuery();
                //MessageBox.Show("se agregó la primera lista");

                SqlCommand comando2 = new SqlCommand(query, coneccion);
                comando2.Parameters.AddWithValue("@Nropregunta", Dato.pregunta2[0]);
                comando2.Parameters.AddWithValue("@respuesta", Dato.pregunta2[1]);
                comando2.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta2[2]);
                comando2.Parameters.AddWithValue("@idprueba", Dato.pregunta2[3]);
                comando2.ExecuteNonQuery();
                //MessageBox.Show("se agregó la segunda lista");


                SqlCommand comando3 = new SqlCommand(query, coneccion);
                comando3.Parameters.AddWithValue("@Nropregunta", Dato.pregunta3[0]);
                comando3.Parameters.AddWithValue("@respuesta", Dato.pregunta3[1]);
                comando3.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta3[2]);
                comando3.Parameters.AddWithValue("@idprueba", Dato.pregunta3[3]);
                comando3.ExecuteNonQuery();
                // MessageBox.Show("se agregó la tercera lista");
                SqlCommand comando4 = new SqlCommand(query, coneccion);
                comando4.Parameters.AddWithValue("@Nropregunta", Dato.pregunta4[0]);
                comando4.Parameters.AddWithValue("@respuesta", Dato.pregunta4[1]);
                comando4.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta4[2]);
                comando4.Parameters.AddWithValue("@idprueba", Dato.pregunta4[3]);
                comando4.ExecuteNonQuery();
                //MessageBox.Show("se agregó la cuarta lista");
                SqlCommand comando5 = new SqlCommand(query, coneccion);
                comando5.Parameters.AddWithValue("@Nropregunta", Dato.pregunta5[0]);
                comando5.Parameters.AddWithValue("@respuesta", Dato.pregunta5[1]);
                comando5.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta5[2]);
                comando5.Parameters.AddWithValue("@idprueba", Dato.pregunta5[3]);
                comando5.ExecuteNonQuery();
                // MessageBox.Show("se agregó la quita lista");
                SqlCommand comando6 = new SqlCommand(query, coneccion);
                comando6.Parameters.AddWithValue("@Nropregunta", Dato.pregunta6[0]);
                comando6.Parameters.AddWithValue("@respuesta", Dato.pregunta6[1]);
                comando6.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta6[2]);
                comando6.Parameters.AddWithValue("@idprueba", Dato.pregunta6[3]);
                comando6.ExecuteNonQuery();

                SqlCommand comando7 = new SqlCommand(query, coneccion);
                comando5.Parameters.AddWithValue("@Nropregunta", Dato.pregunta7[0]);
                comando5.Parameters.AddWithValue("@respuesta", Dato.pregunta7[1]);
                comando5.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta7[2]);
                comando5.Parameters.AddWithValue("@idprueba", Dato.pregunta7[3]);
                comando5.ExecuteNonQuery();

                SqlCommand comando8 = new SqlCommand(query, coneccion);
                comando5.Parameters.AddWithValue("@Nropregunta", Dato.pregunta8[0]);
                comando5.Parameters.AddWithValue("@respuesta", Dato.pregunta8[1]);
                comando5.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta8[2]);
                comando5.Parameters.AddWithValue("@idprueba", Dato.pregunta8[3]);
                comando5.ExecuteNonQuery();

                SqlCommand comando9 = new SqlCommand(query, coneccion);
                comando5.Parameters.AddWithValue("@Nropregunta", Dato.pregunta9[0]);
                comando5.Parameters.AddWithValue("@respuesta", Dato.pregunta9[1]);
                comando5.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta9[2]);
                comando5.Parameters.AddWithValue("@idprueba", Dato.pregunta9[3]);
                comando5.ExecuteNonQuery();

                SqlCommand comando10 = new SqlCommand(query, coneccion);
                comando5.Parameters.AddWithValue("@Nropregunta", Dato.pregunta10[0]);
                comando5.Parameters.AddWithValue("@respuesta", Dato.pregunta10[1]);
                comando5.Parameters.AddWithValue("@Dnipostulante", Dato.pregunta10[2]);
                comando5.Parameters.AddWithValue("@idprueba", Dato.pregunta10[3]);
                comando5.ExecuteNonQuery();
                MessageBox.Show("su examen ah finalizado!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
