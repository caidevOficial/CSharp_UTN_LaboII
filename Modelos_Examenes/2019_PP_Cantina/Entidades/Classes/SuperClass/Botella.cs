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
    public abstract class Botella {
        private int capacidadML;
        private int contenidoML;
        private string marca;

        /// <summary>
        /// Tipes of Bottles.
        /// </summary>
        public enum Tipo {
            Plastico,
            Vidrio
        }

        #region Builder

        /// <summary>
        /// Full constructor of the entity.
        /// </summary>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        protected Botella(string marca, int capacidadML, int contenidoML) {
            this.marca = marca;
            if (capacidadML < contenidoML) {
                this.capacidadML = contenidoML;
            } else {
                this.capacidadML = capacidadML;
            }
            this.contenidoML = contenidoML;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the capacity of the bottle in liters.
        /// </summary>
        protected float CapacidadLitros {
            get => this.capacidadML / 1000;
        }

        /// <summary>
        /// Get: Gets the Content of the bottle in ml.
        /// Set: Sets the content of the bottle in ml.
        /// </summary>
        protected int Contenido {
            get => this.contenidoML;
            set {
                if (value > 0) {
                    this.contenidoML = value;
                } else {
                    this.contenidoML = 0;
                }
            }
        }

        /// <summary>
        /// Get: Gets the percentaje of content of the bottle.
        /// </summary>
        protected float PorcentajeContenido {
            get => (this.contenidoML * 100 / this.capacidadML);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        protected virtual string GenerarInforme() {
            StringBuilder data = new StringBuilder();
            data.Append($"Marca: {this.marca}.\n");
            data.Append($"Capacidad: {this.CapacidadLitros}Lts.\n");
            data.Append($"Contenido: {this.Contenido}Ml.\n");
            data.Append($"Porcentaje Contenido: {this.PorcentajeContenido}%.\n");

            return data.ToString();
        }

        /// <summary>
        /// Serves a measure of drink.
        /// </summary>
        /// <returns>The content with a less amount.</returns>
        public abstract int ServirMedida();

        /// <summary>
        /// Returns the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        public override string ToString() {
            return GenerarInforme();
        }

        #endregion
    }
}
