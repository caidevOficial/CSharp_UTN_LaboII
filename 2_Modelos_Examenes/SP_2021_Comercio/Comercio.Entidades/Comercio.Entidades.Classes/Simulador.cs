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

namespace Entidades {

    public delegate void Simular(Cliente customer);

    public class Simulador {

        #region Attributes

        private Random rd;
        private int atendidos;
        private int sinAtender;
        private Comercio simuComercio;
        private Thread atenciones;
        public event Simular SimularAtencion;

        #endregion

        #region Builders

        /// <summary>
        /// Constructor con comercio por parametro.
        /// </summary>
        /// <param name="comercio">Comercio para asociar al de esta clase.</param>
        public Simulador(Comercio comercio) {
            this.simuComercio = comercio;
            this.atendidos = 0;
            this.sinAtender = simuComercio.Clientes.Count;
        }

        #endregion

        /// <summary>
        /// Empieza la simulacion de los clientes.
        /// </summary>
        public void EmpezarSimulacion() {
            try {
                atenciones = new Thread(SimularLaAtencion);
                atenciones.Start();
            } catch (SinClientesException exe) {
                throw new SinClientesException(exe.Message, exe);
            }
        }

        /// <summary>
        /// Inicia la secuencia de simulacion de llamado de clientes.
        /// </summary>
        public void SimularLaAtencion() {
            try {
                rd = new Random();
                for (int cliente = 0; cliente <= this.sinAtender; cliente++) {
                    Cliente clienteActual = this.simuComercio.LlamarCliente();
                    this.SimularAtencion.Invoke(clienteActual);
                    int numRandom = rd.Next(0, 2);
                    if (numRandom == 1) {
                        this.sinAtender -= 1;
                        this.atendidos += 1;
                    }
                    Thread.Sleep(2000);
                }
            } catch (SinClientesException sc) {
                throw new SinClientesException("No hay mas clientes.", sc);
            }
        }

        /// <summary>
        /// Gets: Clientes atendidos al momento.
        /// </summary>
        /// <returns>Cantidad de clientes atendidos al momento</returns>
        public int GetAtendidos() {
            return this.atendidos;
        }

        /// <summary>
        /// Gets: Clientes sin atender al momento.
        /// </summary>
        /// <returns>Cantidad de clientes sin atender al momento.</returns>
        public int GetSinAtender() {
            return this.sinAtender;
        }

        /// <summary>
        /// Gets: Estado booleano que indica si el thread esta vivo o no.
        /// </summary>
        /// <returns>True si el thread esta vivo, sino false.</returns>
        public Thread SimuThread() {
            return this.atenciones;
        }
    }
}
