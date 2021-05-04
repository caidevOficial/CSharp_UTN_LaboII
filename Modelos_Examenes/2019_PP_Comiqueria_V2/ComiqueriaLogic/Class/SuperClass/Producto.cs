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

using System;
using System.Text;

namespace ComiqueriaLogic {
    public abstract class Producto {

        #region Attributes

        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        #endregion

        #region Builders

        /// <summary>
        /// Builds the entity with description, stock and price.
        /// </summary>
        /// <param name="descripcion">Description of the entity.</param>
        /// <param name="stock">Stock of the entity.</param>
        /// <param name="precio">Price of the entity.</param>
        protected Producto(string descripcion, int stock, double precio) {
            this.descripcion = descripcion;
            this.Stock = stock;
            this.Precio = precio;
            this.codigo = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Descripcion {
            get => this.descripcion;
        }

        /// <summary>
        /// Gets the price.
        /// Sets the price if is higher than 0.
        /// </summary>
        public double Precio {
            get => precio;
            set {
                if(value > 0) {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Updates the stock only if is at least equal to 0 or higher.
        /// Gets the current stock.
        /// </summary>
        public int Stock {
            get => stock;
            set {
                if (value >= 0) {
                    this.stock = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cast a product to get its Guid code.
        /// </summary>
        /// <param name="p">Product to cast.</param>
        public static explicit operator Guid(Producto p) {
            return p.codigo;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the entire info of the product.
        /// </summary>
        /// <returns>the entire info of the product as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Descripcion: {this.Descripcion}");
            data.AppendLine($"Codigo: [{(Guid)this}]");
            data.AppendLine($"Precio: ${this.Precio}");
            data.AppendLine($"Stock: {this.Stock}");

            return data.ToString();
        }

        #endregion
    }
}
