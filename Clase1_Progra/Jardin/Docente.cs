using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin
{
    class Docente
    {
        private int dni;
        private int edad;
        private string nombre;
        private string apellido;
        private string nombreMateria;

        private Docente()
        {
            this.edad = -1;
            this.dni = -1;
            this.nombre = "no cargado";
            this.apellido = "no cargado";
            this.nombreMateria = "sin asignar";

        }

        public Docente(int dni, string nombre, string apellido)
        :this(){
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

    }
}
