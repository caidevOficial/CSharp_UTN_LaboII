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

using System.Collections.Generic;

namespace Models {
    public class Cartuchera2 {

        #region Attributes

        private List<Lapiz> lapices;
        private List<Boligrafo> lapiceras;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with both list.
        /// </summary>
        public Cartuchera2() {
            lapiceras = new List<Boligrafo>();
            lapices = new List<Lapiz>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: The list of pencils.
        /// </summary>
        public List<Lapiz> Lapices {
            get => this.lapices;
        }

        /// <summary>
        /// Gets: The list of pens.
        /// </summary>
        public List<Boligrafo> Lapiceras {
            get => this.lapiceras;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Adds a pen into the list of pens.
        /// </summary>
        /// <param name="cartuchera">Instance of Cartuchera2</param>
        /// <param name="lapicera">Instance of Pen</param>
        /// <returns></returns>
        public static Cartuchera2 operator +(Cartuchera2 cartuchera, Boligrafo lapicera) {
            cartuchera.lapiceras.Add(lapicera);
            return cartuchera;
        }

        /// <summary>
        /// Adds a pencil into the list of pencils.
        /// </summary>
        /// <param name="cartuchera">Instance of Cartuchera2</param>
        /// <param name="lapiz">Instance of Pencil</param>
        /// <returns></returns>
        public static Cartuchera2 operator +(Cartuchera2 cartuchera, Lapiz lapiz) {
            cartuchera.lapices.Add(lapiz);
            return cartuchera;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Tries each item in the lists
        /// </summary>
        /// <returns>True if all the items can spent 1 unit fo ink or mine</returns>
        public bool ProbarElementos() {
            bool canPencil = false;
            bool canPen = false;

            foreach (Lapiz item in this.lapices) {
                if (item.UnidadesDeEscritura < 0) {
                    canPencil = false;
                } else {
                    item.Escribir("F");
                }
            }

            foreach (Boligrafo item in this.lapiceras) {
                if (item.UnidadesDeEscritura < 0) {
                    canPen = false;
                } else {
                    item.Escribir("F");
                    canPen = item.Recargar(1);
                }
            }

            return canPen && canPencil;
        }

        #endregion
    }
}
