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
    public class Jardin {

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        public enum Tipo {
            Terrozo,
            Arenozo
        }

        #region Builders

        /// <summary>
        /// Initializes the type of garden as Terrozo.
        /// </summary>
        static Jardin() {
            suelo = Tipo.Terrozo;
        }

        /// <summary>
        /// Instances the entity and the list of plants.
        /// </summary>
        private Jardin() {
            plantas = new List<Planta>();
        }

        /// <summary>
        /// Instances the entity and the list of plants.
        /// </summary>
        /// <param name="espacioTotal">Total space of the garden.</param>
        public Jardin(int espacioTotal)
            : this() {
            this.espacioTotal = espacioTotal;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the type of ground.
        /// </summary>
        public Tipo TipoSuelo {
            set {
                suelo = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the ocupped space in the garde by the plants.
        /// </summary>
        /// <returns>The ocupped space in the garde by the plants.</returns>
        public int EspacioOcupado() {
            int ocupado = 0;

            foreach (Planta plant in this.plantas) {
                ocupado += plant.Tamanio;
            }

            return ocupado;
        }

        /// <summary>
        /// Calculates the ocupped space in the garde by the plants.
        /// </summary>
        /// <returns>The ocupped space in the garde by the plants.</returns>
        public int EspacioOcupado(Planta planta) {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        /// <summary>
        /// Gets the info of the garden as a string.
        /// </summary>
        /// <returns>The info of the garden as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Composicion del Jardín: {Jardin.suelo}");
            data.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
            data.AppendLine("Lista de plantas:");
            foreach (Planta planta in this.plantas) {
                data.AppendLine(planta.ResumenDeDatos());
            }

            return data.ToString();
        }

        #endregion

        #region Operators

        /// <summary>
        /// Overloads the + operator for add a plant into the garden
        /// if not exist and the garden have space yet.
        /// </summary>
        /// <param name="j">Garden to check.</param>
        /// <param name="p">Plant to add into the garden.</param>
        /// <returns>True if can add the plant into the garden, otherwise returns false.</returns>
        public static bool operator +(Jardin j, Planta p) {
            if (!(j is null) && !(p is null)) {
                if (j.EspacioOcupado(p) <= j.espacioTotal) {
                    j.plantas.Add(p);
                    return true;
                }

            }

            return false;
        }

        #endregion

    }
}
