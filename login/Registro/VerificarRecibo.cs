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
    public partial class VerificarRecibo : Form
    {
        private bool correcto = false;

        private Registrar frmPadre;
        public VerificarRecibo(Registrar FrmPadre)
        {
            InitializeComponent();
            frmPadre = FrmPadre;
        }
        SqlConnection coneccion = new SqlConnection("Data Source = DESKTOP-FPQPC13; Initial Catalog = bdAdmision; Integrated Security = true ");
        private void btn_Click(object sender, EventArgs e)
        {

            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("SELECT DNIpostulante FROM POSTULANTE WHERE DNIpostulante=@dnipostulante;", coneccion);
                comando.Parameters.AddWithValue("@dnipostulante", txtDNI.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    MessageBox.Show("Número de DNI ya registrado, Inicie sesión.", "DNI Registrado");
                    coneccion.Close();
                    Close();
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
            //INGRESO DE DATOS DE RECIBOS
            try
            {
                coneccion.Open();
                SqlCommand comando = new SqlCommand("SELECT NroRecibo, DNIpostulante FROM RECIBO WHERE NroRecibo = @nroRecibo AND DNIpostulante=@dnipostulante;", coneccion);
                comando.Parameters.AddWithValue("@nroRecibo", txtRecibo.Text);
                comando.Parameters.AddWithValue("@dnipostulante", txtDNI.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    coneccion.Close();
                    correcto=true;

                }
                else
                {
                    MessageBox.Show("Número de DNI no corresponde al Número de recibo o Número de recibo incorrecto. \n Corregir Datos.", "Datos incorrectos");
                    coneccion.Close();
                    return;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            frmPadre.setDNI(txtDNI.Text);
            Close();
        }

        private void VerificarRecibo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (correcto == true)
            {
                frmPadre.AbrirDatosPersonales();
            }
            else
            {
                frmPadre.Close();
            }
        }
    }
}
