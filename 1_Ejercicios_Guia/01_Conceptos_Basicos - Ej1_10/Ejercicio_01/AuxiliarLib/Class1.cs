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

namespace AuxiliarLib {
    public class AuxiliarLib {
        /// <summary>
        /// Shows the minimun, maximun and average values in console.
        /// </summary>
        /// <param name="minimun">Minimun value to show.</param>
        /// <param name="maximun">Maximun value to show.</param>
        /// <param name="average">Average value to show.</param>
        private static void ShowMessage(int minimun, int maximun, float average) {
            Console.WriteLine($"El promedio es: {average}.\n" +
                $"El Maximo es: {maximun}.\n" +
                $"El Minimo es: {minimun}.\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Calculates and shows the minimun value, maximun value and average of 5 numbers.
        /// </summary>
        public static void Exercise_01() {
            sbyte index;
            byte sumNumbers = 0;
            byte number;
            byte maximunNumber = byte.MinValue;
            byte minimunNumber = byte.MaxValue;
            float average = float.MinValue;

            Console.Title = "Ejercicio 1";
            for (index = 0; index < 5; index++) {
                Console.Write("Ingrese el " + (index + 1) + "° numero: ");
                byte.TryParse(Console.ReadLine(), out number);

                while (!byte.TryParse(Console.ReadLine(), out number)) {
                    Console.Write("Ingrese el " + (index + 1) + "° numero: ");
                    byte.TryParse(Console.ReadLine(), out number);
                }

                if (number < minimunNumber) {
                    minimunNumber = number;
                } else if (number > maximunNumber) {
                    maximunNumber = number;
                }
                sumNumbers += number;
            }

            average = sumNumbers / index;
            ShowMessage(minimunNumber, maximunNumber, average);
        }
    }
}
