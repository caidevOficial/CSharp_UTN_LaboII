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

using System;

namespace Models {
    public abstract class Persona {
        protected long dni;
        protected string nombre;

        #region Properties

        /// <summary>
        /// Get: gets the dni of the person.
        /// Set: sets the dni of the person.
        /// </summary>
        public long DNI {
            get { return this.dni; }
            set {
                if (value > 5000000) {
                    this.dni = value;
                }
            }
        }

        /// <summary>
        /// Get: gets the name of the person.
        /// Set: sets the name of the person.
        /// </summary>
        public string Nombre {
            get { return this.nombre; }
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.nombre = value;
                }
            }
        }

        #endregion

        #region Builders

        /// <summary>
        /// Builds the person with the name.
        /// </summary>
        /// <param name="nombre">Name of the person.</param>
        public Persona(string nombre) {
            this.Nombre = nombre;
        }

        /// <summary>
        /// Builds the person with the name and the dni.
        /// </summary>
        /// <param name="nombre">Name of the person.</param>
        /// <param name="dni">DNI of the person.</param>
        public Persona(long dni, string nombre)
            : this(nombre) {
            this.DNI = dni;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the data of the person.
        /// </summary>
        /// <returns>The data of the person as a string.</returns>
        public abstract string MostrarDatos();

        #endregion
    }
}
