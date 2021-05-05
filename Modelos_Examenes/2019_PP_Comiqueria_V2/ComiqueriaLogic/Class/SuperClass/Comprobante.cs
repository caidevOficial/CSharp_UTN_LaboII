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

using ComiqueriaLogic;
using System;

namespace ComprobantesLogic {
    public abstract class Comprobante {

        #region Attributes

        protected DateTime fechaEmision;
        private Venta venta;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with the sale and the date of the sale.
        /// </summary>
        /// <param name="v">Sale to take data.</param>
        public Comprobante(Venta v) {
            this.venta = v;
            this.fechaEmision = v.Fecha;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the sale of the entity.
        /// </summary>
        internal Venta Venta {
            get => this.venta;
        }

        #endregion

        #region Methods

        /// <summary>
        /// It generates a voucher.
        /// </summary>
        /// <returns>A voucher as a string.</returns>
        public abstract string GenerarComprobante();

        /// <summary>
        /// It will compare an objetc with this instance
        /// and will return if is equal or not, bassed on they type and date.
        /// </summary>
        /// <param name="obj">Instance to compare with this</param>
        /// <returns>True is are equals, otherwise returns false.</returns>
        public override bool Equals(object obj) {
            return obj.GetType() == obj.GetType() && this.fechaEmision == ((Comprobante)obj).fechaEmision;
        }

        #endregion
    }
}
