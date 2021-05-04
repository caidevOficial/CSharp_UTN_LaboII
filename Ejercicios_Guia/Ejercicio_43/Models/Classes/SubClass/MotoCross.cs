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
    public sealed class MotoCross : VehiculoCarrera {

        #region Attributes

        private short cilindradas;

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the displacement of the moto.
        /// Set: Sets the displacement of the moto.
        /// </summary>
        public short Cilindradas {
            get => cilindradas;
            set {
                if (value > 110) {
                    cilindradas = value;
                }
            }
        }

        #endregion

        #region Builders

        /// <summary>
        /// Builds the moto with number and team.
        /// </summary>
        /// <param name="number">Number of the moto.</param>
        /// <param name="team">Team of the moto.</param>
        public MotoCross(short number, string team) : base(number, team) { }

        /// <summary>
        /// Builds the moto with displacement, number and team.
        /// </summary>
        /// <param name="number">Number of the moto.</param>
        /// <param name="team">Team of the moto.</param>
        /// <param name="displacement">Displacement of the moto.</param>
        public MotoCross(short number, string team, short displacement) : base(number, team) {
            this.Cilindradas = displacement;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if both MotoCross are equals, based in its team, displacement and number.
        /// </summary>
        /// <param name="m1">First MotoCross to compares.</param>
        /// <param name="m2">Second MotoCross to compares.</param>
        /// <returns>True if are equals, otherwise returns false.</returns>
        public static bool operator ==(MotoCross m1, MotoCross m2) {
            if (!(m1 is null) && !(m2 is null)) {
                bool sameTeam = m1.Escuderia == m2.Escuderia;
                bool sameNumber = m1.Numero == m2.Numero;
                bool sameDisp = m1.Cilindradas == m2.Cilindradas;

                return sameTeam && sameNumber && sameDisp;
            }

            return false;
        }

        /// <summary>
        /// Compares if both MotoCross are differents, based in its team, displacement and number.
        /// </summary>
        /// <param name="m1">First MotoCross to compares.</param>
        /// <param name="m2">Second MotoCross to compares.</param>
        /// <returns>True if are differents, otherwise returns false.</returns>
        public static bool operator !=(MotoCross m1, MotoCross m2) {
            if (!(m1 is null) && !(m2 is null)) {
                return !(m1 == m2);
            }

            return false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the info of the MotoCross.
        /// </summary>
        /// <returns>The info of the MotoCross as a string.</returns>
        public override string MostrarDatos() {
            string stats = String.Format("Number: {0,2} | Team: {1,-6} | Comp: {2,-5} | Fuel: {3,3}% | Disp: {4,4}cc | Laps: {5,2}\n",
               this.Numero, this.Escuderia, this.EnCompetencia, this.CantidadCombustible, this.Cilindradas, this.VueltasRestantes);

            return stats;
        }

        #endregion
    }
}
