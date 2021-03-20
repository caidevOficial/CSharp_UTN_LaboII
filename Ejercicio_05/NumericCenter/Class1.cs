using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericCenter
{
    public class NumericCenter
    {
        /// <summary>
        /// Searchs for numeric centers till' the number that the user enters.
        /// </summary>
        public static void CheckNumericCenter()
        {
            Console.Title = "Ejercicio Nro 05";

            int numberTillCheck;
            int sumOfAbove;
            int sumOfFollowing;
            int sumTotal;
            bool flag = false;

            Console.Write("Escriba un numero: ");
            int.TryParse(Console.ReadLine(), out numberTillCheck);

            Console.WriteLine("Buscando centros numéricos:\n");

            for (int i = 2; i < numberTillCheck; i++)
            {
                sumOfFollowing = i + 1;
                sumOfAbove = 0;
                sumTotal = 0;

                for (int y = i - 1; y > 0; y--)
                {
                    sumOfAbove += y;
                }

                while (sumTotal <= sumOfAbove)
                {

                    sumTotal += sumOfFollowing;
                    if (sumTotal == sumOfAbove)
                    {
                        Console.WriteLine($"Centro encontrado: {i}");
                        flag = true;

                    }
                    sumOfFollowing += 1;

                }
            }
            if (!flag)
            {
                Console.WriteLine("Sin centros numéricos");
            }
            Console.WriteLine("\nProgram Terminated!");
            Console.ReadKey(true);
        }
    }
}
