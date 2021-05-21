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
    //ya se agrego el json...
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
                //archivo de las preguntas 
                StreamReader sr2 = new StreamReader("Reticulas2.json");
                String lectura = sr.ReadToEnd();
                String lectura2 = sr2.ReadToEnd();
                sr.Close();
                sr2.Close();

                json = JObject.Parse(lectura);
                JObject json2 = JObject.Parse(lectura2);

                if (json2.ContainsKey("Reticula")) { MessageBox.Show("Si hay archivo");}

                if (json.ContainsKey("registros"))
                {
                    jsonRegistros = (JObject)json.GetValue("registros");

                    //
                    if (jsonRegistros.ContainsKey("alumnos"))
                    {
                        jArray = (JArray)jsonRegistros.GetValue("alumnos");
                        JObject alumno = (JObject)jArray[Form1.indice];
                        label1.Text = "Bienvenido: " + alumno.GetValue("Nombre").ToString() + " ";

                        //revisar materias 
                        if (alumno.ContainsKey("Materias"))
                        {
                            JArray materias = (JArray)alumno.GetValue("Materias");

                            for (int i = 0; i < materias.Count; i++)
                            {
                                JObject m = (JObject)materias[i];
                                comboBox1.Items.Add(m.GetValue("Nombre"));

                            }

                        }
                        
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

        private void button1_Click(object sender, EventArgs e)
        {
            //boton para entrar al formulario de examen, validar que se haya seleccionado 1 materia...

            new FormExamen().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            json = new JObject();
            jsonRegistros = new JObject();

            try
            {
                //buscar las materias que corresponden al alumno actual...
                StreamReader sr = new StreamReader("registros.json");
                String lectura = sr.ReadToEnd();
                sr.Close();

                json = JObject.Parse(lectura);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer "+ex);
                throw;
            }

        }
    }
}
