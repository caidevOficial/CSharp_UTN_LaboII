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
 */using System;
using System.Text;

namespace Entidades {

    [Serializable]
    public class Paciente {

        #region Attributes

        private int turno;
        private string nombre;
        private string apellido;

        #endregion

        #region Properties

        /// <summary>
        /// GETS/SETS: El numero de turno.
        /// </summary>
        public int Turno {
            get => this.turno;
            set {
                if (value > 0) {
                    this.turno = value;
                }
            }
        }

        /// <summary>
        /// GETS/SETS: El nombre del paciente.
        /// </summary>
        public string Nombre {
            get => this.nombre;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// GETS/SETS: El Apellido del paciente.
        /// </summary>
        public string Apellido {
            get => this.apellido;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.apellido = value;
                }
            }
        }

        #endregion

        #region Builder

        public Paciente() { }

        /// <summary>
        /// Constructor con turno, nombre y apellido.
        /// </summary>
        /// <param name="turno">Turno del paciente.</param>
        /// <param name="nombre">Nombre del paciente.</param>
        /// <param name="apellido">Apellido del paciente.</param>
        public Paciente(int turno, string nombre, string apellido) : this() {
            this.Turno = turno;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retorna el apellido y nombre del paciente.
        /// </summary>
        /// <returns>El apellido y nombre del paciente como un string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.Append($"{this.Apellido}, {this.Nombre}");

            return data.ToString();
        }

        #endregion
    }
}
