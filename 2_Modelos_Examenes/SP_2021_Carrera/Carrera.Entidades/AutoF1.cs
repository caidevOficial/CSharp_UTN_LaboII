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

namespace Entidades {
    public class AutoF1 {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;

        /// <summary>
        /// Default builder for serialize.
        /// </summary>
        public AutoF1() {

        }

        /// <summary>
        /// Builder with Team, Speed and startPoint of the car.
        /// </summary>
        /// <param name="escuderia">Team of the car.</param>
        /// <param name="velocidad">Speed of the car.</param>
        /// <param name="puntoPartida">startPoint of the car.</param>
        public AutoF1(string escuderia, int velocidad, int puntoPartida) : this() {
            this.Escuderia = escuderia;
            this.Velocidad = velocidad;
            this.UbicacionEnPista = puntoPartida;
        }

        /// <summary>
        /// Gets/Sets: the team of the car.
        /// </summary>
        public string Escuderia {
            get => this.escuderia;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.escuderia = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the position of the car.
        /// </summary>
        public int Posicion {
            get => this.posicion;
            set {
                if (value.GetType() == typeof(int)) {
                    this.posicion = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the ubication in the track of the car.
        /// </summary>
        public int UbicacionEnPista {
            get => this.puntoPartida;
            set {
                if (value.GetType() == typeof(int)) {
                    this.puntoPartida = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the speed of the car.
        /// </summary>
        public int Velocidad {
            get => this.velocidad;
            set {
                if (value.GetType() == typeof(int)) {
                    this.velocidad = value;
                }
            }
        }

        /// <summary>
        /// Sums the speed*7 to the start point.
        /// </summary>
        public void Acelerar() {
            this.puntoPartida += (this.Velocidad * 7);
        }

        /// <summary>
        /// Gets the team and position of the car as a string.
        /// </summary>
        /// <returns>The team and position of the car as a string.</returns>
        public override string ToString() {
            return $"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}";
        }

    }
}
