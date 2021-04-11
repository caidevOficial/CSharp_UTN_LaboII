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

namespace Ejercicio_15
{
    public class Calculadora
    {
        /// <summary>
        /// Calculates a basic math's operation between two numbers.
        /// </summary>
        /// <param name="firstNumber">First number, MUST be integer.</param>
        /// <param name="secondNumber">Second number, MUST be integer.</param>
        /// <param name="sign">Sign to do the operation in the calculator.</param>
        /// <returns></returns>
        public static double Calcular(int firstNumber, int secondNumber, char sign)
        {
            double result = 0;
            switch (sign)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (Validar(secondNumber))
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;
            }
            return result;
        }

        /// <summary>
        /// Validates if the number is different to 0.
        /// </summary>
        /// <param name="number">Number to validate, MUST be integer.</param>
        /// <returns>True if is different to 0, otherwise returns false.</returns>
        private static bool Validar(int number)
        {
            return number != 0;
        }
    }
}
