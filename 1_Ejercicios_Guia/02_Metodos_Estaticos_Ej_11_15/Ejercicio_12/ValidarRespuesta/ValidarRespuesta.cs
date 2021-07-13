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

namespace Ejercicio_12 {
    public class ValidarRespuesta {

        /// <summary>
        /// Validates if the input is a 'S' or another value.
        /// </summary>
        /// <param name="c">Char to evaluate.</param>
        /// <returns>True if the input is a 'S', otherwise false.</returns>
        public static bool ValidaS_N(char c) {
            c = Char.ToUpper(c);
            if (c.Equals('S')) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Add numbers until the user refuses to continue adding numbers, 
        /// then returns the entire sum.
        /// </summary>
        /// <returns>The final sum of numbers.</returns>
        public static int SumIntegerNumbers() {
            int sum = 0;
            char answer = 'S';

            do {
                Console.Write("Tell me a number to sum in the stack: ");
                int.TryParse(Console.ReadLine(), out int actualNumber);
                sum += actualNumber;

                Console.Write("Wanna continue adding numbers? S/N: ");
                Char.TryParse(Console.ReadLine(), out answer);
                answer = Char.ToUpper(answer);

            } while (ValidaS_N(answer));

            return sum;
        }
    }
}
