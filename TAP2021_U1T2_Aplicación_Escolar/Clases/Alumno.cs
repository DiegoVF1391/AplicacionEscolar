using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAP2021_U1T_Escuela.Clases
{
    class Alumno
    {
        //constructores 
        public Alumno()
        {
        }

        public Alumno(String noControl, String nombre, String carrera, int semestre, String telefono, String contrasena)
        {
            this.noControl = noControl;
            this.nombre = nombre;
            this.carrera = carrera;
            this.semestre = semestre;
            this.telefono = telefono; 
            this.contrasena = contrasena;
        }

        //encapsulamiento 
        private String noControl;
        public String NoControl
        {
            get { return noControl; }
            set
            {
                Console.WriteLine("Se invoco al setter de No de Control");
                noControl = value;
            }
        }

        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set
            {
                Console.WriteLine("Se invoco al setter de nombre");
                nombre = value;
            }
        }

        private String carrera;
        public String Carrera 
        {
            get { return carrera; }
            set
            {
                Console.WriteLine("Se invoco al setter de carrera");
                carrera = value;
            } 
        }

        private int semestre;
        public int Semestre
        {
            get { return semestre; }
            set
            {
                Console.WriteLine("Se invoco al setter de carrera");
                semestre = value;
            }
        }


        private String contrasena;
        public String Contrasena
        {
            get { return contrasena; }
            set
            {
                Console.WriteLine("Se invoco al setter de carrera");
                contrasena = value;
            }
        }

        private String  telefono;

        public String Telefono 
        {
            get { return telefono; }
            set { telefono = value; }
        }


     
    }
}
