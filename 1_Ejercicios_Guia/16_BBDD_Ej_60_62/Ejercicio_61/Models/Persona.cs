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

namespace Models {
    public class Persona {

        #region Attributes

        private int id;
        private string nombre;
        private string apellido;

        #endregion

        #region Builders

        /// <summary>
        /// Builder with name and surname.
        /// </summary>
        /// <param name="nombre">Name of the person.</param>
        /// <param name="apellido">Surname of the person.</param>
        public Persona(string nombre, string apellido) {
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        /// <summary>
        /// Builder with id, name and surname.
        /// </summary>
        /// <param name="id">ID of the person.</param>
        /// <param name="nombre">Name of the person.</param>
        /// <param name="apellido">Surname of the person.</param>
        public Persona(int id, string nombre, string apellido) {
            this.ID = id;
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: The id of the entity.
        /// </summary>
        public int ID {
            get => this.id;
            set {
                if (value > 0) {
                    this.id = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: The Name of the entity.
        /// </summary>
        public string Nombre {
            get => this.nombre;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: The Surname of the entity.
        /// </summary>
        public string Apellido {
            get => this.apellido;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.apellido = value;
                }
            }
        }

        #endregion
    }
}
