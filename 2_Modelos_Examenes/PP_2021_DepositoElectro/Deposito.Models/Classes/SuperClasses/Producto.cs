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

using Enums;
using System;
using System.Text;

namespace Models {
    public abstract class Producto {

        #region Attributes

        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected string modelo;
        protected double precio;

        #endregion

        #region Builders

        private Producto() {
            Producto.generadorDePrecios = new Random();
        }

        /// <summary>
        /// Creates the instance with model and manufacturer.
        /// </summary>
        /// <param name="modelo">Model of the entity as a string.</param>
        /// <param name="fabricante">Manufacturer of the entity.</param>
        public Producto(string modelo, Fabricante fabricante) : this() {
            this.modelo = modelo;
            this.fabricante = fabricante;
        }

        /// <summary>
        /// Creates the instance with model and manufacturer.
        /// </summary>
        /// <param name="modelo">Model of the entity as a string.</param>
        /// <param name="fabricante">Manufacturer of the entity.</param>
        /// <param name="pais">???</param>
        public Producto(string modelo, string marca, EPais pais)
            : this(modelo, new Fabricante(marca, pais)) {

        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the price of the entity, if the price is 0, this property
        /// will generate a random value between 10.5K & 125K and then will
        /// return it.
        /// </summary>
        public double Precio {
            get {
                if (this.precio == 0) {
                    this.precio = generadorDePrecios.Next(10500, 125000);
                }
                return this.precio;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Shows the info of the product as a sitrng.
        /// </summary>
        /// <param name="p">Product to show its info.</param>
        public static explicit operator string(Producto p) {
            return Producto.Mostrar(p);
        }

        /// <summary>
        /// Compares if both products are equals bassed on its models
        /// and manufacturers
        /// </summary>
        /// <param name="a">First Entity to comare.</param>
        /// <param name="b">Second Entity to comare.</param>
        /// <returns>True if both entities are equals, otherwise returns false.</returns>
        public static bool operator ==(Producto a, Producto b) {
            if (!(a is null) && !(b is null)) {
                return a.modelo.Equals(b.modelo) && a.fabricante == b.fabricante;
            }

            return false;
        }

        /// <summary>
        /// Compares if both products aren't equals bassed on its models
        /// and manufacturers
        /// </summary>
        /// <param name="a">First Entity to comare.</param>
        /// <param name="b">Second Entity to comare.</param>
        /// <returns>True if both entities aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Producto a, Producto b) {
            return !(a == b);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the info of the product as a sitrng.
        /// </summary>
        /// <param name="a">Product to show its info.</param>
        /// <returns>The info of the product as a string</returns>
        private static string Mostrar(Producto a) {
            StringBuilder data = new StringBuilder();
            data.Append($"Fabricante: {(string)a.fabricante}");
            data.AppendLine($"Modelo: {a.modelo}");
            data.AppendLine($"Precio: {a.precio}");

            return data.ToString();
        }

        #endregion
    }
}
