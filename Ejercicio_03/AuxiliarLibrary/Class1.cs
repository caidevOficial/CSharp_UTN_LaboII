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

namespace AuxiliarLibrary
{
    public class AuxiliarLibrary
    {
        /// <summary>
        /// Displays prime numbers up to the number that the user has specified.
        /// </summary>
        public static void Ejercicio3()
        {
            int num = 2, divisor, primeTo;
            bool isPrimeNumber;

            Console.Title = "Ejercicio 3";
            Console.Write("Mostrar primos hasta el: ");
            primeTo = int.Parse(Console.ReadLine());

            if (primeTo > 1)
            {

                for (num = 2; num <= primeTo; num++)
                {
                    isPrimeNumber = true;
                    for (divisor = 2; divisor < num; divisor++)
                    {

                        if ((num % divisor) == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }
                    if (isPrimeNumber)
                    {
                        Console.WriteLine($"{num}: es numero primo.");
                    }
                }
            }
            Console.ReadLine(); // para frenar la consola
        }
    }
}
