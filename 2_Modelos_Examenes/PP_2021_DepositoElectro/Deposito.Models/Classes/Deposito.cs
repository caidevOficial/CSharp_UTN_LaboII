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
using System.Collections.Generic;
using System.Text;

namespace Models {
    public class Deposito {

        #region Attributes

        private int capacidad;
        private List<Producto> productos;

        #endregion

        #region Builders

        /// <summary>
        /// Initialices the list.
        /// </summary>
        private Deposito() {
            productos = new List<Producto>();
        }

        /// <summary>
        /// Creates the entity with the capacity
        /// and initializes the list.
        /// </summary>
        /// <param name="capacidad">Capacity of the entity.</param>
        private Deposito(int capacidad) : this() {
            this.capacidad = capacidad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the amount of prices of the Celular-type objects
        /// </summary>
        public double PrecioDeCelulares {
            get => this.ObtenerPrecio(EProducto.PrecioDeCelulares);
        }

        /// <summary>
        /// Get: Gets the amount of prices of the TV-type objects
        /// </summary>
        public double PrecioDeTelevisores {
            get => this.ObtenerPrecio(EProducto.PrecioDeTelevisores);
        }

        /// <summary>
        /// Get: Gets the amount of prices of all the objects
        /// </summary>
        public double PrecioTotal {
            get => this.ObtenerPrecio(EProducto.PrecioTotal);
        }

        #endregion

        #region Operators

        /// <summary>
        /// Returns an instance with the capacity of the parameter.
        /// </summary>
        /// <param name="capacidad">Capacity to set to the instance.</param>
        public static implicit operator Deposito(int capacidad) {
            if (capacidad > 0) {
                return new Deposito(capacidad);
            }

            return new Deposito(1);
        }

        /// <summary>
        /// Checks if the product is inside the list of the warehouse
        /// </summary>
        /// <param name="d">Warehouse to check in its list.</param>
        /// <param name="p">Product to check in the list of the warehouse.</param>
        /// <returns>True if the product exist in the list, otherwise returns false.</returns>
        public static bool operator ==(Deposito d, Producto p) {
            if (!(d is null) && !(p is null)) {
                foreach (Producto item in d.productos) {
                    if (item is Celular && p is Celular) {
                        if ((Celular)item == (Celular)p) {
                            Console.WriteLine("Ya existe en el inventario.");
                            return true;
                        }
                    } else if (item is Televisor && p is Televisor) {
                        if ((Televisor)item == (Televisor)p) {
                            Console.WriteLine("Ya existe en el inventario.");
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the product isn't inside the list of the warehouse
        /// </summary>
        /// <param name="d">Warehouse to check in its list.</param>
        /// <param name="p">Product to check in the list of the warehouse.</param>
        /// <returns>True if the product not exist in the list, otherwise returns false.</returns>
        public static bool operator !=(Deposito d, Producto p) {
            return !(d == p);
        }

        /// <summary>
        /// Adds the product if not exist in the warehouse.
        /// </summary>
        /// <param name="d">Warehouse to try to add the product.</param>
        /// <param name="p">Product to try to add into the warehouse.</param>
        /// <returns>Return the warehouse with or without the new product.</returns>
        public static Deposito operator +(Deposito d, Producto p) {
            if (d.productos.Count < d.capacidad) {
                if (d != p) {
                    d.productos.Add(p);
                }
            } else {
                Console.WriteLine("Inventario lleno.");
            }

            return d;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtains the total price of the product bassed by its type.
        /// </summary>
        /// <param name="tipoProducto">Type of the product</param>
        /// <returns>The total amount of its prices</returns>
        private double ObtenerPrecio(EProducto tipoProducto) {
            double totalPrice = 0;
            foreach (Producto item in this.productos) {
                switch (tipoProducto) {
                    case EProducto.PrecioDeCelulares:
                        if (item is Celular) {
                            totalPrice += item.Precio;
                        }
                        break;
                    case EProducto.PrecioDeTelevisores:
                        if (item is Televisor) {
                            totalPrice += item.Precio;
                        }
                        break;
                    default:
                        totalPrice += item.Precio;
                        break;
                }
            }

            return totalPrice;
        }

        /// <summary>
        /// Gets the info of the warehouse as a string.
        /// </summary>
        /// <param name="d">Warehouse to obtain the info</param>
        /// <returns>The info of the warehouse as a string.</returns>
        public static string Mostrar(Deposito d) {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Capacidad: {d.capacidad} ({d.productos.Count})");
            data.AppendLine($"Total por televisores: ${d.PrecioDeTelevisores}");
            data.AppendLine($"Total por celulares: ${d.PrecioDeCelulares}");
            data.AppendLine($"Total: ${d.PrecioTotal}");
            data.AppendLine("***************************");
            data.AppendLine("Lista De Productos:");
            data.AppendLine("***************************");

            foreach (Producto item in d.productos) {
                data.AppendLine(item.ToString());
            }

            return data.ToString();
        }

        #endregion
    }
}
