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
    public class DataAccesDAO : ConnectionDAO {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool InsertData(string message) {
            bool success = false;
            try {
                if (!(String.IsNullOrWhiteSpace(message))) {
                    DataAccesDAO.MyCommand.CommandText = $"INSERT INTO Productos Values(@Entrada, @Alumno);";
                    DataAccesDAO.MyCommand.Parameters.AddWithValue("@Entrada", message);
                    DataAccesDAO.MyCommand.Parameters.AddWithValue("@Alumno", "Facu Falcone");
                    DataAccesDAO.Execute();
                    success = true;
                    //DataAccesDAO.EventDelegateChange.Invoke(AccionesDB.Insert);
                    DataAccesDAO.MyCommand.Parameters.Clear();
                }
            } catch (Exception exe) {
                throw new Exception("Error While insert a Product into the DB.", exe);
            }

            return success;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetData() {
            StringBuilder data = new StringBuilder();
            string register;
            try {
                DataAccesDAO.MyCommand.CommandText = "Select * from Productos";
                DataAccesDAO.MyConection.Open();
                SqlDataReader myReader = DataAccesDAO.MyCommand.ExecuteReader();

                DataTable myDT = new DataTable();
                myDT.Load(myReader);

                foreach (DataRow item in myDT.Rows) {
                    register = $"{item["entrada"].ToString()} - {item["alumno"].ToString()}");
                    data.AppendLine(register);
                }
            } catch (Exception exe) {
                throw new Exception("Error While obtaining the Products from the DB.", exe);
            } finally {
                if (DataAccesDAO.MyConection.State == ConnectionState.Open) {
                    DataAccesDAO.MyConection.Close();
                }
            }

            return data.ToString();
        }
    }
}
