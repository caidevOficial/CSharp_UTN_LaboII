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
using System.Text.RegularExpressions;

namespace Entidades {

    public static class PatenteStringExtension {

        private const string patente_vieja = "^[A-Z]{3}[0-9]{3}$";
        private const string patente_mercosur = "^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
        private static Regex rgx_v = new Regex(PatenteStringExtension.patente_vieja);
        private static Regex rgx_n = new Regex(PatenteStringExtension.patente_mercosur);

        /// <summary>
        /// Validates if the entity is type old or new, then returns a valid entity regarding
        /// the type of the entity.
        /// </summary>
        /// <param name="patente">String of the entity to validate.</param>
        /// <returns>Returns an object of the entity.</returns>
        public static Patente ValidarPatente(this string patente) {
            Patente pat = null;
            try {
                if (rgx_v.IsMatch(patente)) {
                    pat = new Patente(patente, Patente.Tipo.Vieja);
                } else if (rgx_n.IsMatch(patente)) {
                    pat = new Patente(patente, Patente.Tipo.Mercosur);
                } else {
                    string s = string.Format("{0} no cumple el formato.", patente);
                    throw new PatenteInvalidaException(s);
                }
            } catch (Exception exe) {
                string s = string.Format("{0} no cumple el formato.", patente);
                throw new PatenteInvalidaException(s, exe);
            }

            return pat;
        }
    }
}
