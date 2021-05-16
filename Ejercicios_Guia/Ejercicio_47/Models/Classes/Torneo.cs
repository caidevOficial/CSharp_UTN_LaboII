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
using System.Text;

namespace Models {
    public sealed class Torneo<T>
        where T : Equipo {

        #region Attributes

        private List<T> equipos;
        private string nombre;
        private static Random rnd = new Random();

        #endregion

        #region Builders

        /// <summary>
        /// Init the list of teams.
        /// </summary>
        private Torneo() {
            equipos = new List<T>();
        }

        /// <summary>
        /// Creates the entity and init its list.
        /// </summary>
        /// <param name="nombre">Name of the team.</param>
        public Torneo(string nombre) : this() {
            this.nombre = nombre;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the result of two teams randmly
        /// </summary>
        public string JugarPartido {
            get {
                int firstTeamIndex = rnd.Next(0, this.equipos.Count);
                int secondTeamIndex = rnd.Next(0, this.equipos.Count);
                if (this.equipos.Count > 1) {
                    while (firstTeamIndex == secondTeamIndex) {
                        secondTeamIndex = rnd.Next(0, this.equipos.Count);
                    }
                    return CalcularPartido(this.equipos[firstTeamIndex], this.equipos[secondTeamIndex]);
                }

                return string.Empty;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Checks if the team is inside the list of the tournament.
        /// </summary>
        /// <param name="t">Tournament to check for the team.</param>
        /// <param name="e">Team for check into the list of the tournament.</param>
        /// <returns>True if the team is in the list, otherwise returns false.</returns>
        public static bool operator ==(Torneo<T> t, Equipo e) {
            if (!(t is null) && !(e is null)) {
                foreach (T item in t.equipos) {
                    if (item == e) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the team isn't inside the list of the tournament.
        /// </summary>
        /// <param name="t">Tournament to check for the team.</param>
        /// <param name="e">Team for check into the list of the tournament.</param>
        /// <returns>True if the team isn't in the list, otherwise returns false.</returns>
        public static bool operator !=(Torneo<T> t, Equipo e) {
            return !(t == e);
        }

        /// <summary>
        /// Adds a team in the list if not exist.
        /// </summary>
        /// <param name="t">Tournament instance.</param>
        /// <param name="e">Team instance.</param>
        /// <returns>The tournament with the team inside if it could add it.</returns>
        public static Torneo<T> operator +(Torneo<T> t, Equipo e) {
            if (!(t is null) && !(e is null)) {
                if (t != e) {
                    t.equipos.Add((T)e);
                }
            }
            return t;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the result of the match.
        /// </summary>
        /// <typeparam name="T">Type of the entity.</typeparam>
        /// <param name="t1">First team to calculate its result.</param>
        /// <param name="t2">Second team to calculate its result.</param>
        /// <returns>Returns the result of the match as a string.</returns>
        private string CalcularPartido<T>(T t1, T t2) where T : Equipo {
            StringBuilder data = new StringBuilder();
            data.AppendLine("--------------------------------------------------------------------------------");
            data.AppendLine("\t\t\tMatch");
            data.AppendLine("--------------------------------------------------------------------------------");

            data.AppendLine($"[{t1.NombreEquipo}] {rnd.Next(1, 11)} - {rnd.Next(1, 11)} [{t2.NombreEquipo}]");

            return data.ToString();
        }

        /// <summary>
        /// Shows the info of the tournament and its teams.
        /// </summary>
        /// <returns>The info of the tournament as a string.</returns>
        public string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Torneo: {this.nombre}");
            data.AppendLine("_____________");
            foreach (Equipo item in this.equipos) {
                data.Append(item.Ficha());
                data.AppendLine("------------------");
            }
            data.AppendLine("_____________");

            return data.ToString();
        }

        #endregion
    }
}
