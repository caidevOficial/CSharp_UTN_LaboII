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

using Audio;
using System.Threading;

namespace Entidades {
    public class GolDelSiglo {

        private Thread hiloRelato;

        /// <summary>
        /// Cierra la app y termina los hilos en caso de estar activos.
        /// </summary>
        public void CerrarApp() {
            if (!(hiloRelato is null) && hiloRelato.IsAlive) {
                hiloRelato.Abort();
            }
        }

        /// <summary>
        /// Inicia la app y el hilo de audio en caso de no estar activos, 
        /// sino tira una excepcion.
        /// </summary>
        public void IniciarJugada() {
            if (!(hiloRelato is null) && hiloRelato.IsAlive) {
                throw new JugadaActivaException();
            } else {
                hiloRelato = new Thread(Relato.VictorHugoMorales);
                hiloRelato.Start();
            }
        }
    }
}
