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
    public class Campo {
        private int alimentoDisponible;
        private List<Animal> animales;
        private static Tipo servicio;

        public enum Tipo {
            Pastoreo,
            Engorde
        }

        #region Builders

        /// <summary>
        /// Initializes the type of countryside
        /// </summary>
        static Campo() {
            Campo.servicio = Tipo.Pastoreo;
        }

        /// <summary>
        /// Builds the entity and instances the list of animals.
        /// </summary>
        private Campo() {
            animales = new List<Animal>();
        }

        /// <summary>
        /// Builds the entity with the amount of food and instances 
        /// the list of animals.
        /// </summary>
        /// <param name="alimento">Amount of food.</param>
        public Campo(int alimento)
            : this() {
            this.alimentoDisponible = alimento;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Sets the service's type of the countryside.
        /// </summary>
        public Tipo TipoServicio {
            set {
                Campo.servicio = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the amount of food needed for the animals.
        /// </summary>
        /// <returns>The amount of food needed for the animals.</returns>
        private int AlimentoComprometido() {
            int cantidad = 0;
            foreach (Animal item in this.animales) {
                cantidad += item.KilosAlimento;
            }

            return cantidad;
        }

        /// <summary>
        /// Calculates the amount of food needed for the animals
        /// and the needed for this animal.
        /// </summary>
        /// <returns>The amount of food needed for the animals and the animal passed by parameter.</returns>
        private int AlimentoComprometido(Animal animal) {
            return AlimentoComprometido() + animal.KilosAlimento;
        }

        /// <summary>
        /// Retrieves the info of the countryside.
        /// </summary>
        /// <returns>the info of the countryside as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Servicio del campo {Campo.servicio}");
            data.AppendLine($"Alimento Comprometido {this.AlimentoComprometido()} de {this.alimentoDisponible}");
            data.AppendLine("Lista de animales:");
            foreach (Animal item in this.animales) {
                data.AppendLine(item.Datos());
            }

            return data.ToString();
        }

        #endregion

        #region Operators

        /// <summary>
        /// Overloads the operator + to add an animal inside 
        /// the countryside if not exist yet.
        /// </summary>
        /// <param name="c">Countryside to verificate the animal.</param>
        /// <param name="a">Animal to add in the countryside.</param>
        /// <returns>True if can add the animal, otherwise returns false.</returns>
        public static bool operator +(Campo c, Animal a) {
            if (!(c is null) && !(a is null)) {
                if (c.AlimentoComprometido(a) <= c.alimentoDisponible) {
                    c.animales.Add(a);
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
