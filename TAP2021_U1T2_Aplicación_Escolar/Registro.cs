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
    public partial class Registro : Form
    {
        private JObject json;
        private JObject jsonRegistros;
        private JObject jsonAlumnos;
        JArray jArray = new JArray();
        JArray jMaterias = new JArray();
        public Registro()
        {
            InitializeComponent();
            llenarComboBox(); //Se llena el combo box con las carreras
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            json = new JObject();
            jsonRegistros = new JObject();
            jsonAlumnos = new JObject();
            JArray jMaterias = new JArray();


            al.NoControl = txtNoControl.Text;
            al.Nombre = txtNombre.Text;
            al.Carrera = comBoxCarrera.SelectedItem.ToString();
            if (numSemestre.Value <=9 && numSemestre.Value > 0)
            {
                al.Semestre = int.Parse(numSemestre.Value.ToString());
            }else
            { MessageBox.Show("Semestre no Disponible");   return; }
            
            al.Telefono = txtTel.Text; 
            al.Contrasena = txtContrasena.Text;

            //asignar...
            JObject jcarrera = new JObject();
            JObject jdatos = new JObject();
            JObject jreticula = new JObject();
            JObject carr;
            JObject see;
            
            //
            try
            {
                StreamReader sr = new StreamReader("Reticulas.json");
                String leer = sr.ReadToEnd();
                sr.Close();

                jdatos = JObject.Parse(leer);
                //MessageBox.Show(jdatos.ToString()) ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex);
                MessageBox.Show("Error al leer el archivo");
                throw;
            }

            if (jdatos.ContainsKey("Reticula"))
            {
                jreticula = (JObject)jdatos.GetValue("Reticula");

                if (jreticula.ContainsKey("Carreras"))
                {
                    //crear arreglo...
                    JArray jCa = (JArray)jreticula.GetValue("Carreras");

                    for (int i = 0; i < jCa.Count; i++)
                    {
                        carr = (JObject)jCa[i];
                        if (carr.ContainsKey("Nombre"))
                        {
                            String nom = al.Carrera;
                            //revisar carrera 
                            if (nom.Equals(carr.GetValue("Nombre").ToString()))
                            {
                                //revisar semestres
                                if (carr.ContainsKey("Semestres"))
                                {
                                    JArray sems = (JArray)carr.GetValue("Semestres");
                                    //checar semestre numero 
                                    
                                    for (int j = 0; j < sems.Count; j++)
                                    {
                                        see = (JObject)sems[j];
                                        if (see.ContainsKey("Numero")) //si contiene numero 
                                        {
                                            int nu = al.Semestre;

                                            if(nu == (int)see.GetValue("Numero"))
                                            {
                                                //MessageBox.Show("si jaloooo");
                                                //tomar arreglo de materias 

                                                if (see.ContainsKey("Materias"))
                                                {
                                                    //MessageBox.Show("Si hay materias ");
                                                    jMaterias = (JArray)see.GetValue("Materias");
                                                    //MessageBox.Show(jMaterias.ToString());
                                                    //ahora guardar este arreglo y asignar a cada alumnos sus mat
                                                }
                                            }

                                        }


                                    }

                                }

                            }
                        }

                    }

                }

                //MessageBox.Show(jreticula.ToString());

            }


            JObject jA = JObject.FromObject(al);
            jA.Add("Materias",jMaterias);               //añadir 

            jArray.Add(jA);

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
            this.Dispose();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            json = new JObject();
            jsonRegistros = new JObject();
            jsonAlumnos = new JObject();

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
                    //Se llena el grid
                    if (jsonRegistros.ContainsKey("alumnos"))
                    {
                        jArray = (JArray)jsonRegistros.GetValue("alumnos");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo " + ex);
                MessageBox.Show("No se pudo leer el archivo");
            }
            //Leer el archivo
        }

        private void llenarComboBox()
        {
            comBoxCarrera.Items.Add("Ingeniería Mecanica");
            comBoxCarrera.Items.Add("Ingeniería Electrica");
            comBoxCarrera.Items.Add("Ingeniería en Sistemas");
        }

        private void comBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
