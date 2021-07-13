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
    public sealed class Jugador : Persona {

        #region Attributes

        private bool esCapitan;
        private int numero;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with name and surname and by default 
        /// won't be captain and its number will be 0.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="apellido">Surname of the entity.</param>
        public Jugador(string nombre, string apellido)
            :this(nombre, apellido, 0, false) { }

        /// <summary>
        /// Creates the entity with name, surname, number and boolean
        /// state that indicates if is captain or not.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="apellido">Surname of the entity.</param>
        /// <param name="numero">Number of the entity.</param>
        /// <param name="esCapitan">Boolean contidion for captain state of the entity.</param>
        public Jugador(string nombre, string apellido, int numero, bool esCapitan)
            :base(nombre, apellido) {
            this.numero = numero;
            this.EsCapitan = esCapitan;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: The boolean state for captain.
        /// Sets: The boolean state for captain.
        /// </summary>
        public bool EsCapitan {
            get => this.esCapitan;
            set {
                if(value.GetType() == typeof(bool)) {
                    this.esCapitan = value;
                }
            }
        }

        /// <summary>
        /// Gets: The number of the entity.
        /// Sets: The number of the entity.
        /// </summary>
        public int Numero {
            get => this.numero;
            set {
                if (value.GetType() == typeof(int)) {
                    this.numero = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if both instances are equals, bassed on 
        /// their number, name and surname.
        /// </summary>
        /// <param name="j1">First instance to compare.</param>
        /// <param name="j2">Second instance to compare.</param>
        /// <returns>True if both are equals, otherwise returns false.</returns>
        public static bool operator ==(Jugador j1, Jugador j2) {
            if(!(j1 is null) && !(j2 is null)) {
                if(j1.Nombre.Equals(j2.Nombre) &&
                    j1.Apellido.Equals(j2.Apellido) &&
                    j1.Numero == j1.Numero) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Compares if both instances aren't equals, bassed on 
        /// their number and name.
        /// </summary>
        /// <param name="j1">First instance to compare.</param>
        /// <param name="j2">Second instance to compare.</param>
        /// <returns>True if both aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Jugador j1, Jugador j2) {
            return !(j1 == j2);
        }

        /// <summary>
        /// Cast a soccer player and returns its number.
        /// </summary>
        /// <param name="j1">Instance to cast.</param>
        public static explicit operator int(Jugador j1) {
            if(!(j1 is null)) {
                return j1.Numero;
            }

            return -1;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the fulldata of the entity.
        /// </summary>
        /// <returns>the fulldata of the entity as a string.</returns>
        protected override string FichaTecnica() {
            StringBuilder data = new StringBuilder();
            data.Append(base.NombreCompleto());
            if (this.EsCapitan) {
                data.Append(", capitán del equipo");
            }
            data.AppendLine($", camiseta número {this.Numero}.");

            return data.ToString();
        }

        /// <summary>
        /// Gets the fulldata of the entity.
        /// </summary>
        /// <returns>the fulldata of the entity as a string.</returns>
        public override string ToString() {
            return this.FichaTecnica();
        }

        /// <summary>
        /// Compares if both instances are equals, bassed on 
        /// their number and name.
        /// </summary>
        /// <param name="obj">Instance to compare with this.</param>
        /// <returns>True if both are equals, otherwise returns false.</returns>
        public override bool Equals(object obj) {
            return this == (Jugador)obj;
        }

        #endregion

    }
}
