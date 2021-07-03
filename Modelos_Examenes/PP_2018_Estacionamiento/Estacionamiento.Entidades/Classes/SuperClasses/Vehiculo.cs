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

namespace Entidades {
    public abstract class Vehiculo {
        protected DateTime ingreso;
        private string patente;

        #region Builders

        /// <summary>
        /// Creates the entity with 1 parameters
        /// </summary>
        /// <param name="patente">Patent of the entity</param>
        public Vehiculo(string patente) {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the patent of the entity.
        /// Sets the patent of the entity if its length is 6.
        /// </summary>
        public string Patente {
            get => this.patente;
            set {
                if (!String.IsNullOrWhiteSpace(value) && value.Length == 6) {
                    this.patente = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares 2 entities to know if both are equals bassed 
        /// in they type and patent.
        /// </summary>
        /// <param name="v1">First entity to compare</param>
        /// <param name="v2">Second entity to compare</param>
        /// <returns>True if both are equals, otherwise returns false.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2) {
            if (!(v1 is null) && !(v2 is null)) {
                if (v1.Equals(v2) && v1.Patente == v2.Patente) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Compares 2 entities to know if both aren't equals bassed 
        /// in they type and patent.
        /// </summary>
        /// <param name="v1">First entity to compare</param>
        /// <param name="v2">Second entity to compare</param>
        /// <returns>True if both aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2) {
            return !(v1 == v2);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the data of the entity as a string.
        /// </summary>
        /// <returns>The data of the entity as a string.</returns>
        public abstract string ConsultarDatos();

        /// <summary>
        /// Gets the data of the entity and the amount of the parking.
        /// </summary>
        /// <returns>The data of the entity and the amount of the parking as a string.</returns>
        public virtual string ImprimirTicket() {
            StringBuilder data = new StringBuilder();
            data.AppendLine(this.ToString());
            data.AppendLine($"Ingreso: {this.ingreso}");

            return data.ToString();
        }

        /// <summary>
        /// Retrieves the patent of the entity as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string data = String.Format("Patente: {0}", this.Patente);
            return data;
        }

        #endregion
    }
}
