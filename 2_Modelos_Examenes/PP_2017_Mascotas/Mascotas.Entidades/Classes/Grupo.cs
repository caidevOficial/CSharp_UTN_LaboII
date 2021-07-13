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

using System.Collections.Generic;
using System.Text;

namespace Entidades {
    public sealed class Grupo {
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        public enum TipoManada {
            Unica,
            Mixta
        }

        #region Builders

        /// <summary>
        /// Initializes the type of pack.
        /// </summary>
        static Grupo() {
            Grupo.tipo = TipoManada.Unica;
        }

        /// <summary>
        /// Initializes the list of packs.
        /// </summary>
        private Grupo() {
            manada = new List<Mascota>();
        }

        /// <summary>
        /// Creates the entity with the name.
        /// </summary>
        /// <param name="nombre">Name for the entity.</param>
        public Grupo(string nombre)
            : this() {
            this.nombre = nombre;
        }

        /// <summary>
        /// Creates the entity with the name and type of pack.
        /// </summary>
        /// <param name="nombre">Name for the entity.</param>
        /// <param name="tipo">Type for of pack.</param>
        public Grupo(string nombre, TipoManada tipo)
            : this(nombre) {
            Grupo.tipo = tipo;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Sets the type of pack.
        /// </summary>
        public TipoManada Tipo {
            set {
                Grupo.tipo = value;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares a pack with the pet to see if the pet is in the pack.
        /// </summary>
        /// <param name="g">Pack to compate.</param>
        /// <param name="m">Pet to see inside the pack.</param>
        /// <returns>True if the pet is in the pack, otherwise returns false.</returns>
        public static bool operator ==(Grupo g, Mascota m) {
            if (!(g is null) && !(m is null)) {
                foreach (Mascota masc in g.manada) {
                    if (masc == m) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Compares a pack with the pet to see if the pet is not in the pack.
        /// </summary>
        /// <param name="g">Pack to compate.</param>
        /// <param name="m">Pet to see inside the pack.</param>
        /// <returns>True if the pet is not in the pack, otherwise returns false.</returns>
        public static bool operator !=(Grupo g, Mascota m) {
            return !(g == m);
        }

        /// <summary>
        /// Adds the pet if is not in the pack.
        /// </summary>
        /// <param name="g">Pack to compate.</param>
        /// <param name="m">Pet to see inside the pack.</param>
        /// <returns></returns>
        public static Grupo operator +(Grupo g, Mascota m) {
            if (g != m) {
                g.manada.Add(m);
            }

            return g;
        }

        /// <summary>
        /// Substract the pet if is in the pack.
        /// </summary>
        /// <param name="g">Pack to compate.</param>
        /// <param name="m">Pet to see inside the pack.</param>
        /// <returns></returns>
        public static Grupo operator -(Grupo g, Mascota m) {
            if (g == m) {
                g.manada.Remove(m);
            }

            return g;
        }

        /// <summary>
        /// Retrieves the info of the pack as a string.
        /// </summary>
        /// <param name="g">Pack to see the info.</param>
        public static implicit operator string(Grupo g) {
            StringBuilder data = new StringBuilder();
            data.Append($"**{g.nombre} {Grupo.tipo}**\n");
            data.Append("Integrantes:\n");
            foreach (Mascota m in g.manada) {
                data.Append(m.ToString());
            }

            return data.ToString();
        }

        #endregion
    }
}
