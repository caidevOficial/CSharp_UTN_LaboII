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
    public sealed class PrestamoDolar : Prestamo {

        #region Attributes

        private PeriodicidadDePagos perioricidad;

        #endregion

        #region Builders

        /// <summary>
        /// Crea el objeto con su Prestamo y periodicidad.
        /// </summary>
        /// <param name="prestamo">Pestamo a crear del tipo Peso</param>
        /// <param name="perioricidad">Tipo de perioricidad del prestamo</param>
        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos perioricidad)
            : this(prestamo.Monto, prestamo.Vencimiento, perioricidad) { }

        /// <summary>
        /// Crea el objeto con su monto, vencimiento y periodicidad.
        /// </summary>
        /// <param name="monto">Monto del prestamo</param>
        /// <param name="vencimiento">Vencimiento del prestamo.</param>
        /// <param name="perioricidad">Tipo de periodicidad del prestamo</param>
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos perioricidad)
            : base(monto, vencimiento) {
            this.perioricidad = perioricidad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Retorna el tipo de prestamo, Mensual, Bimestral o trimestral.
        /// </summary>
        public PeriodicidadDePagos Perioricidad {
            get => this.perioricidad;
        }

        /// <summary>
        /// Get: Calcula y retorna el interes del prestamo.
        /// </summary>
        public float Interes {
            get => this.CalcularInteres();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Extiende el plazo del prestamo y suma interes segun la
        /// cantidad extra de dias.
        /// </summary>
        /// <param name="nuevoVencimiento">Nueva fecha de vencimiento del prestamo</param>
        public override void ExtenderPlazo(DateTime nuevoVencimiento) {
            TimeSpan diferenciaDias = nuevoVencimiento - this.Vencimiento;
            if (diferenciaDias.Days > 0) {
                this.monto += diferenciaDias.Days * 2.5F;
                this.Vencimiento = nuevoVencimiento;
            }
        }
        /// <summary>
        /// Calcula el interes del prestamo segun su porcentaje.
        /// </summary>
        /// <returns>El interes del prestamo como float.</returns>
        private float CalcularInteres() {
            float.TryParse($"0,{Convert.ToInt32(this.Perioricidad)}", out float porcentaje);
            return this.Monto * porcentaje;
        }

        /// <summary>
        /// Obtiene un string con la info del prestamo.
        /// </summary>
        /// <returns>Info del prestamo como string.</returns>
        public override string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.Append(base.Mostrar());
            data.AppendLine($"Periodo: {this.perioricidad}\n");

            return data.ToString();
        }

        #endregion
    }
}
