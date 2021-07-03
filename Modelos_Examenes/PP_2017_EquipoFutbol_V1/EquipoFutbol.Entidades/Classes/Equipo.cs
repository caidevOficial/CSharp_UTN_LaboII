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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public sealed class Equipo {

        #region Attributes

        public enum Deportes {
            Basquet,
            Futbol,
            Handball,
            Rugby
        }

        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        #endregion

        #region Builders

        /// <summary>
        /// Initialices the team as a soccer team.
        /// </summary>
        static Equipo() {
            deporte = Deportes.Futbol;
        }

        /// <summary>
        /// Initialices the list of soccer players.
        /// </summary>
        private Equipo() {
            this.jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Creates the entity with name and dt.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="dt">DT of the entity.</param>
        public Equipo(string nombre, DirectorTecnico dt)
            :this(){
            this.nombre = nombre;
            this.dt = dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dt"></param>
        /// <param name="deporte"></param>
        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte)
            : this(nombre, dt) {
            this.Deporte = deporte;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Sets the type of sport of the team.
        /// </summary>
        public Deportes Deporte {
            set {
                if (value.GetType() == typeof(Deportes)) {
                    Equipo.deporte = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if the soccer player is in the team.
        /// </summary>
        /// <param name="e">Team to search for the soccer player.</param>
        /// <param name="j">Soccer player to search into the team.</param>
        /// <returns>True if the soccer player is in the team, otherwise returns false.</returns>
        public static bool operator ==(Equipo e, Jugador j) {
            if(!(e is null) && !(j is null)) {
                foreach (Jugador player in e.jugadores) {
                    if(j.Equals(player)) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Compares if the soccer player isn't in the team.
        /// </summary>
        /// <param name="e">Team to search for the soccer player.</param>
        /// <param name="j">Soccer player to search into the team.</param>
        /// <returns>True if the soccer player isn't in the team, otherwise returns false.</returns>
        public static bool operator !=(Equipo e, Jugador j) {
            return !(e == j);
        }

        /// <summary>
        /// If the soccer player isn't in the team, he will be added.
        /// </summary>
        /// <param name="e">Team to search for the soccer player and add him.</param>
        /// <param name="j">Soccer player to add in the team.</param>
        /// <returns>The team with the new soccer player if can add him, otherwise returns the team as is.</returns>
        public static Equipo operator +(Equipo e, Jugador j) {
            if (e != j) {
                e.jugadores.Add(j);
            }

            return e;
        }

        /// <summary>
        /// If the soccer player is in the team, he will be deleted.
        /// </summary>
        /// <param name="e">Team to search for the soccer player and delete him.</param>
        /// <param name="j">Soccer player to delete in the team.</param>
        /// <returns>The team with the new soccer player deleted if can, otherwise returns the team as is.</returns>
        public static Equipo operator -(Equipo e, Jugador j) {
            if(e == j) {
                e.jugadores.Remove(j);
            }

            return e;
        }

        /// <summary>
        /// Implicit conversion of the team.
        /// </summary>
        /// <param name="e">Team to gets its entire data.</param>
        public static implicit operator string(Equipo e) {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"** {e.nombre} {Equipo.deporte} **");
            data.AppendLine("Nomina de jugadores:");
            foreach (Jugador item in e.jugadores) {
                data.Append(item.ToString());
            }
            data.AppendLine($"Dirigido por: {e.dt.ToString()}");

            return data.ToString();
        }

        #endregion

    }
}
