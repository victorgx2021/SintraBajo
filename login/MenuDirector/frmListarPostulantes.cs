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
    public partial class frmListarPostulantes : Form
    {
        public frmListarPostulantes()
        {
            InitializeComponent();
            Inicializar();
        }

        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();
        private void Inicializar()
        {

            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("SELECT DNIpostulante, Nombres, ApellidoPaterno, ApellidoMaterno FROM POSTULANTE ;", coneccion);


                SqlDataReader lector = comando.ExecuteReader();
                string DNI = " ";
                string Nombre = " ";
                string APaterno = " ";
                string AMaterno = " ";
                bool r = false;

                while (lector.Read())
                {
                    DNI = lector.GetString(0);
                    Nombre = lector.GetString(1);
                    APaterno = lector.GetString(2);
                    AMaterno = lector.GetString(3);
                    r = true;
                    dataGridView1.Rows.Add(DNI, APaterno, AMaterno, Nombre);


                }
                RedimensionarColumnas();
                if (r)
                {
                    coneccion.Close();
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
        private void RedimensionarColumnas()
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 140;
        }
    }
}

