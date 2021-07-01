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
using System.IO;
using System.Linq;
using System.Text;

namespace ComiqueriaLogic {
    public class Comiqueria {

        #region Attributes

        private List<Producto> productos;
        private List<Venta> ventas;
        public event Action productosListChanged;

        #endregion

        #region Builders

        /// <summary>
        /// Constructor, instancia los campos de tipo lista. 
        /// Asocia el evento de cambios en la tabla de productos para actualizar la lista.
        /// </summary>
        public Comiqueria() {
            /* PUNTO 4D: 
             * Cree también un método que retorne la lista de productos (List<Producto>) almacenada en la tabla de productos. 
             * Utilice este método para cargar la lista de productos en la clase Comiqueria cuando se instancie una nueva comiquería.  
             */
            this.ventas = new List<Venta>();
            this.productos = ConnectionDAO.GetProducts();
            ConnectionDAO.eventConDel += Actualizar;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Devuelve o carga la lista de productos.
        /// </summary>
        public List<Producto> Productos {
            get {
                return this.productos;
            }
            set {
                this.productos = value;
                this.productosListChanged();
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Verifica si un producto se encuentra en la lista de productos.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Producto producto) {
            foreach (Producto prod in comiqueria.productos) {
                if (prod.Codigo == producto.Codigo) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si un producto NO se encuentra en la lista de productos. 
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(Comiqueria comiqueria, Producto producto) {
            return !(comiqueria == producto);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Genera una nueva venta.
        /// </summary>
        /// <param name="producto">Producto a Vender.</param>
        /// <param name="cantidad">Cantidad solicitada del producto.</param>
        public void Vender(Producto producto, int cantidad) {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);

            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.bin", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));
            // Punto 6G - Serializar a binario la nueva venta.
            Serializador<Venta>.BinnarySave(ruta, nuevaVenta);
            ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.xml", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));
            // Punto 6G - Serializar a xml la nueva venta.
            Serializador<Venta>.XMLSave(ruta, nuevaVenta);
        }

        /// <summary>
        /// Devuelve un string conteniendo la descripción breve de cada venta en la lista de ventas. 
        /// </summary>
        /// <returns></returns>
        public string ListarVentas() {
            List<Venta> ventasOrdenadas = this.ventas.OrderByDescending(x => x.Fecha).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Venta venta in ventasOrdenadas) {
                sb.AppendLine(venta.ObtenerDescripcionBreve());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Refresh the products of the comic store.
        /// </summary>
        /// <param name="actions">Action in the db.</param>
        private void Actualizar(AccionesDB actions) {
            switch (actions) {
                case AccionesDB.Insert:
                case AccionesDB.Update:
                case AccionesDB.Delete:
                    productos = ConnectionDAO.GetProducts();
                    break;
                default:
                    break;
            }
        }

        #endregion

    }
}
