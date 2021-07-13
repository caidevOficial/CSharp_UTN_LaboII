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

using System.Text;

namespace Models {
    public sealed class Jugador : Persona {
        private int partidosJugados;
        private int totalGoles;

        #region Builders

        /// <summary>
        /// Builds the entity with its pk and name.
        /// </summary>
        /// <param name="dni">PK of the soccer player.</param>
        /// <param name="nombre">name of the soccer player.</param>
        public Jugador(int dni, string nombre) : base(dni, nombre) { }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="dni">PK of the soccer player.</param>
        /// <param name="nombre">name of the soccer player.</param>
        /// <param name="partidosJugados">Games Played of the soccer player.</param>
        /// <param name="totalGoles">Amount of goals of the soccer player.</param>
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
            : base(dni, nombre) {
            this.PartidosJugados = partidosJugados;
            this.TotalGoles = totalGoles;
        }

        #endregion

        #region Properties

        /// <summary>
        /// GET: gets the amount of games played.
        /// Set: sets the amount of games played.
        /// </summary>
        public int PartidosJugados {
            get => partidosJugados;
            set {
                if (value >= 0) {
                    partidosJugados = value;
                }
            }
        }

        /// <summary>
        /// GET: gets the amount goals.
        /// Set: sets the amount goals.
        /// </summary>
        public int TotalGoles {
            get => totalGoles;
            set {
                if (value >= 0) {
                    totalGoles = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if the two entities have the same pk.
        /// </summary>
        /// <param name="j1">First entity to compare.</param>
        /// <param name="j2">Second entity to compare.</param>
        /// <returns>True if both have the same pk, otherwise returns false.</returns>
        public static bool operator ==(Jugador j1, Jugador j2) {
            return j1.dni == j2.dni;
        }

        /// <summary>
        /// Compares if the two entities have different pk.
        /// </summary>
        /// <param name="j1">First entity to compare.</param>
        /// <param name="j2">Second entity to compare.</param>
        /// <returns>True if both have different pk, otherwise returns false.</returns>
        public static bool operator !=(Jugador j1, Jugador j2) {
            return !(j1.dni == j2.dni);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the data of the soccer player.
        /// </summary>
        /// <returns>The data of the soccer player as a string.</returns>
        public override string MostrarDatos() {
            StringBuilder data = new StringBuilder();
            data.Append($"######## Soccer Player ########\n");
            data.Append($"Name: {this.Nombre}.\n");
            data.Append($"Dni: {this.DNI}.\n");
            data.Append($"Games Played: {this.PartidosJugados}.\n");
            data.Append($"Amount Goals: {this.TotalGoles}.\n");

            return data.ToString();
        }

        #endregion
    }
}
