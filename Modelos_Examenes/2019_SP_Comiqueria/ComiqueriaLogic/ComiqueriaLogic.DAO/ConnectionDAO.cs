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
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic {

    public delegate void ConnectionDelegate(AccionesDB actions);

    public static class ConnectionDAO {

        #region Attributes

        private static SqlConnection myConnection;
        private static SqlCommand myCommand;
        private static string connString;
        private static bool trustedConnection = true;
        private static string serverName = "localhost";
        private static string dbName = "Comiqueria";
        public static event ConnectionDelegate eventConDel;

        #endregion

        #region Builders

        /// <summary>
        /// Default Constructor of the DB Connector
        /// </summary>
        static ConnectionDAO() {
            connString = $"Server = {serverName} ; Database = {dbName}; Trusted_Connection = {trustedConnection} ; ";
            myConnection = new SqlConnection(connString);
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a register in the db.
        /// </summary>
        /// <param name="myProduct">Product to add into the db.</param>
        /// <returns>True if can add the product, otherwise returns false.</returns>
        public static bool InsertData(Producto myProduct) {
            bool success = false;
            try {
                if (!(myProduct is null)) {
                    myConnection.Open();
                    myCommand.CommandText = $"INSERT INTO Productos Values(@Description, @Price, @Stock);";
                    myCommand.Parameters.AddWithValue("@Description", myProduct.Descripcion);
                    myCommand.Parameters.AddWithValue("@Price", myProduct.Precio);
                    myCommand.Parameters.AddWithValue("@Stock", myProduct.Stock);
                    int rows = myCommand.ExecuteNonQuery();
                    success = true;
                    if(!(ConnectionDAO.eventConDel is null)) {
                        ConnectionDAO.eventConDel.Invoke(AccionesDB.Insert);
                    }
                }
            } catch (Exception exe) {
                throw new ComiqueriaException("Error While insert a Product into the DB.", exe);
            } finally {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }

            return success;
        }

        /// <summary>
        /// Gets a list of products from the db.
        /// </summary>
        /// <returns>a list of products from the db.</returns>
        public static List<Producto> GetProducts() {
            List<Producto> products = new List<Producto>();
            Producto actualProduct;
            try {
                myCommand.CommandText = "Select * from Productos";
                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                DataTable myDT = new DataTable();
                myDT.Load(myReader);
                foreach (DataRow item in myDT.Rows) {
                    float.TryParse(item["Precio"].ToString(), out float price);
                    int.TryParse(item["Stock"].ToString(), out int stock);
                    actualProduct = new Producto(Convert.ToInt32(item["Codigo"]), item["Descripcion"].ToString(), stock, price);
                    products.Add(actualProduct);
                }
            } catch (Exception exe) {
                throw new ComiqueriaException("Error While obtaining the Products from the DB.", exe);
            } finally {
                myConnection.Close();
            }

            return products;
        }

        /// <summary>
        /// Updates a product in the DB.
        /// </summary>
        /// <param name="myProduct">Producto to update into the db.</param>
        /// <returns>True if can update the producto, otherwise returns false.</returns>
        public static bool UpdateData(Producto myProduct) {
            bool success = false;
            try {
                if (!(myProduct is null)) {
                    myConnection.Open();
                    myCommand.CommandText = $"UPDATE Productos SET Descripcion = @Description, Precio = @Price, Stock = @Stock Where Codigo = @Codigo;";
                    myCommand.Parameters.AddWithValue("@Codigo", myProduct.Codigo);
                    myCommand.Parameters.AddWithValue("@Description", myProduct.Descripcion);
                    myCommand.Parameters.AddWithValue("@Price", myProduct.Precio);
                    myCommand.Parameters.AddWithValue("@Stock", myProduct.Stock);
                    int rows = myCommand.ExecuteNonQuery();
                    success = true;
                    if (!(ConnectionDAO.eventConDel is null)) {
                        ConnectionDAO.eventConDel.Invoke(AccionesDB.Update);
                    }
                }
            } catch (Exception exe) {
                throw new ComiqueriaException("Error While Update a Product into the DB.", exe);
            } finally {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }

            return success;
        }

        /// <summary>
        /// Removes a product from the db.
        /// </summary>
        /// <param name="idProduct">ID of the product to remove from the DB.</param>
        public static bool DeleteProduct(int idProduct) {
            bool success = false;
            try {
                myConnection.Open();
                myCommand.CommandText = $"DELETE FROM Productos WHERE Codigo=@id;";
                myCommand.Parameters.AddWithValue("@id", idProduct);
                int rows = myCommand.ExecuteNonQuery();
                success = true;
                if (!(ConnectionDAO.eventConDel is null)) {
                    ConnectionDAO.eventConDel.Invoke(AccionesDB.Delete);
                }
            } catch (Exception e) {
                throw new ComiqueriaException("Error Deleting a product", e);
            } finally {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }

            return success;
        }

        #endregion
    }
}
