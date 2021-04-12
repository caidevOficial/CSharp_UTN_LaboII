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

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroOrigen;
        protected string nroDestino;

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public float Duracion { get => duracion; }

        /// <summary>
        /// 
        /// </summary>
        public string NroOrigen { get => nroOrigen; }

        /// <summary>
        /// 
        /// </summary>
        public string NroDestino { get => nroDestino; }

        #endregion

        #region Builders

        public Llamada(float duracion, string nroOrigen, string nroDestino)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Compares the duration of both calls.
        /// </summary>
        /// <param name="call1">First call to compare.</param>
        /// <param name="call2">Second call to compare.</param>
        /// <returns></returns>
        public int OrdenarPorDuracion(Llamada call1, Llamada call2)
        {
            return call1.Duracion.CompareTo(call2.Duracion);
        }

        /// <summary>
        /// Shows the data of the call.
        /// </summary>
        /// <returns>The data of the call as a string.</returns>
        public virtual string Mostrar()
        {
            StringBuilder data = new StringBuilder();
            data.Append($"Origen {this.NroOrigen}.\n");
            data.Append($"Destino {this.NroDestino}.\n");
            data.Append($"Duracion {this.Duracion}.\n");

            return data.ToString();
        }

        #endregion
    }
}
