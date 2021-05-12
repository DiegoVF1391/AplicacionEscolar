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
using TAP2021_U1T_Escuela;
using TAP2021_U1T2_Aplicación_Escolar;

namespace TAP2021_U1T_Escuela
{
    public partial class Form1 : Form
    {
        public static int indice;
        private JObject json;
        private JObject jsonRegistros;
        private JObject jsonAlumnos;
        JArray jArray = new JArray();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            int cont = jArray.Count;
            if((txtNoControl.Text!="") && (txtContrasena.Text !=""))
            {
                for (int i = 0; i < jArray.Count; i++)
                {
                    JObject alumno = (JObject)jArray[i];
                    if (alumno.GetValue("NoControl").ToString().Equals(txtNoControl.Text) == true)
                    {
                        if (alumno.GetValue("Contrasena").ToString().Equals(txtContrasena.Text) == true)
                        {
                            Alumno al = new Alumno(alumno.GetValue("NoControl").ToString(),
                                alumno.GetValue("Nombre").ToString(),
                                alumno.GetValue("Carrera").ToString(),
                                int.Parse(alumno.GetValue("Semestre").ToString()),
                                alumno.GetValue("Telefono").ToString(),
                                alumno.GetValue("Contrasena").ToString());

                            MessageBox.Show("Entrando... ");
                            indice = i;


                            /*al.Nombre = alumno.GetValue("Nombre").ToString();
                            al.NoControl = alumno.GetValue("NoControl").ToString();*/
                            cont--;
                            new FormPrincipal().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña no valida");
                            return;

                        }
                    }
                }
                if (cont == jArray.Count)
                {
                    MessageBox.Show("No. de Control no valido");
                }
              

            }else
            {
                MessageBox.Show("Debes ingresar datos");
                return; 
            }
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Se llama al formulario de registro
            new Registro().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        }
    }
}
