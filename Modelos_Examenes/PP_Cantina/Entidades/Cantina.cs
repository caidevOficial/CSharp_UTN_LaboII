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

namespace Entidades
{
    public sealed class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        #region Properties

        /// <summary>
        /// Get: Gets the list of bottles.
        /// </summary>
        public List<Botella> Botellas
        {
            get => this.botellas;
        }

        #endregion

        #region Builder

        private Cantina(int espacios)
        {
            botellas = new List<Botella>();
            espaciosTotales = espacios;
        }

        #endregion

        #region Methods

        public static Cantina GetCantina(int espacios)
        {
            if (Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
            }

            return Cantina.singleton;
        }

        #endregion

        #region Operator

        /// <summary>
        /// Tries to add a bottle in the list if have an empty space inside.
        /// </summary>
        /// <param name="c">Cantina to add bottles.</param>
        /// <param name="b">Bottle to add in the Cantina.</param>
        /// <returns>True if can add, otherwise returns false.</returns>
        public static bool operator +(Cantina c, Botella b)
        {
            if (!(c is null) && !(b is null))
            {
                if (c.botellas.Count < c.espaciosTotales)
                {
                    c.botellas.Add(b);
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
