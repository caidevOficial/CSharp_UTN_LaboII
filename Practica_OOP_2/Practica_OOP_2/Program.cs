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
using ClassLibrary;

namespace Practica_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            Pet fatiga = new Pet("Pulgoso", "Fatiga", new DateTime(2020,02,24));
            Pet salem = new Pet("Black", "Salem", new DateTime(2020, 02, 25));
            salem.SetVaccine(new Vaccination("Triple Felina"));
            Pet garfield = new Pet("Orange", "Garfield", new DateTime(2020, 02, 20));
            Pet scooby = new Pet("Pulgoso", "Scooby doo", new DateTime(2020, 02, 26));
            scooby.SetVaccine(new Vaccination("Rabia"));
            
            Customer person1 = new Customer("Pepe", "Argento", "CABA", "11222333");
            Customer person2 = new Customer("Moni", "Argento", "CABA", "11222333");
            Customer person3 = new Customer("Paola", "Argento", "CABA", "11222333");
            
            person1.SetPet(fatiga);
            person2.SetPet(salem);
            person3.SetPet(garfield);
            person3.SetPet(scooby);

            customers[0] = person1;
            customers[1] = person2;
            customers[2] = person3;

            foreach (Customer thisCustomer in customers)
            {
                Console.WriteLine(thisCustomer.CustomerToString());
            }
            Console.ReadKey();
        }
    }
}
