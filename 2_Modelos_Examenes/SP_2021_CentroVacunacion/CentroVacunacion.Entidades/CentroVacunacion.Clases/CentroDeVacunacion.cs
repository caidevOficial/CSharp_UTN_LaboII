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
using System.Collections.Generic;

namespace Entidades {

    [Serializable]
    public class CentroDeVacunacion {

        #region Attributes

        private List<Paciente> personas;

        #endregion

        #region Builders

        /// <summary>
        /// Constructor basico.
        /// </summary>
        public CentroDeVacunacion() {
            this.personas = new List<Paciente>();
        }

        /// <summary>
        /// Constructor con una lista de pacientes.
        /// </summary>
        /// <param name="pacientes">Lista de pacientes para agregar a la lista de personas.</param>
        public CentroDeVacunacion(List<Paciente> pacientes) : this() {
            this.personas = new List<Paciente>(pacientes);
        }


        #endregion

        #region Properties

        /// <summary>
        /// GET/SET: List of patients.
        /// </summary>
        public List<Paciente> Pacientes {
            get => this.personas;
            set {
                if (value.GetType() == typeof(List<Paciente>)) {
                    this.personas = value;
                }
            }
        }

        #endregion
    }
}
