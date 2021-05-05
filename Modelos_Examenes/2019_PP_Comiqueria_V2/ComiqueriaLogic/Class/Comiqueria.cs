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

using ComprobantesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComiqueriaLogic {
    public class Comiqueria {

        #region Attributes

        private List<Producto> productos;
        private List<Venta> ventas;
        static Stack<Comprobante> comprobantes;

        #endregion

        #region Builders

        static Comiqueria() {
            comprobantes = new Stack<Comprobante>();
        }

        /// <summary>
        /// Initialices both list.
        /// </summary>
        public Comiqueria() {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// It will return the product bassed on its Guid if exist, otherwise will return a null.
        /// </summary>
        /// <param name="codigo">Guid Code to compare</param>
        /// <returns>A Product or a null, who knows</returns>
        public Producto this[Guid codigo] {
            get {
                foreach (Producto item in this.productos) {
                    if ((Guid)item == codigo) {
                        return item;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// It will return a list of Comprobantes of the product passed
        /// by parameter.
        /// </summary>
        /// <param name="p">Product to search its Comprobante</param>
        /// <param name="ordenar">Boolear for sort or not.</param>
        /// <returns>A list of Comprobantes of the product</returns>
        public List<Comprobante> this[Producto p, bool ordenar] {
            get {
                List<Comprobante> boletas = new List<Comprobante>();
                foreach (Comprobante item in comprobantes) {
                    if (((Producto)(item.Venta)) == p) {
                        boletas.Add(item);
                    }
                }
                if (ordenar) {
                    boletas.OrderBy(item => item.Venta.Fecha);
                }
                return boletas;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cheks if the product is in the list of the comiqueria, bassed on its descriptcion.
        /// </summary>
        /// <param name="c">An instance of Comiqueria</param>
        /// <param name="p">An instance of Product.</param>
        /// <returns>True if the product exist in the list of products, otherwise returns false</returns>
        public static bool operator ==(Comiqueria c, Producto p) {
            if (!(c is null) && !(p is null)) {
                foreach (Producto item in c.productos) {
                    if (item.Descripcion.Equals(p.Descripcion)) {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Cheks if the product isn't in the list of the comiqueria, bassed on its descriptcion.
        /// </summary>
        /// <param name="c">An instance of Comiqueria</param>
        /// <param name="p">An instance of Product.</param>
        /// <returns>True if the product not exist in the list of products, otherwise returns false</returns>
        public static bool operator !=(Comiqueria c, Producto p) {
            return !(c == p);
        }

        /// <summary>
        /// Cheks if the Comprobante is in the list of the comiqueria.
        /// </summary>
        /// <param name="c">Comiqueria instance</param>
        /// <param name="co">Comprobante to search for</param>
        /// <returns>True if the Comprobante exist in the list of Comprobante, otherwise returns false</returns>
        public static bool operator ==(Comiqueria c, Comprobante co) {
            if (!(c is null) && !(co is null)) {
                foreach (Comprobante item in Comiqueria.comprobantes) {
                    if (item == co) {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Cheks if the Comprobante isn't in the list of the comiqueria.
        /// </summary>
        /// <param name="c">Comiqueria instance</param>
        /// <param name="co">Comprobante to search for</param>
        /// <returns>True if the Comprobante not exist in the list of Comprobante, otherwise returns false</returns>
        public static bool operator !=(Comiqueria c, Comprobante co) {
            return !(c == co);
        }

        /// <summary>
        /// Adds a product to the list of product only if not exist.
        /// </summary>
        /// <param name="c">An instance of Comiqueria</param>
        /// <param name="p">An instance of Product.</param>
        /// <returns>The instance of comiqueria with the product.</returns>
        public static Comiqueria operator +(Comiqueria c, Producto p) {
            if (!(c is null) && !(p is null)) {
                if (c != p) {
                    c.productos.Add(p);
                }
            }
            return c;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Makes the sale of the product with 1 unit by default.
        /// </summary>
        /// <param name="p">Instance of the producto to sell.</param>
        public void Vender(Producto p) {
            Vender(p, 1);
        }

        /// <summary>
        /// Makes the sale of the product with ''cantidad'' units of the entity.
        /// </summary>
        /// <param name="p">Instance of the producto to sell.</param>
        /// <param name="cantidad">Amount of units of producto.</param>
        public void Vender(Producto p, int cantidad) {
            this.ventas.Add(new Venta(p, cantidad));
        }

        /// <summary>
        /// Gets the details of all the sales of the comiqueria.
        /// </summary>
        /// <returns>The details of all the sales of the comiqueria as a string.</returns>
        public string ListarVentas() {
            StringBuilder data = new StringBuilder();
            this.ventas.OrderBy(item => item.Fecha);
            foreach (Venta item in this.ventas) {
                data.Append(item.ObtenerDescripcionBreve());
            }

            return data.ToString();
        }

        /// <summary>
        /// Creates a Dictionary of the Guid of oevery product as a key
        /// and its description as a value of that key.
        /// </summary>
        /// <returns>A dictionary of all the products.</returns>
        public Dictionary<Guid, string> ListarProductos() {
            Dictionary<Guid, string> prodToDict = new Dictionary<Guid, string>();
            foreach (Producto item in this.productos) {
                prodToDict[(Guid)item] = item.Descripcion;
            }

            return prodToDict;
        }

        /// <summary>
        /// Adds a Comprobante into the list of comprobantes if not exist.
        /// </summary>
        /// <param name="c">Comiqueria instance</param>
        /// <param name="co">Comprobante instance</param>
        /// <returns>True if can add the comprobante, otherwise returns false.</returns>
        public bool AgregarComprobante(Comprobante co) {
            if (this != co) {
                Comiqueria.comprobantes.Push(co);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Adds the Comprobante of the sale into the list of comprobantes if not exist.
        /// </summary>
        /// <param name="v">Sale instance</param>
        /// <returns>True if can add the comprobante, otherwise returns false.</returns>
        private bool AgregarComprobante(Venta v) {
            if (this.AgregarComprobante(new Factura(v, Factura.TipoFactura.B))) {
                return true;
            }

            return false;
        }

        #endregion
    }
}
