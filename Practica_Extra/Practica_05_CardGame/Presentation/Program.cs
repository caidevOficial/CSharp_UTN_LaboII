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

using Business;
using System;
using System.Collections.Generic;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practica 05 - CardGame";

            #region Instances

            Baraja deck = new Baraja();
            List<Carta> mazo = deck.CrearBaraja();
            deck = new Baraja(mazo);

            #endregion

            #region Ordered Decks

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("####### Initial Ordered Deck #######\n");
            deck.MostrarBaraja(mazo);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("####### Ordered Deck [Fisher-Yates] #######\n");
            deck.MostrarBaraja(deck.SortCards(mazo));

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("####### Ordered Deck [Common Sort] #######\n");
            mazo.Sort(Carta.CompareCards);
            deck.MostrarBaraja(mazo);

            #endregion

            Console.ReadKey();
        }
    }
}
