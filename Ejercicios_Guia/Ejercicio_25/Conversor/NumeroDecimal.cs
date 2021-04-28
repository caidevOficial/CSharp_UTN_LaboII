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

using C = ConversorApp;

namespace Number {
    public class NumeroDecimal {
        private double numero;

        #region Builders

        /// <summary>
        /// Builds the entity with one param.
        /// </summary>
        /// <param name="number">Number for the entity.</param>
        private NumeroDecimal(double number) {
            this.numero = number;
        }

        #endregion

        #region Getters

        /// <summary>
        /// Gets the number of the entity.
        /// </summary>
        /// <returns>The number of the entity.</returns>
        public double GetDecimalNumber() {
            return this.numero;
        }

        #endregion

        #region Operators_Cast

        /// <summary>
        /// Explicitly casts an object of type double to an object of type NumeroDecimal.
        /// </summary>
        /// <param name="number">double to cast to NumeroDecimal</param>
        public static implicit operator NumeroDecimal(double number) {
            return new NumeroDecimal(number);
        }

        /// <summary>
        /// Explicitly casts an object of type NumeroBinario to an object of type NumeroDecimal.
        /// </summary>
        /// <param name="binary">NumeroBinario object to cast to NumeroDecimal</param>
        public static explicit operator NumeroDecimal(NumeroBinario binary) {
            NumeroDecimal decimalNumber = new NumeroDecimal(C.Conversor.BinaryToDecimal(binary.GetBinaryNumber()));
            return decimalNumber;
        }

        #endregion

        #region Operators_Compare

        /// <summary>
        /// Compares if the amount of NumeroDecimal and NumeroBinario are equals.
        /// </summary>
        /// <param name="n">NumeroDecimal to compare.</param>
        /// <param name="b">NumeroBinario to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(NumeroDecimal n, NumeroBinario b) {
            return n.GetDecimalNumber() == ((NumeroDecimal)b).GetDecimalNumber();
        }

        /// <summary>
        /// Compares if the amount of NumeroDecimal and NumeroBinario are differents.
        /// </summary>
        /// <param name="n">NumeroDecimal to compare.</param>
        /// <param name="b">NumeroBinario to compare.</param>
        /// <returns>True if are differents, otherwise returns False</returns>
        public static bool operator !=(NumeroDecimal n, NumeroBinario b) {
            return !(n == b);
        }

        #endregion

        #region Operators+-

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static NumeroDecimal operator +(NumeroDecimal n, NumeroBinario b) {
            return new NumeroDecimal(n.GetDecimalNumber() + ((NumeroDecimal)b).GetDecimalNumber());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static NumeroDecimal operator -(NumeroDecimal n, NumeroBinario b) {
            return new NumeroDecimal(n.GetDecimalNumber() - ((NumeroDecimal)b).GetDecimalNumber());
        }

        #endregion
    }
}