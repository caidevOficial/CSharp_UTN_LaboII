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
using System.Threading;

namespace Entidades {

    public delegate void FinalDelegate(string texto);
    public delegate void SimuladoDelegate<U>(U item);

    public class SimuladorDeAtencion<T> {

        #region Events

        public event SimuladoDelegate<T> AvisoDeUso;
        public event FinalDelegate FinDeUso;
        //private Thread nuevoHilo;

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public void SimularVacunacion(object param) {
            if (param.GetType() == typeof(List<T>)) {
                List<T> lista = param as List<T>;
                if (!(lista is null) && lista.Count > 0) {
                    foreach (T item in lista) {
                        if (!(this.AvisoDeUso is null)) {
                            this.AvisoDeUso.Invoke(item);
                            Thread.Sleep(1200);
                        }
                    }

                    if (!(this.FinDeUso is null)) {
                        this.FinDeUso.Invoke("Tarea Terminada!");
                    }
                }
            }
        }

        #endregion
    }
}
