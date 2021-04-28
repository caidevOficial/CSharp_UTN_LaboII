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

using System.Collections.Generic;
using System.Text;

namespace Entidades {
    public class Vendedor {

        private string nombre;
        private List<Publicacion> ventas;

        #region Builders

        /// <summary>
        /// instancia la lista de ventas.
        /// </summary>
        private Vendedor() {
            ventas = new List<Publicacion>();
        }

        /// <summary>
        /// Crea la entidad vendedor con el nombre e instancia la list de ventas.
        /// </summary>
        /// <param name="nombre"></param>
        public Vendedor(string nombre) : this() {
            this.nombre = nombre;
        }

        #endregion

        #region Operators

        /// <summary>
        /// agregará siempre y cuando haya stock suficiente para realizar 
        /// una venta del producto, agregando en ese caso la información 
        /// de la venta a la lista y descontando Stock de la publicación.
        /// </summary>
        /// <param name="v">Vendedor que hara la venta.</param>
        /// <param name="p">publicacion a vender</param>
        /// <returns>True si pudo vender, caso contrario sera false.</returns>
        public static bool operator +(Vendedor v, Publicacion p) {
            if (!(v is null) && !(p is null)) {
                if (p.Stock > 0) {
                    p.Stock--;
                    v.ventas.Add(p);
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// será de clase y retornará la información del vendedor, 
        /// sus ventas y la ganancia total de las mismas.
        /// </summary>
        /// <param name="v">Entidad vendedor.</param>
        /// <returns>Retorna un string con la info de ventas del vendedor.</returns>
        public static string InformeDeVentas(Vendedor v) {
            double ganancias = 0;
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {v.nombre}");
            data.AppendLine("-----------------");
            foreach (Publicacion publi in v.ventas) {
                data.AppendLine(publi.Informacion());
                ganancias += publi.Importe;
                data.AppendLine("-----------------");
            }
            data.AppendLine($"Ganancias: ${ganancias}");

            return data.ToString();
        }

        #endregion
    }
}
