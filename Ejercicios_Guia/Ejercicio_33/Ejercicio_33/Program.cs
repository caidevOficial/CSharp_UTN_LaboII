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

using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        /// <summary>
        /// Recorre una clase y muestra lo que contienen sus indices.
        /// </summary>
        /// <param name="indexado"></param>
        /// <param name="cantidadIndices"></param>
        private static void MostrarIndices(Libro indexado, int cantidadIndices)
        {
            for (int i = 0; i < cantidadIndices; i++)
            {
                Console.WriteLine($"{indexado[i]}");
            }
        }

        static void Main(string[] args)
        {
            Libro harryPotter = new Libro();

            harryPotter[0] = "Capitulo 1";
            harryPotter[1] = "Capitulo 2";
            harryPotter[2] = "Capitulo 3";

            MostrarIndices(harryPotter, 4);

            harryPotter[0] = "Capitulo 0";
            harryPotter[1] = "Capitulo 1.1";

            MostrarIndices(harryPotter, 2);

            Console.ReadKey();
        }
    }
}
