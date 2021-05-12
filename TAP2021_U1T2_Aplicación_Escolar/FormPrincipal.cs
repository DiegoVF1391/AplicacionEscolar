using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAP2021_U1T_Escuela.Clases;
using TAP2021_U1T2_Aplicación_Escolar;

namespace TAP2021_U1T_Escuela
{
    public partial class FormPrincipal : Form
    {
        private JObject json;
        private JObject jsonRegistros;
        private JObject jsonAlumnos;
        JArray jArray = new JArray();
        Alumno al = new Alumno();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            new FormCalificaciones().Show();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            new FormHorario().Show();
        }

        private void btnReticula_Click(object sender, EventArgs e)
        {
            new FormReticula().Show();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            new FormDatos().Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            json = new JObject();
            jsonRegistros = new JObject();

            //Leer el archivo
            try
            {
                StreamReader sr = new StreamReader("registros.json");
                String lectura = sr.ReadToEnd();
                sr.Close();

                json = JObject.Parse(lectura);

                if (json.ContainsKey("registros"))
                {
                    jsonRegistros = (JObject)json.GetValue("registros");

                    //
                    if (jsonRegistros.ContainsKey("alumnos"))
                    {
                        jArray = (JArray)jsonRegistros.GetValue("alumnos");
                        JObject alumno = (JObject)jArray[Form1.indice];
                        label1.Text = "Bienvenido: " + alumno.GetValue("Nombre").ToString() + " ";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo " + ex);
                MessageBox.Show("No se pudo leer el archivo");
            }
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            new Form1().Show();
        }
    }
}
