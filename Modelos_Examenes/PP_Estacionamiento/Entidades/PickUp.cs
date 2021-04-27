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

using System;
using System.Text;

namespace Entidades {
    public class PickUp : Vehiculo {

        private string modelo;
        private static int valorHora;

        #region Builders

        static PickUp() {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base(patente) {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora)
            : this(patente, modelo) {
            PickUp.valorHora = valorHora;
        }

        #endregion

        #region Methods

        public override string ConsultarDatos() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Tipo: {this.GetType().Name}");
            data.AppendLine($"{base.ToString()}");
            data.AppendLine($"Modelo: {this.modelo}");

            return data.ToString();
        }

        public override bool Equals(object obj) {
            return this.GetType() == obj.GetType();
        }

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
