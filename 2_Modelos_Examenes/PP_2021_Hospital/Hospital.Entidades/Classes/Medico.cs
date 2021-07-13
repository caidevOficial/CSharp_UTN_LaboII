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
    public class Medico : Personal {

        #region Attributes

        protected Especialidad especialidad;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with all its parameters.
        /// </summary>
        /// <param name="apellido">Surname of the entity.</param>
        /// <param name="legajo">Docket number of the entity.</param>
        /// <param name="ingreso">Checkin time of the entity.</param>
        /// <param name="especialidad">Speciality time of the entity.</param>
        public Medico(string apellido, int legajo, DateTime ingreso, Especialidad especialidad)
            : base(apellido, legajo, ingreso) {
            this.especialidad = especialidad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: the speciality.
        /// </summary>
        public Especialidad Especialidad {
            get => this.especialidad;
        }

        /// <summary>
        /// Gets: The information.
        /// </summary>
        public override string Info {
            get => this.ToString();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the surname, docket number and speciality of the entity as a string.
        /// </summary>
        /// <returns>The surname and docket of the entity as a string.</returns>
        protected override string ArmarInfo() {
            StringBuilder data = new StringBuilder();
            data.Append($"DOCTOR - {base.ArmarInfo()}, Especialidad: {this.especialidad}");

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
