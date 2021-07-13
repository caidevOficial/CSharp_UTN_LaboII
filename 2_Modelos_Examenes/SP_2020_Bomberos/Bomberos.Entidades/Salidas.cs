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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberos.Extension;

namespace Bomberos.Entidades {

    [Serializable]
    public class Salidas {

        #region Attributes

        private DateTime fechaInicio;
        private DateTime fechaFin;

        #endregion

        #region Builders

        /// <summary>
        /// Init the time.
        /// </summary>
        public Salidas() {
            this.FechaInicio = DateTime.Now;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: the initial time.
        /// </summary>
        public DateTime FechaInicio { 
            get => this.fechaInicio;
            set {
                if (value.GetType() == typeof(DateTime)) {
                    this.fechaInicio = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the end time.
        /// </summary>
        public DateTime FechaFin { 
            get => this.fechaFin; 
            set {
                if (value.GetType() == typeof(DateTime)) {
                    this.fechaFin = value;
                }
            }
        }

        /// <summary>
        /// Gets: the difference between the 
        /// initial time and end time.
        /// </summary>
        public int TiempoTotal {
            get => this.FechaInicio.DiferenciaEnMinutos(this.FechaFin);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Ends the time.
        /// </summary>
        public void FinalizarSalida() {
            this.FechaFin = DateTime.Now;
        }

        /// <summary>
        /// Info of the entity.
        /// </summary>
        /// <returns>The info as a string</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.Append($"Inicio: {this.FechaInicio.ToUniversalTime()} ");
            data.Append($"Fin: {this.FechaFin.ToUniversalTime()} ");
            data.Append($"Total: {this.TiempoTotal} Minutes");

            return data.ToString();
        }

        #endregion
    }
}
