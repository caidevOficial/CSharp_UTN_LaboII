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

namespace Entidades {
    public abstract class Mascota {
        private string nombre;
        private string raza;

        #region Builders

        /// <summary>
        /// Builds the instance with the name and race.
        /// </summary>
        /// <param name="nombre">Name of the instance.</param>
        /// <param name="raza">Race of the isntance.</param>
        public Mascota(string nombre, string raza) {
            this.nombre = nombre;
            this.raza = raza;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the entity.
        /// </summary>
        public string Nombre {
            get => this.nombre;
        }

        /// <summary>
        /// Gets the race of the entity.
        /// </summary>
        public string Raza {
            get => this.raza;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves the data of the instance.
        /// </summary>
        /// <returns>The data as a string.</returns>
        protected virtual string DatosCompletos() {
            StringBuilder data = new StringBuilder();
            data.Append($"{this.Nombre} {this.Raza} ");
            return data.ToString();
        }

        /// <summary>
        /// Retrieves the data of the instance.
        /// </summary>
        /// <returns>The data as a string.</returns>
        protected abstract string Ficha();

        #endregion
    }
}
