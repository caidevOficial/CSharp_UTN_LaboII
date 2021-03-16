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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        /// <summary>
        /// Draws a half pyramid of height 'size' with asterisks
        /// </summary>
        /// <param name="size">The height</param>
        /// <returns>0</returns>
        static int DrawPyramid(int size)
        {
            char star = '*';
            if (size > 0)
            {
                // for write every line
                for (int height = 0; height <= size; height++)
                {
                    //for write the spaces
                    for (int i = 1; i <= (size-height); i++)
                    {
                        Console.Write(" ");
                    }

                    //for write the asterisks
                    //long = double -1
                    for (int asterisk = 1; asterisk <= (height * 2) - 1; asterisk++)
                    {
                        Console.Write(star);
                    }
                    Console.WriteLine();
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int size = 5;
            DrawPyramid(size);
            Console.ReadKey();
        }
    }
}
