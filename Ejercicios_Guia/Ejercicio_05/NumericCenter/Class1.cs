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

namespace NumericCenter {
    public class NumericCenter {
        /// <summary>
        /// Searchs for numeric centers till' the number that the user enters.
        /// </summary>
        public static void CheckNumericCenter() {
            Console.Title = "Ejercicio Nro 05";

            int numberTillCheck;
            int sumOfAbove;
            int sumOfFollowing;
            int sumTotal;
            bool flag = false;

            Console.Write("Escriba un numero: ");
            int.TryParse(Console.ReadLine(), out numberTillCheck);

            Console.WriteLine("Buscando centros numéricos:\n");

            for (int i = 2; i < numberTillCheck; i++) {
                sumOfFollowing = i + 1;
                sumOfAbove = 0;
                sumTotal = 0;

                for (int y = i - 1; y > 0; y--) {
                    sumOfAbove += y;
                }

                while (sumTotal <= sumOfAbove) {

                    sumTotal += sumOfFollowing;
                    if (sumTotal == sumOfAbove) {
                        Console.WriteLine($"Centro encontrado: {i}");
                        flag = true;

                    }
                    sumOfFollowing += 1;

                }
            }
            if (!flag) {
                Console.WriteLine("Sin centros numéricos");
            }
            Console.WriteLine("\nProgram Terminated!");
            Console.ReadKey(true);
        }
    }
}
