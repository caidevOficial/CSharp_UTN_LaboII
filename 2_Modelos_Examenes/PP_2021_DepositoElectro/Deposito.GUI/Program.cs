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

using Enums;
using Models;
using System;

namespace _2021_PP_DepositoElectro {
    class Program {
        static void Main(string[] args) {
            Deposito miDeposito = 7;
            Fabricante f1 = new Fabricante("Samsung", EPais.Corea);
            Fabricante f2 = new Fabricante("Huawei", EPais.China);

            Televisor t1 = new Televisor("LED 4K", "Philips", EPais.Holanda, ETipo.Led);
            Televisor t2 = new Televisor("Plasma 2000", "Noblex", EPais.Argentina, ETipo.Plasma);
            Televisor t3 = new Televisor("LED 4K", "Philips", EPais.Holanda, ETipo.Tubo);
            Televisor t4 = new Televisor("LED 4K", "Philips", EPais.Holanda, ETipo.Led);
            Celular c1 = new Celular("A6", f1, EGama.Media);
            Celular c2 = new Celular("A20", f2, EGama.Alta);
            Celular c3 = new Celular("A20", f2, EGama.Baja);
            Celular c4 = new Celular("Iphone 12", new Fabricante("Apple", EPais.USA), EGama.Alta);
            Celular c5 = new Celular("A20", f1, EGama.Alta);
            miDeposito += c1;
            //YA INGRESADO
            miDeposito += c1; // NO
            miDeposito += t1;
            miDeposito += t2;
            miDeposito += t3;// ERROR CON T1
            miDeposito += c2;
            miDeposito += c3;
            //YA INGRESADO
            miDeposito += t4;
            miDeposito += c4;
            //SIN LUGAR
            miDeposito += c5;
            Console.WriteLine(Deposito.Mostrar(miDeposito));
            Console.ReadLine();
        }
    }
}
