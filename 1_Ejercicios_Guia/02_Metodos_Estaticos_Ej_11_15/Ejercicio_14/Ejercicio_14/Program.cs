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

namespace Ejercicio_14 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Side of the Square: ");
            Double.TryParse(Console.ReadLine(), out double side);
            double areaSquare = CalculoDeArea.CalcularCuadrado(side);

            Console.Write("Base of the Triangle: ");
            Double.TryParse(Console.ReadLine(), out double baseT);
            Console.Write("Height of the Triangle: ");
            Double.TryParse(Console.ReadLine(), out double heightT);
            double areaT = CalculoDeArea.CalcularTriangulo(baseT, heightT);

            Console.Write("Radio of the Circle: ");
            Double.TryParse(Console.ReadLine(), out double radio);
            double areaC = CalculoDeArea.CalcularCirculo(radio);

            // Messages
            Console.WriteLine($"The area of the Square is: {areaSquare}");
            Console.WriteLine($"The area of the Triangle is: {areaT}");
            Console.WriteLine($"The area of the Circle is: {areaC}");
            Console.ReadKey();
        }
    }
}