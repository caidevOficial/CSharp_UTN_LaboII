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

namespace Entidades {
    public class Patente {

        public enum Tipo {
            Vieja,
            Mercosur
        }

        private Tipo tipoCodigo;
        private string codPatente;

        /// <summary>
        /// Default Constructor for xml.
        /// </summary>
        public Patente() { }

        /// <summary>
        /// Constructor with code and type.
        /// </summary>
        /// <param name="codPatente">Code of the entity.</param>
        /// <param name="tipo">Type of the entity.</param>
        public Patente(string codPatente, Tipo tipo) {
            this.CodigoPatente = codPatente;
            this.TipoCodigo = tipo;
        }

        /// <summary>
        /// Gets/Sets: The code.
        /// </summary>
        public string CodigoPatente {
            get => this.codPatente;
            set {
                this.codPatente = value;
            }
        }

        /// <summary>
        /// Gets/Sets: The type of code.
        /// </summary>
        public Tipo TipoCodigo {
            get => this.tipoCodigo;
            set {
                this.tipoCodigo = value;
            }
        }

        /// <summary>
        /// Gets the code of the entity as a string.
        /// </summary>
        /// <returns>The code of the entity as a string.</returns>
        public override string ToString() {
            return this.CodigoPatente;
        }
    }
}
