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

using System.Collections.Generic;
using System.Text;

namespace Entidades {
    public sealed class Equipo {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        #region Builders

        /// <summary>
        /// Creates the entity and its list of soccer players.
        /// </summary>
        private Equipo() {
            jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Creates the entity with the name.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        public Equipo(string nombre) : this() {
            this.nombre = nombre;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Set the DT of the entity.
        /// </summary>
        public DirectorTecnico DirectorTecnico {
            set {
                if (!(value is null) && value.ValidarAptitud()) {
                    directorTecnico = value;
                }
            }
        }

        /// <summary>
        /// Gets the anme of the entity.
        /// </summary>
        public string Nombre {
            get => this.nombre;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cast an entity to a string and retrieves its info!
        /// </summary>
        /// <param name="e">Team to cast.</param>
        public static explicit operator string(Equipo e) {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {e.Nombre}");
            if (!(e.directorTecnico is null)) {
                data.AppendLine($"DT: {e.directorTecnico.Nombre} {e.directorTecnico.Apellido}");
            } else {
                data.AppendLine("Sin DT Asignado");
            }
            data.AppendLine($"Cantidad maxima de jugadores: {cantidadMaximaJugadores}");
            data.AppendLine("Jugadores:");
            foreach (Jugador jugador in e.jugadores) {
                data.AppendLine(jugador.Mostrar());

            }

            return data.ToString();
        }

        /// <summary>
        /// Compares a player in a team and checks if exist.
        /// </summary>
        /// <param name="e">Team to check the soccer player.</param>
        /// <param name="j">Soccer player to find in the team.</param>
        /// <returns>True if the soccer player is in the team, otherwise returns false.</returns>
        public static bool operator ==(Equipo e, Jugador j) {
            return e.jugadores.Contains(j);
        }

        /// <summary>
        /// Compares a player in a team and checks if not exist.
        /// </summary>
        /// <param name="e">Team to check the soccer player.</param>
        /// <param name="j">Soccer player to find in the team.</param>
        /// <returns>True if the soccer player is not in the team, otherwise returns false.</returns>
        public static bool operator !=(Equipo e, Jugador j) {
            return !(e == j);
        }

        /// <summary>
        /// Adds a player in the team if not exist.
        /// </summary>
        /// <param name="e">Team to check the soccer player.</param>
        /// <param name="j">Soccer player to find in the team.</param>
        /// <returns>true if can add the soccer player into the team, otherwise returns false.</returns>
        public static Equipo operator +(Equipo e, Jugador j) {
            if (e != j && e.jugadores.Count < Equipo.cantidadMaximaJugadores) {
                if (j.ValidarAptitud() && j.ValidarEstadoFisico()) {
                    e.jugadores.Add(j);
                }
            }

            return e;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Validates that te team have at least one soccer player in
        /// each position, DT and 6 soccer players.
        /// </summary>
        /// <param name="e">Team to check.</param>
        /// <returns>True if is a valid team, otherwise returns false.</returns>
        public static bool ValidarEquipo(Equipo e) {
            int defensor = 0;
            int delantero = 0;
            int arquero = 0;
            int central = 0;

            if (!(e.directorTecnico is null) &&
                e.jugadores.Count == 6) {
                foreach (Jugador item in e.jugadores) {
                    switch (item.Posicion) {
                        case Posicion.Arquero:
                            arquero++;
                            break;
                        case Posicion.Central:
                            central++;
                            break;
                        case Posicion.Defensor:
                            defensor++;
                            break;
                        case Posicion.Delantero:
                            delantero++;
                            break;
                    }
                }
                if (delantero >= 1 && defensor >= 1 && arquero == 1 && central >= 1) {
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
