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

using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        #region Properties

        /// <summary>
        /// Get: Gets the profits of the local calls.
        /// </summary>
        public float GananciasPorLocal
        {
            get => CalcularGanancias(Llamada.TipoLlamada.Local);
        }

        /// <summary>
        /// Get: Gets the profits of the province calls.
        /// </summary>
        public float GananciasPorProvincial
        {
            get => CalcularGanancias(Llamada.TipoLlamada.Provincial);
        }

        /// <summary>
        /// Get: Gets the profits of the total calls.
        /// </summary>
        public float GananciasPorTotal
        {
            get => CalcularGanancias(Llamada.TipoLlamada.Todas);
        }

        /// <summary>
        /// Get: Gets all the calls.
        /// </summary>
        public List<Llamada> Llamadas { get => listaDeLlamadas; }

        #endregion

        #region Builders

        /// <summary>
        /// Builds and initialize the List of the entity.
        /// </summary>
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        /// <summary>
        /// /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="nombreEmpresa">Name of the enterprice</param>
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculate the profits of the enterprise.
        /// </summary>
        /// <param name="tipoLlamada">Type of the call.</param>
        /// <returns>Returns the profits of the calls.</returns>
        private float CalcularGanancias(Llamada.TipoLlamada tipoLlamada)
        {
            float profits = 0;
            foreach (Llamada call in listaDeLlamadas)
            {
                switch (tipoLlamada)
                {
                    case Llamada.TipoLlamada.Local:
                        if (call is Local)
                        {
                            profits += ((Local)call).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (call is Provincial)
                        {
                            profits += ((Provincial)call).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (call is Provincial)
                        {
                            profits += ((Provincial)call).CostoLlamada;
                        }
                        else if (call is Local)
                        {
                            profits += ((Local)call).CostoLlamada;
                        }
                        break;
                }
            }

            return profits;

        }

        /// <summary>
        /// Sorts the calls of the list.
        /// </summary>
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder data = new StringBuilder();
            data.Append($"Razon Social: {this.razonSocial}.\n");
            data.Append($"Costo Total Local: {this.GananciasPorLocal}.\n");
            data.Append($"Costo Total Provincial: {this.GananciasPorProvincial}.\n");
            data.Append($"Costo Total Llamadas: {this.GananciasPorTotal}.\n");
            data.Append("Llamadas:\n");
            foreach (Llamada call in Llamadas)
            {
                data.Append(call.Mostrar());
                data.Append("________________________________________________________________\n");
            }


            return data.ToString();
        }

        #endregion

    }
}
