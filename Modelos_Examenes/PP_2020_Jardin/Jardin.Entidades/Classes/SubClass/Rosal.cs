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
    public class Rosal : Planta {
        private Color florColor;

        public enum Color {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }

        #region Builders

        /// <summary>
        /// Builds the entity with name and size.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="tamanio">Size of the entity.</param>
        public Rosal(string nombre, int tamanio)
            : base(nombre, tamanio) { }

        /// <summary>
        /// Builds the entity with name, color and size.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="tamanio">Size of the entity.</param>
        /// <param name="color">Color of the entity.</param>
        public Rosal(string nombre, int tamanio, Color color)
            : this(nombre, tamanio) {
            this.florColor = color;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the boolean state if have flowers or not.
        /// </summary>
        public override bool TieneFlores {
            get => true;
        }

        /// <summary>
        /// Gets the boolean state if have fruits or not.
        /// </summary>
        public override bool TieneFruto {
            get => false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the data of the entity as a string.
        /// </summary>
        /// <returns>The data of the entity as a string.</returns>
        public override string ResumenDeDatos() {
            StringBuilder data = new StringBuilder();
            data.Append(base.ResumenDeDatos());
            data.AppendLine($"Flores de Color: {this.florColor}");

            return data.ToString();
        }

        #endregion
    }
}
