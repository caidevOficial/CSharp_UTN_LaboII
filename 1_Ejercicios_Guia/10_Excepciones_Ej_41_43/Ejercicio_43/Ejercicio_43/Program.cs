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
            Console.Title = "Excercise N° 43";
            
            #region Instances

            Competencia competencia = new Competencia(4, 6, Competencia.TipoCompetencia.F1);

            AutoF1 f1 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f2 = new AutoF1(25, "Masseratti", 500);
            AutoF1 f3 = new AutoF1(7, "McLaren", 510);
            AutoF1 f5 = new AutoF1(16, "Masseratti", 88);
            AutoF1 f6 = new AutoF1(23, "Lamborghini", 115);

            MotoCross m1 = new MotoCross(1, "Honda", 160);
            
            #endregion

            #region Motorcycle


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Motorcycle in F1 Competence -----------");

            try {
                if (competencia + m1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(m1.MostrarDatos());
                }
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Car

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            try {
                if (competencia + f1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(f1.MostrarDatos());
                }
            } catch (Exception e) {

                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            try {
                if (competencia + f2) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(f2.MostrarDatos());
                }
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Repeated Car in F1 Competence -----------");
            try {
                if (competencia + f2) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(f2.MostrarDatos());
                }
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            try {
                if (competencia + f3) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(f3.MostrarDatos());
                }
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            try {
                if (competencia + f5) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(f5.MostrarDatos());
                }
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            try {
                if (competencia + f6) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(f6.MostrarDatos());
                }
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            #endregion

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Data of Competence -----------");
            Console.WriteLine(competencia.MostrarDatos());
            Console.ReadKey();
        }
    }
}
