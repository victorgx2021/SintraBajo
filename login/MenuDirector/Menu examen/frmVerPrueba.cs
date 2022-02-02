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
    

    public partial class frmVerPrueba : Form
    {
        private int preguntaAnterior = 1;
        private string[,] Formulacion = new string[10,2];
        private string[,] Alternativas = new string[10,5];

        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();

        public frmVerPrueba(string pid_prueba)
        {
            InitializeComponent();
            lblID.Text = pid_prueba;
            rellenarMatrices();
        }
        private void rellenarMatrices()
        {
            for(int i = 0; i < 10; i++)
            {
                Formulacion[i,0] = "";
                Formulacion[i,1] = "";
            }
            for(int i = 0;i < 10; i++)
            {
                Alternativas[i,0] = "";
                Alternativas[i,1] = "";
                Alternativas[i,2] = "";
                Alternativas[i,3] = "";
                Alternativas[i,4] = "";
            }
        }
        public int getNroP()
        {
            return int.Parse(lblNro.Text);
        }
        public string getID()
        {
            return lblID.Text;
        }
        
        public void get_enunciado()
        {
            /*String enunciado = "";
            String clave = "";
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("exec usp_seleccionar_cuestionario @Nro,@pId", coneccion);
                //int nro = getNroP();
                comando.Parameters.AddWithValue("@Nro", getNroP());
                comando.Parameters.AddWithValue("@pId", getID());                              

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    enunciado = lector.GetString(1);
                    clave = lector.GetString(2);                    
                }                
                coneccion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtEnunciado.Text = enunciado;
            switch(clave)
            {
                case "a":rdba.Select();
                    break;
                case "b":
                    rdbb.Select();
                    break;
                case "c":
                    rdbc.Select();
                    break;
                case "d":
                    rdbd.Select();
                    break;
                case "e":
                    rdbe.Select();
                    break;
            }*/

        }
        public void get_alternativa(string pClave)
        {
            String alternativa="";            
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("exec usp_seleccionar_alternativa @clave,@NroPregunta,@pId", coneccion);
                comando.Parameters.AddWithValue("@clave", pClave);
                comando.Parameters.AddWithValue("@NroPregunta", getNroP());
                comando.Parameters.AddWithValue("@pId", getID());
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    alternativa = lector.GetString(1);                    
                }                
                coneccion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            switch (pClave)
            {
                case "a":
                    txta.Text = alternativa;
                    break;
                case "b":
                    txtb.Text = alternativa;
                    break;
                case "c":
                    txtc.Text = alternativa;
                    break;
                case "d":
                    txtd.Text = alternativa;
                    break;
                case "e":
                    txte.Text = alternativa;
                    break;
            }
        }
        public void guardarCuestionario(string NroPregunta,string enunciado,string ClaveCorrecta)
        {
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("exec usp_insertar_cuestionario @NroPregunta,@enunciado,@clave,@pId", coneccion);
                comando.Parameters.AddWithValue("@NroPregunta", NroPregunta);
                comando.Parameters.AddWithValue("@enunciado", enunciado);
                comando.Parameters.AddWithValue("@clave", ClaveCorrecta);
                comando.Parameters.AddWithValue("@pId", getID());
                comando.ExecuteNonQuery();
                coneccion.Close();
            }
            catch (Exception ex)
            {
                coneccion.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void guardarAlternativa(string NroPregunta,string pClave,string pEnunciado)
        {
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("exec usp_insertar_alternativa @clave,@alternativa,@NroPregunta,@pId", coneccion);
                
                comando.Parameters.AddWithValue("@clave", pClave);
                comando.Parameters.AddWithValue("@alternativa", pEnunciado);
                comando.Parameters.AddWithValue("@NroPregunta", NroPregunta);
                comando.Parameters.AddWithValue("@pId", getID());
                comando.ExecuteNonQuery();
                coneccion.Close();
            }
            catch (Exception ex)
            {
                coneccion.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private string SalvarClaveCorrecta()
        {
            string rpta="";
            if (rdba.Checked) {
                rpta = "a";
            }
            else if (rdbb.Checked)
            {
                rpta = "b";
            }
            else if (rdbc.Checked)
            {
                rpta = "c";
            }
            else if (rdbd.Checked)
            {
                rpta = "d";
            }
            else if (rdbe.Checked)
            {
                rpta = "e";
            }
            
            return rpta;
        }

        private void RecuperarClaveCorrecta(string alternativa) 
        {
            if( alternativa == "a")
            {
                rdba.Checked = true;
            }
            else if ( alternativa == "b")
            {
                rdbb.Checked = true;
            }
            else if ( alternativa == "c")
            {
                rdbc.Checked = true;
            }
            else if ( alternativa == "d")
            {
                rdbd.Checked = true;
            }
            else if ( alternativa == "e")
            {
                rdbe.Checked = true;
            }
            else
            {
                rdba.Checked=true;
                rdba.Checked = false;
            }
        }
        public void guardarPregunta()
        {
            for(int i = 0;i<10; i++)
            {
                guardarCuestionario(i.ToString(),Formulacion[i,0],Formulacion[i,1]);

                for (int j = 0; j < 5; j++)
                {
                    guardarAlternativa(i.ToString(),j.ToString(),Alternativas[i,j]);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInfoActual();
            guardarPregunta();
            this.Close();
        }

        private void GuardarInfoActual()
        {
            //Guardar pregunta antes de cambiar de número
            Formulacion[preguntaAnterior - 1, 0] = txtEnunciado.Text;
            Formulacion[preguntaAnterior - 1, 1] = SalvarClaveCorrecta();

            //Guardar alternativas de las preguntas
            Alternativas[preguntaAnterior - 1, 0] = txta.Text;
            Alternativas[preguntaAnterior - 1, 1] = txtb.Text;
            Alternativas[preguntaAnterior - 1, 2] = txtc.Text;
            Alternativas[preguntaAnterior - 1, 3] = txtd.Text;
            Alternativas[preguntaAnterior - 1, 4] = txte.Text;
        }
        private void ActualizarForm(int pPreguntaActual)
        {            
            GuardarInfoActual();

            //Actualizar frm
            preguntaAnterior = pPreguntaActual;
            lblNro.Text = preguntaAnterior.ToString();

            txtEnunciado.Text = Formulacion[preguntaAnterior - 1, 0];
            RecuperarClaveCorrecta(Formulacion[preguntaAnterior - 1, 1]);

            txta.Text = Alternativas[preguntaAnterior - 1, 0];
            txtb.Text = Alternativas[preguntaAnterior - 1, 1];
            txtc.Text = Alternativas[preguntaAnterior - 1, 2];
            txtd.Text = Alternativas[preguntaAnterior - 1, 3];
            txte.Text = Alternativas[preguntaAnterior - 1, 4];
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(1);
        }
        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {

            ActualizarForm(2);
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(3);
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(4);
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(5);
        }

        private void rdb6_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(6);
        }

        private void rdb7_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(7);
        }

        private void rdb8_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(8);
        }

        private void rdb9_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(9);
        }

        private void rdb10_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarForm(10);
        }        
    }
}
