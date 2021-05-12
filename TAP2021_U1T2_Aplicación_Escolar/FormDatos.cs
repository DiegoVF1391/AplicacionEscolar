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

namespace TAP2021_U1T_Escuela
{
    public partial class FormDatos : Form
    {
        private JObject json;
        private JObject jsonRegistros;
        private JObject jsonAlumnos;
        private JObject alumno;
        JArray jArray = new JArray();

        public FormDatos()
        {
            InitializeComponent();
        }

        private void FormDatos_Load(object sender, EventArgs e)
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

                    if (jsonRegistros.ContainsKey("alumnos"))
                    {
                        jArray = (JArray)jsonRegistros.GetValue("alumnos");
                        for (int i = 0; i < jArray.Count; i++)
                        {
                            alumno = (JObject)jArray[i];
                            if (jArray[i].ToString().Equals(jArray[Form1.indice].ToString()) == true)
                            {
                                textNoControl.Text = alumno.GetValue("NoControl").ToString();
                                textNombre.Text = alumno.GetValue("Nombre").ToString();
                                textSemestre.Text = alumno.GetValue("Semestre").ToString();
                                textCarrera.Text = alumno.GetValue("Carrera").ToString();
                                textTel.Text = alumno.GetValue("Telefono").ToString();
                                textNueva.Text = alumno.GetValue("Contrasena").ToString(); 
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

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            json = new JObject();
            jsonRegistros = new JObject();

           
                JObject o = new JObject();
                o = (JObject)jArray[Form1.indice];
                if (o.GetValue("Nombre").ToString().Equals(textNombre.Text.ToString()) == true)
                {
                    o.Remove("Contrasena");
                    o.Add("Contrasena", textNueva.Text.ToString());
                    o.Remove("Telefono");
                    o.Add("Telefono", textTel.Text);
                    MessageBox.Show("Datos actualizados");
                }
           

            jsonRegistros.Remove("alumnos");
            jsonRegistros.Add("alumnos", jArray);
            json.Remove("registros");
            json.Add("registros", jsonRegistros);

            try
            {
                StreamWriter sw = new StreamWriter("registros.json", false);
                sw.Write(json.ToString());
                sw.Close();

                MessageBox.Show("Registro éxitoso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir el archivo: " + ex);
                MessageBox.Show("Erro al guardar");
            }
        }
    }
}
