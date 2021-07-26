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
using System.Collections.Generic;
using System.Text;
using Exceptions;

namespace Models {

    public delegate void EventDelegatePrice(object sender, EventArgs e);

    public class Caja<T> where T : Producto {

        #region Attributes

        protected int capacidad;
        protected List<T> elementos;
        public event EventDelegatePrice EventoPrecio;

        #endregion

        #region Builders

        /// <summary>
        /// 
        /// </summary>
        public Caja() {
            this.elementos = new List<T>();
        }

        public Caja(int capacidad) : this() {
            this.capacidad = capacidad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: the path of the file.
        /// </summary>
        public string Path {
            get {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\";
                string fileName = "facturas.log";
                string absPath = $"{path}{fileName}";

                return absPath;
            }
        }

        public List<T> Elementos {
            get => this.elementos;
        }

        /// <summary>
        /// Gets the total amount of the entity.
        /// </summary>
        public float PrecioTotal {
            get {
                float total = 0;
                foreach (T item in this.Elementos) {
                    total += item.Precio;
                }

                return total;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Tries to add a product into the list if the list not reach the maximun capacity.
        /// </summary>
        /// <param name="caja">Entity to add the product.</param>
        /// <param name="p">Product to add into the lsit.</param>
        /// <returns>The entity with or without the product.</returns>
        public static Caja<T> operator +(Caja<T> caja, Producto p) {
            const int LIMIT_PRICE = 120;
            if (!(caja is null) && !(p is null)) {
                if (caja.PrecioTotal > LIMIT_PRICE && !(caja.EventoPrecio is null)) {
                    caja.EventoPrecio.Invoke(caja, EventArgs.Empty);
                }
                if (caja.capacidad > caja.Elementos.Count) {
                    caja.Elementos.Add((T)p);

                    return caja;
                } else {
                    throw new CajaLlenaException("La caja no puede recibir mas productos");
                }
            }

            return caja;
        }



        #endregion

        #region Methods

        /// <summary>
        /// Gets the full info of the entity.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            string basicData = string.Format($"Type: {this.GetType().Name} - Capacity: {this.capacidad} - Occuped: {this.Elementos.Count} - Amount: ${this.PrecioTotal}");
            data.AppendLine(basicData);
            foreach (Producto item in this.Elementos) {
                data.Append(item);
            }
            return data.ToString();
        }

        #endregion
    }
}
