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
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Entidades {
    public static class ConnectionDAO {

        #region Attributes

        private static SqlCommand myCommand;
        private static SqlConnection myConnection;
        private static string dbConnection;
        #endregion

        #region Builders

        /// <summary>
        /// Constructor estatico por defecto.
        /// </summary>
        static ConnectionDAO() {
            dbConnection = $"Server = localhost; Database=20201203-sp; Trusted_Connection=true";
            myCommand = new SqlCommand();
            myConnection = new SqlConnection(dbConnection);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        #endregion

        /// <summary>
        /// Inserta en la DB un mensaje con el nombre del alumno.
        /// </summary>
        /// <param name="message">Mensaje a guardar en la DB.</param>
        /// <returns>True si pudo guardar en la DB.</returns>
        public static bool InsertLog(string message) {
            try {
                myConnection.Open();
                myCommand.CommandText = "INSERT INTO log VALUES (@Entrada, @Alumno)";

                myCommand.Parameters.AddWithValue("@entrada", message);
                myCommand.Parameters.AddWithValue("@Alumno", "FacuFalcone");
                myCommand.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                throw new Exception(e.Message);
            } finally {
                myCommand.Parameters.Clear();
                if (myConnection.State == ConnectionState.Open) {
                    myConnection.Close();
                }
            }
        }

        /// <summary>
        /// Lee de una DB los registros y los almacena como un string.
        /// </summary>
        /// <param name="message">Variable a donde cargara con los registros.</param>
        /// <returns>True si pudo cargar al menos un registro.</returns>
        public static bool ReadLog(out string message) {
            bool queryOK = false;
            StringBuilder data = new StringBuilder();
            myConnection.Open();
            myCommand.CommandText = "SELECT * FROM log";
            SqlDataReader myReader = myCommand.ExecuteReader();
            DataTable myDT = new DataTable();
            myDT.Load(myReader);
            foreach (DataRow item in myDT.Rows) {
                data.AppendLine($"{item["entrada"].ToString()} - {item["alumno"].ToString()}");
                queryOK = true;
            }
            myConnection.Close();
            message = data.ToString();

            return queryOK;
        }
    }
}
