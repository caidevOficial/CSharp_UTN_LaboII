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

namespace Models {
    public class PersonaDAO {

        #region Attributes

        private static SqlCommand myCommand;
        private static SqlConnection myConnection;
        private static string dbConnection = $"Server = localhost; Initial Catalog=EjerciciosUTN; Trusted_Connection=true";

        #endregion

        #region Builders

        static PersonaDAO() {
            myCommand = new SqlCommand();
            myConnection = new SqlConnection(dbConnection);
        }

        #endregion

        #region Methods

        public static bool Insertar(Persona persona) {
            try {
                myCommand.Parameters.Clear();
                myConnection.Open();
                myCommand.Connection = myConnection;
                myCommand.CommandType = CommandType.Text;

                myCommand.CommandText = "INSERT INTO Clientes_Facturacion (codigoCliente, facturacionTotal) VALUES (@codCliente, @facturacion)";

                myCommand.Parameters.AddWithValue("@codCliente", persona.CodigoPersona);
                myCommand.Parameters.AddWithValue("@facturacion", persona.MontoTotal);
                myCommand.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                throw new Exception(e.Message);
            } finally {
                if (myConnection.State == ConnectionState.Open) {
                    myConnection.Close();
                }
            }
        }

        #endregion
    }
}
