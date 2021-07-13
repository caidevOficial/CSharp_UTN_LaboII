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

using Models;
using System;

namespace Ejercicio_47 {
    class Program {
        static void Main(string[] args) {

            #region Instances

            Torneo<Equipo> fifa = new Torneo<Equipo>("Fifa 2021");
            Torneo<Equipo> nbaLive = new Torneo<Equipo>("NBA Live 2021");

            EquipoBasket e1 = new EquipoBasket("Basket 1", new DateTime(2020, 02, 25));
            EquipoBasket e2 = new EquipoBasket("Basket 2", new DateTime(2019, 02, 25));
            EquipoBasket e3 = new EquipoBasket("Basket 3", new DateTime(2018, 02, 25));
            EquipoBasket e4 = new EquipoBasket("Basket 4", new DateTime(2021, 02, 25));

            EquipoFutbol f1 = new EquipoFutbol("Fulbo 1", new DateTime(2020, 02, 25));
            EquipoFutbol f2 = new EquipoFutbol("Fulbo 2", new DateTime(2019, 02, 25));
            EquipoFutbol f3 = new EquipoFutbol("Fulbo 3", new DateTime(2018, 02, 25));
            EquipoFutbol f4 = new EquipoFutbol("Fulbo 4", new DateTime(2021, 02, 25));

            #endregion

            #region AddInTheSoccerTournament

            fifa += f1;
            fifa += f2;
            fifa += f3;
            fifa += f4;
            fifa += f1; // Repeated

            #endregion

            #region AddInTheNBATournament

            nbaLive += e1;
            nbaLive += e2;
            nbaLive += e3;
            nbaLive += e4;
            nbaLive += e1; // Repeated

            #endregion

            #region ShowsSoccerStatics

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\tSoccer Tournament Statics");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(fifa.Mostrar());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(fifa.JugarPartido);

            #endregion

            #region ShowsNBAStatics

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\tNBA Tournament Statics");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(nbaLive.Mostrar());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(nbaLive.JugarPartido);

            #endregion

            Console.ReadKey();
        }
    }
}
