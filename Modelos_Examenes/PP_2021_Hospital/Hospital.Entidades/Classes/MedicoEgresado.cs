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

namespace EntidadesRPP {
    public class MedicoEgresado : Medico {

        #region Attributes

        protected DateTime horarioSalida;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity bassed on the entity passed by parameter.
        /// </summary>
        /// <param name="medico">Doctor to extract the data.</param>
        public MedicoEgresado(Medico medico)
            : base(medico.Apellido, medico.Legajo, medico.HorarioEntrada, medico.Especialidad) {
            this.horarioSalida = DateTime.Now;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: the information.
        /// </summary>
        public override string Info {
            get => this.ToString();
        }

        /// <summary>
        /// Gets: the checkout time.
        /// </summary>
        public DateTime Egreso {
            get => this.horarioSalida;
        }

        /// <summary>
        /// Gets: calculates the journal.
        /// </summary>
        public double Jornal {
            get => CalcularJornal();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the salary of the entity.
        /// </summary>
        /// <returns>The Jornal.</returns>
        private double CalcularJornal() {
            TimeSpan diff = this.Egreso - this.HorarioEntrada;
            double diferencia = (diff).TotalSeconds / 60 / 60;

            int monto = 40;
            if (this.Especialidad == Especialidad.Cirujano)
                monto = 90;
            else if (this.Especialidad == Especialidad.Clinico)
                monto = 70;

            return diferencia * monto;
        }

        /// <summary>
        /// Gets the surname, docket number, speciality and jornal salary of the entity as a string.
        /// </summary>
        /// <returns>The surname, docket number, speciality and jornal salary  of the entity as a string.</returns>
        protected override string ArmarInfo() {
            StringBuilder data = new StringBuilder();
            data.Append($"{base.ArmarInfo()} - JORNAL: ${Math.Round(this.Jornal, 2)}");

            return data.ToString();
        }

        /// <summary>
        /// Gets the info of the entity as a string.
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.Append($"{this.ArmarInfo()} - ingreso: {DateTime.Now.ToLongTimeString()}");

            return data.ToString();
        }

        #endregion
    }
}
