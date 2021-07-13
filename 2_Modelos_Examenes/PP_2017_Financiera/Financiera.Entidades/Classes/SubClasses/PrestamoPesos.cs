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

namespace PrestamosPersonales {
    public sealed class PrestamoPesos : Prestamo {

        #region Attributes

        private float porcentajeInteres;

        #endregion

        #region Builders

        /// <summary>
        /// Crea el objeto con su Prestamo e interes.
        /// </summary>
        /// <param name="prestamo">Pestamo a crear del tipo Peso</param>
        /// <param name="interes">Interes del prestamo</param>
        public PrestamoPesos(Prestamo prestamo, float interes)
            : this(prestamo.Monto, prestamo.Vencimiento, interes) { }

        /// <summary>
        /// Crea el objeto con su Prestamo e interes.
        /// </summary>
        /// <param name="monto">Monto del prestamo.</param>
        /// <param name="vencimiento">Vencimiento del prestamo.</param>
        /// <param name="interes">Interes del prestamo</param>
        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            : base(monto, vencimiento) {
            this.porcentajeInteres = interes;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Calcula y retorna el interes del prestamo.
        /// </summary>
        public float Interes {
            get => this.CalcularInteres();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calcula el interes del prestamo segun su porcentaje.
        /// </summary>
        /// <returns>El interes del prestamo como float.</returns>
        private float CalcularInteres() {
            return this.Monto * this.porcentajeInteres / 100;
        }

        /// <summary>
        /// Extiende el plazo del prestamo y suma interes segun la
        /// cantidad extra de dias.
        /// </summary>
        /// <param name="nuevoPlazo">Nueva fecha de vencimiento del prestamo</param>
        public override void ExtenderPlazo(DateTime nuevoPlazo) {
            TimeSpan diferenciaDias = nuevoPlazo - this.Vencimiento;
            if (diferenciaDias.Days > 0) {
                this.porcentajeInteres += diferenciaDias.Days * 0.25F;
                this.Vencimiento = nuevoPlazo;
            }
        }

        /// <summary>
        /// Obtiene un string con la info del prestamo.
        /// </summary>
        /// <returns>Info del prestamo como string.</returns>
        public override string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.Append(base.Mostrar());
            data.AppendLine($"Interes: {this.Interes}%\n");
            return data.ToString();
        }

        #endregion
    }
}
