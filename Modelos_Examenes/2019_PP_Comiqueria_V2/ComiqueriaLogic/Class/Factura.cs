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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobantesLogic {
    public class Factura : Comprobante {

        #region Attributes

        public enum TipoFactura {
            A,
            B,
            C,
            E
        }

        private DateTime fechaVencimiento;
        private TipoFactura tipoFactura;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the instance of Factura with all its parameters
        /// and a due date of 15 by default.
        /// </summary>
        /// <param name="venta">Sale to add in the instance.</param>
        /// <param name="tf">Type of instance.</param>
        public Factura(Venta venta, TipoFactura tf)
            :this(venta, 15, tf) { }

        /// <summary>
        /// Creates the instance of Factura with all its parameters.
        /// </summary>
        /// <param name="venta">Sale to add in the instance.</param>
        /// <param name="diasVencimiento">Due Date of the instance.</param>
        /// <param name="tf">Type of instance.</param>
        public Factura(Venta venta, int diasVencimiento, TipoFactura tf)
            : base(venta) {
            this.fechaEmision = venta.Fecha;
            this.fechaVencimiento = this.fechaEmision.AddDays(diasVencimiento);
            this.tipoFactura = tf;
        }

        #endregion

        #region Methods

        /// <summary>
        /// It will compare an objetc with this instance
        /// and will return if is equal or not, bassed on they type and date.
        /// </summary>
        /// <param name="obj">Instance to compare with this</param>
        /// <returns>True is are equals, otherwise returns false.</returns>
        public override bool Equals(object obj) {
            return base.Equals(obj) && this.tipoFactura == ((Factura)obj).tipoFactura;
        }

        /// <summary>
        /// It generates a voucher.
        /// </summary>
        /// <returns>A voucher as a string.</returns>
        public override string GenerarComprobante() {
            StringBuilder data = new StringBuilder();
            double unitPrice = Math.Round(((Producto)this.Venta).Precio, 2);
            double subTotal = unitPrice * this.Venta.Cantidad;
            double iva = (subTotal * 21/100);
            data.AppendLine($"Factura: {this.tipoFactura.ToString()}");
            data.AppendLine($"Fecha Emision: {this.fechaEmision.ToString()}");
            data.AppendLine($"Fecha Vencimiento: {this.fechaVencimiento.ToString()}");
            data.AppendLine($"Producto: {((Producto)this.Venta).Descripcion}");
            data.AppendLine($"Cantidad: {this.Venta.Cantidad.ToString()}");
            data.AppendLine($"Precio Unit: ${unitPrice}");
            data.AppendLine($"SubTotal: ${subTotal}");
            data.AppendLine($"IVA: ${iva}");
            data.AppendLine($"Total: ${subTotal + iva}");

            return data.ToString();
        }

        #endregion
    }
}
