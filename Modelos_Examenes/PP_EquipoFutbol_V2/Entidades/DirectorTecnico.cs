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
    public class DirectorTecnico : Persona {
        private int añosExperiencia;

        #region Builders

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

        public override string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {this.Nombre}");
            data.AppendLine($"Apellido: {this.Apellido}");
            data.AppendLine($"DNI: {this.Dni}");
            data.AppendLine($"Edad: {this.Edad}");
            data.AppendLine($"Experiencia: {this.AñosExperiencia}");

            return base.Mostrar();
        }

        public override bool ValidarAptitud() {
            return this.añosExperiencia > 2 && this.Edad < 65;
        }

        #endregion

    }
}
