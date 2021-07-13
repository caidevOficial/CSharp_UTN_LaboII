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

namespace EntidadesRPP {
    public abstract class Personal {

        #region Attributes

        private string apellido;
        private DateTime horarioEntrada;
        private int legajo;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with docket number and surname.
        /// </summary>
        /// <param name="apellido">Surname of the entity.</param>
        /// <param name="legajo">Docket number of the entity.</param>
        public Personal(string apellido, int legajo)
            : this(apellido, legajo, DateTime.Now) { }

        /// <summary>
        /// Creates the entity with all its parameters.
        /// </summary>
        /// <param name="apellido">Surname of the entity.</param>
        /// <param name="legajo">Docket number of the entity.</param>
        /// <param name="ingreso">Checkin time of the entity.</param>
        public Personal(string apellido, int legajo, DateTime ingreso) {
            this.legajo = legajo;
            this.apellido = apellido;
            this.horarioEntrada = ingreso;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: the surname.
        /// </summary>
        public string Apellido {
            get => this.apellido;
        }

        /// <summary>
        /// Gets: the checkin time.
        /// </summary>
        public DateTime HorarioEntrada {
            get => this.horarioEntrada;
        }

        /// <summary>
        /// Gets: the docket number.
        /// </summary>
        public int Legajo {
            get => this.legajo;
        }

        /// <summary>
        /// Gets: the information.
        /// </summary>
        public abstract string Info { get; }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if both entities are equals, bassed on its surname and docket number.
        /// </summary>
        /// <param name="p1">First entity Persoanl-type to compare.</param>
        /// <param name="p2">Second entity Persoanl-type to compare.</param>
        /// <returns>True if both are equals, otherwise returns false.</returns>
        public static bool operator ==(Personal p1, Personal p2) {
            if (!(p1 is null) && !(p2 is null)) {
                return p1.Apellido.Equals(p2.Apellido) && p1.Legajo == p2.Legajo;
            }

            return false;
        }

        /// <summary>
        /// Compares if both entities aren't equals, bassed on its surname and docket number.
        /// </summary>
        /// <param name="p1">First entity Persoanl-type to compare.</param>
        /// <param name="p2">Second entity Persoanl-type to compare.</param>
        /// <returns>True if both aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Personal p1, Personal p2) {
            return !(p1 == p2);
        }

        /// <summary>
        /// Gets the docket number as a string.
        /// </summary>
        /// <param name="p1">Entity Personal-type</param>
        public static explicit operator string(Personal p1) {
            return p1.Legajo.ToString();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the surname and docket of the entity as a string.
        /// </summary>
        /// <returns>The surname and docket of the entity as a string.</returns>
        protected virtual string ArmarInfo() {
            return $"{this.Apellido}, Legajo: {(string)this}";
        }

        /// <summary>
        /// Gets the info of the entity as a string.
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.Append($"{this.ArmarInfo()} - ingreso: {DateTime.Now.ToLongTimeString()}");
            return data.ToString();
        }

        /// <summary>
        /// Sets the comparison criteria between objects of type Personal that are given as parameters.
        /// </summary>
        /// <param name="p1">First entity Persoanl-type to compare.</param>
        /// <param name="p2">Second entity Persoanl-type to compare.</param>
        /// <returns>Returns 1 if p1 is bigger, -1 if p2 is bigger, otherwise 0.</returns>
        public static int OrdenarPorLegajoASC(Personal p1, Personal p2) {
            if (p1.Legajo > p2.Legajo) {
                return 1;
            } else if (p1.Legajo < p2.Legajo) {
                return -1;
            } else {
                return 0;
            }
        }

        /// <summary>
        /// Sets the comparison criteria between objects of type Personal that are given as parameters
        /// </summary>
        /// <param name="p1">First entity Persoanl-type to compare.</param>
        /// <param name="p2">Second entity Persoanl-type to compare.</param>
        /// <returns>Returns 1 if p2 is bigger, -1 if p1 is bigger, otherwise 0.</returns>
        public static int OrdenarPorLegajoDESC(Personal p1, Personal p2) {
            return OrdenarPorLegajoASC(p1, p2) * -1;
        }

        #endregion
    }
}
