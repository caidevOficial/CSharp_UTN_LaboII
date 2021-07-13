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
using System.Text;

namespace Entidades {
    public sealed class Jugador : Persona {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region Builders

        /// <summary>
        /// Builds the entity with name, surname, age and dni.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="apellido">Surname of the entity.</param>
        /// <param name="edad">Age of the entity.</param>
        /// <param name="dni">Dni of the entity.</param>
        /// <param name="peso">Weigth of the entity</param>
        /// <param name="altura">Heigth of the entity.</param>
        /// <param name="posicion">Position of the entity.</param>
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            : base(nombre, apellido, edad, dni) {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the height
        /// </summary>
        public float Altura {
            get => this.altura;
        }

        /// <summary>
        /// Gets the weight
        /// </summary>
        public float Peso {
            get => this.peso;
        }

        /// <summary>
        /// Gets the position
        /// </summary>
        public Posicion Posicion {
            get => this.posicion;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the info of the entity as a string.
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public override string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.Append(base.Mostrar());
            data.AppendLine($"Altura: {this.Altura}");
            data.AppendLine($"Peso: {this.Peso}");
            data.AppendLine($"Posicion: {this.Posicion}");
            data.AppendLine("==================#");

            return data.ToString();
        }

        /// <summary>
        /// Validates if the age is under 40.
        /// </summary>
        /// <returns>True if is valid, otherwise returns false.</returns>
        public override bool ValidarAptitud() {
            return this.Edad < 40;
        }

        /// <summary>
        /// Validates if its phisic state is correct.
        /// </summary>
        /// <returns>True if is valid, otherwise returns false.</returns>
        public bool ValidarEstadoFisico() {
            double imc = (this.peso / Math.Pow(this.altura, 2));
            return imc <= 25 && imc > 18.5;
        }

        #endregion
    }
}
