using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
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
