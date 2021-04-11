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

using C = Conversor;
using System;

namespace Number
{
    public class NumeroBinario
    {
        private string number;

        #region Builders

        /// <summary>
        /// Builds the entity with one param.
        /// </summary>
        /// <param name="number">String to add</param>
        private NumeroBinario(string number)
        {
            this.number = number;
        }

        #endregion

        #region Getters

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetBinaryNumber()
        {
            return this.number;
        }

        #endregion

        #region Operators_Cast

        /// <summary>
        /// Explicitly casts an object of type string to an object of type NumeroBinario.
        /// </summary>
        /// <param name="number">string to cast</param>
        public static implicit operator NumeroBinario(string number)
        {
            return new NumeroBinario(number);
        }

        /// <summary>
        /// Explicitly casts an object of type NumeroDecimal to an object of type NumeroBinario.
        /// </summary>
        /// <param name="n">NumeroDecimal object to cast to NumeroBinario</param>
        public static explicit operator NumeroBinario(NumeroDecimal n)
        {
            NumeroBinario binary = new NumeroBinario(C.Conversor.IntegerToBinary((int)n.GetDecimalNumber()));
            return binary;
        }

        #endregion

        #region Operators_Compare

        /// <summary>
        /// Compares if the amount of NumeroBinario and NumeroDecimal are equals.
        /// </summary>
        /// <param name="b">NumeroBinario to compare.</param>
        /// <param name="n">NumeroDecimal to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return b.GetBinaryNumber() == ((NumeroBinario)d).GetBinaryNumber();
        }

        /// <summary>
        /// Compares if the amount of NumeroBinario and NumeroDecimal are differents.
        /// </summary>
        /// <param name="b">NumeroBinario to compare.</param>
        /// <param name="n">NumeroDecimal to compare.</param>
        /// <returns>True if are differents, otherwise returns False</returns>
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        #endregion

        #region Operators+-

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static NumeroBinario operator +(NumeroBinario b, NumeroDecimal d)
        {
            double number = C.Conversor.BinaryToDecimal(b.GetBinaryNumber());
            double result = d.GetDecimalNumber() + number;
            return new NumeroBinario(C.Conversor.IntegerToBinary((int)result));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static NumeroBinario operator -(NumeroBinario b, NumeroDecimal d)
        {
            double number = C.Conversor.BinaryToDecimal(b.GetBinaryNumber());
            double result = number - d.GetDecimalNumber();
            return new NumeroBinario(C.Conversor.IntegerToBinary((int)result));
        }

        #endregion
    }
}
