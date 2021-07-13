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
    public abstract class Prestamo {

        #region Attributes

        protected float monto;
        protected DateTime vencimiento;

        #endregion

        #region Builders

        /// <summary>
        /// Crea el objeto con su monto y vencimiento.
        /// </summary>
        /// <param name="monto">Monto del prestamo.</param>
        /// <param name="vencimiento">Vencimiento del prestamo.</param>
        public Prestamo(float monto, DateTime vencimiento) {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Obtiene el monto del prestamo.
        /// </summary>
        public float Monto {
            get => this.monto;
        }

        /// <summary>
        /// Get: Obtiene el vencimiento del prestamo.
        /// Set: Setea el vencimiento del prestamo siempre y cuando sea mayor al actual, sino dejara el actual..
        /// </summary>
        public DateTime Vencimiento {
            get => this.vencimiento;
            set {
                if (value > this.vencimiento) {
                    this.vencimiento = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Se usa para ordenar la lista de prestamos, segun fecha.
        /// </summary>
        /// <param name="p1">Primer prestamo a comparar.</param>
        /// <param name="p2">Segundo prestamo a comparar.</param>
        /// <returns>Retorna 1 si p1 es mas actual, -1 si p2 es mas  actual y 0 si tienen misma fecha</returns>
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2) {
            if (!(p1 is null) && !(p2 is null)) {
                if (p1.Vencimiento > p2.Vencimiento) {
                    return 1;
                } else if (p1.Vencimiento < p2.Vencimiento) {
                    return -1;
                }
            }

            return 0;
        }

        /// <summary>
        /// Extiende el plazo del prestamo y suma interes segun la
        /// cantidad extra de dias.
        /// </summary>
        /// <param name="nuevoVencimiento">Nueva fecha de vencimiento del prestamo</param>
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        /// <summary>
        /// Obtiene un string con la info del prestamo.
        /// </summary>
        /// <returns>Info del prestamo como string.</returns>
        public virtual string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Monto: {this.Monto}");
            data.AppendLine($"Vencimiento: {this.Vencimiento}");

            return data.ToString();
        }

        #endregion
    }
}
