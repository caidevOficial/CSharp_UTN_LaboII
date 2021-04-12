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

namespace Models
{
    public class AutoF1 : VehiculoCarrera
    {
        private short caballosFuerza;

        #region Properties

        /// <summary>
        /// Get: Gets the hp of the vehicle.
        /// Set: Sets the hp of the vehicle.
        /// </summary>
        public short CaballosFuerza
        {
            get => caballosFuerza;
            set
            {
                if (value > 50)
                {
                    caballosFuerza = value;
                }
            }
        }

        #endregion

        #region Builders

        /// <summary>
        /// Builds the car with number and team.
        /// </summary>
        /// <param name="numero">Number of the car.</param>
        /// <param name="escuderia">Team of the car.</param>
        public AutoF1(short numero, string escuderia) : base(numero, escuderia) { }

        /// <summary>
        /// Builds the car with number, horsepower and team.
        /// </summary>
        /// <param name="numero">Number of the car.</param>
        /// <param name="escuderia">Team of the car.</param>
        /// <param name="hp">HorsePower of the car.</param>
        public AutoF1(short numero, string escuderia, short hp) : base(numero, escuderia)
        {
            this.CaballosFuerza = hp;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if both cars are equals, based in its team, hp and number.
        /// </summary>
        /// <param name="a1">First Car to compares.</param>
        /// <param name="a2">Second Car to compares.</param>
        /// <returns>True if are equals, otherwise returns false.</returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (!(a1 is null) && !(a2 is null))
            {
                bool sameTeam = a1.Escuderia == a2.Escuderia;
                bool sameNumber = a1.Numero == a2.Numero;
                bool sameHP = a1.CaballosFuerza == a2.CaballosFuerza;

                return sameTeam && sameNumber && sameHP;
            }

            return false;
        }

        /// <summary>
        /// Compares if both cars are different, based in its team, hp and number.
        /// </summary>
        /// <param name="a1">First Car to compares.</param>
        /// <param name="a2">Second Car to compares.</param>
        /// <returns>True if are different, otherwise returns false.</returns>
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            if (!(a1 is null) && !(a2 is null))
            {
                return !(a1 == a2);
            }

            return false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the info of the car.
        /// </summary>
        /// <returns>The info of the car as a string.</returns>
        public override string MostrarDatos()
        {
            string stats = String.Format("Number: {0,2} | Team: {1,-6} | Comp: {2,-5} | Fuel: {3,3}% | HP: {4,4} | Laps: {5,2}\n",
               this.Numero, this.Escuderia, this.EnCompetencia, this.CantidadCombustible, this.CaballosFuerza, this.VueltasRestantes);

            return stats;
        }

        #endregion

    }
}
