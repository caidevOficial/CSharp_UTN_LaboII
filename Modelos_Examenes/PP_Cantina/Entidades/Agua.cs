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
    public sealed class Agua : Botella
    {
        private const int MEDIDA = 400;

        #region Builder

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="capacidadML">Capacity of the bottle.</param>
        /// <param name="marca">Brand of the bottle.</param>
        /// <param name="contenidoML">Content of the bottle.</param>
        public Agua(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML) { }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medida">Content default of the bottle.</param>
        /// <returns></returns>
        public int ServirMedida(int medida)
        {
            if (medida <= this.Contenido)
            {
                this.Contenido -=  medida;
            }
            else if (medida > this.Contenido)
            {
                this.Contenido -= this.Contenido;
            }

            return this.Contenido;
        }

        /// <summary>
        /// Shows the data of the bottle.
        /// </summary>
        /// <returns>the data of the bottle as a string.</returns>
        protected string GenerarInforme()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.ToString());
            data.Append($"Medida: {MEDIDA}.\n");

            return data.ToString();
        }

        #endregion

    }
}
