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

using EntidadFinanciera;
using PrestamosPersonales;
using System;

namespace _2017_PP_Financiera {
    class Program {
        static void Main(string[] args) {
            Financiera financiera = new Financiera("Mi Financiera");
            PrestamoDolar pd1 = new PrestamoDolar(1500, new DateTime(2017, 11, 01), PeriodicidadDePagos.Mensual);
            PrestamoDolar pd2 = new PrestamoDolar(2000, new DateTime(2017, 12, 05), PeriodicidadDePagos.Bimestral);
            PrestamoDolar pd3 = new PrestamoDolar(2500, new DateTime(2018, 01, 01), PeriodicidadDePagos.Trimestral);
            PrestamoPesos pp1 = new PrestamoPesos(8000, new DateTime(2018, 01, 01), 20);
            PrestamoPesos pp2 = new PrestamoPesos(7000, new DateTime(2001, 10, 01), 25);
            PrestamoPesos pp3 = new PrestamoPesos(5000, new DateTime(2017, 11, 20), 20);

            financiera = financiera + pd1;
            financiera = financiera + pd2;
            financiera = financiera + pd3;
            financiera = financiera + pd3; //Préstamo repetido
            financiera = financiera + pp1;
            financiera = financiera + pp2;
            financiera = financiera + pp3;
            financiera = financiera + pp3; //Préstamo repetido
            Console.WriteLine((String)financiera);
            pd1.ExtenderPlazo(new DateTime(2017, 12, 01));
            pp1.ExtenderPlazo(new DateTime(2018, 02, 01));
            financiera.OrdenarPrestamos();
            Console.WriteLine("\n ********************ORDENADOS POR FECHA**************************");
            Console.WriteLine(Financiera.Mostrar(financiera));
            Console.ReadKey();
        }
    }
}
