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

namespace Ejercicio_13 {
    public class Conversor {

        /// <summary>
        /// Converts a integer number into a binary string.
        /// </summary>
        /// <param name="integerNumber">The number to convert.</param>
        /// <returns>The binary string.</returns>
        public static string IntegerToBinary(int integerNumber) {
            string reverseBinaryNumber = "";
            string binaryNumber = "";
            char[] listReverseBinaryNumber;

            do {
                reverseBinaryNumber += integerNumber % 2;
                integerNumber /= 2;

            } while (integerNumber > 0);

            listReverseBinaryNumber = reverseBinaryNumber.ToCharArray();
            Array.Reverse(listReverseBinaryNumber);
            binaryNumber = new string(listReverseBinaryNumber);

            return binaryNumber;
        }

        /// <summary>
        /// Converts a binary string into a integer number.
        /// </summary>
        /// <param name="binary">The binary string to convert</param>
        /// <returns>The integer number of the binary string.</returns>
        public static int BinaryToDecimal(string binary) {

            const int DIV = 10;
            int number = 0;
            int digitNumber = 0;
            long binario = 0;

            long.TryParse(binary, out binario);

            for (long i = binario, j = 0; i > 0; i /= DIV, j++) {
                digitNumber = (int)i % DIV;
                if (digitNumber != 1 && digitNumber != 0) {
                    return -1;
                }
                number += digitNumber * (int)Math.Pow(2, j);
            }

            return number;
        }
    }
}