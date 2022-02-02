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
    public partial class evaluar_v1 : Form
    {
        public evaluar_v1(string alter1, string alter2, string alter3,string alter4,string alter5)
        {
            InitializeComponent();
            
            checkBox1.Text = alter1;
            checkBox2.Text = alter2;
            checkBox3.Text = alter3;
            checkBox4.Text = alter4;
            checkBox5.Text = alter5;
        }
        public void Pregunta(string quest)
        {
            label1.Text = quest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            if (checkBox1.Checked == true)
                respuesta = "a";
            if (checkBox2.Checked == true)
                respuesta = "b";
            if (checkBox3.Checked == true)
                respuesta = "c";
            if (checkBox4.Checked == true)
                respuesta = "d";
            if (checkBox5.Checked == true)
                respuesta = "e";
            Dato.datos.Insert(1, respuesta);
            if (Dato.datos[0] == "1")
            {

                foreach (string a in Dato.datos)
                    Dato.pregunta1.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "2")
            {
                foreach (string b in Dato.datos)
                    Dato.pregunta2.Add(b);
                //int g = Dato.datos.IndexOf(respuesta);
                //MessageBox.Show(Dato.datos[4]);
                Dato.datos.Remove(respuesta);
            }

            if (Dato.datos[0] == "3")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta3.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "4")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta4.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "5")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta5.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "6")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta6.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "7")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta7.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "8")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta8.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "9")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta9.Add(a);
                Dato.datos.Remove(respuesta);
            }
            if (Dato.datos[0] == "10")
            {
                foreach (string a in Dato.datos)
                    Dato.pregunta10.Add(a);
                Dato.datos.Remove(respuesta);
            }
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void evaluar_v1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
