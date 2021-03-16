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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        /// <summary>
        /// Validates if the number 'valor' is between the range [min:max]
        /// </summary>
        /// <param name="valor">Value to validate.</param>
        /// <param name="min">minimun number of the range to validate</param>
        /// <param name="max">maximun number of the range to validate</param>
        /// <returns>true if the value is inside the range, otherwise returns false.</returns>
        static bool Validar(int valor, int min, int max)
        {
            bool isValid = false;
            if(valor<max && valor > min)
            {
                isValid = true;
            }

            return isValid;
        }

        /// <summary>
        /// Validates if the number given by the user is in the range and prints on console the minimun & maximun number, otherwise prints a message that the number is OOR.
        /// </summary>
        /// <param name="min">Minimun number of the range.</param>
        /// <param name="max">Maximun number of the range.</param>
        static void Validate10Numbers(int min, int max)
        {
            int minimun = int.MaxValue;
            int maximun = int.MinValue;

            int amountTries = 0;
            do
            {
                Console.Write("Tell me the {0}° number: ", amountTries + 1);
                int.TryParse(Console.ReadLine(), out int actualValue);

                if (Validar(actualValue, min, max))
                {
                    if(amountTries==0 || actualValue < minimun)
                    {
                        minimun = actualValue;
                    }

                    else if(amountTries == 0 || actualValue > maximun)
                    {
                        maximun = actualValue;
                    }
                }
                else
                {
                    Console.WriteLine("The number {0} is out of range! It should be more than {1} and less than {2}", actualValue, min, max);
                }
                amountTries++;
            } while (amountTries<10);

            Console.WriteLine("Minimun Number: {0}.\nMaximun Number: {1}.",minimun, maximun);
        }

        static void Main(string[] args)
        {
            int min = -100;
            int max = 100;
            Validate10Numbers(min, max);
            Console.ReadKey();
        }
    }
}
