using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin
{
    class Alumno
    {
        private int dni;
        private int edad;
        private string nombre;
        private string apellido;

        // ctor tab tab
        private Alumno()
        { // inicializo por defecto
            this.dni = -1;
            this.edad = -1;
            this.nombre = "sin nombre";
            this.apellido = "sin nombre";
        }

        public Alumno(string nombre, string apellido, int dni)
            :this() { // llamo al constructor sin parametros para que rellene lo que falta
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public Alumno(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public string GetNombreYApellido() {
            return this.nombre + " " + this.apellido;
        }

        //sobrecarga de operadores

        public static bool operator ==(Alumno[] arrayEstud, Alumno auxEstud) {
            bool esIgual = false;
            for (int i = 0; i < arrayEstud.Length; i++)
            {
                if (arrayEstud[i].dni == auxEstud.dni) {
                    esIgual =  true;
                    break;
                }
            }

            return esIgual;
        }

        public static bool operator !=(Alumno[] arrayEstud, Alumno auxEstud)
        {
            return !(arrayEstud==auxEstud);
        }

        public static bool operator +(Alumno[] arrayEstud, Alumno auxEstud)
        {
            bool agregado = false;
            if (arrayEstud != auxEstud) // si no esta en el array, lo agrego
            {
                for (int i = 0; i < arrayEstud.Length; i++)
                {
                    if (arrayEstud[i] == null)
                    {
                        arrayEstud[i] = auxEstud;
                        agregado = true;
                        break;
                    }
                }
            }
            return agregado;
        }

        public static bool operator -(Alumno[] arrayEstud, Alumno auxEstud)
        {
            bool sacado = false;
            if (arrayEstud == auxEstud) // si esta en el array, lo saco
            {
                for (int i = 0; i < arrayEstud.Length; i++)
                {
                    if (arrayEstud[i] == auxEstud) // si encuentro
                    {
                        arrayEstud[i] = null; // clavo null
                        sacado = true;
                        break;
                    }
                }
            }
            return sacado;
        }
    }
}
