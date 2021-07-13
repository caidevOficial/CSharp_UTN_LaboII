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

namespace Library {
    public abstract class VehiculoTerrestre {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        #region Enum

        /// <summary>
        /// Enum of colors of the vehicle.
        /// </summary>
        public enum Colores {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }

        #endregion

        #region Builder

        /// <summary>
        /// Builds the entity without parameters.
        /// </summary>
        public VehiculoTerrestre() { }

        /// <summary>
        /// Builds the entity with 3 params.
        /// </summary>
        /// <param name="cantidadRuedas">Amount of wheels.</param>
        /// <param name="cantidadPuertas">Amount of doors.</param>
        /// <param name="color">Color of the vehicle.</param>
        protected VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
            : this() {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the amount of wheels of the vehicle.
        /// </summary>
        public short CantidadRuedas {
            get { return this.cantidadRuedas; }
            set {
                if (value > 0) {
                    this.cantidadRuedas = value;
                }
            }
        }

        /// <summary>
        /// Get: Gets the amount of doors of the vehicle.
        /// </summary>
        public short CantidadPuertas {
            get { return this.cantidadPuertas; }
            set {
                if (value > 1) {
                    this.cantidadPuertas = value;
                }
            }
        }

        /// <summary>
        /// Get: Gets the color of the vehicle.
        /// </summary>
        public Colores Color {
            get { return this.color; }
            set {
                if (!(value >= 0)) {
                    this.color = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the info of the vehicle.
        /// </summary>
        /// <returns>Returns the info as a string.</returns>
        public abstract string ShowInfo();

        #endregion
    }
}
