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
using Temperaturas;

namespace Ejercicio_21 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Exercise 21°";

            Kelvin kTemperature = new Kelvin(298.15);
            Celsius cTemperature = new Celsius(25);
            Fahrenheit fTemperature = new Fahrenheit(77);

            Celsius cTemperature2 = new Celsius(25);


            Kelvin kNew = new Kelvin();
            Celsius cNew = new Celsius();
            Fahrenheit fNew = new Fahrenheit();

            Console.WriteLine("########## Temperature Convertions ##########");
            /*Fahrenheite -> Kelvin*/
            kNew = (Kelvin)fTemperature;
            double kNewDouble = kNew.GetAmount();
            Console.WriteLine($"Fahrenheit: {fTemperature.GetAmount()}° - Kelvin: {Math.Round(kNewDouble, 2)}°");

            /*Fahrenheite -> Celsius*/
            cNew = (Celsius)fTemperature;
            double cNewDouble = cNew.GetAmount();
            Console.WriteLine($"Fahrenheit: {fTemperature.GetAmount()}° - Celsius: {cNewDouble}°\n");

            /*Celsius -> Kelvin*/
            kNew = (Kelvin)cTemperature;
            kNewDouble = kNew.GetAmount();
            Console.WriteLine($"Celsius: {cTemperature.GetAmount()}° - Kelvin: {kNewDouble}°");

            /*Celsius -> Fahrenheite*/
            fNew = (Fahrenheit)cTemperature;
            double fNewDouble = fNew.GetAmount();
            Console.WriteLine($"Celsius: {cTemperature.GetAmount()}° - Fahrenheit: {fNewDouble}°\n");

            /*Kelvin -> Celsius*/
            cNew = (Celsius)kTemperature;
            cNewDouble = cNew.GetAmount();
            Console.WriteLine($"Kelvin: {kTemperature.GetAmount()}° - Celsius: {cNewDouble}°");

            /*Kelvin -> Fahrenheit*/
            fNew = (Fahrenheit)kTemperature;
            fNewDouble = fNew.GetAmount();
            Console.WriteLine($"Kelvin: {kTemperature.GetAmount()}° - Fahrenheit: {Math.Round(fNewDouble, 2)}°\n");

            Console.WriteLine("########## Temperature Equality ##########");
            /*Equally: Celsius -> Fahrenheit*/
            Console.WriteLine($"Celsius: {cTemperature.GetAmount()}° - Fahrenheit: {fTemperature.GetAmount()}° -> Equally: {cTemperature == fTemperature}");
            /*Equally: Celsius -> Kelvin*/
            Console.WriteLine($"Celsius: {cTemperature.GetAmount()}° - Kelvin: {kTemperature.GetAmount()}° -> Equally: {cTemperature == kTemperature}");
            /*Equally: Celsius -> Celsius*/
            Console.WriteLine($"Celsius: {cTemperature.GetAmount()}° - Celsius: {cTemperature2.GetAmount()}° -> Equally: {cTemperature == cTemperature2}\n");

            Console.WriteLine("########## Temperature Addition ##########");
            Celsius sumCelsius = new Celsius();
            sumCelsius = cTemperature + fTemperature;
            Console.WriteLine($" {cTemperature.GetAmount()}°C + {fTemperature.GetAmount()}°F: {Math.Round(sumCelsius.GetAmount(), 2)}° Celsius");
            sumCelsius = cTemperature + kTemperature;
            Console.WriteLine($" {cTemperature.GetAmount()}°C + {kTemperature.GetAmount()}°K: {Math.Round(sumCelsius.GetAmount(), 2)}° Celsius");

            Console.ReadKey(true);
        }
    }
}
