﻿/*
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
using System.Data;
using System.Data.SqlClient;

namespace ComiqueriaLogic {
    public abstract class AbstractDAO {

        #region Attributes

        public delegate void ConnectionDelegate(AccionesDB actions);
        public static event ConnectionDelegate EventChanged;
        private static SqlConnection myConnection;
        private static SqlCommand myCommand;
        private static string connString;
        private static bool trustedConnection = true;
        private static string serverName = "localhost";
        private static string dbName = "Comiqueria";

        #endregion

        #region Builder

        static AbstractDAO() {
            AbstractDAO.connString = $"Server = {serverName} ; Database = {dbName}; Trusted_Connection = {trustedConnection} ; ";
            AbstractDAO.myConnection = new SqlConnection(connString);
            AbstractDAO.myCommand = new SqlCommand();
            AbstractDAO.myCommand.Connection = myConnection;
            AbstractDAO.myCommand.CommandType = CommandType.Text;
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
                AbstractDAO.MyConection.Open();
                AbstractDAO.MyCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                throw new ComiqueriaException("Error De Acceso.", ex);
            } finally {
                if (AbstractDAO.MyConection.State == ConnectionState.Open) {
                    AbstractDAO.MyConection.Close();
                }
            }
        }

        #endregion
    }
}
