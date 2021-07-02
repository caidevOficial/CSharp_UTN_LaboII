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

namespace Persistencia {
    public abstract class ConnectionDAO {
        #region Attributes

        private static SqlConnection myConnection;
        private static SqlCommand myCommand;
        private static string connString;
        private static bool trustedConnection = true;
        private static string serverName = "localhost";
        private static string dbName = "20201119-sp";

        #endregion

        #region Builder

        static ConnectionDAO() {
            ConnectionDAO.connString = $"Server = {serverName} ; Database = {dbName}; Trusted_Connection = {trustedConnection} ; ";
            ConnectionDAO.myConnection = new SqlConnection(connString);
            ConnectionDAO.myCommand = new SqlCommand();
            ConnectionDAO.myCommand.Connection = myConnection;
            ConnectionDAO.myCommand.CommandType = CommandType.Text;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the conection of the object.
        /// </summary>
        protected static SqlConnection MyConection {
            get => myConnection;
        }

        /// <summary>
        /// Gets the Command of the object.
        /// </summary>
        protected static SqlCommand MyCommand {
            get => myCommand;
        }

        /// <summary>
        /// Execute the query of the object.
        /// </summary>
        protected static void Execute() {
            try {
                ConnectionDAO.MyConection.Open();
                ConnectionDAO.MyCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                throw new Exception("Error De Acceso.", ex);
            } finally {
                if (ConnectionDAO.MyConection.State == ConnectionState.Open) {
                    ConnectionDAO.MyConection.Close();
                }
            }
        }

        #endregion
    }
}
