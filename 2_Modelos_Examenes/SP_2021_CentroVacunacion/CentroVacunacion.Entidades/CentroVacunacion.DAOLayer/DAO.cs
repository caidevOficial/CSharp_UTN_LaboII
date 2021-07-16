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

namespace Entidades {
    public class DAO : DAOAbstract, IReadData<CentroDeVacunacion> {

        /// <summary>
        /// Reads a DB and gets a list of patients.
        /// </summary>
        /// <param name="path">name of the Table to read.</param>
        /// <param name="data">List to get.</param>
        /// <returns>True if can, otherwise returns false.</returns>
        public CentroDeVacunacion ReadData(string path, CentroDeVacunacion data) {
            Paciente actualPaciente;

            try {
                DAO.MyCommand.CommandText = $"Select * from {path}";
                DAO.MyConection.Open();
                using (SqlDataReader myReader = DAO.MyCommand.ExecuteReader()) {
                    DataTable myDT = new DataTable();
                    myDT.Load(myReader);
                    foreach (DataRow item in myDT.Rows) {
                        int turno = Convert.ToInt32(item["turno"]);
                        actualPaciente = new Paciente(turno, item["nombre"].ToString(), item["apellido"].ToString());
                        data.Pacientes.Add(actualPaciente);
                    }
                }
            } catch (Exception exe) {
                throw new Exception(exe.Message, exe); ;
            } finally {
                DAO.MyConection.Close();
            }

            return data;
        }
    }
}
