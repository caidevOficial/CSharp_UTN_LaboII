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

namespace Business
{
    public class Carta
    {
        public enum Palo
        {
            Copas,
            Oros,
            Bastos,
            Espadas
        }

        public enum Valor
        {
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

        private Valor valor;
        private Palo palo;

        /// <summary>
        /// Builds the entity with a value and a type of card.
        /// </summary>
        /// <param name="valor">Enum Valor-type.</param>
        /// <param name="palo">Enum Palo-type.</param>
        public Carta(Valor valor, Palo palo)
        {
            this.valor = valor;
            this.palo = palo;
        }

        /// <summary>
        /// Obtains the name and value of a card.
        /// </summary>
        /// <returns>The name and value of a card as a string</returns>
        public string ObtenerNombre()
        {
            return $"{this.valor} de {this.palo}";
        }
    }
}
