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
    public class Biografia : Publicacion {

        #region Builders

        /// <summary>
        /// Crea la instancia de Biografia con parametro nombre
        /// </summary>
        /// <param name="nombre">nombre de la instancia</param>
        public Biografia(string nombre)
            : base(nombre) { }

        /// <summary>
        /// Crea la instancia de Biografia con nombre y stock
        /// </summary>
        /// <param name="nombre">nombre de la instancia</param>
        /// <param name="stock">Stock de la instancia</param>
        public Biografia(string nombre, int stock)
            : base(nombre, stock) { }

        /// <summary>
        /// Crea la instancia de Biografia con nombre, stock y precio
        /// </summary>
        /// <param name="nombre">nombre de la instancia</param>
        /// <param name="stock">Stock de la instancia</param>
        /// <param name="valor">importe de la instancia</param>
        public Biografia(string nombre, int stock, float valor)
            : base(nombre, stock, valor) { }

        #endregion

        #region Properties

        /// <summary>
        /// Retorna el stock de la entidad.
        /// </summary>
        public override bool HayStock {
            get => base.HayStock;
        }

        /// <summary>
        /// Retorna False.
        /// </summary>
        protected override bool EsColor {
            get => false;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Crea y devuelve una instancia de biografia con el nombre.
        /// </summary>
        /// <param name="nombre">una instancia de biografia con el nombre.</param>
        public static explicit operator Biografia(string nombre) {
            Biografia bio = new Biografia(nombre);
            bio.Stock += 1;
            return bio;
        }

        #endregion
    }
}
