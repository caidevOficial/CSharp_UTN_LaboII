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

using System.Text;

namespace Library {
    public class Estante {
        private Producto[] productos;
        private int ubicacionEstante;

        #region Builders

        /// <summary>
        /// Sets the capacity of the array of products.
        /// </summary>
        /// <param name="capacidad">capacity of the array.</param>
        private Estante(int capacidad) {
            this.productos = new Producto[capacidad];
        }

        /// <summary>
        /// Builds the entity with two params.
        /// </summary>
        /// <param name="capacidad">capacity of the array.</param>
        /// <param name="ubicacionEstante">Ubication of the products.</param>
        public Estante(int capacidad, int ubicacionEstante) : this(capacidad) {
            this.ubicacionEstante = ubicacionEstante;
        }

        #endregion

        #region Get&Set

        /// <summary>
        /// Gets all the Products of the entity.
        /// </summary>
        /// <returns>An array with all the products of the entity.</returns>
        public Producto[] GetProductos() {
            return this.productos;
        }

        #endregion

        #region Operators

        #region Comparators

        /// <summary>
        /// Checks if the product is in the Shelf.
        /// </summary>
        /// <param name="e">Shelf to check.</param>
        /// <param name="p">Product to check.</param>
        /// <returns>True if the product is in the Shelf, otherwise returns false.</returns>
        public static bool operator ==(Estante e, Producto p) {
            foreach (Producto item in e.GetProductos()) {
                if (item == p) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the product isn't in the Shelf.
        /// </summary>
        /// <param name="e">Shelf to check.</param>
        /// <param name="p">Product to check.</param>
        /// <returns>True if the product isn't in the Shelf, otherwise returns false.</returns>
        public static bool operator !=(Estante e, Producto p) {
            return !(e == p);
        }

        #endregion

        #region Addition&Substraction

        /// <summary>
        /// Checks if can add a product in the Shelf.
        /// </summary>
        /// <param name="e">Shelf to check.</param>
        /// <param name="p">Product to add in the Shelf</param>
        /// <returns>True if can add the product, otherwise returns false.</returns>
        public static bool operator +(Estante e, Producto p) {
            if (e != p) {
                for (int i = 0; i < e.productos.Length; i++) {
                    if (e.GetProductos()[i] is null) {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the product is on the shelf, if it is, it will remove it.
        /// </summary>
        /// <param name="e">Shelf to check.</param>
        /// <param name="p">Product to remove if is in the shelf.</param>
        /// <returns>The shelf without the product.</returns>
        public static Estante operator -(Estante e, Producto p) {
            if (e == p) {
                for (int i = 0; i < e.GetProductos().Length; i++) {
                    if (e.GetProductos()[i] == p) {
                        e.GetProductos()[i] = null;
                    }
                }

            }

            return e;
        }

        #endregion

        #region Methods

        /// <summary>
        ///  Make a string with the description of the attributes of the entity.
        /// </summary>
        /// <param name="e">Entity to return its description.</param>
        /// <returns>A message with the description of the entity.</returns>
        public static string MostrarEstante(Estante e) {
            StringBuilder message = new StringBuilder();
            foreach (Producto item in e.GetProductos()) {
                if (!(item is null)) {
                    message.Append(Producto.MostrarProducto(item));
                }
            }

            return message.ToString();
        }

        #endregion

        #endregion
    }
}
