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

namespace Receipt {
    public class Receipt {

        /// <summary>
        /// Shows the info of the employee.
        /// </summary>
        /// <param name="name">Name of the employee.</param>
        /// <param name="yearsWorked">Total of years worked.</param>
        /// <param name="amountPerHour">Salary per hour.</param>
        /// <param name="finalAmount">Final Salary.</param>
        private static void ShowInfo(string name, int yearsWorked, double amountPerHour, double finalAmount) {
            Console.WriteLine($"##############\n" +
                                $"Name: {name}.\n" +
                                $"Years Worked: {yearsWorked}.\n" +
                                $"Amount per Hour: ${amountPerHour}.\n" +
                                $"Final Salary: ${finalAmount}.\n" +
                                $"##############\n");
        }

        /// <summary>
        /// Calculates the salary of employees and prints in console the receipt.
        /// </summary>
        public static void CalculateReceipt() {
            const int BASE = 150;
            const double DISCOUNT = 0.87;

            string name = "";
            int employeesChargeds = 0;
            int amountEmployees = 0;
            int yearsWorked = 0;

            double pricePerHour = 0;
            double monthlySalary = 0;
            double finalAmount = 0;

            Console.Write("How many employees do you wanna charge?: ");
            if (int.TryParse(Console.ReadLine(), out amountEmployees)) {
                do {
                    Console.Write($"Tell me the name of the {employeesChargeds + 1}° employee: ");
                    name = Console.ReadLine();

                    Console.Write("Tell me the Price-Per-Hour: ");
                    if (double.TryParse(Console.ReadLine(), out pricePerHour)) {
                        Console.Write("How many hours worked per month?: ");
                        int.TryParse(Console.ReadLine(), out int amountHoursInMonth);
                        monthlySalary = amountHoursInMonth * pricePerHour;
                    }

                    Console.Write("How many years worked?: ");
                    if (int.TryParse(Console.ReadLine(), out yearsWorked)) {
                        finalAmount = (monthlySalary) + (yearsWorked * BASE);
                        finalAmount *= DISCOUNT;
                    }
                    ShowInfo(name, yearsWorked, pricePerHour, finalAmount);

                    employeesChargeds++;
                } while (employeesChargeds < amountEmployees);
                Console.WriteLine("All operations has been done!.");
            } else {
                Console.WriteLine("Something went wrong, please try again.");
            }
        }
    }
}
