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

using Enums;
using System.Text;

namespace Models {
    public class Celular : Producto {

        #region Attributes

        public EGama gama;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with its modelo, manufacturer and type.
        /// </summary>
        /// <param name="modelo">Modell of the entity.</param>
        /// <param name="fabricante">Manufacturerl of the entity.</param>
        /// <param name="gama">Gammal of the entity.</param>
        public Celular(string modelo, Fabricante fabricante, EGama gama)
            : base(modelo, fabricante) {
            this.gama = gama;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cast the entity to return its price if exist, otherwise returns 0.
        /// </summary>
        /// <param name="a">Entity to cast to double.</param>
        public static explicit operator double(Celular a) {
            if (!(a is null)) {
                return a.Precio;
            }

            return 0;
        }

        /// <summary>
        /// Compares if both products are equals bassed on its products
        /// and types
        /// </summary>
        /// <param name="a">First Entity to comare.</param>
        /// <param name="b">Second Entity to comare.</param>
        /// <returns>True if both entities are equals, otherwise returns false.</returns>
        public static bool operator ==(Celular a, Celular b) {
            if (!(a is null) && !(b is null)) {
                return a.gama.ToString() == b.gama.ToString() && ((Producto)a) == ((Producto)b);
            }

            return false;
        }

        /// <summary>
        /// Compares if both products aren't equals bassed on its products
        /// and types
        /// </summary>
        /// <param name="a">First Entity to comare.</param>
        /// <param name="b">Second Entity to comare.</param>
        /// <returns>True if both entities aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Celular a, Celular b) {
            return !(a == b);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Compares if the type of the object of the 
        /// parameter is the same of this.
        /// </summary>
        /// <param name="obj">Object to check its type.</param>
        /// <returns>True if its type es the same as this, otherwise returns false.</returns>
        public override bool Equals(object obj) {
            return this == (Celular)obj;
        }

        /// <summary>
        /// Gets all the info of the entity.
        /// </summary>
        /// <returns>the info of the entity as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.Append((string)this);
            data.AppendLine($"Gama: {this.gama}");

            return data.ToString();
        }

        #endregion
    }
}
