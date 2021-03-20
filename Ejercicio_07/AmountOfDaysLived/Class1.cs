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

namespace AmountOfDaysLived
{
    public class AmountOfDaysLived
    {
        /// <summary>
        /// Checks if the year is Leap or not.
        /// </summary>
        /// <param name="year">Year to check.</param>
        /// <returns>True if is a leap year, otherwise returns false.</returns>
        private static bool isLeapYear(int year)
        {
            if ((year % 4) == 0)
            {
                if ((year % 100) != 0 || (year % 400) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Calculates the amount of days lived since the birthday of the user till' now.
        /// </summary>
        public static void CalculatesDaysLived()
        {
            int year;
            int amountOfDays = 0;
            DateTime actualTime = DateTime.Now;

            Console.Title = "Ejercicio 7";
            Console.WriteLine("Indicame el año: ");
            int.TryParse(Console.ReadLine(), out year);

            for (int actualYear = year; actualYear < actualTime.Year; actualYear++)
            {
                if (isLeapYear(actualYear))
                {
                    amountOfDays += 366;
                }
                else
                {
                    amountOfDays += 365;
                }
            }

            Console.WriteLine($"Hay dias: {amountOfDays}.");
            Console.ReadKey();
        }
    }
}
