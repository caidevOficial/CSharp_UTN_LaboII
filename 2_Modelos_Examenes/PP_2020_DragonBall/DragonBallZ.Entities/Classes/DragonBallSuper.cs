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

using Entities.Classes.SubClasses;
using Entities.Enums;
using System.Collections.Generic;

namespace Entities.Classes {
    public static class DragonBallSuper {
        static List<Personaje> listaPersonajes;

        #region Builders

        /// <summary>
        /// Creates the entity and the list of characters.
        /// </summary>
        static DragonBallSuper() {
            listaPersonajes = new List<Personaje>();
            CargarDatosDefault();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of characters.
        /// </summary>
        public static List<Personaje> ListaPersonajes {
            get => listaPersonajes;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Hardcodes the list with some characters.
        /// </summary>
        static void CargarDatosDefault() {
            List<EHabilidades> ataquesV = new List<EHabilidades> { EHabilidades.FinalFlash, EHabilidades.GarlikHo, EHabilidades.Teletransportacion, EHabilidades.BigBang_Attack };
            List<EHabilidades> ataquesG = new List<EHabilidades> { EHabilidades.GenkiDama, EHabilidades.Kamehameha, EHabilidades.Teletransportacion };
            List<EHabilidades> ataquesC = new List<EHabilidades> { EHabilidades.GarlikHo, EHabilidades.Kamehameha };
            listaPersonajes.Add(new Heroe("Goku", 100, ataquesG, true));
            listaPersonajes.Add(new Villano("KidBuu", 8000, ataquesC, EOrigen.Demon, false));
        }

        /// <summary>
        /// Adds a character into the list if the character not exist inside.
        /// </summary>
        /// <param name="p">Character to try into the list.</param>
        /// <returns>True if add the character, otherwise returns false.</returns>
        public static bool AgregarPersonaje(Personaje p) {
            if (!(p is null)) {
                foreach (Personaje personaje in listaPersonajes) {
                    if (p == personaje) {
                        return false;
                    }
                }
                listaPersonajes.Add(p);
            }

            return true;
        }

        /// <summary>
        /// Gets the info of a character as a string of the specified index.
        /// </summary>
        /// <param name="index">Index to search in the list.</param>
        /// <returns>The info ofa character as a string</returns>
        public static string GetPersonajeInfo(int index) {
            if (DragonBallSuper.listaPersonajes.Count > index) {
                return DragonBallSuper.listaPersonajes[index].InfoPersonaje();
            } else {
                return "No existe un personaje en ese índice";
            }
        }

        #endregion

    }
}
