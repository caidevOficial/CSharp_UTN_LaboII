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

namespace Suma
{
    public class Sumador
    {
        private int cantidadSumas;

        // Builders

        /// <summary>
        /// Initializates the entity with 0.
        /// </summary>
        public Sumador():this(0)
        {

        }

        /// <summary>
        /// Builds the entity with 'cantidadSumas'.
        /// </summary>
        /// <param name="cantidadSumas">Amount to set.</param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        // Operators

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        public static explicit operator int(Sumador s1)
        {
            int result = s1.cantidadSumas;
            return result;
        }

        /// <summary>
        /// Overloads the operator + for add the attribute of one objet to the another.
        /// </summary>
        /// <param name="s1">An object for sum</param>
        /// <param name="s2">Another object for sum</param>
        /// <returns></returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }

        /// <summary>
        /// Checks if the attribute of an objets has the same value of the same attribute of another object.
        /// </summary>
        /// <param name="s1">First object to compare.</param>
        /// <param name="s2">Second object to compare.</param>
        /// <returns></returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return ((int)s1).Equals((int)s2);
        }

        /// <summary>
        /// Adds two numbers and retirns the sum.
        /// </summary>
        /// <param name="a">a long type number.</param>
        /// <param name="b">another long type number.</param>
        /// <returns>returns the sum of both numbers.</returns>
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// Concatenate two strings.
        /// </summary>
        /// <param name="a">Fisrt string.</param>
        /// <param name="b">Second string.</param>
        /// <returns>Both string concatenateds.</returns>
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// Shows the attribute of the entity.
        /// </summary>
        /// <returns>The value of the attribute.</returns>
        public int Mostrar()
        {
             return this.cantidadSumas;
        }
    }
}
