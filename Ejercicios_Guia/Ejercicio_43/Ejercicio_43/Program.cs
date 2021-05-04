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

using Models;
using System;

namespace Ejercicio_43 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Excercise N° 36";
            #region Instances

            Competencia granTurismo = new Competencia(5, 20, Competencia.TipoCompetencia.F1);
            Competencia motoDakar = new Competencia(8, 10, Competencia.TipoCompetencia.MotoCross);

            AutoF1 f1 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f2 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f3 = new AutoF1(7, "McLaren", 510);

            MotoCross m1 = new MotoCross(1, "Honda", 160);
            MotoCross m2 = new MotoCross(1, "Honda", 160);
            MotoCross m3 = new MotoCross(69, "Yamaha", 159);

            string status;

            #endregion

            #region CompareCars

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            //New Car into a car competence
            if (granTurismo + f1) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            //New Car into a car competence
            if (granTurismo + f3) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f3.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Same Car in F1 Competence -----------");
            //Same Car into a car competence
            if (granTurismo + f2) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f2.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Motorcycle in F1 Competence -----------");

            if (granTurismo + m1) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            #endregion

            # region ComparerMotorcycles

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Moto in MotoCross Competence -----------");
            if (motoDakar + m1) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Moto in MotoCross Competence -----------");
            if (motoDakar + m3) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m3.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Same Moto in MotoCross Competence -----------");
            if (motoDakar + m2) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m2.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Car in MotoCross Competence -----------");
            if (motoDakar + f1) {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Auto no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            #endregion

            #region ShowCompetencesData

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Data of Competences -----------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Turismo Carretera:");
            Console.WriteLine(granTurismo.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Dakar MotoCross:");
            Console.WriteLine(motoDakar.MostrarDatos());

            #endregion

            Console.ReadKey();
        }
    }
}
