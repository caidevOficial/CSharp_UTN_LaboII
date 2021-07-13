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

namespace Ejercicio_31 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Excercise N° 31";
            Cliente first = new Cliente("Fatiga", 007);
            Cliente firstError = new Cliente("Pepe", 007);
            Cliente second = new Cliente("Moni", 008);
            Cliente third = new Cliente("Paola", 009);
            string status = "Diferente";

            #region CompareCustomers

            if (first == firstError) // Comparo con un cliente con el mismo numero
            {
                status = "Igual";
            } else {
                status = "Direfente";
            }
            Console.WriteLine($"{first.Nombre} - {firstError.Nombre}: Tienen el {status} numero");

            if (first == third) // Comparo con un cliente diferente
            {
                status = "Igual";
            } else {
                status = "Direfente";
            }
            Console.WriteLine($"{first.Nombre} - {third.Nombre}: Tienen el {status} numero");

            #endregion

            #region AddingCustomers

            Negocio tienda = new Negocio("Los Argento");

            if (tienda + first) {
                status = "Se agrego";
            } else {
                status = "No se agrego";
            }
            Console.WriteLine($"{first.Nombre} : {status} a la fila");

            if (tienda + second) {
                status = "Se agrego";
            } else {
                status = "No se agrego";
            }
            Console.WriteLine($"{second.Nombre} : {status} a la fila");

            if (tienda + third) {
                status = "Se agrego";
            } else {
                status = "No se agrego";
            }
            Console.WriteLine($"{third.Nombre} : {status} a la fila");

            if (tienda + firstError)//no se puede agregar
            {
                status = "Se agrego";
            } else {
                status = "No se agrego";
            }
            Console.WriteLine($"{firstError.Nombre} : {status} a la fila");

            #endregion

            #region CompareCustomersInQueue

            if (tienda == first) {
                status = "Existe en la fila";
            } else {
                status = "No existe en la fila";
            }
            Console.WriteLine($"{first.Nombre} : {status}");

            #endregion

            #region Store

            if (~tienda) {
                Console.WriteLine($"Nro de cliente atendido: {first.Numero}");
            }
            if (~tienda) {
                Console.WriteLine($"Nro de cliente atendido: {second.Numero}");
            }
            if (~tienda) {
                Console.WriteLine($"Nro de cliente atendido: {third.Numero}");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
