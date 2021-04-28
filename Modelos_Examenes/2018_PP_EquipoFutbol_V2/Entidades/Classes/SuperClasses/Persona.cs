/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System.Text;

namespace Entidades {
    public abstract class Persona {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        #region Builders

        /// <summary>
        /// Builds the entity with name, surname, age and dni.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="apellido">Surname of the entity.</param>
        /// <param name="edad">Age of the entity.</param>
        /// <param name="dni">Dni of the entity.</param>
        public Persona(string nombre, string apellido, int edad, int dni) {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.edad = edad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the surname.
        /// </summary>
        public string Apellido {
            get => this.apellido;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Nombre {
            get => this.nombre;
        }

        /// <summary>
        /// Gets the age.
        /// </summary>
        public int Edad {
            get => this.edad;
        }

        /// <summary>
        /// Gets the dni.
        /// </summary>
        public int Dni {
            get => this.dni;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the info of the entity as a string.
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public virtual string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {this.nombre}");
            data.AppendLine($"Apellido: {this.apellido}");
            data.AppendLine($"DNI: {this.dni}");
            data.AppendLine($"Edad: {this.edad}");

            return data.ToString();
        }

        public abstract bool ValidarAptitud();

        #endregion
    }
}
