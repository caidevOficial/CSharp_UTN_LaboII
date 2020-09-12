using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRacticaPersona
{
    class Personaje
    {
        //atributos
        string nombre;
        int edad;

        //metodos
        public void SetNombre(string name) {
            this.nombre = name;
        }

        private string GetNombre() {
            return this.nombre;
        }

        public static string MostrarMensaje(Personaje personaje) {
            return personaje.GetNombre();
        }

    }
}
