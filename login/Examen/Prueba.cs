using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Examen
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdAdmisionDataSet.PRUEBA' Puede moverla o quitarla según sea necesario.
            this.pRUEBATableAdapter.Fill(this.bdAdmisionDataSet.PRUEBA);

        }

        public static string FechaHoy()
        {
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            return (Date);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Id = "", Nombre = "", Mensaje = "", Error = "";
            for (int i = 0; i <= dgvExamenes.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgvExamenes.Rows[3]) != FechaHoy())
                {
                    Mensaje = "Error, revise correctamente la fecha ";

                }
                else
                {
                    
                    if (Convert.ToBoolean(dgvExamenes.Rows[i].Cells["chkSeleccionar"].Value) == true)
                    {
                        Id = dgvExamenes.Rows[i].Cells[1].Value.ToString();
                        Nombre = dgvExamenes.Rows[i].Cells[2].Value.ToString();
                        Mensaje = Nombre + ", prueba seleccionada";
                        evaluar B = new evaluar();
                        B.ShowDialog();
                        this.Hide();
                        MessageBox.Show(Mensaje);
                    }
                    
                }
                
            }
            evaluar A = new evaluar();
            A.ShowDialog();
            this.Hide();
            MessageBox.Show(Mensaje);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
