using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRacticaPersona
{
    class Galletita
    {
        private string sabor = "Vainilla";
        //al ser public le digo que sea abierto para 
        // leer o modificar el dato

        private bool bajasCalorias = true;
        //private <- hablade encapsulamiento, ya que no se puede acceder desde afuera.

        /// <summary>
        /// Es un metodo get.
        /// </summary>
        /// <returns>Devuelve el sabor.</returns>
        public string GetSabor() {
            return this.sabor;
        }

        /// <summary>
        /// Graba el valor que se pasa por parametro en el atributo nuevoSabor.
        /// </summary>
        /// <param name="nuevoSabor">Es la variable que se recibe.</param>
        public void SetSabor(string nuevoSabor) {
            this.sabor = nuevoSabor;
        }
    }
}
