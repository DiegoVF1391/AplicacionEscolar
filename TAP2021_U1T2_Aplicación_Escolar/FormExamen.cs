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
        private JObject jse;

        private JArray jmaterias;
        private JObject jMateriaEx;
        private JArray jaExamenes;
        private JObject jExamen;
        private JArray jaPreguntas;
        private JObject jPreguntaEx;


        //guardar semestre, respuesta y carrera
        private  String car, inciso, respuestaCorrecta;
        private  int sem, cont=0, numRespuestas = 0;
        private String materiaCalif;



        //Formulario para hacer examen de acreditación
        public FormExamen()
        {
            InitializeComponent();
        }


        //Cargar archivo de json para preguntas
        private void FormExamen_Load(object sender, EventArgs e)
        {
            labelMateria.Text = FormPrincipal.materiaExamen;
            try
            {
                StreamReader sr = new StreamReader("registros.json");
                StreamReader sr2 = new StreamReader("Reticulas2.json");
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
                        if (jalumno.ContainsKey("Semestre"))
                        {
                            jalumno = (JObject)jalumnos[Form1.indice];
                            sem = (int)jalumno.GetValue("Semestre");
                            //MessageBox.Show("Semestre: "+sem );
                        }

                    }
                }

                //MessageBox.Show(json2.ToString());

                //revisar reticulas.... Para entrar a las preguntas
                if (json2.ContainsKey("Reticula"))
                {
                    jr = (JObject)json2.GetValue("Reticula");
                    //MessageBox.Show(jr.ToString());

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
                                        //MessageBox.Show(jsemestre.ToString());
                                        
                                        //revisar carreras y que el "numero" coincida con "sem"
                                        for (int i = 0; i < jsemestre.Count; i++)
                                        {
                                            jse = (JObject)jsemestre[i];
                                            if (jse.ContainsKey("Numero"))
                                            {
                                                if (sem == int.Parse(jse.GetValue("Numero").ToString()))
                                                {
                                                    //MessageBox.Show("Valor "+ sem);
                                                    if (jse.ContainsKey("Materias"))
                                                    {
                                                        jmaterias = (JArray)jse.GetValue("Materias");
                                                        for (int k = 0; k < jmaterias.Count; k++)
                                                        {
                                                            jMateriaEx = (JObject)jmaterias[k];
                                                            if (jMateriaEx.ContainsKey("Nombre"))
                                                            {
                                                                //MessageBox.Show(jMateriaEx.GetValue("Nombre").ToString());
                                                                if (jMateriaEx.GetValue("Nombre").ToString().Equals(FormPrincipal.materiaExamen.ToString()))
                                                                {
                                                                    //guardar nombre de la materia...
                                                                    materiaCalif = jMateriaEx.GetValue("Nombre").ToString();
                                                                    if (jMateriaEx.ContainsKey("Examen"))
                                                                    {
                                                                        
                                                                        jaExamenes = (JArray)jMateriaEx.GetValue("Examen");
                                                                        //MessageBox.Show("Tiene "+jaExamenes.Count.ToString());
                                                                        
                                                                        
                                                                            jExamen = (JObject)jaExamenes[cont];
                                                                            if (jExamen.ContainsKey("Pregunta"))
                                                                            {
                                                                                label1.Text = "";
                                                                                comboBox1.Items.Clear();

                                                                                label1.Text = (String)jExamen.GetValue("Pregunta");
                                                                                inciso = (String)jExamen.GetValue("Correcta");
                                                                                //Console.WriteLine((String)jExamen.GetValue("Pregunta"));

                                                                                if (jExamen.ContainsKey("Respuestas"))
                                                                                {
                                                                                    jaPreguntas = (JArray)jExamen.GetValue("Respuestas");
                                                                                    for (int m = 0; m < jaPreguntas.Count; m++)
                                                                                    {
                                                                                        jPreguntaEx = (JObject)jaPreguntas[m];
                                                                                        if (jPreguntaEx.ContainsKey("Texto"))
                                                                                        {
                                                                                            comboBox1.Items.Add(jPreguntaEx.GetValue("Inciso") + ") " + jPreguntaEx.GetValue("Texto"));
                                                                                            if (jPreguntaEx.GetValue("Inciso").ToString().Equals(inciso))
                                                                                            {
                                                                                                respuestaCorrecta = jPreguntaEx.GetValue("Inciso") + ") " + jPreguntaEx.GetValue("Texto");
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        
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

        //Cada vez que se presiona el boton, califica la respuesta y muestra la siguiente pregunta
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals(respuestaCorrecta))
            {
                numRespuestas += 10;
                MessageBox.Show(numRespuestas.ToString());
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
            cont++;
            pregunta();
        }

        //Se hace el proceso para mostrar la respuesta y pregunta
        private void pregunta()
        {
            if (cont < 10)
            {
                jExamen = (JObject)jaExamenes[cont];
                if (jExamen.ContainsKey("Pregunta"))
                {
                    label1.Text = "";
                    comboBox1.Items.Clear();
                    label1.Text = (String)jExamen.GetValue("Pregunta");
                    inciso = (String)jExamen.GetValue("Correcta");
                    Console.WriteLine((String)jExamen.GetValue("Pregunta"));

                    if (jExamen.ContainsKey("Respuestas"))
                    {
                        jaPreguntas = (JArray)jExamen.GetValue("Respuestas");
                        for (int m = 0; m < jaPreguntas.Count; m++)
                        {
                            jPreguntaEx = (JObject)jaPreguntas[m];
                            if (jPreguntaEx.ContainsKey("Texto"))
                            {
                                comboBox1.Items.Add(jPreguntaEx.GetValue("Inciso") + ") " + jPreguntaEx.GetValue("Texto"));
                                if (jPreguntaEx.GetValue("Inciso").ToString().Equals(inciso))
                                {
                                    respuestaCorrecta = jPreguntaEx.GetValue("Inciso") + ") " + jPreguntaEx.GetValue("Texto");
                                }
                                Console.WriteLine(inciso);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted obtuvo "+ numRespuestas);
                calificarExamen(numRespuestas);
            }
        }


        //Calificar la materia con el examen....
        public void calificarExamen(int calif)
        {
            json = new JObject();
            JArray jalumnos;
            JArray jcalifs;


            try
            {
                StreamReader sr = new StreamReader("registros.json");
                String leer = sr.ReadToEnd();
                sr.Close();

                json = JObject.Parse(leer);

                if (json.ContainsKey("registros"))
                {
                    jregistros = (JObject)json.GetValue("registros");

                    //MessageBox.Show(jregistros.ToString());
                    if (jregistros.ContainsKey("alumnos"))
                    {
                        jalumnos = (JArray)jregistros.GetValue("alumnos");
                        //MessageBox.Show(jalumnos.ToString());
                        //buscar el alumno 

                        for (int i = 0; i < jalumnos.Count; i++)
                        {
                            jalumno = (JObject)jalumnos[i];


                            if (jalumno.ContainsKey("Nombre"))
                            {
                                //elegir el alumno en jobjeto
                                jalumno = (JObject)jalumnos[Form1.indice];


                            }

                        }

                        String nombre = jalumno.GetValue("Nombre").ToString();
                       
                        //MessageBox.Show(jalumno.ToString());

                        if (jalumno.ContainsKey("Materias"))
                        {
                            jcalifs = (JArray)jalumno.GetValue("Materias");
                            //MessageBox.Show("funciona ");
                            //                                llenar grid 
                            for (int j = 0; j < jcalifs.Count; j++)
                            {
                                JObject a = (JObject)jcalifs[j];
                                if (a.ContainsKey("Nombre"))
                                {
                                    if (a.GetValue("Nombre").ToString().Equals(materiaCalif))
                                    {
                                        if (a.ContainsKey("Calificación")) 
                                        {
                                            // MessageBox.Show("si jala calificacion");
                                            a.Remove("Calificación");
                                            a.Add("Calificación",numRespuestas);
                                            MessageBox.Show("Calificacion asignada..");
                                            //guardar archivo json 
                                        }
                                        
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
