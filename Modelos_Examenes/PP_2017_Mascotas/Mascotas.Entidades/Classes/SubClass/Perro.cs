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
using System.Text;

namespace Entidades {
    public sealed class Perro : Mascota {
        private int edad;
        private bool esAlfa;

        #region Properties

        /// <summary>
        /// Gets the age of the entity.
        /// Sets the age of the entity.
        /// </summary>
        public int Edad {
            get => this.edad;
            set {
                if (value >= 0) {
                    this.edad = value;
                }
            }
        }

        /// <summary>
        /// Gets the alpha state of the entity.
        /// Sets the alpha state of the entity.
        /// </summary>
        public bool EsAlfa {
            get => this.esAlfa;
            set {
                this.esAlfa = value;
            }
        }

        #endregion

        #region Builders

        /// <summary>
        /// Builds the instance with the name and race.
        /// </summary>
        /// <param name="nombre">Name of the instance.</param>
        /// <param name="raza">Race of the isntance.</param>
        public Perro(string nombre, string raza)
        : this(nombre, raza, 0, false) { }

        /// <summary>
        /// Builds the instance with the name, race, age and a boolean
        /// that indicates if the instance is alpha or not.
        /// </summary>
        /// <param name="nombre">Name of the instance.</param>
        /// <param name="raza">Race of the isntance.</param>
        /// <param name="edad">Age of the isntance.</param>
        /// <param name="esAlfa">Boolean for alpha state.</param>
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza) {
            this.EsAlfa = esAlfa;
            this.Edad = edad;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Overloads the operator == to compare two instances by its name and race.
        /// </summary>
        /// <param name="p1">First instance to compare.</param>
        /// <param name="p2">Second instance to compare.</param>
        /// <returns>True if both are equals, otherwise returns false.</returns>
        public static bool operator ==(Perro p1, Perro p2) {
            if (!(p1 is null) && !(p2 is null)) {
                return p1.Edad == p2.Edad && p1.Raza == p2.Raza && p1.Nombre == p2.Nombre;
            }

            return false;
        }

        /// <summary>
        /// Overloads the operator != to compare two instances by its name and race.
        /// </summary>
        /// <param name="p1">First instance to compare.</param>
        /// <param name="p2">Second instance to compare.</param>
        /// <returns>True if both are not equals, otherwise returns false.</returns>
        public static bool operator !=(Perro p1, Perro p2) {
            return !(p1 == p2);
        }

        /// <summary>
        /// Overloads the operator int to retrieve the age of the instance.
        /// </summary>
        /// <param name="perro">Instance to do the action.</param>
        public static explicit operator int(Perro perro) {
            return perro.Edad;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves the data of the instance.
        /// </summary>
        /// <returns>The data as a string.</returns>
        protected override string Ficha() {
            StringBuilder data = new StringBuilder();
            data.Append(base.DatosCompletos());
            if (this.EsAlfa) {
                data.Append($", alfa de la manada");
            }
            data.Append($", edad {this.Edad}\n");

            return data.ToString();
        }

        /// <summary>
        /// Retrieves the data of the instance.
        /// </summary>
        /// <returns>The data as a string.</returns>
        public override string ToString() {
            return Ficha();
        }

        /// <summary>
        /// Overloads the Equals operator to compare and object with this.
        /// </summary>
        /// <param name="p1">Another instance to compare with this.</param>
        /// <returns>True if both instances are equals, otherwise returns false.</returns>
        public override bool Equals(Object p1) {
            if (!(p1 is null)) {
                return this == (Perro)p1;
            }

            return false;
        }

        #endregion
    }
}
