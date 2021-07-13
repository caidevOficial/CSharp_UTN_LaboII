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

using System.Text;

namespace Entidades {
    public sealed class DirectorTecnico : Persona {
        private int añosExperiencia;

        #region Builders

        /// <summary>
        /// Builds the entity with name, surname, age and dni.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="apellido">Surname of the entity.</param>
        /// <param name="edad">Age of the entity.</param>
        /// <param name="dni">Dni of the entity.</param>
        /// <param name="añosExperiencia">Years of experience as a DT</param>
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
            : base(nombre, apellido, edad, dni) {
            this.añosExperiencia = añosExperiencia;
        }

        #endregion

        #region Properties

        public int AñosExperiencia {
            get => this.añosExperiencia;
            set {
                if (value >= 0) {
                    this.añosExperiencia = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the info of the entity as a string.
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public override string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {this.Nombre}");
            data.AppendLine($"Apellido: {this.Apellido}");
            data.AppendLine($"DNI: {this.Dni}");
            data.AppendLine($"Edad: {this.Edad}");
            data.AppendLine($"Experiencia: {this.AñosExperiencia}");

            return base.Mostrar();
        }

        /// <summary>
        /// Validates if is a valid DT.
        /// </summary>
        /// <returns>True if is valid, otherwise returns false.</returns>
        public override bool ValidarAptitud() {
            return this.añosExperiencia > 2 && this.Edad < 65;
        }

        #endregion

    }
}
