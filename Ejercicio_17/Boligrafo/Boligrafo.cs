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

namespace Boligrafo
{
    public class Boligrafo
    {
        //##### Attributes #####
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;
        
        //##### Builders #####

        /// <summary>
        /// Builds the entity with default params.
        /// </summary>
        public Boligrafo()
        {
            this.color = ConsoleColor.Black;
            this.tinta = cantidadTintaMaxima;
        }

        /// <summary>
        /// Builds the entity with ink level.
        /// </summary>
        /// <param name="tinta">The ink level.</param>
        public Boligrafo(short tinta):this()
        {
            this.tinta = tinta;
        }

        /// <summary>
        /// Builds the entity with all its params.
        /// </summary>
        /// <param name="tinta">The ink level.</param>
        /// <param name="color">The color of the ink.</param>
        public Boligrafo(short tinta, ConsoleColor color):this(tinta)
        {
            this.color = color;
        }

        //##### Properties #####

        /// <summary>
        /// Gets the ink's level of the pen.
        /// </summary>
        /// <returns>The ink's level of the pen.</returns>
        public short GetTinta() 
        { 
            return this.tinta; 
        }

        /// <summary>
        /// Gets the color of the pen.
        /// </summary>
        /// <returns>The color of the pen.</returns>
        public ConsoleColor GetColor() 
        {
            return this.color;
        }

        /// <summary>
        /// Sets the ink's level of the pen.
        /// </summary>
        /// <param name="tinta">Ink's level.</param>
        private void SetTinta(short tinta)
        {
            short actualTinta = (short)(GetTinta() + tinta);
            if (actualTinta < 0)
            {
                this.tinta = 0;
            }else if (actualTinta >= 0 && actualTinta <= 100)
            {
                this.tinta = actualTinta;
            }
            else
            {
                this.tinta = 100;
            }
        }

        /// <summary>
        /// Fully fill the amount of ink of the pen.
        /// </summary>
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        /// <summary>
        /// Draws asterisks.
        /// </summary>
        /// <param name="gasto">The spending amount of ink.</param>
        /// <param name="dibujo">The draw of the pen.</param>
        /// <returns>True if it can draw, otherwise false.</returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            short initInk = GetTinta();
            short actualInk;

            if (gasto < 0)
            {
                if (initInk > 0)
                {
                    this.SetTinta(gasto);
                    actualInk = GetTinta();

                    switch (actualInk)
                    {
                        case 0:
                            dibujo = Boligrafo.Asterisks(initInk);
                            break;
                        default:
                            dibujo = Boligrafo.Asterisks(initInk - actualInk);
                            break;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Out of Ink! Please Recharge!");
                }
            }

            return false;
        }

        /// <summary>
        /// Draws a string of asterisks.
        /// </summary>
        /// <param name="spending">Amount of ink that needs to draw.</param>
        /// <returns>if can, returns the draw of asterisks. Otherwise an empty string.</returns>
        private static string Asterisks(int spending)
        {
            string draw = "";

            for (int i = 0; i < spending; i++)
            {
                draw += '*';
            }
            return draw;
        }

        /// <summary>
        /// Draws the line of asterisks.
        /// </summary>
        /// <param name="draw">The string to draw.</param>
        public void ShowDraw(string draw)
        {
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine(draw);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
