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

namespace AuxiliarLibrary
{
    public class AuxiliarLibrary
    {

        /// <summary>
        /// Shows the cube and square of a number if it is greater than 0, otherwise shows an error message.
        /// </summary>
        public static void Exercise_02()
        {
            int number;
            double quadra = 0;
            double cube = 0;

            Console.Title = "Ejercicio 2";
            Console.WriteLine("Ingrese un numero y te mostrare su cuadrado y cubo: ");
            int.TryParse(Console.ReadLine(), out number);
            if (number < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            else
            {
                quadra = Math.Pow(number, 2);
                cube = Math.Pow(number, 3);
            }

            Console.WriteLine("Numero: {0,-5}, Cuadrado: {1,-5}, Cubo: {2,-5}", number, quadra, cube);
            Console.ReadKey();
        }
    }
}
