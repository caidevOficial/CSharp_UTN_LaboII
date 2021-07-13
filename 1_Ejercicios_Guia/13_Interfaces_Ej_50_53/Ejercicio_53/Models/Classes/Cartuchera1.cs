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
using System.Collections.Generic;

namespace Models {
    public class Cartuchera1 {

        #region Attributes

        private List<IAcciones> acciones;

        #endregion

        #region Builders

        public Cartuchera1() {
            acciones = new List<IAcciones>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: The list of the 'Cartuchera1'. 
        /// </summary>
        public List<IAcciones> UtilesCartuchera {
            get => this.acciones;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Adds an objet to the list.
        /// </summary>
        /// <param name="cartu1">Instance of Cartuchera1</param>
        /// <param name="obj">Objecto to add in the list.</param>
        /// <returns>The instance</returns>
        public static Cartuchera1 operator +(Cartuchera1 cartu1, object obj) {
            if (obj is Lapiz || obj is Boligrafo)
                cartu1.acciones.Add((IAcciones)obj);

            return cartu1;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Tries the item
        /// </summary>
        /// <returns>True if all the items can spent 1 unit fo ink or mine</returns>
        public bool ProbarElementos() {
            foreach (IAcciones item in this.acciones) {
                if (item.UnidadesDeEscritura < 0) {
                    return false;
                } else {
                    item.Escribir("F");
                    Console.WriteLine(item);
                    return item.Recargar(1);
                }
            }

            return false;
        }

        #endregion
    }
}
