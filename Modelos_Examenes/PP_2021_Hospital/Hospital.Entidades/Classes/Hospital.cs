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

namespace EntidadesRPP {
    public class Hospital {

        #region Attributes

        private string nombre;
        private List<Personal> personal;

        #endregion

        #region Builders

        /// <summary>
        /// Init the list.
        /// </summary>
        private Hospital() {
            personal = new List<Personal>();
        }

        /// <summary>
        /// Creates the entity with the name and init the list.
        /// </summary>
        /// <param name="nombre"></param>
        private Hospital(string nombre) : this() {
            this.nombre = nombre;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets: the amount of personal in the hospital.
        /// </summary>
        public int CantidadPersonal {
            get => this.personal.Count;
        }

        /// <summary>
        /// Gets: the entity at the index 'indice' or a null object
        /// if the index is higher than the amount of indexes of the list.
        /// </summary>
        /// <param name="indice">Index to search the entity.</param>
        /// <returns>the entity at the index or a null object.</returns>
        public Personal this[int indice] {
            get {
                if (indice > (this.CantidadPersonal - 1)) {
                    return null;
                } else {
                    return this.personal[indice];
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cast the string and returns an hospital.
        /// </summary>
        /// <param name="nombre">Name to set to the hospital.</param>
        public static implicit operator Hospital(string nombre) {
            return new Hospital(nombre);
        }

        /// <summary>
        /// It will return the index of the personal if exist in the list
        /// otherwise it will return -1.
        /// </summary>
        /// <param name="h">Instance type-Hospital to search in the list.</param>
        /// <param name="p">Instance Personal-type to search inside the listo of the hospital.</param>
        /// <returns>The index of P or -1.</returns>
        public static int operator |(Hospital h, Personal p) {
            if (!(h is null) && !(p is null)) {
                foreach (Personal item in h.personal) {
                    if (item == p) {
                        return h.personal.IndexOf(item);
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// It will add the entity Personal if not exist in the list.
        /// </summary>
        /// <param name="h">Instance type-Hospital to search in the list.</param>
        /// <param name="p">Instance Personal-type to search inside the listo of the hospital.</param>
        /// <returns>The hospital with or without the entity Personal-type.</returns>
        public static Hospital operator +(Hospital h, Personal p) {
            if ((h | p) == -1) {
                h.personal.Add(p);
            }

            return h;
        }

        /// <summary>
        /// It will remove the entity Personal if exist in the list.
        /// </summary>
        /// <param name="h">Instance type-Hospital to search in the list.</param>
        /// <param name="p">Instance Personal-type to search inside the listo of the hospital.</param>
        /// <returns>The hospital without the entity Personal-type.</returns>
        public static Hospital operator -(Hospital h, Personal p) {
            if ((h | p) != -1) {
                h.personal.Remove(p);
            }

            return h;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the full information of the hospital.
        /// </summary>
        /// <returns>The full information of the hospital as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {this.nombre}");
            data.AppendLine($"Empleados: {this.CantidadPersonal}");
            data.AppendLine($"Datos:");
            foreach (Personal item in this.personal) {
                data.AppendLine(item.Info);
            }

            return base.ToString();
        }

        #endregion
    }
}
