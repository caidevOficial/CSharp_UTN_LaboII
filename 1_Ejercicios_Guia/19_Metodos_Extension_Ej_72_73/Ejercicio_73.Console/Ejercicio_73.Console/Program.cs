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
using Ejercicio_73.Models;

namespace Ejercicio_73 {
    class Program {

        static void Main(string[] args) {
            Console.Title = "Ejercicio 72";
            string myString = string.Empty;
            string digits = "punctuations signs";
            int amountPunctuationsSigns;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Write a string: ");
            myString = Console.ReadLine();
            amountPunctuationsSigns = myString.CantidadSignosPuntuacion();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("________________________");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"The string: '{myString}' has {amountPunctuationsSigns} {digits}.");

            Console.ReadKey();
        }
    }
}
