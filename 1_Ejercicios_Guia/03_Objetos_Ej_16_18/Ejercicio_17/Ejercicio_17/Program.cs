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
using B = Boligrafo;

namespace Ejercicio_17 {
    class Program {
        static void Main(string[] args) {
            B.Boligrafo sharpie = new B.Boligrafo(100, ConsoleColor.Blue);
            B.Boligrafo bic = new B.Boligrafo(50, ConsoleColor.Red);

            Console.Title = "Ejercicio Nro 17";

            string drawPen1;
            string drawPen2;

            // Shows Color and Ink's level.
            Console.WriteLine(sharpie.GetColor());
            Console.WriteLine(bic.GetColor());
            Console.WriteLine(sharpie.GetTinta());
            Console.WriteLine(bic.GetTinta());

            Console.WriteLine("----------------------");

            /*Draws*/
            sharpie.Pintar(-20, out drawPen1);
            Console.WriteLine(sharpie.GetTinta());// "80
            /*Show Line*/
            sharpie.ShowDraw(drawPen1);// #20

            Console.WriteLine("-----------------------");

            bic.Pintar(-60, out drawPen2);
            Console.WriteLine(bic.GetTinta()); // #0
            bic.ShowDraw(drawPen2); // #50

            Console.WriteLine("-----------------------");

            bic.Pintar(-60, out drawPen2); // It can't
            Console.WriteLine(bic.GetTinta());
            bic.ShowDraw(drawPen2);

            Console.WriteLine("-----------------------");
            bic.Recargar();
            Console.WriteLine(bic.GetTinta());


            Console.ReadKey(true);
        }
    }
}
