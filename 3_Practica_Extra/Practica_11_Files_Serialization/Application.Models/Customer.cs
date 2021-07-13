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

using Application.Common;
using System;
using System.Collections.Generic;

namespace Application.Models {
    public class Customer : Entity {

        #region Attributes

        private string name;
        private string lastName;
        private int age;

        #endregion

        #region Builders

        public Customer() {

        }

        public Customer(string name, string lastName, int age) : this() {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: the name of the entity.
        /// </summary>
        public string Name {
            get => this.name;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.name = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the age of the entity.
        /// </summary>
        public int Age {
            get => this.age;
            set {
                if (value > 0) {
                    this.age = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the surname of the entity.
        /// </summary>
        public string LastName {
            get => this.lastName;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.lastName = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares a list of customers and a customer to know if the customer is inside the list
        /// bassed in the name, surname and age.
        /// </summary>
        /// <param name="customers">List to search a customer.</param>
        /// <param name="customer">Customer to search into the list.</param>
        /// <returns>True if the customer exist inside, otherwise returns false.</returns>
        public static bool operator ==(List<Customer> customers, Customer customer) {
            bool response = false;
            foreach (Customer item in customers) {
                if (item.name == customer.name && item.lastName == customer.lastName && item.age == customer.age) {
                    response = true;
                }
            }

            return response;
        }

        /// <summary>
        /// Compares a list of customers and a customer to know if the customer isn't inside the list
        /// bassed in the name, surname and age.
        /// </summary>
        /// <param name="customers">List to search a customer.</param>
        /// <param name="customer">Customer to search into the list.</param>
        /// <returns>True if the customer not exist inside, otherwise returns false.</returns>
        public static bool operator !=(List<Customer> customers, Customer customer) {
            return !(customers == customer);
        }

        #endregion

    }
}
