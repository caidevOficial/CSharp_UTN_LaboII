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

namespace ComiqueriaLogic {
    public class Comic : Producto {

        #region Attributes

        private string autor;
        private TipoComic tipoComic;

        public enum TipoComic {
            Occidental,
            Oriental
        }

        #endregion

        #region Builders

        /// <summary>
        /// Builds the entity with description, stock, price, autor and type of comic.
        /// </summary>
        /// <param name="descripcion">Description of the entity.</param>
        /// <param name="stock">Stock of the entity.</param>
        /// <param name="precio">Price of the entity.</param>
        /// <param name="autor">autor of the entity.</param>
        /// <param name="tipoComic">type of the entity.</param>
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic)
            : base(descripcion, stock, precio) {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the entire info of the Comic.
        /// </summary>
        /// <returns>the entire info of the Comic as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.Append(base.ToString());
            data.AppendLine($"Tipo Comic: {this.tipoComic}");
            data.AppendLine($"Autor: {this.autor}");

            return data.ToString();
        }

        #endregion
    }
}
