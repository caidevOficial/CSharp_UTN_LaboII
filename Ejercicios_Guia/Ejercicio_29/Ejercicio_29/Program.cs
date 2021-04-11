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

using Clases;
using System;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 29";
            Console.ForegroundColor = ConsoleColor.Green;

            Jugador j1 = new Jugador(35055008, "Pepe", 10, 25);
            Jugador j2 = new Jugador(35055008, "Coqui");
            Jugador j3 = new Jugador(35055001, "Paola", 5, 10);
            Jugador j4 = new Jugador(35055002, "Moni", 4, 1);
            Equipo losArgento = new Equipo(2, "Los Argento");
            string status;

            #region ComparePlayers

            if (j1 == j2)
            {
                status = "Iguales";
            }
            else
            {
                status = "Diferentes";
            }
            Console.WriteLine($"{j1.MostrarDatos()}{j2.MostrarDatos()}###############\nStatus: {status}.\n###############\n");

            if (j1 == j3)
            {
                status = "Iguales";
            }
            else
            {
                status = "Diferentes";
            }
            Console.WriteLine($"{j1.MostrarDatos()}{j3.MostrarDatos()}###############\nStatus: {status}.\n###############\n");

            #endregion

            #region AddPlayerToTeam

            if (losArgento + j1)
            {
                status = "Jugador agregado";
            }
            else
            {
                status = "Jugador existente o Equipo lleno.";
            }
            Console.WriteLine($"{j1.MostrarDatos()}###############\nStatus: {status}.\n###############\n");

            if (losArgento + j2)
            {
                status = "Jugador agregado";
            }
            else
            {
                status = "Jugador existente o Equipo lleno.";
            }
            Console.WriteLine($"{j2.MostrarDatos()}###############\nStatus: {status}.\n###############\n");

            if (losArgento + j3)
            {
                status = "Jugador agregado";
            }
            else
            {
                status = "Jugador existente o Equipo lleno.";
            }
            Console.WriteLine($"{j3.MostrarDatos()}###############\nStatus: {status}.\n###############\n");

            if (losArgento + j4)
            {
                status = "Jugador agregado";
            }
            else
            {
                status = "Jugador existente o Equipo lleno.";
            }
            Console.WriteLine($"{j4.MostrarDatos()}###############\nStatus: {status}.\n###############\n");

            #endregion

            Console.ReadKey();
        }
    }
}
