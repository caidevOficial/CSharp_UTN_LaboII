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

using Interfaces;
using System;
using System.Text;

namespace Models {
    public class Lapiz : IAcciones {

        #region Attributes

        private float tamanioMina;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with its units.
        /// </summary>
        /// <param name="unidades">Writting units of the entity.</param>
        public Lapiz(int unidades) {
            this.UnidadesDeEscritura = unidades;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: The color of the pencil.
        /// </summary>
        public ConsoleColor Color {
            get => ConsoleColor.Gray;
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Gets/Sets: The size of the mine of the pen.
        /// </summary>
        public float UnidadesDeEscritura {
            get => this.tamanioMina;
            set {
                if (value > 0) {
                    this.tamanioMina = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Reduces the mine size by 0.1 for each character wrote.
        /// </summary>
        /// <param name="texto">Text to write.</param>
        /// <returns>A new EscrituraWrapper instance.</returns>
        public EscrituraWrapper Escribir(string texto) {
            this.UnidadesDeEscritura -= (texto.Length * 0.1f);
            return new EscrituraWrapper(texto, this.Color);
        }

        /// <summary>
        /// It will throw a NotImplementedException
        /// </summary>
        /// <param name="unidades">Nothing</param>
        /// <returns>NotImplementedException</returns>
        public bool Recargar(int unidades) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// It will returns a text with the info of the entity
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Object: {this.GetType().Name}");
            data.AppendLine($"Color: {this.Color}");
            data.AppendLine($"Mine's size: {this.UnidadesDeEscritura}");

            return data.ToString();
        }

        #endregion

    }
}
