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
using TAP2021_U1T_Escuela;

namespace TAP2021_U1T2_Aplicación_Escolar
{
    public partial class FormExamen : Form
    {
        private JObject json;
        private JObject json2;
        private JObject jregistros;
        private JObject jalumno;
        private JArray jalumnos;

        private JObject jr;
        private JArray jcarreras;
        private JObject jcarrera;
        private JArray jsemestre;

        private String car;


        //Formulario para hacer examen de acreditación
        public FormExamen()
        {
            InitializeComponent();
        }

        //Cargar archivo de json para preguntas
        private void FormExamen_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("registros.json");
                StreamReader sr2 = new StreamReader("Reticulas.json");
                String leer = sr.ReadToEnd();
                String leer2 = sr2.ReadToEnd();
                sr.Close();
                sr2.Close();

                json = JObject.Parse(leer);
                json2 = JObject.Parse(leer2);

                //obtener la carrera del alumno, abrir registros de alumnos
                if (json.ContainsKey("registros"))
                {
                    jregistros = (JObject)json.GetValue("registros");
                    //MessageBox.Show(jregistros.ToString());
                    if (jregistros.ContainsKey("alumnos"))
                    {
                        jalumnos = (JArray)jregistros.GetValue("alumnos");

                        for (int i = 0; i < jalumnos.Count; i++)
                        {

                            jalumno = (JObject)jalumnos[i];
                        }
                        if (jalumno.ContainsKey("Carrera"))
                        {
                            //obtener nombre de la carrera en "car", se guarda 
                            jalumno = (JObject)jalumnos[Form1.indice];
                            car = jalumno.GetValue("Carrera").ToString();
                            //MessageBox.Show(car);
                        }

                    }
                }

                MessageBox.Show(json2.ToString());

                //revisar reticulas.... Para entrar a las preguntas
                if (json2.ContainsKey("Reticula"))
                {
                    jr = (JObject)json2.GetValue("Reticula");
                    MessageBox.Show(jr.ToString());

                    //revisar carrera 
                    if (jr.ContainsKey("Carreras"))
                    {
                        jcarreras = (JArray)jr.GetValue("Carreras");
                        //MessageBox.Show(jcarreras.ToString());

                        for (int j = 0; j < jcarreras.Count; j++)
                        {
                            jcarrera = (JObject)jcarreras[j];

                            if (jcarrera.ContainsKey("Nombre"))
                            {
                                //MessageBox.Show(jcarrera.ToString());
                                //Se compara el nombre de "car " con las carreras en reticulas
                                if (car.Equals(jcarrera.GetValue("Nombre").ToString()))
                                {
                                    //tomar materias si el nombre coincide 
                                    if (jcarrera.ContainsKey("Semestres"))
                                    {
                                        jsemestre = (JArray)jcarrera.GetValue("Semestres");
                                        MessageBox.Show(jsemestre.ToString());

                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Error al leer el archivo");
                throw;
            }
        }
    }
}
