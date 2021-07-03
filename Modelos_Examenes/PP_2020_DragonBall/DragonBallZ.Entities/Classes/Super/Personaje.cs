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

using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    public abstract class Personaje {
        protected List<EHabilidades> ataques;
        protected int nivelPoder;
        protected string nombre;

        #region Builders

        /// <summary>
        /// Creates the list of skills.
        /// </summary>
        private Personaje() {
            ataques = new List<EHabilidades>();
        }

        /// <summary>
        /// Creates the entity with the name and powerlevel
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="nivelPoder">PowerLevel of the entity.</param>
        protected Personaje(string nombre, int nivelPoder) : this() {
            this.nombre = nombre;
            this.nivelPoder = nivelPoder;
        }

        /// <summary>
        /// Creates the entity with the name, powerlevel and list of skills.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="nivelPoder">PowerLevel of the entity.</param>
        /// <param name="ataques">List of skills</param>
        protected Personaje(string nombre, int nivelPoder, List<EHabilidades> ataques)
            : this(nombre, nivelPoder) {
            this.ataques = new List<EHabilidades>(ataques);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the description of the entity.
        /// </summary>
        protected abstract string Descripcion { get; }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if the character is inside the list of characters.
        /// </summary>
        /// <param name="p">Character to check in the list.</param>
        /// <param name="listaPersonajes">List to check the character.</param>
        /// <returns>Returns true if the character is in the list, otherwise returns false.</returns>
        public static bool operator ==(Personaje p, List<Personaje> listaPersonajes) {
            if (!(p is null) && !(listaPersonajes is null)) {
                return listaPersonajes.Contains(p);
            }

            return false;
        }

        /// <summary>
        /// Compares if the character is not inside the list of characters.
        /// </summary>
        /// <param name="p">Character to check in the list.</param>
        /// <param name="listaPersonajes">List to check the character.</param>
        /// <returns>Returns true if the character is not in the list, otherwise returns false.</returns>
        public static bool operator !=(Personaje p, List<Personaje> listaPersonajes) {
            return !(p == listaPersonajes);
        }

        /// <summary>
        /// Checks if both characters are equals.
        /// </summary>
        /// <param name="p1">First character to check.</param>
        /// <param name="p2">Second character to check.</param>
        /// <returns>True if are equals, otherwise returns false</returns>
        public static bool operator ==(Personaje p1, Personaje p2) {
            return p1.GetType().Name == p2.GetType().Name && p1.nombre == p2.nombre;
        }

        /// <summary>
        /// Checks if both characters are not equals.
        /// </summary>
        /// <param name="p1">First character to check.</param>
        /// <param name="p2">Second character to check.</param>
        /// <returns>True if are not equals, otherwise returns false</returns>
        public static bool operator !=(Personaje p1, Personaje p2) {
            return !(p1 == p2);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the info of the character as a string.
        /// </summary>
        /// <returns>The info of the character as a string.</returns>
        public virtual string InfoPersonaje() {
            StringBuilder data = new StringBuilder();
            data.AppendLine(String.Format("Nombre: {0}", this.nombre));
            data.AppendLine($"PowerLevel: {this.nivelPoder}");
            data.AppendLine($"Descripcion: {this.Descripcion}");
            data.AppendLine("Ataques:");
            foreach (EHabilidades eHabilidades in ataques) {
                data.AppendLine(eHabilidades.ToString());
            }

            return data.ToString();
        }

        /// <summary>
        /// Gets the name of the character as a string.
        /// </summary>
        /// <returns>The name of the character as a string.</returns>
        public override string ToString() {
            return this.nombre;
        }

        /// <summary>
        /// Transforms the characters.
        /// </summary>
        /// <returns>A string with a message.</returns>
        public abstract string Transformarse();

        #endregion
    }
}
