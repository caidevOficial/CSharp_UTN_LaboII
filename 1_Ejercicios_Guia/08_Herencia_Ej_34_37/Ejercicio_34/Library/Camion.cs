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

namespace Library {
    public sealed class Camion : VehiculoTerrestre {
        private short cantidadMarchas;
        private int pesoCarga;

        #region Builder

        /// <summary>
        /// Builds the entity with all the parameters
        /// </summary>
        /// <param name="cantidadRuedas">Amount of wheels of the truck.</param>
        /// <param name="cantidadPuertas">Amount of doors of the truck.</param>
        /// <param name="color">Color of the truck.</param>
        /// <param name="cantidadMarchas">Number of gears of the truck.</param>
        /// <param name="pesoCarga">Amount of charge of the truck.</param>
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color) {
            this.CantidadMarchas = cantidadMarchas;
            this.CargaPeso = pesoCarga;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the amount of gears of the truck.
        /// Set: Sets the amount of gears of the truck.
        /// </summary>
        public short CantidadMarchas {
            get => cantidadMarchas;
            set {
                if (value > 0) {
                    cantidadMarchas = value;
                }
            }
        }

        /// <summary>
        /// Get: Gets the amount of passengers of the truck.
        /// Set: Sets the amount of passengers of the truck.
        /// </summary>
        public int CargaPeso {
            get => pesoCarga;
            set {
                if (value >= 0) {
                    pesoCarga = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the info of the truck.
        /// </summary>
        /// <returns>Returns the info as a string.</returns>
        public override string ShowInfo() {
            StringBuilder information = new StringBuilder();
            information.Append($"###### Camion ######\nMarchas: {this.CantidadMarchas}\n");
            information.Append($"Puertas: {this.CantidadPuertas}\n");
            information.Append($"Ruedas: {this.CantidadRuedas}\n");
            information.Append($"Color: {this.Color}\n");
            information.Append($"Carga: {this.CargaPeso}Kgs.\n");

            return information.ToString();
        }

        #endregion
    }
}
