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

namespace ComiqueriaLogic {
    
    [Serializable]
    public sealed class Venta {

        #region Attributes

        private static int porcentajeIva;
        private DateTime fecha;
        private Producto producto;
        private double precioFinal;
        private int cantidad;

        #endregion

        #region Builders

        /// <summary>
        /// Inicializará el porcentaje de IVA que se aplicará sobre las ventas.
        /// </summary>
        static Venta() {
            Venta.porcentajeIva = 21;
        }

        /// <summary>
        /// Constructor para serializar.
        /// </summary>
        public Venta() {

        }

        /// <summary>
        /// Constructor de una venta.
        /// </summary>
        /// <param name="producto">Producto vendido.</param>
        /// <param name="cantidad">Cantidad vendida del producto.</param>
        internal Venta(Producto producto, int cantidad) : this() {
            this.Cantidad = cantidad;
            this.Producto = producto;
            this.Vender(Cantidad);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Porcentaje de IVA aplicado sobre las ventas.
        /// </summary>
        public static int PorcentajeIva {
            get => Venta.PorcentajeIva;
            set {
                Venta.PorcentajeIva = porcentajeIva;
            }
        }

        /// <summary>
        /// Cantidad vendida del producto.
        /// </summary>
        private int Cantidad {
            get => this.cantidad;
            set {
                if (value > 0) {
                    this.cantidad = value;
                }
            }
        }

        /// <summary>
        /// Producto que fue vendido.
        /// </summary>
        public Producto Producto {
            get => this.producto;
            set {
                if (value.GetType() == typeof(Producto)) {
                    this.producto = value;
                }
            }
        }

        /// <summary>
        /// Fecha de la venta. 
        /// </summary>
        internal DateTime Fecha {
            get => this.fecha;
            set {
                if (value.GetType() == typeof(DateTime)) {
                    this.fecha = value;
                }
            }
        }

        /// <summary>
        /// Precio final de la venta. 
        /// </summary>
        public double PrecioFinal {
            get => this.precioFinal;
            set {
                if (value > 0) {
                    this.precioFinal = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Método privado que inicializa y calcula las propiedades de la venta.
        /// </summary>
        /// <param name="cantidad"></param>
        private void Vender(int cantidad) {
            producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }

        /// <summary>
        /// Calcula el precio final de la venta aplicando los impuestos.
        /// </summary>
        /// <param name="precioUnidad">Precio unitario del producto vendido.</param>
        /// <param name="cantidad">Cantidad de productos vendidos.</param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad) {
            double precioSinIva = precioUnidad * cantidad;
            return precioSinIva + precioSinIva * Venta.porcentajeIva / 100;
        }

        /// <summary>
        /// Devuelve un breve texto describiendo los datos más importantes de la venta.
        /// </summary>
        /// <returns></returns>
        public string ObtenerDescripcionBreve() {
            return String.Format("{0} - {1} - {2}", this.fecha, this.producto.Descripcion, this.precioFinal.FormatearPrecio());
        }

        #endregion

    }
}
