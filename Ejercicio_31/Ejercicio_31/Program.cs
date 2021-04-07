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

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente first = new Cliente("Fatiga", 007);
            Cliente firstError = new Cliente("Pepe", 007);
            Cliente second = new Cliente("Moni", 008);
            Cliente third = new Cliente("Paola", 009);
            string status = "Diferente";


            if (first == firstError) // Comparo con un cliente con el mismo numero
            {
                status = "Igual";
            }
            else
            {
                status = "Direfente";
            }
            Console.WriteLine($"{first.Nombre} - {firstError.Nombre}: Tienen el {status} numero");

            if (first == third) // Comparo con un cliente diferente
            {
                status = "Igual";
            }
            else
            {
                status = "Direfente";
            }
            Console.WriteLine($"{first.Nombre} - {third.Nombre}: Tienen el {status} numero");


            Negocio tienda = new Negocio("Los Argento");

            if (tienda + first)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (tienda + second)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (tienda + third)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (tienda + firstError)//no se puede agregar
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (tienda == first)
            {
                Console.WriteLine("Está");
            }
            else
            {
                Console.WriteLine("No Está");
            }

            if (~tienda)
            {
                Console.WriteLine($"Atendido cliente {first.Numero}");
            }
            if (~tienda)
            {
                Console.WriteLine($"Atendido cliente {second.Numero}");
            }
            if (~tienda)
            {
                Console.WriteLine($"Atendido cliente {third.Numero}");
            }

            Console.ReadKey();
        }
    }
}
