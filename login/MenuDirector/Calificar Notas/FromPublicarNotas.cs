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
    public partial class FromPublicarNotas : Form
    {
        static Conexion cnx = new Conexion();
        SqlConnection coneccion = cnx.getConection();

        DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();

        public FromPublicarNotas()
        {
            InitializeComponent();

            colBotones.Name = "columnVer";
            colBotones.HeaderText = "Ver...";
            colBotones.Text = "Ver...";
            colBotones.Width = 40;
            colBotones.UseColumnTextForButtonValue = true;
        }

        public void Ver()
        {
            try {
                coneccion.Open();
                string consulta = "select IdPrueba,Tipo,Fecha,Hora from PRUEBA";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                coneccion.Close();
            }
            catch(Exception e) 
            {
                coneccion.Close();
                MessageBox.Show(e.Message);
            }            
        }

        private void FromPublicarNotas_Load(object sender, EventArgs e)
        {
            Ver();
            AgregarColumnaBotones();
            RedimensionarColumnas();
        }

        private void AgregarColumnaBotones()
        {
            this.dataGridView1.Columns.Add(colBotones);
        }

        private void RedimensionarColumnas()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 98;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se convierte el objeto en el que se hizo clic a un dataGridView 
            var senderGrid = (DataGridView)sender;

            //Si la columna que se hizo clic es una columna de boton y el indice de la fila al hacer clic es 0 o mayor, entonces
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //Se recupera el indice de la fila y de la columna
                int row = e.RowIndex;
                int col = e.ColumnIndex;

                string id = dataGridView1.Rows[row].Cells[1].Value.ToString();

                FormCalificarExamen frm = new FormCalificarExamen(id);
                frm.Show();
            }
        }
    }
}
