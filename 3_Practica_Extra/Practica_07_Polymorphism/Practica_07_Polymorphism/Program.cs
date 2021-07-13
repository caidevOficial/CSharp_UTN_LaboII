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

using Entities.Classes;
using System;
using System.Collections.Generic;

namespace Practica_07_Polymorphism {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Practica 07 - Polimorfismo";

            #region Instances

            List<Figura> listFigures = new List<Figura>();
            Circulo circle = new Circulo(15);
            Cuadrado square = new Cuadrado(6);
            Rectangulo rectangle = new Rectangulo(6, 4);

            #endregion

            #region AddInList

            listFigures.Add(circle);
            listFigures.Add(square);
            listFigures.Add(rectangle);

            #endregion

            foreach (Figura figure in listFigures) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"   ========= Figura {listFigures.IndexOf(figure) + 1} ==========");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"    {figure.GetType()}");
                Console.WriteLine($"    {figure.Dibujar()} ");
                Console.WriteLine($"    Área: {Math.Round(figure.CalcularSuperficie(), 2)}");
                Console.WriteLine($"    Perímetro: {Math.Round(figure.CalcularPerimetro(), 2)}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   =============================");
            }

            Console.ReadKey();
        }
    }
}
