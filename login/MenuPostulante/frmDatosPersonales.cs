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
    public partial class frmDatosPersonales : Form
    {

        private string DNI = "";
        private string Nombre = "";
        private string APaterno = "";
        private string AMaterno = "";
        private bool Anulacion = false;
        public frmDatosPersonales(string pDNI, string pAPaterno, string pAMaterno, string pNombre, bool pAnulacion)
        {
            InitializeComponent();

            DNI = pDNI;
            Nombre = pNombre;
            APaterno = pAPaterno;
            AMaterno = pAMaterno;
            Anulacion = pAnulacion;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosPersonales_Load(object sender, EventArgs e)
        {
            lblDNI.Text = DNI;
            lblNombre.Text = Nombre;
            lblAPaterno.Text = APaterno;
            lblAMaterno.Text = AMaterno;
            if (Anulacion)
            {
                btnAnulacion.Visible = false;
            }
            else
            {
                lblAnulacion.Visible = false;
            }
        }
        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();
        private void btnAnulacion_Click(object sender, EventArgs e)
        {
            bool aux = false;
            try
            {
                coneccion.Open();

                //SqlCommand comando = new SqlCommand("SELECT DNIpostulante, Contraseña, Nombres, ApellidoPaterno, ApellidoMaterno, Anular FROM POSTULANTE WHERE DNIpostulante = @vusuario AND PWDCOMPARE( @Vcontrasena, Contraseña)=1;", coneccion);

                SqlCommand comando = new SqlCommand("UPDATE POSTULANTE SET Anular = 1 WHERE DNIPostulante = @vusuario", coneccion);
                comando.Parameters.AddWithValue("@vusuario", DNI);

                SqlDataReader lector = comando.ExecuteReader();

                aux= true;
                coneccion.Close();

               
            }
            catch (Exception ex)
            {
                coneccion.Close();
                MessageBox.Show(ex.Message);
            }//*/
            if(aux)
            {
                lblAnulacion.Visible = true;
                btnAnulacion.Visible = false;
            }
        }
    }
}
