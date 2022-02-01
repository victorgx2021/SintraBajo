﻿using System;
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
        public frmExamen()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text!="")
            {
                frmVerPrueba formVerPrueba = new frmVerPrueba(textBoxID.Text);
                formVerPrueba.Show();
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection coneccion = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bdAdmision; Integrated Security = true ");
        //SqlConnection coneccion = new SqlConnection("Data Source = DESKTOP-FPQPC13; Initial Catalog = bdAdmision; Integrated Security = true ");
        public void Ver(object sender, EventArgs e)
        {
            coneccion.Open();
            string consulta = "select * from PRUEBA";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            coneccion.Close();

        }
        private void frmExamen_Load(object sender, EventArgs e)
        { 
            Ver(sender, e);

        }

        

        

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Ingresar ID.", "Campo vacio");
                textBoxID.Focus();
            }
            else if (comboBoxTipo.Text == "")
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
            else if (textBoxDNI.Text == "")
            {
                MessageBox.Show("Ingresar DNI.", "Campo vacio");
                textBoxDNI.Focus();
            }
            else
            {
                bool aux = false;
                try
                {
                    coneccion.Open();
                    SqlCommand comando = new SqlCommand("insert into PRUEBA values(@ID,@TIPO,@FECHA,@HORA,@DNI);", coneccion);

                    comando.Parameters.AddWithValue("@ID", textBoxID.Text);
                    comando.Parameters.AddWithValue("@TIPO", comboBoxTipo.Text);

                    //comando.Parameters.AddWithValue("@DNI", txtNombre.Text);
                    DateTime fecha = Convert.ToDateTime(dateTimePicker_Fecha.Value.Date.ToString("dd-MM-yyyy"));
                    //comando.Parameters.AddWithValue((int)fecha.Year, (int)fecha.Month, (int)fecha.Day);
                    comando.Parameters.AddWithValue("@FECHA", fecha);
                    DateTime hora = Convert.ToDateTime(dateTimeHORA.Value.Date.ToString("hh:mm:ss"));
                    comando.Parameters.AddWithValue("@HORA", hora);
                    comando.Parameters.AddWithValue("@DNI", textBoxDNI.Text);
                    SqlDataReader lector = comando.ExecuteReader();
                    MessageBox.Show("Sus datos fueron registrados exitosamente.", "Datos Registrados");

                    coneccion.Close();
                    Ver(sender, e);
                    aux = true;

                }
                catch (Exception ex)
                {
                    coneccion.Close();
                    MessageBox.Show(ex.Message, "ERROR");
                }
                if (aux)
                {
                    frmVerPrueba formVerPrueba = new frmVerPrueba(textBoxID.Text);
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