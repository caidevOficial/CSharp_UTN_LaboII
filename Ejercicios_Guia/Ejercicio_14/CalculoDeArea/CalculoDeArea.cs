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

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        /// <summary>
        /// Calculates the area of a square.
        /// </summary>
        /// <param name="side">The side of the square.</param>
        /// <returns>The area of the square.</returns>
        public static double CalcularCuadrado(double side)
        {
            double area = 0;
            area = Math.Pow(side, 2);
            return area;
        }

        /// <summary>
        /// Calculates the area of a rectangle.
        /// </summary>
        /// <param name="baseT">The base of the rectangle.</param>
        /// <param name="heightT">The height of the rectangle.</param>
        /// <returns>The area of the rectangle</returns>
        public static double CalcularTriangulo(double baseT, double heightT)
        {
            double area = 0;
            area = baseT * heightT;
            return area;
        }

        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <param name="radio">Radio of the circle</param>
        /// <returns>The area of the circle.</returns>
        public static double CalcularCirculo(double radio)
        {
            double area = 0;
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}