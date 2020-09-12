using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin
{
    static class JardinInfantes
    {

        //Al ser estatica esta clase, todo lo de adentro
        // esta obligado a ser estatico tmb.
        static string nombreJardin;
        static int antiguedad;
        static Docente[] arrayDoc; // son objetos, coleccion array
        static Alumno[] arrayAlu; // son objetos, coleccion array

        // al ser estaticos, se inicializan en un
        //constructor estatico
        static JardinInfantes() {
            nombreJardin = null;
            antiguedad = -1;
            arrayDoc = new Docente[2];
            arrayAlu = new Alumno[3];
        }

        /// <summary>
        /// Agrega un alumno al array.
        /// </summary>
        /// <param name="alu">Alumno a agregar</param>
        /// <returns>True si agrego un alumno</returns>
        public static bool AgregarAlumnos(Alumno alu) {
            bool retorno = false;
            for (int i = 0; i < arrayAlu.Length; i++)
            {
                //guardo solo si esta vacia la posicion.
                if (arrayAlu[i] == null) { 
                    arrayAlu[i] = alu;
                    retorno = true;
                    break; // al encontrar un espacio, dejo de buscar.
                }
            }
            return retorno;
        }

        public static void SetearInfoJardin(string nombre)
        {
            if (string.IsNullOrEmpty(nombreJardin)) {
                nombreJardin = nombre;
            }
        }

        private static void SetearInfoJardin(int antiguedadJardin)
        {
            if(antiguedadJardin >= 0)
             antiguedad = antiguedadJardin;
        }
    }
}
