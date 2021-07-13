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

namespace Entities {
    public sealed class AutoF1 {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Builders

        /// <summary>
        /// Builds the Car.
        /// </summary>
        /// <param name="escuderia">Team of the car.</param>
        /// <param name="numero">Number of the car.</param>
        public AutoF1(string escuderia, short numero) {
            this.escuderia = escuderia;
            this.numero = numero;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
            this.EnCompetencia = false;
        }

        #endregion

        #region Getters

        /// <summary>
        /// Get: The amount of fuel.
        /// Set: The amount of fuel (positive number only).
        /// </summary>
        public short CantidadCombustible {
            get => cantidadCombustible;
            set {
                if (value >= 0 && value < 101) {
                    cantidadCombustible = value;

                }
            }
        }

        /// <summary>
        /// Get: The remaining laps.
        /// Set: The remaining laps (positive number only).
        /// </summary>
        public short VueltasRestantes {
            get => vueltasRestantes;
            set {
                if (value >= 0) {
                    vueltasRestantes = value;
                }
            }
        }

        /// <summary>
        /// Get: The competition state of the car.
        /// Set: The competition state of the car.
        /// </summary>
        public bool EnCompetencia {
            get => enCompetencia;
            set => enCompetencia = value;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if the number and team of both cars are the same.
        /// </summary>
        /// <param name="a1">First car to compare.</param>
        /// <param name="a2">Second car to compare.</param>
        /// <returns>True if both cars are the same, otherwise false.</returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2) {
            if (!(a1 is null) && !(a2 is null)) {
                if ((a1.numero == a2.numero) && (String.Compare(a1.escuderia, a2.escuderia) == 0)) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Compares if the number and team of both cars are different.
        /// </summary>
        /// <param name="a1">First car to compare.</param>
        /// <param name="a2">Second car to compare.</param>
        /// <returns>True if both cars are different, otherwise false.</returns>
        public static bool operator !=(AutoF1 a1, AutoF1 a2) {
            return !(a1 == a2);
        }

        #endregion

        #region ShowData

        /// <summary>
        /// Shows the data of the car.
        /// </summary>
        /// <returns>The data as a string.</returns>
        public string MostrarDatos() {
            string stats = String.Format("Number: {0,2} | Team: {1,-6} | Comp: {2,-5} | Fuel: {3,3}% | Laps: {4,2}",
                this.numero, this.escuderia, this.EnCompetencia, this.CantidadCombustible, this.VueltasRestantes);

            return stats;
        }

        #endregion
    }
}
