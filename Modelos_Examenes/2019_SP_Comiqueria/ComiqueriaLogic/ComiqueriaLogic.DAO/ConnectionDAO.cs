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

namespace ComiqueriaLogic {


    public class ConnectionDAO : AbstractDAO {

        #region Attributes

        public delegate void ConnectionDelegate(AccionesDB accion);
        public static event ConnectionDelegate EventDelegateChange;

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
                    ConnectionDAO.MyCommand.CommandText = $"INSERT INTO Productos Values(@Description, @Price, @Stock);";
                    ConnectionDAO.MyCommand.Parameters.AddWithValue("@Description", myProduct.Descripcion);
                    ConnectionDAO.MyCommand.Parameters.AddWithValue("@Price", myProduct.Precio);
                    ConnectionDAO.MyCommand.Parameters.AddWithValue("@Stock", myProduct.Stock);
                    ConnectionDAO.Execute();
                    success = true;
                    ConnectionDAO.EventDelegateChange.Invoke(AccionesDB.Insert);
                    ConnectionDAO.MyCommand.Parameters.Clear();
                }
            } catch (Exception exe) {
                throw new ComiqueriaException("Error While insert a Product into the DB.", exe);
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
                ConnectionDAO.MyCommand.CommandText = "Select * from Productos";
                ConnectionDAO.MyConection.Open();
                SqlDataReader myReader = ConnectionDAO.MyCommand.ExecuteReader();

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
                if (ConnectionDAO.MyConection.State == ConnectionState.Open) {
                    ConnectionDAO.MyConection.Close();
                }
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
                    ConnectionDAO.MyConection.Open();
                    ConnectionDAO.MyCommand.CommandText = $"UPDATE Productos SET Descripcion = @Description, Precio = @Price, Stock = @Stock Where Codigo = @Codigo;";
                    ConnectionDAO.MyCommand.Parameters.AddWithValue("@Codigo", myProduct.Codigo);
                    ConnectionDAO.MyCommand.Parameters.AddWithValue("@Description", myProduct.Descripcion);
                    ConnectionDAO.MyCommand.Parameters.AddWithValue("@Price", myProduct.Precio);
                    ConnectionDAO.MyCommand.Parameters.AddWithValue("@Stock", myProduct.Stock);
                    ConnectionDAO.Execute();
                    success = true;
                    ConnectionDAO.EventDelegateChange.Invoke(AccionesDB.Update);
                }
            } catch (Exception exe) {
                throw new ComiqueriaException("Error While Update a Product into the DB.", exe);
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
                ConnectionDAO.MyConection.Open();
                ConnectionDAO.MyCommand.CommandText = $"DELETE FROM Productos WHERE Codigo=@id;";
                ConnectionDAO.MyCommand.Parameters.AddWithValue("@id", idProduct);
                ConnectionDAO.Execute();
                success = true;
                ConnectionDAO.EventDelegateChange.Invoke(AccionesDB.Delete);
            } catch (Exception e) {
                throw new ComiqueriaException("Error Deleting a product", e);
            }

            return success;
        }

        #endregion
    }
}
