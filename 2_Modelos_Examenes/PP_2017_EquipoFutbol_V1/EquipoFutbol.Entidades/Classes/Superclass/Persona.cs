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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {

        #region Attributes

        private string apellido;
        private string nombre;

        #endregion

        #region Builders

        /// <summary>
        /// Builds the entity with the name and surname.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="apellido">Surname of the entity.</param>
        public Persona(string nombre, string apellido) {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Properties

        /// <summary>
        /// ReadOnly: Gets the surname.
        /// </summary>
        public string Apellido {
            get => this.apellido;
        }

        /// <summary>
        /// ReadOnly: Gets the name.
        /// </summary>
        public string Nombre {
            get => this.nombre;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets all the info of the entity.
        /// </summary>
        /// <returns>All the info of the entity as a string.</returns>
        protected abstract string FichaTecnica();

        /// <summary>
        /// Gets the fullname of the entity.
        /// </summary>
        /// <returns>fullname of the entity as a string.</returns>
        protected virtual string NombreCompleto() {
            return String.Format("{0} {1}", this.Nombre, this.Apellido);
        }

        #endregion
    }
}
