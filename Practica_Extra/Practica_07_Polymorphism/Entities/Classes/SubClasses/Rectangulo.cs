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

namespace Entities.Classes
{
    public class Rectangulo : Figura
    {
        protected double figureBase;
        protected double figureHeigth;

        #region Builders

        /// <summary>
        /// Builds the entity without parameters.
        /// </summary>
        public Rectangulo() : base() { }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="figureBase">Base of the entity.</param>
        /// <param name="figureHeight">Heigth of the entity.</param>
        public Rectangulo(double figureBase, double figureHeigth) : base()
        {
            this.Base = figureBase;
            this.Heigth = figureHeigth;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the Heigth of the entity.
        /// Set: Sets the Heigth of the entity.
        /// </summary>
        public double Heigth
        {
            get { return this.figureHeigth; }
            set
            {
                if (value > 0)
                {
                    this.figureHeigth = value;
                }
            }
        }

        /// <summary>
        /// Get: Gets the Base of the entity.
        /// Set: Sets the Base of the entity.
        /// </summary>
        public double Base
        {
            get { return this.figureBase; }
            set
            {
                if (value > 0)
                {
                    this.figureBase = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the perimeter of the entity.
        /// </summary>
        /// <returns>The perimeter of the entity as a double</returns>
        public override double CalcularPerimetro()
        {
            return this.Base * 2 + this.Heigth * 2;
        }

        /// <summary>
        /// Calculates the area of the entity.
        /// </summary>
        /// <returns>The area as a double.</returns>
        public override double CalcularSuperficie()
        {
            return this.Base * this.Heigth;
        }

        /// <summary>
        /// Writes a message about draw the entity.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }

        #endregion
    }
}
