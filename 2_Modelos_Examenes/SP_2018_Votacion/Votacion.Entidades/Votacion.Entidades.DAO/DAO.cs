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

namespace Entidades {
    public class DAO : AbstractDAO, IArchivos<Votacion> {

        #region Methods

        /// <summary>
        /// Adds a register in the db.
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        /// <param name="objeto">Object to save its data into the db.</param>
        /// <returns>True if can save the data, otherwise returns false.</returns>
        public bool Guardar(string tableName, Votacion objeto) {
            bool success = false;
            try {
                string insertStatement = $"INSERT INTO {tableName}";
                string valuesStatement = $"Values(@NombreLey, @Afir, @Neg, @Abs, @Alumno);";
                DAO.MyCommand.CommandText = $"{insertStatement} {valuesStatement}";
                DAO.MyCommand.Parameters.AddWithValue("@NombreLey", objeto.NombreLey);
                DAO.MyCommand.Parameters.AddWithValue("@Afir", objeto.ContadorAfirmativo);
                DAO.MyCommand.Parameters.AddWithValue("@Neg", objeto.ContadorNegativo);
                DAO.MyCommand.Parameters.AddWithValue("@Abs", objeto.ContadorAbstencion);
                DAO.MyCommand.Parameters.AddWithValue("@Alumno", "FacuFalcone");
                DAO.Execute();
                success = true;
                DAO.MyCommand.Parameters.Clear();
            } catch (Exception exe) {
                throw exe;
            }

            return success;
        }

        /// <summary>
        /// Nothing to do.
        /// </summary>
        /// <param name="tableName">Name of the table to read.</param>
        /// <returns>NotImplementedException</returns>
        public Votacion Leer(string tableName) {
            throw new NotImplementedException();
        }

        #endregion
    }
}
