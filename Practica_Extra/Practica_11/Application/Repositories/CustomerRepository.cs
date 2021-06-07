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

using Application.DataAcces;
using Application.Exceptions;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Repositories {
    public class CustomerRepository : RepositoryBase<Customer> {
        private static List<Customer> customers;

        #region -- Los datos no se encuentran guardados más que en memoria --

        #region Builders

        static CustomerRepository() {
            // Carga de 100 clientes de forma predeterminada
            customers = new List<Customer>();

            for (int i = 0; i < 20; i++) {
                var customer = new Customer();
                customer.ID = i + 1;
                customer.Name = "CustomerName" + customer.ID;
                customer.LastName = "CustomerLastname" + customer.ID;
                customer.Age = 20 + (int)customer.ID;

                customers.Add(customer);
            }
        }

        #endregion

        #endregion

        #region Methods

        /// <summary>
        /// Creates an entity in the list.
        /// </summary>
        /// <param name="entity">Entity to create.</param>
        public override void Create(Customer entity) {
            try {
                long lastId = (long)(customers[customers.Count - 1]).ID;
                entity.ID = (int)lastId + 1;
                if (customers != entity) {
                    customers.Add(entity);
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {
                throw new TechnicalException(
                    string.Format("No se pudo crear el cliente \"{0} {1}\".", entity.Name, entity.LastName),
                    ex);
            }

        }

        /// <summary>
        /// Order the list by ID and return it.
        /// </summary>
        /// <returns>The ordered list by id.</returns>
        public override List<Customer> GetAll() {
            return customers.OrderBy(x => x.ID).ToList();
        }

        /// <summary>
        /// Reads a path and gets a list of customers.
        /// </summary>
        /// <param name="path">Path to get the objects</param>
        /// <returns>A list of customers.</returns>
        public List<Customer> GetAll(string path) {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            customers.AddRange(customerSerializer.Read(path));
            return customers;
        }

        /// <summary>
        /// Gets a customer by its id.
        /// </summary>
        /// <param name="entityId">ID to search a customer into the list.</param>
        /// <returns>A customer by its id.</returns>
        public override Customer GetById(long entityId) {
            // implementar
            foreach (Customer item in this.GetAll()) {
                if (item.ID == entityId) {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Removes an entity frmo the list.
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public override void Remove(Customer entity) {
            foreach (Customer item in this.GetAll()) {
                if (entity.ID == item.ID) {
                    customers.Remove(item);
                }
            }
        }

        /// <summary>
        /// Updates an entity of the list.
        /// </summary>
        /// <param name="entity">Entity to update</param>
        public override void Update(Customer entity) {
            Customer edit;
            if (!(entity is null)) {
                edit = this.GetById(entity.ID);
                edit.Age = entity.Age;
                edit.LastName = entity.LastName;
                edit.Name = entity.Name;
            }
        }

        /// <summary>
        /// Reads a file to get a list of customers.
        /// </summary>
        /// <param name="path">Path to read the file.</param>
        /// <returns>A list of customers.</returns>
        public List<Customer> LoadFromFile(string path) {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            customers.AddRange(customerSerializer.Read(path));
            return customers;
        }

        /// <summary>
        /// Saves a list of customers into a file.
        /// </summary>
        /// <param name="customers">List to save into a file.</param>
        /// <returns>True if can save the file.</returns>
        public bool SaveToFile(List<Customer> customers) {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            return customerSerializer.Save(customers);
        }

        #endregion

    }
}
