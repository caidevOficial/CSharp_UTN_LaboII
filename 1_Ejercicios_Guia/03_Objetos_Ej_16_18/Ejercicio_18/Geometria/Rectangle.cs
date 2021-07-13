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

namespace Geometria
{
    public class Rectangle
    {
        #region Attributes

        private float area;
        private float perimetro;
        private Point vertice1;
        private Point vertice2;
        private Point vertice3;
        private Point vertice4;

        #endregion

        #region Builder

        /// <summary>
        /// Builds the entity with all its parameters
        /// </summary>
        /// <param name="vertice1">First vertice of the entity</param>
        /// <param name="vertice3">Second vertice of the entity</param>
        public Rectangle(Point vertice1, Point vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = Point.AssignVertice(this.vertice1, this.vertice3);
            this.vertice4 = Point.AssignVertice(this.vertice3, this.vertice1);
            this.area = Math.Abs(vertice1.GetX() - vertice3.GetX()) * Math.Abs(vertice1.GetY() - vertice3.GetY());
            this.perimetro = (Math.Abs(vertice1.GetX() - vertice3.GetX()) + Math.Abs(vertice1.GetY() - vertice3.GetY())) * 2;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the area of the entity
        /// </summary>
        /// <returns>The area of the entity</returns>
        public float GetArea()
        {
            return this.area;
        }

        /// <summary>
        /// Gets the perimeter of the entity
        /// </summary>
        /// <returns>The perimeter of the entity</returns>
        public float GetPerimeter() {
            return this.perimetro;
        }

        #endregion

        #region Methods

        public void ShowData() {
            Console.WriteLine($"First Vertice   x:{this.vertice1.GetX()}  y:{this.vertice1.GetY()}");
            Console.WriteLine($"Second Vertice  x:{this.vertice2.GetX()}  y:{this.vertice2.GetY()}");
            Console.WriteLine($"Third Vertice   x:{this.vertice3.GetX()}  y:{this.vertice3.GetY()}");
            Console.WriteLine($"Fourth Vertice  x:{this.vertice4.GetX()}  y:{this.vertice4.GetY()}");
            Console.WriteLine($"Area: {this.area}, Perimetro: {this.perimetro}");
        }

        #endregion

    }
}
