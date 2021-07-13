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

namespace Models {
    public abstract class VehiculoCarrera {

        #region Attributes

        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected string escuderia;
        protected short numero;
        protected short vueltasRestantes;

        #endregion

        #region Properties

        /// <summary>
        /// Get: The amount of fuel.
        /// Set: The amount of fuel (positive number only).
        /// </summary>
        public short CantidadCombustible {
            get => cantidadCombustible;
            set {
                if (value >= 0 && value < 101) {
                    cantidadCombustible = value;

                }
            }
        }

        /// <summary>
        /// Get: The remaining laps.
        /// Set: The remaining laps (positive number only).
        /// </summary>
        public short VueltasRestantes {
            get => vueltasRestantes;
            set {
                if (value >= 0) {
                    vueltasRestantes = value;
                }
            }
        }

        /// <summary>
        /// Get: The competition state of the car.
        /// Set: The competition state of the car.
        /// </summary>
        public bool EnCompetencia {
            get => enCompetencia;
            set => enCompetencia = value;
        }

        /// <summary>
        /// Get: Gets the Team of the entity.
        /// Set: Sets the Team of the entity.
        /// </summary>
        public string Escuderia {
            get => escuderia;
            set {
                if (!(value is null)) {
                    escuderia = value;
                }
            }
        }

        /// <summary>
        /// Get: Gets the number of the entity.
        /// Set: Sets the number of the entity.
        /// </summary>
        public short Numero {
            get => numero;
            set {
                if (value >= 0) {
                    numero = value;
                }
            }
        }

        #endregion

        #region Builders

        /// <summary>
        /// Builds the Entity.
        /// </summary>
        /// <param name="escuderia">Team of the car.</param>
        /// <param name="numero">Number of the car.</param>
        protected VehiculoCarrera(short numero, string escuderia) {
            this.Escuderia = escuderia;
            this.Numero = numero;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
            this.EnCompetencia = false;
        }

        #endregion

        #region Methods

        public abstract string MostrarDatos();

        #endregion
    }
}
