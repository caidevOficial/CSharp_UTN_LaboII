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

namespace PerfectNumber
{
    public class PerfectNumber
    {
        /// <summary>
        /// Searches the first 4 perfect numbers and shows them in the console.
        /// </summary>
        public static void SearchPerfectNumber()
        {
            int divisor;
            int sumOfDivisors;
            int amountPerfects = 0;
            Console.Title = "Ejercicio 4";

            // I check that i have 4 PerfNumbers.
            for (int numero = 1; amountPerfects < 4; numero++)
            {
                sumOfDivisors = 0;

                // go througth the divisors of the number.
                for (divisor = 1; divisor <= (numero / 2); divisor++)
                {
                    // if is a divisor of the number, i'll add it.
                    if ((numero % divisor) == 0)
                    {
                        sumOfDivisors += divisor;
                    }
                }

                //if the sum is equal to the iterated number, IT'S PERFECT PERRI!.
                if (sumOfDivisors == numero)
                {
                    Console.WriteLine("El numero " + numero + " es perfecto");
                    amountPerfects++; //Update the perfect's amount.
                }
            }
            Console.ReadKey();
        }
    }
}
