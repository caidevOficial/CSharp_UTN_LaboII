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
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Baraja
    {
        List<Carta> cartasDeBaraja;

        #region Builders

        public Baraja() { }

        /// <summary>
        /// Builds the entity and initializes the list.
        /// </summary>
        /// <param name="cartasDeBaraja">List to initialize.</param>
        public Baraja(List<Carta> cartasDeBaraja)
            : this()
        {
            this.cartasDeBaraja = cartasDeBaraja;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get: gets the deck.
        /// </summary>
        /// <returns></returns>
        public List<Carta> GetBaraja()
        {
            return this.cartasDeBaraja;
        }

        /// <summary>
        /// Creates an inverse ordered deck.
        /// </summary>
        /// <returns>The deck with 48 cards.</returns>
        public List<Carta> CrearBaraja()
        {
            List<Carta> miBaraja = new List<Carta>();

            for (int r = 4; r > 0; r--)
            {
                for (int c = 12; c > 0; c--)
                {
                    miBaraja.Add(new Carta((Carta.Valor)c, (Carta.Palo)r - 1));
                }
            }

            return miBaraja;
        }

        /// <summary>
        /// Shows the cards of the deck.
        /// </summary>
        /// <param name="baraja">Deck to shows the cards.</param>
        public void MostrarBaraja(List<Carta> baraja)
        {
            StringBuilder message = new StringBuilder();

            foreach (Carta laCarta in baraja)
            {
                message.Append(laCarta.ObtenerNombre() + "\n");
            }
            Console.WriteLine(message);
        }

        /// <summary>
        /// Devuelve La ultima carta de la baraja y la remueve.
        /// </summary>
        /// <param name="miBaraja">Baraja a iterar</param>
        /// <returns>La ultima carta de la baraja.</returns>
        public Carta RemoverCarta(List<Carta> miBaraja)
        {
            if (miBaraja.Count > 0)
            {
                Carta ultimaCarta = miBaraja[miBaraja.Count - 1];
                miBaraja.Remove(ultimaCarta);
                return ultimaCarta;
            }

            return null;
        }

        /// <summary>
        /// Adds a card into the Deck.
        /// </summary>
        /// <param name="baraja">Deck to add a card.</param>
        /// <param name="miCarta">Card to add into the deck.</param>
        /// <returns>The list of cards.</returns>
        public List<Carta> AgregarCarta(List<Carta> baraja, Carta miCarta)
        {
            if (baraja.Count < 48)
            {
                baraja.Add(miCarta);
            }

            return baraja;
        }

        /// <summary>
        /// Sorts the deck randomly.
        /// </summary>
        /// <param name="deck">Deck to sort.</param>
        /// <returns>The deck sorted randomly</returns>
        public List<Carta> SortCards(List<Carta> deck)
        {
            int amountCards = deck.Count;
            int randomNumber;
            Random rand = new Random();
            Carta aCard;
            for (int i = amountCards - 1; i > 1; i--)
            {
                randomNumber = rand.Next(0, i);
                aCard = deck[randomNumber];
                deck.RemoveAt(randomNumber);
                deck.Add(aCard);
            }
            return deck;
        }

        #endregion

    }
}
