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

namespace Ejercicio_16 {
    class Program {
        static void Main(string[] args) {
            // Create instances.
            Alumno pepe = new Alumno("Argento", "Pepe", 0001);
            Alumno moni = new Alumno("Argento", "Moni", 0002);
            Alumno paola = new Alumno("Argento", "Paola", 0003);

            // ################
            pepe.Estudiar(4, 4);
            pepe.CalcularFinal();
            Console.WriteLine(pepe.Mostrar());

            moni.Estudiar(1, 3);
            moni.CalcularFinal();
            Console.WriteLine(moni.Mostrar());

            paola.Estudiar(8, 9);
            paola.CalcularFinal();
            Console.WriteLine(paola.Mostrar());

            Console.ReadKey();
        }
    }
}
