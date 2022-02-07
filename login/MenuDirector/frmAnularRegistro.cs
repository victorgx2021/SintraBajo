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
    public partial class frmAnularRegistro : Form
    {
        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();

        DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();

        public frmAnularRegistro()
        {
            InitializeComponent();

            colBotones.Name = "columnEliminar";
            colBotones.HeaderText = "Eliminar";
            colBotones.Text = "Eliminar";
            colBotones.Width = 40;
            colBotones.UseColumnTextForButtonValue = true;
        }

        public void Ver()
        {
            try
            {
                coneccion.Open();
                string consulta = "select DNIpostulante, ApellidoPaterno, ApellidoMaterno, Nombres from POSTULANTE where Anular=1";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvPostulantes.DataSource = dt;
                coneccion.Close();
            }
            catch (Exception error)
            {
                coneccion.Close();
                MessageBox.Show(error.Message);
            }
        }
        private void RedimensionarColumnas()
        {
            dgvPostulantes.Columns[0].Width = 84;
            //dataGridView1.Columns[1].Width = 134;
            //dataGridView1.Columns[2].Width = 134;
            //dataGridView1.Columns[3].Width = 134;
            dgvPostulantes.Columns[4].Width = 76;
        }

        private void frmAnularRegistro_Load(object sender, EventArgs e)
        {
            Ver();
            AgregarColumnaBotones();
            RedimensionarColumnas();
        }

        private void AgregarColumnaBotones()
        {
            this.dgvPostulantes.Columns.Add(colBotones);
        }

        private void dgvPostulantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se convierte el objeto en el que se hizo clic a un dataGridView 
            var senderGrid = (DataGridView)sender;

            //Si la columna que se hizo clic es una columna de boton y el indice de la fila al hacer clic es 0 o mayor, entonces
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //Se recupera el indice de la fila y de la columna
                int row = e.RowIndex;
                int col = e.ColumnIndex;

                string DNI = dgvPostulantes.Rows[row].Cells[1].Value.ToString();

                string apellidos = dgvPostulantes.Rows[row].Cells[2].Value.ToString() + dgvPostulantes.Rows[row].Cells[3].Value.ToString();
                string nombre = dgvPostulantes.Rows[row].Cells[4].Value.ToString();

                string mnsj = "¿Está seguro de eliminar el registro del postulante?\n" +
                                "DNI: " + DNI + "\nNombre(es): " + nombre + "\nApellidos: " + apellidos;

                DialogResult dialogResult = MessageBox.Show(mnsj, "Eliminar Registro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        coneccion.Open();
                        SqlCommand comando = new SqlCommand("delete from POSTULANTE where DNIpostulante = @dni;", coneccion);
                        comando.Parameters.AddWithValue("@dni", DNI);

                        SqlDataReader lector = comando.ExecuteReader();

                        coneccion.Close();
                        MessageBox.Show("Se eliminó el registro del postulante exitosamente.");
                        Ver();
                    }
                    catch (Exception ex)
                    {
                        coneccion.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                /*else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("se cancelo");
                }*/
            }
        }
    }    
}
