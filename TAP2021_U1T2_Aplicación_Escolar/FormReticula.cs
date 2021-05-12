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
using TAP2021_U1T2_Aplicación_Escolar;
using TAP2021_U1T_Escuela;

namespace TAP2021_U1T2_Aplicación_Escolar
{
    public partial class FormReticula : Form
    {
        JObject json;
        JObject json2;
        JObject jregistros;
        JObject jalumno;
        JObject jcarrera;
        JObject jr;
   
        JArray jmate;
        JArray jse;
        JObject s1, s2, s3, s4, s5, s6, s7, s8, s9;
        JObject m1, m2, m3, m4, m5, m6;



       String[] numeros = { "1", "2", "3", "4", "5", "6","7","8","9" };

        public FormReticula()
        {
            InitializeComponent();
        }

        private void FormReticula_Load(object sender, EventArgs e)
        {
            String car="";
            json = new JObject();
            JArray jalumnos;
            JArray jcarreras;

            tablaR.RowTemplate.Height = 70;


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
                            jalumno = (JObject)jalumnos[Form1.indice];
                            car = jalumno.GetValue("Carrera").ToString();
                            //MessageBox.Show(car);
                        }

                    }
                }

                //revisar reticulas.... 
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
                                if (car.Equals(jcarrera.GetValue("Nombre").ToString()))
                                {
                                    //tomar materias 
                                    if (jcarrera.ContainsKey("Semestres"))
                                    {
                                        jse = (JArray)jcarrera.GetValue("Semestres");
                                        
                                    }

                                }
                            }
                        }
                    }
                }
                //MessageBox.Show(jse.ToString());

                //llenar grid 
                s1 = (JObject)jse[0];
                if (s1.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s1.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[0], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(0, rowArray);
                }

                s2 = (JObject)jse[1];
                if (s2.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s2.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[1], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(1, rowArray);
                }

                s3 = (JObject)jse[2];
                if (s3.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s3.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[2], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(2, rowArray);

                }

                s4 = (JObject)jse[3];
                if (s4.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s4.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[3], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(3, rowArray);

                }

                s5 = (JObject)jse[4];
                if (s5.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s5.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[4], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(4, rowArray);

                }

                s6 = (JObject)jse[5];
                if (s6.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s6.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[5], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(5, rowArray);

                }

                s7 = (JObject)jse[6];
                if (s7.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s7.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[6], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(6, rowArray);

                }

                s8 = (JObject)jse[7];
                if (s8.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s8.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[7], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(7, rowArray);

                }

                s9 = (JObject)jse[8];
                if (s9.ContainsKey("Materias"))
                {
                    JArray ss1 = (JArray)s9.GetValue("Materias");
                    m1 = (JObject)ss1[0];
                    m2 = (JObject)ss1[1];
                    m3 = (JObject)ss1[2];
                    m4 = (JObject)ss1[3];
                    m5 = (JObject)ss1[4];
                    m6 = (JObject)ss1[5];
                    String[] rowArray = { numeros[8], $"{m1.GetValue("Nombre")}", $"{m2.GetValue("Nombre")}", $"{m3.GetValue("Nombre")}",
                    $"{m4.GetValue("Nombre")}",$"{m5.GetValue("Nombre")}",$"{m6.GetValue("Nombre")}"};
                    tablaR.Rows.Insert(8, rowArray);

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
