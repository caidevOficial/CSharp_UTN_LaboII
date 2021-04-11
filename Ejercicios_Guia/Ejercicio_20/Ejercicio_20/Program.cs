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
using Currency;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 20°";

            Dolar dCurrency = new Dolar(10);
            Peso pCurrency = new Peso(15, 97); //BNA value
            Euro eCurrency = new Euro(7, 1.17); //Oficial Taxes
            
            /*cotizations done*/
            Peso pSalary = new Peso();
            Euro eSalary = new Euro();
            Dolar dSalary = new Dolar();
            Peso pesoDouble = new Peso();

            Console.WriteLine("########## Currency Convertions ##########");
            /*Dolar -> Euro*/
            eSalary = (Euro)dCurrency;
            double eSalaryDouble = eSalary.GetCantidad();
            Console.WriteLine($"Dolares: ${dCurrency.GetCantidad()} - Euro: ${Math.Round(eSalaryDouble, 2)}");

            /*Dolar -> Peso*/
            pSalary = (Peso)dCurrency;
            double pSalaryDouble = pSalary.GetCantidad();
            Console.WriteLine($"Dolares: ${dCurrency.GetCantidad()} - Pesos: ${pSalaryDouble}\n");

            /*Peso -> Dolar*/
            dSalary = (Dolar)pCurrency;
            double dSalaryDouble = dSalary.GetCantidad();
            Console.WriteLine($"Pesos: ${pCurrency.GetCantidad()} - Dolares: ${Math.Round(dSalaryDouble, 2)}");

            /*Peso -> Euro*/
            eSalary = (Euro)pCurrency;
            eSalaryDouble = eSalary.GetCantidad();
            Console.WriteLine($"Pesos: ${pCurrency.GetCantidad()} - Euros: ${Math.Round(eSalaryDouble, 2)}\n");

            /*Euro -> Pesos*/
            pSalary = (Peso)eCurrency;
            pSalaryDouble = pSalary.GetCantidad();
            Console.WriteLine($"Euros: ${eCurrency.GetCantidad()} - Pesos: ${Math.Round(pSalaryDouble, 2)}");

            /*Euro -> Dolar*/
            dSalary = (Dolar)eCurrency;
            dSalaryDouble = dSalary.GetCantidad();
            Console.WriteLine($"Euros: ${eCurrency.GetCantidad()} - Dolares: ${Math.Round(dSalaryDouble, 2)}\n");

            /*Double -> Peso*/
            pesoDouble = (Peso)88;
            Console.WriteLine($"Pesos: ${pesoDouble.GetCantidad()}\n");

            Dolar original = new Dolar(1);
            Euro sameE = new Euro(1.16);
            Peso sameP = new Peso(38.33);
            Dolar sameD = new Dolar(1);

            /*Dolar's Overload*/
            /*Equally: Dolar -> Euro*/
            Console.WriteLine($"Dolar: ${original.GetCantidad()} - Euro: ${sameE.GetCantidad()} -> Equally: {original == sameE}");
            /*Equally: Dolar -> Peso*/
            Console.WriteLine($"Dolar: ${original.GetCantidad()} - Pesos: ${sameP.GetCantidad()} -> Equally: {original == sameP}");
            /*Equally: Dolar -> Dolar*/
            Console.WriteLine($"Dolar: ${original.GetCantidad()} - Dolar: ${sameD.GetCantidad()} -> Equally: {original == sameD}");

            /*Add and Substract Dolars*/
            Dolar sumDolars = new Dolar();
            sumDolars = original + sameE;
            Console.WriteLine($"{Math.Round(sumDolars.GetCantidad(),2)}");
            sumDolars = original + sameP;
            Console.WriteLine($"{Math.Round(sumDolars.GetCantidad(),2)}");
            sumDolars = original - sameE;
            Console.WriteLine($"{Math.Round(sumDolars.GetCantidad(),2)}");
            sumDolars = original - sameP;
            Console.WriteLine($"{Math.Round(sumDolars.GetCantidad(),2)}");

            Console.WriteLine("########## Additions ##########");
            Euro sumaEuro = eCurrency + dCurrency;
            Console.WriteLine($"Addition euro & dolar: {Math.Round(sumaEuro.GetCantidad(), 2)}");
            sumaEuro = eCurrency + pCurrency;
            Console.WriteLine($"Addition euro & Peso: {Math.Round(sumaEuro.GetCantidad(), 2)}");

            Dolar sumaDolar = dCurrency + eCurrency;
            Console.WriteLine($"Addition Dolar & Euro: {Math.Round(sumaDolar.GetCantidad(), 2)}");
            sumaDolar = dCurrency + pCurrency;
            Console.WriteLine($"Addition Dolar & Peso: {Math.Round(sumaDolar.GetCantidad(), 2)}");

            Peso sumaPeso = pCurrency + dCurrency;
            Console.WriteLine($"Addition Peso & Dolar: {Math.Round(sumaPeso.GetCantidad(), 2)}");
            sumaPeso = pCurrency + eCurrency;
            Console.WriteLine($"Addition Peso & Euro: {Math.Round(sumaPeso.GetCantidad(), 2)}");

            Console.WriteLine("########## Substractions ##########");
            Euro restaEuro = eCurrency - dCurrency;
            Console.WriteLine($"Substraction Euro & Dolar: {Math.Round(restaEuro.GetCantidad(), 2)}");

            Console.WriteLine("########## Substractions ##########");
            Dolar dolarCurrency = new Dolar(1.08);
            Peso pesoCurrency = new Peso(71.29, 66);
            Euro euroCurrency = new Euro(1, 1.08);
            Console.WriteLine($" Pesos: ${pesoCurrency.GetCantidad()} - Dolar: $ {dolarCurrency.GetCantidad()} -> Equal?: {pesoCurrency==dolarCurrency}");
            Console.WriteLine($" Dolar: ${dolarCurrency.GetCantidad()} - Euro: $ {euroCurrency.GetCantidad()} -> Equal?: {euroCurrency == dolarCurrency}");
            Console.WriteLine($" Pesos: ${pesoCurrency.GetCantidad()} - Euro: $ {euroCurrency.GetCantidad()} -> Equal?: {pesoCurrency == dolarCurrency}");
            Console.WriteLine($" Pesos: ${pesoCurrency.GetCantidad()} - Euro: $ {euroCurrency.GetCantidad()} -> Different?: {pesoCurrency != dolarCurrency}");

            Console.ReadKey(true);

        }
    }
}
