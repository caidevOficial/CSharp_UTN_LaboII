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
    public class Fabricante {

        #region Attributes

        private string marca;
        private EPais pais;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with its brand and country.
        /// </summary>
        /// <param name="marca">Brand of the entity as a string.</param>
        /// <param name="pais">Country of the entity (enum EPais)</param>
        public Fabricante(string marca, EPais pais) {
            this.marca = marca;
            this.pais = pais;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Gets the info of the entity as a string.
        /// </summary>
        /// <param name="f">Entity to get the information as a string.</param>
        public static implicit operator string(Fabricante f) {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{f.marca} - {f.pais}.");

            return data.ToString();
        }

        /// <summary>
        /// Compares if both Manufacturers are equals bassed in its
        /// brand and country.
        /// </summary>
        /// <param name="a">First entity to compare.</param>
        /// <param name="b">Second entity to compare.</param>
        /// <returns>True if both entities are equals, otherwise returns false.</returns>
        public static bool operator ==(Fabricante a, Fabricante b) {
            if (!(a is null) && !(b is null)) {
                return a.marca.Equals(b.marca) && a.pais == b.pais;
            }

            return false;
        }

        /// <summary>
        /// Compares if both Manufacturers aren't equals bassed in its
        /// brand and country.
        /// </summary>
        /// <param name="a">First entity to compare.</param>
        /// <param name="b">Second entity to compare.</param>
        /// <returns>True if both entities aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Fabricante a, Fabricante b) {
            return !(a == b);
        }

        #endregion

    }
}
