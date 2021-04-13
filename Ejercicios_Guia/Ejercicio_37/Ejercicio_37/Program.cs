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

using CentralitaHerencia;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 37 - Centralita";
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            #region Instances

            // Mi central
            Centralita c = new Centralita("Telecom");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", "Rosario", 30, 2.65f);
            Provincial l2 = new Provincial(21, "Morón", "Bernal", Provincial.Franja.Franja_01);
            Local l3 = new Local("Lanús", "San Rafael", 45, 1.99f);
            Provincial l4 = new Provincial(l2, Provincial.Franja.Franja_03);

            #endregion

            #region Test

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=======================");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=======================");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=======================");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=======================");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            c.OrdenarLlamadas();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();

            #endregion

            Console.ReadKey();
        }
    }
}
