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

namespace ClassLibrary {
    public sealed class Customer {
        // Attributes
        private string name;
        private string surname;

        #region Builders

        /// <summary>
        /// Builds the entity whitout parameters.
        /// </summary>
        public Customer() { }

        /// <summary>
        /// Builds the entity with its all parameters.
        /// </summary>
        /// <param name="name">Name of the entity.</param>
        /// <param name="surname">surname of the entity.</param>
        public Customer(string name, string surname) : this() {
            this.name = name;
            this.surname = surname;
        }

        #endregion

        #region Getters and Setters

        // Properties
        /// <summary>
        /// Gets the name of the entity.
        /// </summary>
        /// <returns>The name of the entity.</returns>
        public string GetName() {
            return this.name;
        }

        /// <summary>
        /// Gets the surname of the entity.
        /// </summary>
        /// <returns>The surname of the entity.</returns>
        public string GetSurname() {
            return this.surname;
        }

        /// <summary>
        /// Gets the full name of the entity.
        /// </summary>
        /// <returns>The full name of the entity.</returns>
        public string GetFullName() {
            return $"{this.name} {this.surname}.";
        }

        /// <summary>
        /// Sets the name of the entity.
        /// </summary>
        /// <param name="name">Name to set.</param>
        public void SetName(string name) => this.name = name;

        /// <summary>
        /// Sets the surname of the entity.
        /// </summary>
        /// <param name="surname">Surname to set.</param>
        public void SetSurname(string surname) => this.surname = surname;

        #endregion

    }
}
