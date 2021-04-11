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

using Number;
using System;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal decimalNumber = (NumeroDecimal)30;
            NumeroBinario binaryNumber = (NumeroBinario)"111001";
            
            Console.WriteLine("########## Convert ##########");
            NumeroDecimal decimalNumber2 = (NumeroDecimal)binaryNumber;
            NumeroBinario binaryNumber2 = (NumeroBinario)decimalNumber;

            Console.WriteLine($"Binary: {binaryNumber.GetBinaryNumber()} -> {decimalNumber2.GetDecimalNumber()}");
            Console.WriteLine($"Decimal: {decimalNumber.GetDecimalNumber()} -> {binaryNumber2.GetBinaryNumber()}");

            Console.WriteLine("\n########## Adition ##########");
            
            decimalNumber2 = (NumeroDecimal)((decimalNumber + binaryNumber).GetDecimalNumber());
            binaryNumber2 = (NumeroBinario)((binaryNumber + decimalNumber).GetBinaryNumber());
            Console.WriteLine($"D: {decimalNumber.GetDecimalNumber()} + B: {binaryNumber.GetBinaryNumber()} = {decimalNumber2.GetDecimalNumber()}");
            Console.WriteLine($"B: {binaryNumber.GetBinaryNumber()} + D: {decimalNumber.GetDecimalNumber()} = {binaryNumber2.GetBinaryNumber()}");


            Console.WriteLine("\n########## Subtraction ##########");
            decimalNumber2 = (NumeroDecimal)((decimalNumber - binaryNumber).GetDecimalNumber());
            binaryNumber2 = (NumeroBinario)((binaryNumber - decimalNumber).GetBinaryNumber());
            Console.WriteLine($"D: {decimalNumber.GetDecimalNumber()} - B: {binaryNumber.GetBinaryNumber()} = {decimalNumber2.GetDecimalNumber()}");
            Console.WriteLine($"B: {binaryNumber.GetBinaryNumber()} - D: {decimalNumber.GetDecimalNumber()} = {binaryNumber2.GetBinaryNumber()}");

            Console.ReadKey();
        }
    }
}
