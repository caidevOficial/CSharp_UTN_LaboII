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

namespace PP_Estacionamiento_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento e = new Estacionamiento("UTN", 6);
            // Creación de Vehículos
            Console.WriteLine("MOTOS");
            Vehiculo m1 = new Moto("ASD123", 75, 4);
            Console.WriteLine(m1.ConsultarDatos());
            Moto m2 = new Moto("ASDaa123", 175);
            Console.WriteLine(m2.ConsultarDatos());
            Moto m3 = new Moto("QWE312", 175, 4, 35);
            Console.WriteLine(m3.ConsultarDatos());
            Console.WriteLine("PICKUPS");
            PickUp p1 = new PickUp("TYR753", "78", 51);
            Console.WriteLine(p1.ConsultarDatos());
            PickUp p2 = new PickUp("TYR753", "Model A");
            Console.WriteLine(p2.ConsultarDatos());
            Console.WriteLine("AUTOMOVILES");
            Automovil a1 = new Automovil("POI952", ConsoleColor.Red);
            Console.WriteLine(a1.ConsultarDatos());
            Automovil a2 = new Automovil("MNB651", ConsoleColor.DarkCyan, 23);
            Console.WriteLine(a2.ConsultarDatos());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Estacionamiento Ingreso");
            e += m1; // Entra
            e += p1; // Entra
            e += a1; // Entra
            e += m1; // No Entra Repetido
            e += p1; // No Entra Repetido
            e += a1; // No Entra Repetido
            e += m2; // Entra
            e += p2; // Entra
            e += a2; // Entra
            e += m3; // No Entra por espacio
            Console.WriteLine((string)e);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Estacionamiento Egreso");
            Console.WriteLine(e - m1);
            Console.WriteLine(e - p1);
            Console.WriteLine(e - a1);
            Console.WriteLine(e - m2);
            Console.WriteLine(e - p2);
            Console.WriteLine(e - a2);
            Console.WriteLine(e - m3);
            Console.WriteLine("--------------------------------");
            Console.WriteLine((string)e);
            Console.ReadKey();
        }
    }
}
