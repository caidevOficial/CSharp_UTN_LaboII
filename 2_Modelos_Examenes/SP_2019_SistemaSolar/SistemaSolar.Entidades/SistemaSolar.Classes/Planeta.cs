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

using SistemaSolar.Events;

namespace SistemaSolar.Entidades {

    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);

    public class Planeta {


        #region Attributes

        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;
        public event InformacionDeAvance InformarAvance;

        #endregion

        #region Builders

        public Planeta() {

        }

        /// <summary>
        /// Builder with all the parameters.
        /// </summary>
        /// <param name="velocidad">Speed of the planet.</param>
        /// <param name="posicion">Position of the planet.</param>
        /// <param name="radioRespectoSol">Radius respect the sun of the planet.</param>
        /// <param name="objetoVisual">Something of the planet.</param>
        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual) : this() {
            this.VelocidadTraslacion = velocidad;
            this.posicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.radioRespectoSol = radioRespectoSol;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: the actual position of the planet.
        /// </summary>
        public short PosicionActual {
            get => this.posicionActual;
            set => this.posicionActual = value;
        }

        /// <summary>
        /// Gets/Sets: the radius respect the sun.
        /// </summary>
        public short RadioRespectoSol {
            get => this.radioRespectoSol;
            set {
                if (value.GetType() == typeof(short)) {
                    this.radioRespectoSol = value;
                }
            }
        }

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado {
            get => this.objetoAsociado;
            set {
                this.objetoAsociado = value;
            }
        }

        /// <summary>
        /// Gets/Sets: the Traslation speed of the planet.
        /// </summary>
        public short VelocidadTraslacion {
            get => velocidadTraslacion;
            set {
                if (value.GetType() == typeof(short)) {
                    velocidadTraslacion = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar() {
            this.posicionActual += VelocidadTraslacion;
            return this.posicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar() {
            do {
                System.Threading.Thread.Sleep(60 + this.VelocidadTraslacion);
                // Dispara evento y manejador asociado a este planeta.
                InformarAvance.Invoke(this, new PlanetaEventArgs(this.Avanzar(), this.RadioRespectoSol));
            } while (true);
        }

        #endregion
    }
}
