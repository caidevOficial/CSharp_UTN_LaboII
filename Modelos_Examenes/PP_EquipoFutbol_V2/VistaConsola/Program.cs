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

using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genero un equipo nuevo
            Equipo equipo = new Equipo("UTN");
            // Genero un Director Técnico y lo asigno al equipo
            DirectorTecnico dt = new DirectorTecnico("Roberto", "Gonzalez", 60, 8332112, 10);
            DirectorTecnico dtInvalido = new DirectorTecnico("Angel", "Ramirez", 90, 6332112, 1);
            equipo.DirectorTecnico = dtInvalido;
            // Genero Jugadores
            Jugador j1 = new Jugador("Juan", "López", 28, 33222456, 70.5f, 1.82f, Posicion.Arquero);
            Jugador j2 = new Jugador("José", "Martínez", 28, 33222456, 72f, 1.70f, Posicion.Defensor);
            Jugador j3 = new Jugador("Pedro", "Gonzalez", 31, 31333444, 73.5f, 1.90f, Posicion.Delantero);
            Jugador j4 = new Jugador("Matías", "Rodríguez", 32, 30443332, 75.5f, 1.75f, Posicion.Central);
            Jugador j5 = new Jugador("Jugador5", "Inválido", 26, 36555443, 99.5f, 1.73f, Posicion.Delantero);
            Jugador j6 = new Jugador("Jugador6", "Inválido", 50, 37456678, 86.5f, 1.94f, Posicion.Delantero);
            Jugador j7 = new Jugador("Martín", "Perez", 26, 36555443, 66.5f, 1.73f, Posicion.Defensor);
            Jugador j8 = new Jugador("Diego", "Roa", 25, 37456678, 86.5f, 1.94f, Posicion.Delantero);
            // Agrego los jugadores al equipo
            equipo = equipo + j1;
            equipo = equipo + j2;
            equipo = equipo + j3;
            Console.WriteLine("*******************************EQUIPO INVÁLIDO*******************************");
            // Imprimo los datos del equipo
            Console.WriteLine((string)equipo);
            if (Equipo.ValidarEquipo(equipo))
                Console.WriteLine("El equipo es válido");
            else
                Console.WriteLine("El equipo no es válido");
            equipo.DirectorTecnico = dt;
            equipo = equipo + j4;
            equipo = equipo + j5;
            equipo = equipo + j6;
            equipo = equipo + j7;
            equipo = equipo + j8;
            Console.WriteLine("*******************************EQUIPO VÁLIDO*********************************");
            // Imprimo los datos del equipo
            Console.WriteLine((string)equipo);
            if (Equipo.ValidarEquipo(equipo))
                Console.WriteLine("El equipo es válido");
            else
                Console.WriteLine("El equipo no es válido");
            Console.ReadKey();
        }
    }
}
