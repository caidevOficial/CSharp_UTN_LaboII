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
    public sealed class PickUp : Vehiculo {

        private string modelo;
        private static int valorHora;

        #region Builders

        /// <summary>
        /// Creates the entity and sets the cost of the parking for this type of entity.
        /// </summary>
        static PickUp() {
            valorHora = 70;
        }

        /// <summary>
        /// Creates the entity with 2 parameters
        /// </summary>
        /// <param name="patente">Patent of the entity</param>
        /// <param name="modelo">Model of the entity</param>
        public PickUp(string patente, string modelo)
            : base(patente) {
            this.modelo = modelo;
        }

        /// <summary>
        /// Creates the entity with 2 parameters
        /// </summary>
        /// <param name="patente">Patent of the entity</param>
        /// <param name="modelo">Model of the entity</param>
        /// <param name="valorHora">Value per hour</param>
        public PickUp(string patente, string modelo, int valorHora)
            : this(patente, modelo) {
            PickUp.valorHora = valorHora;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the data of the entity as a string.
        /// </summary>
        /// <returns>The data of the entity as a string.</returns>
        public override string ConsultarDatos() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Tipo: {this.GetType().Name}");
            data.AppendLine($"{base.ToString()}");
            data.AppendLine($"Modelo: {this.modelo}");

            return data.ToString();
        }

        /// <summary>
        /// Compares two entities bassed by its type.
        /// </summary>
        /// <param name="obj">Secong object to compare with this.</param>
        /// <returns>True if both are equals, otherwise returns false.</returns>
        public override bool Equals(object obj) {
            return this.GetType() == obj.GetType();
        }

        /// <summary>
        /// Gets the data of the entity and the amount of the parking.
        /// </summary>
        /// <returns>The data of the entity and the amount of the parking as a string.</returns>
        public override string ImprimirTicket() {
            TimeSpan intervaloTiempo = DateTime.Now.Subtract(this.ingreso); //DateTime.Now.Hour - this.ingreso.Hour;
            int costoEstadia = (int)(Math.Round(intervaloTiempo.TotalHours) * PickUp.valorHora);
            StringBuilder data = new StringBuilder();
            data.Append($"Ticket");
            data.Append(this.ConsultarDatos());
            data.AppendLine($"Value: {costoEstadia}");
            data.AppendLine("-------------------------##");

            return data.ToString();
        }

        #endregion
    }
}
