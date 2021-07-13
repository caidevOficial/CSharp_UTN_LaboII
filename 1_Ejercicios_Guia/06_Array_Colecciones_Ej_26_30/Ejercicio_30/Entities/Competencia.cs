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
using System.Collections.Generic;

namespace Entities {
    public sealed class Competencia {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        #region Builders

        /// <summary>
        /// Builds the instance and the list.
        /// </summary>
        private Competencia() {
            competidores = new List<AutoF1>();
        }

        /// <summary>
        /// Builds the instance with the parameters and initialize the list.
        /// </summary>
        /// <param name="cantidadCompetidores">Amount of competitors</param>
        /// <param name="cantidadVueltas">Amount of laps.</param>
        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this() {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Tries to add the car to the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Car to add into the competence.</param>
        /// <returns>True if can add the car, otherwise returns false.</returns>
        public static bool operator +(Competencia c, AutoF1 a) {
            Random rdm = new Random();
            if (!(c is null) && !(a is null)) {
                if (c.competidores.Count < c.cantidadCompetidores) {
                    if (!(c == a)) {
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVueltas;
                        a.CantidadCombustible = (short)rdm.Next(15, 100);
                        c.competidores.Add(a);
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Tries to remove the car from the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Car to remove from the competence.</param>
        /// <returns>True if can remove the car, otherwise returns false.</returns>
        public static bool operator -(Competencia c, AutoF1 a) {
            if (!(c is null) && !(a is null)) {
                if (c == a) {
                    c.competidores.RemoveAt(c.competidores.IndexOf(a));
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Compares if the car is in the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Car to verify if is in the competence.</param>
        /// <returns>True if the car is inside the competence, otherwise returns false.</returns>
        public static bool operator ==(Competencia c, AutoF1 a) {
            if (!(c is null) && !(a is null)) {
                foreach (AutoF1 autoF1 in c.competidores) {
                    if (a == autoF1) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Compares if the car is not in the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Car to verify if is not in the competence.</param>
        /// <returns>True if the car is not inside the competence, otherwise returns false.</returns>
        public static bool operator !=(Competencia c, AutoF1 a) {
            return !(c == a);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the stats of the competence.
        /// </summary>
        /// <returns>Returns the stats as a string.</returns>
        public string MostrarDatos() {
            string stats = String.Format("Competitors: {0,2} | remaining Laps: {1,2}\nCars:\n", this.cantidadCompetidores, this.cantidadVueltas);
            foreach (AutoF1 autoF1 in competidores) {
                stats += autoF1.MostrarDatos();
            }

            return stats;
        }

        #endregion

    }
}
