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

namespace Entidades {
    public class Comic : Publicacion {

        #region Attributes

        private bool esColor;

        #endregion

        #region Builders

        /// <summary>
        /// Crea una instancia de comic con todos sus parametros
        /// </summary>
        /// <param name="nombre">nombre de la instancia</param>
        /// <param name="esColor"></param>
        /// <param name="stock">Stock de la instancia</param>
        /// <param name="valor">importe de la instancia</param>
        public Comic(string nombre, bool esColor, int stock, float valor)
            : base(nombre, stock, valor) {
            this.esColor = esColor;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Retorna si el comic es de color o no.
        /// </summary>
        protected override bool EsColor {
            get => this.esColor;
        }

        #endregion

    }
}
