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

using Entidades;
using System;

namespace PP_LabII_2017_Mascotas {
    class Program {
        static void Main(string[] args) {
            Console.Title = "PP Mascotas";
            Grupo manadita = new Grupo("Rio", Grupo.TipoManada.Unica);
            Perro p1 = new Perro("Moro", "Pitbull");
            Perro p2 = new Perro("Julio", "Cruza");
            p2.Edad = 13;
            Perro p3 = new Perro("Ramón", "Salchicha", 2, true);

            Gato g1 = new Gato("José", "Angora");
            Gato g2 = new Gato("Hernan", "Cruza");
            Gato g3 = new Gato("Fer", "Siames");


            Console.ForegroundColor = ConsoleColor.Green;
            if (manadita != p1) {
                manadita = manadita + p1;
                Console.WriteLine($"Se agrego a {p1.Nombre} al grupo");
            }

            if (manadita != p2) {
                manadita = manadita + p2;
                Console.WriteLine($"Se agrego a {p2.Nombre} al grupo");
            }

            if (manadita != p3) {
                manadita = manadita + p3;
                Console.WriteLine($"Se agrego a {p3.Nombre} al grupo");
            }

            if (manadita != g1) {
                manadita = manadita + g1;
                Console.WriteLine($"Se agrego a {g1.Nombre} al grupo");
            }

            if (manadita != g2) {
                manadita = manadita + g2;
                Console.WriteLine($"Se agrego a {g2.Nombre} al grupo");
            }

            if (manadita != g3) {
                manadita = manadita + g3;
                Console.WriteLine($"Se agrego a {g3.Nombre} al grupo");
            }

            if (manadita != g3) {
                manadita = manadita + g3;
                Console.WriteLine($"Se agrego a {g3.Nombre} al grupo");
            } else {
                Console.ForegroundColor = ConsoleColor.Magenta;
                manadita = manadita - g3;
                Console.WriteLine($"No Se agrego de nuevo a {g3.Nombre} al grupo\n");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine((string)manadita);

            Console.ReadKey();
        }
    }
}
