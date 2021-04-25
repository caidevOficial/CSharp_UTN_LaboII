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

namespace Entidades
{
    public class QuesoAzul : Ingrediente
    {
        private Procedencia procedencia;

        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }

        #region Builder

        public QuesoAzul(string descripcion, int cantidad)
            : base(descripcion, cantidad) { }

        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia)
            : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }

        #endregion

        #region Properties

        public override string Proceso { get => "Desgranar"; }

        public override string UnidadDeMedida { get => "Gramos"; }

        #endregion

        #region Methods

        public override string Informacion()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.Informacion());
            data.AppendLine($"Procedente de: {this.procedencia}");

            return data.ToString();
        }

        #endregion
    }
}
