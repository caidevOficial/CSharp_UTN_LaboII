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
using System.Text;

namespace Models {
    public class CompetenciaNoDisponibleException : Exception {

        #region Attributes

        private string nombreClase;
        private string nombreMetodo;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the exception with the message, className and MethodName.
        /// </summary>
        /// <param name="mensaje">Mesage of the exception.</param>
        /// <param name="clase">Class-name of the exception.</param>
        /// <param name="metodo">Method-name of the exception.</param>
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null) { }

        /// <summary>
        /// Creates the exception with the message, className, MethodName and innerException.
        /// </summary>
        /// <param name="mensaje">Mesage of the exception.</param>
        /// <param name="clase">Class-name of the exception.</param>
        /// <param name="metodo">Method-name of the exception.</param>
        /// <param name="innerException">InnerException of the exception.</param>
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException) {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the Class-name of the exception.
        /// </summary>
        public string NombreClase {
            get => this.nombreClase;
        }

        /// <summary>
        /// Gets the Method-name of the exception.
        /// </summary>
        public string NombreMetodo {
            get => this.nombreMetodo;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the message of the exception.
        /// </summary>
        /// <returns>The message of the exception as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendFormat("Excepcion en el metodo {0} de la clase {1}\n", this.NombreMetodo, this.NombreClase);
            data.AppendLine("Algo salio mal, revisa los detalles.");
            data.AppendLine($"Details: {this.InnerException}");

            return data.ToString(); ;
        }

        #endregion
    }
}
