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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {

    public abstract class Producto {

        private string tipo;
        private string marca;
        private float precio;

        public Producto() { }

        public Producto(string tipo, string marca, float precio) {
            this.Tipo = tipo;
            this.Marca = marca;
            this.Precio = precio;
        }

        /// <summary>
        /// Gets:Sets the type.
        /// </summary>
        public string Tipo {
            get => this.tipo;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.tipo = value;
                }
            }
        }

        /// <summary>
        /// Gets:Sets the Brand.
        /// </summary>
        public string Marca {
            get => this.marca;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.marca = value;
                }
            }
        }

        /// <summary>
        /// Gets:Sets the price.
        /// </summary>
        public float Precio {
            get => this.precio;
            set {
                if (value > 0) {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Gets the data of the product.
        /// </summary>
        /// <returns>Data of the product as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine(String.Format("{0,10} - {1,10} - ${2,5}", this.Tipo, this.Marca, this.Precio));

            return data.ToString();
        }
    }
}
