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

namespace Business {
    public sealed class Carta {
        private Valor valor;
        private Palo palo;

        #region Enums

        public enum Palo {
            Copas,
            Oros,
            Bastos,
            Espadas
        }

        public enum Valor {
            As = 1,
            Dos,
            Tres,
            Cuatro,
            Cinco,
            Seis,
            Siete,
            Ocho,
            Nueve,
            Sota = 10,
            Caballo,
            Rey
        }

        #endregion

        #region Builders

        /// <summary>
        /// Builds the entity with a value and a type of card.
        /// </summary>
        /// <param name="valor">Enum Valor-type.</param>
        /// <param name="palo">Enum Palo-type.</param>
        public Carta(Valor valor, Palo palo) {
            this.valor = valor;
            this.palo = palo;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtains the name and value of a card.
        /// </summary>
        /// <returns>The name and value of a card as a string</returns>
        public string ObtenerNombre() {
            return $"{this.valor} de {this.palo}";
        }

        /// <summary>
        /// Compares the importance of the cards by its wand or value.
        /// </summary>
        /// <param name="c1">First Card to compare.</param>
        /// <param name="c2">Second Card To Compare.</param>
        /// <returns>Returns the subtraction of both cards.</returns>
        public static int CompareCards(Carta c1, Carta c2) {
            int comparer = 0;
            if (c1.palo != c2.palo) {
                comparer = c1.palo - c2.palo;
            } else {
                comparer = c1.valor - c2.valor;
            }

            return comparer;
        }

        #endregion
    }
}
