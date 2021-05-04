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
    public sealed class Venta {

        #region Attributes

        private DateTime fecha;
        static int porcentajeIva;
        private int cantidad;
        private double precioFinal;
        private Producto producto;

        #endregion

        #region Builders

        /// <summary>
        /// Init the percentage.
        /// </summary>
        static Venta() {
            porcentajeIva = 21;
        }

        /// <summary>
        /// Creates the entity with the product and amount of it.
        /// </summary>
        /// <param name="producto">Product's entity to sell.</param>
        /// <param name="cantidad">Amount of product.</param>
        internal Venta(Producto producto, int cantidad) {
            this.producto = producto;
            this.cantidad = cantidad;
            Vender(cantidad);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the date time of the sell.
        /// </summary>
        internal DateTime Fecha {
            get => this.fecha;
        }

        /// <summary>
        /// Gets the amount of product.
        /// </summary>
        public int Cantidad {
            get => this.cantidad;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Gets the product of the sale.
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Producto(Venta v) {
            return v.producto;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the final price bassed on the unit price and the amount of units.
        /// </summary>
        /// <param name="precioUnit">Unit price of the product.</param>
        /// <param name="cantidad">Amount of the product.</param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnit, int cantidad) {
            string pIva = $"1,{porcentajeIva}";
            double.TryParse(pIva, out double dIva);
            return (precioUnit * cantidad) * dIva;
        }

        /// <summary>
        /// Makes the sell of the product.
        /// </summary>
        /// <param name="cantidad">Amount of product to sell.</param>
        private void Vender(int cantidad) {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        /// <summary>
        /// Gets a little description of the sell.
        /// </summary>
        /// <returns>A little description of the sell as a string.</returns>
        public string ObtenerDescripcionBreve() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Fecha: {this.Fecha} - Descripcion: {this.producto.Descripcion} Cantidad: {this.Cantidad} - Precio: ${Math.Round(this.precioFinal, 2)}");

            return data.ToString();
        }

        #endregion
    }
}
