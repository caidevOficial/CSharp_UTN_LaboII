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
    public class Caballo : Animal
    {
        private bool corredor;

        #region Builders

        public Caballo(string nombre, int kilosAlimento, bool corredor)
            : base(nombre, kilosAlimento)
        {
            this.corredor = corredor;
        }

        #endregion

        #region Properties

        public override bool ComePasto { get => true; }

        public override bool ComeBalanceado { get => false; }

        #endregion

        #region Methods

        public override string Datos()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.Datos());
            if (this.corredor)
            {
                data.Append("Es de carrera SI");
            }
            else
            {
                data.Append("Es de carrera NO");
            }

            return data.ToString();
        }

        #endregion
    }
}
