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
    public sealed class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        #region Builders

        /// <summary>
        /// Builds the entity with all its parameters and sets the type of glass by default value.
        /// </summary>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = Botella.Tipo.Vidrio;
        }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="tipo">Type of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : this(capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        protected string GenerarInforme()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.ToString());
            data.Append($"Tipo: {this.tipo}.\n");
            data.Append($"Medida: {MEDIDA}.\n");

            return data.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            if (MEDIDA <= this.Contenido)
            {
                this.Contenido = (int)(this.Contenido - MEDIDA * 0.8);
            }
            else if (MEDIDA > this.Contenido)
            {
                this.Contenido -= this.Contenido;
            }

            return this.Contenido;
        }

        #endregion

        #region Operator

        /// <summary>
        /// Shows the type of the bottle.
        /// </summary>
        /// <param name="cerveza">Beer class to check its type.</param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        #endregion
    }
}
