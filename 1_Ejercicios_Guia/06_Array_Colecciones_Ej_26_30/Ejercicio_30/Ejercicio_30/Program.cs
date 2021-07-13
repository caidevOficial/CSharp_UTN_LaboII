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

using Entities;
using System;

namespace Ejercicio_30 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio 30";
            Console.ForegroundColor = ConsoleColor.Green;

            #region Instances

            Competencia granTurismo = new Competencia(2, 10);
            AutoF1 car1 = new AutoF1("McLaren", 10);
            AutoF1 car2 = new AutoF1("McLaren", 10);
            AutoF1 car3 = new AutoF1("Ferrari", 1);
            AutoF1 car4 = new AutoF1("Aston Martin", 7);
            string status;

            #endregion

            #region CompareCars

            if (car1 == car2) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Iguales";
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Diferentes";
            }
            Console.WriteLine($"{car1.MostrarDatos()} \n{car2.MostrarDatos()} \n##########\nStatus: {status}\n##########\n");

            if (car1 == car3) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Iguales";
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Diferentes";
            }
            Console.WriteLine($"{car1.MostrarDatos()} \n{car3.MostrarDatos()} \n##########\nStatus: {status}\n##########\n");

            #endregion

            #region Competence

            if (granTurismo + car1) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Agregado a la competencia";
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Auto existente";
            }
            Console.WriteLine($"{granTurismo.MostrarDatos()} \n{car1.MostrarDatos()} \n##########\nStatus: {status}\n##########\n");

            if (granTurismo + car2) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Agregado a la competencia";
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Auto existente";
            }
            Console.WriteLine($"{granTurismo.MostrarDatos()} \n{car2.MostrarDatos()} \n##########\nStatus: {status}\n##########\n");

            #endregion

            Console.ReadKey();
        }
    }
}
