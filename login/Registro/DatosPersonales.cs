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
    public partial class DatosPersonales : Form
    {
        private Registrar frmPadre;
        private string dni="";
        public DatosPersonales(Registrar FrmPadre)
        {
            InitializeComponent();
            frmPadre = FrmPadre;
        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            dni=frmPadre.getDNI();
            txtDNI.Text=dni;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regitrarse_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingresar nombre.","Campo vacio");
                txtNombre.Focus();      
            }
            else if(txtApaterno.Text =="")
            {
                MessageBox.Show("Ingresar apellido paterno.", "Campo vacio");
                txtApaterno.Focus();
            }
            else if (txtAmaterno.Text == "")
            {
                MessageBox.Show("Ingresar apellido materno.", "Campo vacio");
                txtAmaterno.Focus();
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingresar contraseña.", "Campo vacio");
                txtContraseña.Focus();
            }
            else if (txtConfirmar.Text == "")
            {
                MessageBox.Show("Ingresar Confirmación de Contraseña.", "Campo vacio");
                txtConfirmar.Focus();
            }
            else if(txtContraseña.Text != txtConfirmar.Text)
            {
                MessageBox.Show("No coinciden las contraseñas.","Corregir Contraseña");

            }
            else
            {
                Conexion cnx = new Conexion();
                SqlConnection coneccion = cnx.getConection();
                try
                {
                    coneccion.Open();
                    SqlCommand comando = new SqlCommand("insert into POSTULANTE values(@DNIpostulante,@APPaterno,@APMaterno,@Nombre,@FechaNacimiento,PWDENCRYPT(@Contraseña),0);", coneccion);

                    comando.Parameters.AddWithValue("@DNIpostulante", txtDNI.Text);
                    comando.Parameters.AddWithValue("@APPaterno", txtApaterno.Text);
                    comando.Parameters.AddWithValue("@APMaterno", txtAmaterno.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    DateTime fecha = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("dd-MM-yyyy"));
                    //comando.Parameters.AddWithValue((int)fecha.Year, (int)fecha.Month, (int)fecha.Day);
                    comando.Parameters.AddWithValue("@FechaNacimiento", fecha);
                    comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                    //SELECT NroRecibo, DNIpostulante FROM RECIBO WHERE NroRecibo = @nroRecibo AND DNIpostulante=@dnipostulante;
                    SqlDataReader lector = comando.ExecuteReader();
                    MessageBox.Show("Sus datos fueron registrados exitosamente.", "Datos Registrados");
                    Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private void DatosPersonales_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPadre.Close();
        }
    }
}
