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
    public partial class frmExamen : Form
    {
        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();
        private string DNI;

        public frmExamen(string pDNI)
        {
            InitializeComponent();
            DNI = pDNI;
        }
        
        public void Ver(object sender, EventArgs e)
        {
            try
            {
                coneccion.Open();
                string consulta = "select * from PRUEBA";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                coneccion.Close();
            }
            catch (Exception error)
            {
                coneccion.Close();
                MessageBox.Show(error.Message);
            }

        }
        private void frmExamen_Load(object sender, EventArgs e)
        { 
            Ver(sender, e);

        }
        int id = -1;
        private int ObtenerNroPrueba() {
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("SELECT COUNT(IDPRUEBA) FROM PRUEBA;", coneccion);

                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    id = lector.GetInt32(0);
                    id++;
                }
                coneccion.Close();
            }
            catch (Exception ex)
            {
                coneccion.Close();
                MessageBox.Show(ex.Message, "ERROR 60");
            }

            return id;
        }

        private string ProcesarId(int pid) 
        {
            int l = pid.ToString().Length;
            l = 4 - l;
            string rpta = "";
            for (int i = 0; i < l; i++)
            {
                rpta += "0";
            }
            rpta += pid.ToString();
            return rpta;
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {if (comboBoxTipo.Text == "")
            {
                MessageBox.Show("Ingresar Tipo.", "Campo vacio");
                comboBoxTipo.Focus();
            }
            else if (dateTimePicker_Fecha.Text == "")
            {
                MessageBox.Show("Ingresar Fecha.", "Campo vacio");
                dateTimePicker_Fecha.Focus();
            }
            else if (dateTimeHORA.Text == "")
            {
                MessageBox.Show("Ingresar Hora.", "Campo vacio");
                dateTimeHORA.Focus();
            }
            else
            {
                bool aux = false;
                try
                {
                    ObtenerNroPrueba();
                    coneccion.Open();
                    SqlCommand comando = new SqlCommand("insert into PRUEBA values(@ID,@TIPO,@FECHA,@HORA,@DNI);", coneccion);

                    comando.Parameters.AddWithValue("@ID", ProcesarId(id));
                    comando.Parameters.AddWithValue("@TIPO", comboBoxTipo.Text.Substring(3));

                    //comando.Parameters.AddWithValue("@DNI", txtNombre.Text);
                    DateTime fecha = Convert.ToDateTime(dateTimePicker_Fecha.Value.Date.ToString("dd-MM-yyyy"));
                    //comando.Parameters.AddWithValue((int)fecha.Year, (int)fecha.Month, (int)fecha.Day);
                    comando.Parameters.AddWithValue("@FECHA", fecha);
                    DateTime hora = Convert.ToDateTime(dateTimeHORA.Value.Date.ToString("hh:mm:ss"));
                    comando.Parameters.AddWithValue("@HORA", hora);
                    comando.Parameters.AddWithValue("@DNI", DNI);
                    SqlDataReader lector = comando.ExecuteReader();
                    MessageBox.Show("Sus datos fueron registrados exitosamente.", "Datos Registrados");

                    coneccion.Close();
                    Ver(sender, e);
                    aux = true;
                }
                catch (Exception ex)
                {
                    coneccion.Close();
                    MessageBox.Show(ex.Message, "ERROR 124");
                }
                if (aux)
                {
                    frmVerPrueba formVerPrueba = new frmVerPrueba(ProcesarId(id));
                    formVerPrueba.Show();
                }
            }

        }

        private void frmExamen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("CERRANDO..");
        }
    }
}
