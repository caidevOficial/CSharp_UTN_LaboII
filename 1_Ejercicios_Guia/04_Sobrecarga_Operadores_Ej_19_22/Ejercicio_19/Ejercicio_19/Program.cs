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
using Suma;

namespace Ejercicio_19 {
    class Program {
        static void Main(string[] args) {
            Sumador s1 = new Sumador(10);
            Sumador s2 = new Sumador(12);
            Console.WriteLine(s1.Mostrar());

            long longSum = s1.Sumar(10, 15);
            string stringSum = s1.Sumar("10", "15");
            Console.WriteLine($"Long: {longSum} - String: {stringSum}.");
            Console.WriteLine(s1.Mostrar());

            int amount = (int)s2;
            Console.WriteLine($"Explicit cast: {amount}.");

            long overloadSum = s1 + s2;
            bool overloadEquals = s1 | s2;
            Console.WriteLine($"OverSum: {overloadSum} - OverEquals: {overloadEquals}.");
            Console.ReadKey();
        }
    }
}
