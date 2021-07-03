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
    public abstract class Publicacion {

        #region Attributes

        protected float importe;
        protected string nombre;
        protected int stock;

        #endregion

        #region Builders

        /// <summary>
        /// Crea la instancia de publicacion con parametro nombre
        /// </summary>
        /// <param name="nombre">nombre de la instancia</param>
        public Publicacion(string nombre) {
            this.nombre = nombre;
        }

        /// <summary>
        /// Crea la instancia de publicacion con nombre y stock
        /// </summary>
        /// <param name="nombre">nombre de la instancia</param>
        /// <param name="stock">Stock de la instancia</param>
        public Publicacion(string nombre, int stock)
            : this(nombre) {
            this.Stock = stock;
        }

        /// <summary>
        /// Crea la instancia de publicacion con nombre, stock y precio
        /// </summary>
        /// <param name="nombre">nombre de la instancia</param>
        /// <param name="stock">Stock de la instancia</param>
        /// <param name="importe">importe de la instancia</param>
        public Publicacion(string nombre, int stock, float importe)
            : this(nombre, stock) {
            this.importe = importe;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Retornara True si es una edicion a color, caso contrario retornara false.
        /// </summary>
        protected abstract bool EsColor { get; }

        /// <summary>
        ///  retornará True siempre y cuando haya stock y el importe sea mayor a 0
        /// </summary>
        public virtual bool HayStock {
            get {
                if (this.Stock > 0 && this.Importe >= 0) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        /// <summary>
        /// Retornara el importe.
        /// </summary>
        public float Importe {
            get => this.importe;
        }

        /// <summary>
        /// Retornara el stock
        /// Seteara el stock siempre que sea mayor a 0
        /// </summary>
        public int Stock {
            get => this.stock;
            set {
                if (value >= 0) {
                    this.stock = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// retornará los datos de la Publicacion
        /// </summary>
        /// <returns>los datos de la Publicacion</returns>
        public string Informacion() {
            StringBuilder data = new StringBuilder();
            data.AppendFormat("Nombre: {0}\n", this.nombre);
            data.Append($"Stock: {this.Stock}\n");
            if (this.EsColor) {
                data.AppendLine("Color: SI");
            } else {
                data.AppendLine("Color: NO");
            }
            data.AppendLine($"Valor: ${this.Importe}");


            return data.ToString();
        }

        /// <summary>
        /// retornará el nombre
        /// </summary>
        /// <returns>retornará el nombre</returns>
        public override string ToString() {
            return this.nombre;
        }

        #endregion
    }
}
