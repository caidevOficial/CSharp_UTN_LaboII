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

using Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes.SubClasses
{
    public class Villano : Personaje
    {
        private bool maximoPoder;
        private EOrigen origen;

        #region Builders

        public Villano(string nombre, int nivelPoder, List<EHabilidades> ataques, EOrigen origen, bool maximoPoder)
            : base(nombre, nivelPoder, ataques)
        {
            this.origen = origen;
            this.maximoPoder = maximoPoder;
        }

        #endregion

        #region Properties

        protected override string Descripcion
        {
            get => "No estas a mi altura!";
        }

        public string Mensaje
        {
            get => this.Descripcion;
        }

        public bool MaximoPoder
        {
            get => this.maximoPoder;
            set
            {
                this.maximoPoder = value;
            }
        }

        public int PowerLevel
        {
            get => this.nivelPoder;
        }

        #endregion

        #region Methods

        public override string InfoPersonaje()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.InfoPersonaje());
            data.AppendLine($"Al Maximo: {this.maximoPoder}");
            data.AppendLine($"Origen: {this.origen}");

            return data.ToString();
        }

        public override string Transformarse()
        {
            if (!maximoPoder)
            {
                this.nivelPoder *= 2;
                return "Poder aumentado al máximo";
            }

            return "El poder ya esta al límite";
        }

        #endregion
    }
}
