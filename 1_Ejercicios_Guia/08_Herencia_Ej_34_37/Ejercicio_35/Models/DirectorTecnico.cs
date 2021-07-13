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
using System.Text;

namespace Models {
    public sealed class DirectorTecnico : Persona {
        private DateTime fechaNacimiento;

        #region Builders

        /// <summary>
        /// Builds the entity with the name.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        public DirectorTecnico(string nombre) : base(nombre) { }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="fechaNac">Birthday of the entity.</param>
        public DirectorTecnico(string nombre, DateTime fechaNac) : base(nombre) {
            this.FechaNacimiento = fechaNac;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: gets the birthday of the entity.
        /// Set: Sets the birthday of the entity.
        /// </summary>
        public DateTime FechaNacimiento {
            get => fechaNacimiento;
            set { fechaNacimiento = value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if both entities have same fields.
        /// </summary>
        /// <param name="t1">First entity to compare.</param>
        /// <param name="t2">Second entity to compare.</param>
        /// <returns>True if have the same fields, otherwise returns False.</returns>
        public static bool operator ==(DirectorTecnico t1, DirectorTecnico t2) {
            return (t1.FechaNacimiento == t2.FechaNacimiento && t1.Nombre == t2.Nombre);
        }

        /// <summary>
        /// Compares if both entities haven't same fields.
        /// </summary>
        /// <param name="t1">First entity to compare.</param>
        /// <param name="t2">Second entity to compare.</param>
        /// <returns>True if haven't the same fields, otherwise returns False.</returns>
        public static bool operator !=(DirectorTecnico t1, DirectorTecnico t2) {
            return !(t1 == t2);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the data of the Entity.
        /// </summary>
        /// <returns>The data of the Entity as a string.</returns>
        public override string MostrarDatos() {
            StringBuilder data = new StringBuilder();
            data.Append($"######## Soccer Player ########\n");
            data.Append($"Name: {this.Nombre}.\n");
            data.Append($"DNI: {this.DNI}.\n");

            return data.ToString();
        }

        #endregion

    }
}
