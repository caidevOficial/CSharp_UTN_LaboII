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
    public abstract class Equipo {

        #region Attributes

        private string nombre;
        private DateTime fechaCreacion;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with name and foundation date.
        /// </summary>
        /// <param name="nombre">Name of the entity</param>
        /// <param name="fecha">foundation date of the entity</param>
        public Equipo(string nombre, DateTime fecha) {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the name of the team.
        /// </summary>
        public string NombreEquipo {
            get => this.nombre;
        }

        #endregion

        #region Operators

        /// <summary>
        /// It will compares both teams to know if are equals
        /// bassed in its names and foundation's date.
        /// </summary>
        /// <param name="a">First team to compare</param>
        /// <param name="b">Second team to compare</param>
        /// <returns>True if both teams are equals, otherwise returns false.</returns>
        public static bool operator ==(Equipo a, Equipo b) {
            if (!(a is null) && !(b is null)) {
                return a.fechaCreacion == b.fechaCreacion && a.nombre.Equals(b.nombre);
            }

            return false;
        }

        /// <summary>
        /// It will compares both teams to know if are not equals
        /// bassed in its names and foundation's date.
        /// </summary>
        /// <param name="a">First team to compare</param>
        /// <param name="b">Second team to compare</param>
        /// <returns>True if both teams aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Equipo a, Equipo b) {
            return !(a == b);
        }

        #endregion

        #region Methods

        /// <summary>
        /// It will return the name and de foundation date of the team.
        /// </summary>
        /// <returns>The name and de foundation date of the team as a string.</returns>
        public string Ficha() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{this.nombre} fundado el {this.fechaCreacion}");

            return data.ToString();
        }

        #endregion
    }
}
