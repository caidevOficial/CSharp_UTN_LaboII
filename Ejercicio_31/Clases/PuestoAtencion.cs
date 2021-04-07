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

using System;
using System.Threading;

namespace Clases
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puestoAsignado;

        #region Enumerators

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        #endregion

        #region Properties

        /// <summary>
        /// Incrementa en 1 el numero actual y lo retorna.
        /// </summary>
        public static int NumeroActual
        {
            get
            {
                numeroActual += 1;
                return numeroActual;
            }
        }

        #endregion

        #region Builders

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        /// <summary>
        /// Crea la entidad con el puesto asignado para atencion.
        /// </summary>
        /// <param name="puesto">Enumerador del puesto.</param>
        public PuestoAtencion(Puesto puesto)
        {
            this.puestoAsignado = puesto;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Simulará un tiempo de atención a un cliente.
        /// </summary>
        /// <param name="cli">Cliente que sera atendido.</param>
        /// <returns>True al terminar el tiempo.</returns>
        public bool Atender(Cliente cli)
        {
            int siguiente = PuestoAtencion.NumeroActual;
            Console.WriteLine(siguiente);
            Thread.Sleep(500);

            return true;
        }

        #endregion
    }
}
