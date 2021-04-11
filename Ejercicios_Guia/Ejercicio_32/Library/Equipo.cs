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

namespace Library
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> listaJugadores;
        private string nombre;

        #region Builders

        /// <summary>
        /// Creates the entity initializing the List.
        /// </summary>
        private Equipo()
        {
            listaJugadores = new List<Jugador>();
        }

        /// <summary>
        /// Creates the entity with the amount of players and the name.
        /// </summary>
        /// <param name="cantidadJugadores">Amount of players of the team.</param>
        /// <param name="nombre">Name of the team.</param>
        public Equipo(short cantidadJugadores, string nombre) : this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Tries to add a player in the team if not exist.
        /// </summary>
        /// <param name="e">Team to checkout.</param>
        /// <param name="j1">Player to compare between the players of the team.</param>
        /// <returns>True if can add the player, otherwise false.</returns>
        public static bool operator +(Equipo e, Jugador j1)
        {
            if (e.listaJugadores.Count < e.cantidadJugadores)
            {
                foreach (Jugador player in e.listaJugadores)
                {
                    if (player == j1)
                    {
                        return false;
                    }
                }

                e.listaJugadores.Add(j1);
                return true;
            }

            return false;
        }

        #endregion
    }
}