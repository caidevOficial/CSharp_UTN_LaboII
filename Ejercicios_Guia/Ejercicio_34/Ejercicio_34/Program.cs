﻿/*
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

using Library;
using System;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil toyota = new Automovil(4, 5, VehiculoTerrestre.Colores.Negro, 5, 5);
            Motocicleta harleyDavison = new Motocicleta(2, 0, VehiculoTerrestre.Colores.Gris, 150);
            Camion scania = new Camion(6, 2, VehiculoTerrestre.Colores.Blanco, 12, 15000);

            Console.WriteLine(toyota.ShowInfo());
            Console.WriteLine(harleyDavison.ShowInfo());
            Console.WriteLine(scania.ShowInfo());

            Console.ReadKey();
        }
    }
}