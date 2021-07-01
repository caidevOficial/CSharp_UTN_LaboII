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
using System.Text;

namespace ComiqueriaLogic {
    
    [Serializable]
    public class Producto {

        #region Attributes

        private int stock;
        private double precio;
        private int codigo;
        private string descripcion;

        #endregion

        #region Builders

        /// <summary>
        /// Basic constructor for serialize.
        /// </summary>
        public Producto() {

        }

        /// <summary>
        /// Constructor. Inicializa los atributos del producto. 
        /// </summary>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="stock">Stock disponible del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        public Producto(string descripcion, int stock, double precio) : this() {
            this.Stock = stock;
            this.Precio = precio;
            this.Descripcion = descripcion;
        }

        /// <summary>
        /// Constructor. Inicializa los atributos del producto. 
        /// </summary>
        /// <param name="codigo">Codigo único (PK) del producto en la base de datos.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="stock">Stock disponible del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        public Producto(int codigo, string descripcion, int stock, double precio)
            : this(descripcion, stock, precio) {
            this.codigo = codigo;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Stock del producto. Debe ser mayor a cero. 
        /// </summary>
        public int Stock {
            get => this.stock;
            set {
                if (value >= 0) {
                    this.stock = value;
                }
            }
        }

        /// <summary>
        /// Precio del producto. Debe ser mayor a 1. 
        /// </summary>
        public double Precio {
            get => this.precio;
            set {
                if (value > 0) {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Descripción del producto. 
        /// </summary>
        public string Descripcion {
            get => this.descripcion;
            set {
                this.descripcion = value;
            }
        }

        /// <summary>
        /// Código del producto en la base de datos (PK). 
        /// </summary>
        public int Codigo {
            get => this.codigo;
            set {
                if(value > 0) {
                    this.codigo = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Devuelve un string con los datos de un producto: código, descripción, precio y stock. 
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine(String.Format("Código: {0}", this.Codigo));
            data.AppendLine(String.Format("Descripción: {0}", this.Descripcion));
            data.AppendLine(String.Format("Precio: ${0:0.00}", this.Precio));
            data.AppendLine(String.Format("Stock: {0} unidades", this.Stock));

            return data.ToString();
        }

        #endregion

    }
}
