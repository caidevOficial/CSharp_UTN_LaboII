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

namespace LeapYear {
    public class LeapYear {

        /// <summary>
        /// Prints to the console all leap years between the beginning year and the ending year that the user enters.
        /// </summary>
        public static void CheckLeapYear() {

            int begginingYear;
            int endYear;
            Console.Title = "Ejercicio 6";

            Console.WriteLine("Ingrese año de inicio: ");
            int.TryParse(Console.ReadLine(), out begginingYear);
            Console.WriteLine("Ingrese año de fin: ");
            int.TryParse(Console.ReadLine(), out endYear);

            for (int init = begginingYear; init <= endYear; init++) {
                if ((init % 4) == 0) {
                    if ((init % 100) != 0 || (init % 400) == 0) {
                        Console.WriteLine($"Es bisiesto el año {init}.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
