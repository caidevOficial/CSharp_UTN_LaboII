﻿/*
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

namespace Clases {
    public sealed class Negocio {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #region Enumerators

        /// <summary>
        /// 
        /// </summary>
        public Cliente Clientes {
            get { return clientes.Dequeue(); }
            set { bool rtn = this + value; }
        }

        #endregion

        #region Builders

        /// <summary>
        /// 
        /// </summary>
        private Negocio() {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        public Negocio(string nombre) : this() {
            this.nombre = nombre;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Trata de Agregar un cliente a la cola de la tienda.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns>True si puede agregarlo, sino false.</returns>
        public static bool operator +(Negocio n, Cliente c) {
            if (n != c) {
                n.clientes.Enqueue(c);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Compara si un cliente ya esta agregado a la fila de la tienda (según su numero).
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns>True si ya existe en la fila, sino false.</returns>
        public static bool operator ==(Negocio n, Cliente c) {
            if (n.clientes.Count > 0) {
                foreach (Cliente cliente in n.clientes) {
                    if (cliente == c) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Compara si un cliente no esta agregado a la fila de la tienda (según su numero).
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns>True si no existe en la fila, sino false.</returns>
        public static bool operator !=(Negocio n, Cliente c) {
            return !(n == c);
        }

        /// <summary>
        /// Atiende un cliente y los aca de la fila.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>True al terminar el tiempo.</returns>
        public static bool operator ~(Negocio n) {
            return n.caja.Atender(n.clientes.Dequeue());
        }

        #endregion
    }
}
