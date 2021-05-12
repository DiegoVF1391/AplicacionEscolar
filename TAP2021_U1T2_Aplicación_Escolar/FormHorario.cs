using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAP2021_U1T2_Aplicación_Escolar;
using TAP2021_U1T_Escuela;
using Newtonsoft.Json.Linq;
using System.IO;

namespace TAP2021_U1T2_Aplicación_Escolar
{
    public partial class FormHorario : Form
    {
        String[] horasP = { "7:00-8:00", "8:00-9:00", "9:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00" };
        String[] horasI = { "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00", "17:00-18:00", "18:00-19:00" };
        String[] horas;

        JObject json;
        JObject jregistros;
        JObject jalumno;
       

        public FormHorario()
        {
            InitializeComponent();
        }

        private void FormHorario_Load(object sender, EventArgs e)
        {
            json = new JObject();
            JArray jalumnos;
            JArray jmat;

            tablaH.RowTemplate.Height = 70;


            try
            {
                StreamReader sr = new StreamReader("registros.json");
                String lectura = sr.ReadToEnd();
                sr.Close();
                json = JObject.Parse(lectura);

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

                            

                            if (jalumno.ContainsKey("Nombre"))
                            {
                                jalumno = (JObject)jalumnos[Form1.indice];

                            }
                        }

                        //revisar semestre 
                        if (jalumno.ContainsKey("Semestre"))
                        {
                            int s = (int)jalumno.GetValue("Semestre");
                            //MessageBox.Show("Semestre: " + s);
                            if (s % 2 == 0)
                            {
                                horas = horasP;
                            }
                            else
                            {
                                horas = horasI;
                            }
                        }

                        if (jalumno.ContainsKey("Materias"))
                        {
                            jmat = (JArray)jalumno.GetValue("Materias");
                            //MessageBox.Show("funciona ");
                            //                                llenar grid 
                            for (int j = 0; j < jmat.Count; j++)
                            {
                                JObject a = (JObject)jmat[j];

                                String[] rowArray = { horas[j], $"{a.GetValue("Nombre")}", $"{a.GetValue("Nombre")}", $"{a.GetValue("Nombre")}", $"{a.GetValue("Nombre")}", $"{a.GetValue("Nombre")}" };
                                tablaH.Rows.Insert(j, rowArray);


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
