﻿/*
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

using System.Text;

namespace Entidades {
    public abstract class Animal {
        private int kilosAlimentos;
        private string nombre;

        #region Builder

        /// <summary>
        /// Builds the entity with the name and volume of food that eats.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="volumen">Volume of food that eats</param>
        public Animal(string nombre, int volumen) {
            this.kilosAlimentos = volumen;
            this.nombre = nombre;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the kilos of food that eats the entity.
        /// </summary>
        public int KilosAlimento {
            get => this.kilosAlimentos;
        }

        /// <summary>
        /// Gets the boolean state if eat grass or not.
        /// </summary>
        public abstract bool ComePasto { get; }

        /// <summary>
        /// Gets the boolean state if eats balanced food or not.
        /// </summary>
        public abstract bool ComeBalanceado { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the data of the entity as a string.
        /// </summary>
        /// <returns>The data of the entity as a string.</returns>
        public virtual string Datos() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{this.nombre} come {this.KilosAlimento}kg");
            if (this.ComeBalanceado) {
                data.AppendLine("Consume Balanceado SI");
            } else {
                data.AppendLine("Consume Balanceado NO");
            }

            if (this.ComePasto) {
                data.AppendLine("Come Pasto SI");
            } else {
                data.AppendLine("Come Pasto NO");
            }

            return data.ToString();
        }

        #endregion

    }
}
