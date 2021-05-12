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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TAP2021_U1T_Escuela;
using TAP2021_U1T2_Aplicación_Escolar;

namespace TAP2021_U1T2_Aplicación_Escolar
{
    public partial class FormCalificaciones : Form
    {
        JObject json;
        JObject jregistros;
        JObject jalumno;
       

   
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        private void FormCalificaciones_Load(object sender, EventArgs e)
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
                                jalumno = (JObject)jalumnos[Form1.indice];
                                

                            }
                
                        }

                        String no = jalumno.GetValue("Nombre").ToString();
                        labelCalificaciones.Text = "Calificaciones de: " + no;
                        if (jalumno.ContainsKey("Semestre"))
                        {
                            labelSemestre.Text = "Semestre: " + jalumno.GetValue("Semestre");
                        }
                        //MessageBox.Show(jalumno.ToString());

                        if (jalumno.ContainsKey("Materias"))
                        {
                            jcalifs = (JArray)jalumno.GetValue("Materias");
                            //MessageBox.Show("funciona ");
                            //                                llenar grid 
                            for (int j = 0; j < jcalifs.Count; j++)
                            {
                                JObject a = (JObject)jcalifs[j];

                                String[] rowArray = { $"{a.GetValue("Nombre")}", $"{a.GetValue("Calificación")}" };
                                tablaC.Rows.Insert(j, rowArray);


                            }


                        }
                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex);
                MessageBox.Show("Error al leer el archivo");
                throw;
            }




        }
    }
}
