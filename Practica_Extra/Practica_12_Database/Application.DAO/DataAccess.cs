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

using Application.Exceptions;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Application.DAO {

    public static class DataAccess {

        #region Attributes

        private static string connString;
        private static SqlConnection myConnection;
        private static SqlCommand myCommand;

        #endregion

        #region Builder

        static DataAccess() {
            connString = " Server = localhost ; Database = RepasoBD; Trusted_Connection = true ; ";
            myConnection = new SqlConnection(connString);
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets all the customers from the DB.
        /// </summary>
        /// <returns>A list of customers.</returns>
        public static List<Customer> GetCustomers() {

            List<Customer> customers = new List<Customer>();
            Customer actualCustomer;
            myCommand.CommandText = "Select * from Customers";
            myConnection.Open();
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read()) {
                actualCustomer = new Customer(myReader["Name"].ToString(), myReader["Surname"].ToString(), Convert.ToInt32(myReader["Age"]));
                actualCustomer.ID = Convert.ToInt32(myReader["id"]);
                customers.Add(actualCustomer);
            }
            myReader.Close();
            myConnection.Close();

            return customers;
        }

        /// <summary>
        /// Gets a customer from the DB by its ID.
        /// </summary>
        /// <param name="idCustomer">ID of the customer to get.</param>
        /// <returns>A customer.</returns>
        public static Customer GetCustomerByID(int idCustomer) {
            Customer theCustomer = null;
            myCommand.CommandText = $"Select * from Customers WHERE id=@id";
            myCommand.Parameters.AddWithValue("@id", idCustomer);
            myConnection.Open();
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read()) {
                theCustomer = new Customer(myReader["Name"].ToString(), myReader["Surname"].ToString(), Convert.ToInt32(myReader["Age"]));
            }
            myReader.Close();
            myConnection.Close();

            return theCustomer;
        }

        /// <summary>
        /// Inserts a customer into the DB.
        /// </summary>
        /// <param name="entity">Customer to insert into the DB.</param>
        public static void InsertCustomer(Customer entity) {
            List<Customer> customers = GetCustomers();
            try {
                myConnection.Open();
                if (customers != entity) {
                    myCommand.CommandText = $"INSERT INTO Customers Values(@Name,@Surname,@Age);";
                    myCommand.Parameters.AddWithValue("@Name", entity.Name);
                    myCommand.Parameters.AddWithValue("@Surname", entity.LastName);
                    myCommand.Parameters.AddWithValue("@Age", entity.Age);
                    int rows = myCommand.ExecuteNonQuery();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {
                throw new TechnicalException(string.Format("No se pudo crear el cliente \"{0} {1}\".", entity.Name, entity.LastName), ex);
            } finally {
                myConnection.Close();
            }

        }

        /// <summary>
        /// Updates a customer from the DB.
        /// </summary>
        /// <param name="entity">Customer to update.</param>
        public static void UpdateCustomer(Customer entity) {
            try {
                myConnection.Open();
                if (!(entity is null)) {
                    myCommand.CommandText = $"UPDATE Customers SET Name = @Name, Surname = @Surname, Age = @Age WHERE id = @id;";
                    myCommand.Parameters.AddWithValue("@Name", entity.Name);
                    myCommand.Parameters.AddWithValue("@Surname", entity.LastName);
                    myCommand.Parameters.AddWithValue("@Age", entity.Age);
                    myCommand.Parameters.AddWithValue("@id", entity.ID);
                    int rows = myCommand.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                throw new TechnicalException("Error", ex);
            } finally {
                myConnection.Close();
            }
        }

        /// <summary>
        /// Deletes a customer from the DB.
        /// </summary>
        /// <param name="idCustomer">ID of the customer to delete.</param>
        public static void DeleteCustomer(int idCustomer) {
            try {
                myConnection.Open();
                myCommand.CommandText = $"DELETE FROM Customers WHERE id=@id;";
                myCommand.Parameters.AddWithValue("@id", idCustomer);
                int rows = myCommand.ExecuteNonQuery();
            } catch (Exception e) {
                throw new TechnicalException("Error", e);
            } finally {
                myConnection.Close();
            }
        }

        #endregion

    }
}
