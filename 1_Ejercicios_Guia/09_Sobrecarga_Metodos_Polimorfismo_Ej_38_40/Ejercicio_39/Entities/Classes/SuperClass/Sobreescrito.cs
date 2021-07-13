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

namespace Entities {
    public abstract class Sobreescrito {
        protected string miAtributo;

        /// <summary>
        /// Builder of the entity.
        /// </summary>
        public Sobreescrito() {
            this.miAtributo = "Probar abstractos";
        }

        /// <summary>
        /// Get: returns the unique attribute.
        /// </summary>
        public abstract string MiPropiedad { get; }

        #region Methods

        /// <summary>
        /// Abstract method.
        /// </summary>
        /// <returns>Returns a string.</returns>
        public abstract string MiMetodo();

        /// <summary>
        /// Override of ToString() that returns a new message.
        /// </summary>
        /// <returns>Returns a custom message.</returns>
        public override string ToString() {
            return "¡Este es mi método ToString sobreescrito!";
        }

        /// <summary>
        /// Compares if the objetc is the same of this.
        /// </summary>
        /// <param name="obj">Objet to compare with this.</param>
        /// <returns>True if the object is equal of this, otherwise returns false.</returns>
        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        /// <summary>
        /// An override implementation of GetHashCode().
        /// </summary>
        /// <returns>Returns an specific number.</returns>
        public override int GetHashCode() {
            return 1142510187;
        }

        #endregion
    }
}
