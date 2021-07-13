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

using Models;
using System;

namespace Ejercicio_52 {
    class Program {
        static void Main(string[] args) {

            Cartuchera1 cartuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();

            Boligrafo lapicera1 = new Boligrafo(10, ConsoleColor.Blue);
            Boligrafo lapicera2 = new Boligrafo(15, ConsoleColor.Green);
            Boligrafo lapicera3 = new Boligrafo(20, ConsoleColor.Red);

            Lapiz lapiz1 = new Lapiz(10);
            Lapiz lapiz2 = new Lapiz(15);
            Lapiz lapiz3 = new Lapiz(20);
            bool canTryc1 = true;
            bool canTryc2 = true;

            cartuchera1 += lapicera1;
            cartuchera1 += lapicera2;
            cartuchera1 += lapicera3;
            cartuchera1 += lapiz1;
            cartuchera1 += lapiz2;
            cartuchera1 += lapiz3;

            while (canTryc1) {
                canTryc1 = cartuchera1.ProbarElementos();
            }

            cartuchera2 += lapicera1;
            cartuchera2 += lapicera2;
            cartuchera2 += lapicera3;
            cartuchera2 += lapiz1;
            cartuchera2 += lapiz2;
            cartuchera2 += lapiz3;

            while (canTryc2) {
                canTryc1 = cartuchera2.ProbarElementos();
            }

            Console.ReadKey();
        }
    }
}
