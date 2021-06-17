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

namespace Models {
    public delegate bool DelegadoCajero(Persona persona);
    public class Cajero {

        #region Attributes

        private List<Thread> hiloCajas;
        private static Queue<Persona> personas;

        #endregion

        #region Builders

        public Cajero() {
            this.hiloCajas = new List<Thread>();
            personas = new Queue<Persona>();
        }

        #endregion

        #region Properties

        public static Queue<Persona> Personas {
            get => personas;
        }

        #endregion

        #region Methods

        public void Cobrar(Cajero cajero, Persona persona) {
            float montoFatura = 0;
            foreach (Factura item in persona.Facturas) {
                montoFatura += item.Precio;
            }
            persona.MontoTotal = montoFatura;

            Thread nuevoHilo = new Thread(persona.MockClicCajero);
            cajero.hiloCajas.Add(nuevoHilo);
            nuevoHilo.Start();
        }

        public void CerrarCajero() {
            foreach (Thread item in this.hiloCajas) {
                if (item.IsAlive) {
                    item.Abort();
                }
            }
        }

        #endregion
    }
}
