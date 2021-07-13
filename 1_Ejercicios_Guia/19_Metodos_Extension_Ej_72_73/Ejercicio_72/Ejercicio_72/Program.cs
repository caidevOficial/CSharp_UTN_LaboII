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
using Ejercicio_72.Models;

namespace Ejercicio_72 {
    class Program {
        static void Main(string[] args) {
            long number;
            int amountNumbers;
            string digits = "digitos";
            Console.Title = "Ejercicio 72";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Write a number: ");
            long.TryParse(Console.ReadLine(), out number);
            amountNumbers = number.CantidadDeDigitos();

            if (amountNumbers == 1) {
                digits = "digito";
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("________________________");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"El numero {number} tiene {number.CantidadDeDigitos()} {digits}");
            Console.ReadKey();
        }
    }
}
