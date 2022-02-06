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
    public partial class FormCalificarExamen : Form
    {
        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();
        private string idExamen;
        public FormCalificarExamen(string pidExamen)
        {
            InitializeComponent();
            idExamen = pidExamen;
            lblID.Text = idExamen;
            Ver(idExamen);
        }
        public void Ver(string pIDPrueba)
        {
            btnCalificar.Visible = false;
            try
            {
                coneccion.Open();
                string consulta = "exec usp_listar_examenes '"+pIDPrueba+"'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvNotas.DataSource = dt;
                coneccion.Close();
            }
            catch (Exception e)
            {
                coneccion.Close();
                MessageBox.Show(e.Message);
            }
            RedimensionarColumnas();
            if(dgvNotas.Rows.Count != 0) 
            {
                if(int.Parse(dgvNotas.Rows[0].Cells[1].Value.ToString()) <= 0)
                {
                    btnCalificar.Visible = true;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RedimensionarColumnas()
        {
            dgvNotas.Columns[0].Width = 134;
            dgvNotas.Columns[1].Width = 134;
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            int rango = dgvNotas.RowCount;
            for (int i = 0; i < rango; i++)
            {
                try
                {
                    coneccion.Open();
                    SqlCommand comando = new SqlCommand("exec usp_calificar_postulante @IDprueba, @DNIpostulante", coneccion);
                    comando.Parameters.AddWithValue("IDprueba", idExamen);
                    comando.Parameters.AddWithValue("@DNIpostulante", dgvNotas.Rows[i].Cells[0].Value.ToString());
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                coneccion.Close();
            }
            Ver(idExamen);
        }
    }
}
