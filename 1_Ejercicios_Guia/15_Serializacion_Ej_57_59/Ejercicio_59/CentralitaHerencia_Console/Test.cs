
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

namespace CentralitaHerencia_Console {
    class Test {
        static void Main(string[] args) {

            #region Attributes

            string centralitaPath = $"{Environment.CurrentDirectory}";
            string centralitaFileName = "Bitacora";

            #endregion

            #region Instances

            Centralita c = new Centralita("Fede Center");

            Local l1 = new Local("Bernal", "Rosario", 33, (float)2.85);
            Provincial l2 = new Provincial(29, "Morón", "Bernal", Provincial.Franja.Franja_01);
            Local l3 = new Local("Lanús", "San Rafael", 55, 1.98f);
            Provincial l4 = new Provincial(l2, Provincial.Franja.Franja_03);

            #endregion

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try {
                c += l1;
                c.Guardar(centralitaPath, centralitaFileName);
                l1.Guardar(centralitaPath, l1);
                c += l2;
                c.Guardar(centralitaPath, centralitaFileName);
                l2.Guardar(centralitaPath, l2);
                c += l3;
                c.Guardar(centralitaPath, centralitaFileName);
                l3.Guardar(centralitaPath, l3);
                c += l4;
                c.Guardar(centralitaPath, centralitaFileName);
                l4.Guardar(centralitaPath, l4);
                c += l4; // Duplicado
            } catch (CentralitaException ce) {
                Console.WriteLine($"Error: {ce.Message} producido en {ce.NombreClase} al usar {ce.NombreMetodo}.");
            } catch (FallaLogException fl) {
                Console.WriteLine($"Error: {fl.Message} producido en {fl.NombreClase} al usar {fl.NombreMetodo}.");
            }
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("_________________________________");
            Console.WriteLine(c.Leer());
            Console.ReadKey();
        }
    }
}
