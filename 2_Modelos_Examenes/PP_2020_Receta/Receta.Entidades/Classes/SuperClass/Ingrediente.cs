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
    public abstract class Ingrediente {
        private int cantidad;
        private string descripcion;

        #region Builders

        /// <summary>
        /// Builds the entity with description and amount.
        /// </summary>
        /// <param name="descripcion">Descriptcion of the entity.</param>
        /// <param name="cantidad">Amount of the entity.</param>
        public Ingrediente(string descripcion, int cantidad) {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the amount of entity.
        /// </summary>
        public int Cantidad {
            get => this.cantidad;
        }

        /// <summary>
        /// Gets the process of cook the entity.
        /// </summary>
        public abstract string Proceso { get; }

        /// <summary>
        /// Gets the unity of medition of the entity.
        /// </summary>
        public abstract string UnidadDeMedida { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the info of the entity as a string.
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public virtual string Informacion() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{this.descripcion} en una cantidad {this.Cantidad} {this.UnidadDeMedida}");
            data.AppendLine($"Procesar {this.Proceso}");

            return data.ToString();
        }

        #endregion
    }
}
