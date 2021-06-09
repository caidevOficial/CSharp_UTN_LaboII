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

    public delegate void DelegadoString(string msg);

    public class Persona {

        #region Attributes

        private string apellido;
        private string nombre;


        #endregion

        #region Builders

        public Persona() {
            this.nombre = String.Empty;
            this.apellido = String.Empty;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: The Surname.
        /// </summary>
        public string Apellido {
            get => this.apellido;
            set {
                if (!String.IsNullOrWhiteSpace(value) && !value.Equals(this.apellido)) {
                    this.apellido = value;
                    this.EventoString.Invoke(this.Mostrar());
                }
            }
        }

        /// <summary>
        /// Gets/Sets: The Name.
        /// </summary>
        public string Nombre {
            get => this.nombre;
            set {
                if (!String.IsNullOrWhiteSpace(value) && !value.Equals(this.nombre)) {
                    this.nombre = value;
                    this.EventoString.Invoke(this.Mostrar());
                }
            }
        }

        /// <summary>
        /// Delegate, IDK what do this!
        /// </summary>
        public event DelegadoString EventoString;

        #endregion

        #region Methods

        /// <summary>
        /// Returns a string with name and surname.
        /// </summary>
        /// <returns>A string with name and surname.</returns>
        public string Mostrar() {
            return $"{this.Nombre} {this.Apellido}";
        }

        #endregion
    }
}
