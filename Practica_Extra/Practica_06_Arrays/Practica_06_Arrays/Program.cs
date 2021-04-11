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

namespace Practica_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar
            string[] nombres;
            // Instanciar
            nombres = new string[4];
            // Inicializar - asignar
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == null)
                {
                    nombres[i] = "Nombre " + (i+1).ToString();
                }
            }

            // Mostrar posiciones
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine($"Dimensiones: {nombres.Rank}");

            // Hardcodear dos dimensiones
            string[,] personas = new string[2, 2];
            personas[0,0] = "Facu";
            personas[0, 1] = "007";
            personas[1, 0] = "Pepe";
            personas[1, 1] = "048";

            // Mostrar dos dimensiones
            for (int i = 0; i < personas.GetLength(0); i++)
            {
                Console.WriteLine($"Personas: {personas[i,0]} Numero: {personas[i,1]}");
            }

            Console.WriteLine($"Dimensiones Personas: {personas.Rank}");
            Console.WriteLine($"Posiciones Personas: {personas.Length}");
            // resize
            Array.Resize(ref nombres, nombres.Length + 1);

            // Jagged Array
            string[][] arrayDeArray = new string[2][];
            arrayDeArray[0] = nombres;
            arrayDeArray[1] = new string[1] {"casa" };

            Console.ReadKey();
        }
    }
}
