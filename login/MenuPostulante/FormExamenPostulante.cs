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
    public partial class FormExamenPostulante : Form
    {
        private string DNI;
        private string idExamen;
        private int preguntaAnterior = 1;
        private string[,] Formulacion = new string[10, 2];
        private string[,] Alternativas = new string[10, 5];

        private string[] respuestas = { "", "", "", "", "", "", "", "", "", "" };

        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();
        public FormExamenPostulante(string pIdExamen, string pDNI)
        {
            InitializeComponent();
            idExamen = pIdExamen;
            DNI= pDNI;
            lblDNI.Text = pDNI;
            lblID.Text = pIdExamen;

        }

        private int textoAnumero(string alternativa) { 
            if(alternativa == "a")
            {
                return 1;
            }
            else if (alternativa == "b")
            {
                return 2;
            }
            else if (alternativa == "c")
            {
                return 3;
            }
            else if (alternativa == "d")
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        private string numeroAtexto(int alternativa) { 
            if(alternativa == 1)
            {
                return "a";
            }
            else if (alternativa == 2)
            {
                return "b";
            }
            else if (alternativa == 3)
            {
                return "c";
            }
            else if (alternativa == 4)
            {
                return "d";
            }
            else
            {
                return "e";
            }
        }

        public void get_enunciado(int nroPregunta)
        {
            String enunciado = "";
            String clave = "";
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("exec usp_seleccionar_cuestionario @Nro,@pId", coneccion);
                //int nro = getNroP();
                comando.Parameters.AddWithValue("@Nro", nroPregunta);
                comando.Parameters.AddWithValue("@pId", idExamen);                              

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    enunciado = lector.GetString(1);
                    clave = lector.GetString(2);                    
                }
                Formulacion[nroPregunta - 1, 0] = enunciado;
                Formulacion[nroPregunta - 1, 1] = clave;
                coneccion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                coneccion.Close();
            }
        }
        public void get_alternativa(string pClave, int nroPregunta)
        {
            String alternativa = "";
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("exec usp_seleccionar_alternativa @clave,@NroPregunta,@pId", coneccion);
                comando.Parameters.AddWithValue("@clave", pClave);
                comando.Parameters.AddWithValue("@NroPregunta", nroPregunta);
                comando.Parameters.AddWithValue("@pId", idExamen);
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    alternativa = lector.GetString(1);
                }
                int a = textoAnumero(pClave);
                Alternativas[nroPregunta - 1, a - 1] = alternativa;
                coneccion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                coneccion.Close();
            }
        }

        private void FormExamenPostulante_Load(object sender, EventArgs e)
        {
            //Rellenar Formulacion y Alternativa
            for (int i = 0; i < 10; i++)
            {
                get_enunciado(i + 1);

                for(int j = 0; j < 5; j++)
                {
                    get_alternativa(numeroAtexto(j + 1), i + 1);
                }
            }

            ActualizarForm(1);
        }

        private void ActualizarForm(int nroPregunta)
        {
            txtEnunciado.Text = Formulacion[nroPregunta -1, 0];

            txta.Text = Alternativas[nroPregunta - 1, 0];
            txtb.Text = Alternativas[nroPregunta - 1, 1];
            txtc.Text = Alternativas[nroPregunta - 1, 2];
            txtd.Text = Alternativas[nroPregunta - 1, 3];
            txte.Text = Alternativas[nroPregunta - 1, 4];
        }

        private void ConservarRespuesta(int nroPregunta)
        {
            if(rdba.Checked == true)
            {
                respuestas[nroPregunta - 1] = "a";
            }
            else if (rdbb.Checked == true)
            {
                respuestas[nroPregunta -1] = "b";
            }
            else if (rdbc.Checked == true)
            {
                respuestas[nroPregunta - 1] = "c";
            }
            else if(rdbd.Checked == true)
            {
                respuestas[nroPregunta - 1] = "d";
            }
            else if(rdbe.Checked == true)
            {
                respuestas[nroPregunta - 1] = "e";
            }
        }

        private void RecuperarRespuesta(int nroPregunta)
        {
            rdba.Checked = false;
            rdbb.Checked = false;
            rdbc.Checked = false;
            rdbd.Checked = false;
            rdbe.Checked = false;

            string aux = respuestas[nroPregunta - 1];

            if (aux == "a")
            {
                rdba.Checked = true;
            }
            else if(aux == "b")
            {
                rdbb.Checked = true;
            }
            else if( aux == "c")
            {
                rdbc.Checked = true;
            }
            else if( aux == "d")
            {
                rdbd.Checked = true;
            }
            else if (aux == "e")
            {
                rdbe.Checked = true;
            }
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb1.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 1;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 2;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 3;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb4.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 4;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb5.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 5;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb6_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb6.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 6;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb7_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb7.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 7;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb8_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb8.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 8;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb9_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb9.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 9;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void rdb10_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb10.Checked == true)
            {
                ConservarRespuesta(preguntaAnterior);
                preguntaAnterior = 10;
                ActualizarForm(preguntaAnterior);
                RecuperarRespuesta(preguntaAnterior);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool aux = false;
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("exec usp_insertar_prueba -1,@dni,@IdPrueba", coneccion);
                comando.Parameters.AddWithValue("@dni", DNI);
                comando.Parameters.AddWithValue("@IdPrueba", lblID.Text);
                comando.ExecuteNonQuery();
                coneccion.Close();
                aux=true;
            }
            catch (Exception ex)
            {
                coneccion.Close();
                MessageBox.Show(ex.Message);
            }

            if (aux)
            {

                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        coneccion.Open();
                        SqlCommand comando = new SqlCommand("exec usp_insertar_respuesta_postulante @NroPregunta,@Respuesta,@DNIpostulante,@IdPrueba", coneccion);
                        comando.Parameters.AddWithValue("@NroPregunta", i + 1);
                        comando.Parameters.AddWithValue("@Respuesta", respuestas[i]);
                        comando.Parameters.AddWithValue("@DNIpostulante", DNI);
                        comando.Parameters.AddWithValue("@IdPrueba", lblID.Text);
                        comando.ExecuteNonQuery();
                        coneccion.Close();
                    }
                    catch (Exception ex)
                    {
                        coneccion.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Datos registrados exitosamente");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
