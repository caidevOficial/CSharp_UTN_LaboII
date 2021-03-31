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

namespace Library
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        #region Builders

        /// <summary>
        /// Builds the entity Without params.
        /// </summary>
        public Producto()
        {
        }

        /// <summary>
        /// Builds the entity With one param.
        /// </summary>
        /// <param name="codigoDeBarra">Barcode to set.</param>
        public Producto(string codigoDeBarra)
        {
            this.codigoDeBarra = codigoDeBarra;
        }

        /// <summary>
        /// Builds the entity With two params.
        /// </summary>
        /// <param name="codigoDeBarra">Barcode to set.</param>
        /// <param name="marca">Brand to set.</param>
        public Producto(string marca, string codigoDeBarra) : this(codigoDeBarra)
        {
            this.marca = marca;
        }

        /// <summary>
        /// Builds the entity With 3 params.
        /// </summary>
        /// <param name="codigoDeBarra">Barcode to set.</param>
        /// <param name="marca">Brand to set.</param>
        /// <param name="precio">Price to set.</param>
        public Producto(string marca, string codigoDeBarra, float precio) : this(marca, codigoDeBarra)
        {
            this.precio = precio;
        }

        #endregion

        #region Get_&_Set

        /// <summary>
        /// Gets the brans of the entity.
        /// </summary>
        /// <returns>The brand.</returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// Gets the Price of the entity.
        /// </summary>
        /// <returns>The price of the entity.</returns>
        public float GetPrecio()
        {
            return this.precio;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cast a product to string to return its barcode.
        /// </summary>
        /// <param name="product">Product type object to cast.</param>
        public static explicit operator string(Producto product)
        {
            if(product is null)
            {
                return " ";
            }        
            
            return product.codigoDeBarra;
        }

        #region Inequallity

        /// <summary>
        /// Compares if the brand of product1 and the string passed by parameter are differents.
        /// </summary>
        /// <param name="product1">Product to compare.</param>
        /// <param name="marca">String of the brand to compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Producto product1, string marca)
        {
            return !(product1 == marca);
        }

        /// <summary>
        /// Compares if the brand of product1 and product2 are differents.
        /// </summary>
        /// <param name="product1">Product to compare.</param>
        /// <param name="product2">Product to compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Producto product1, Producto product2)
        {
            return !(product1 == product2);
        }

        #endregion

        #region Equallity

        /// <summary>
        /// Compares if the brand of product1 and the string are equals.
        /// </summary>
        /// <param name="product1">Product to compare its brand.</param>
        /// <param name="marca">string of the brand to compare.</param>
        /// <returns>True if are equals, otherwise returns False.</returns>
        public static bool operator ==(Producto product1, string marca)
        {
            return (product1.GetMarca() == marca);
        }

        /// <summary>
        /// Compares if the brand and barcode of product1 are equal to the same attributes of product2.
        /// </summary>
        /// <param name="product1">Product to compare its brand and barcode.</param>
        /// <param name="product2">Product to compare its brand and barcode.</param>
        /// <returns>True if are equals, otherwise returns False.</returns>
        public static bool operator ==(Producto product1, Producto product2)
        {
            return (((string)product1 == (string)product2) && product1.GetMarca() == product2.GetMarca());
        }

        #endregion

        #endregion

        #region Methods

        /// <summary>
        /// Make a string with the description of the attributes of the entity.
        /// </summary>
        /// <param name="product">Entity to return its description.</param>
        /// <returns>A message with the description of the entity.</returns>
        public static string MostrarProducto(Producto product)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine($"Barcode: {((string)product)}.");
            message.AppendLine($"Brand: {product.GetMarca()}.");
            message.AppendLine($"Price: ${product.GetPrecio()}.\n");

            return message.ToString();
        }

        #endregion
    }
}
