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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class ConnectionDAO : AbstractDAO {

        #region Methods

        /// <summary>
        /// Adds a register in the db.
        /// </summary>
        /// <param name="myProduct">atentions to add into the db.</param>
        /// <returns>True if can add the atentions, otherwise returns false.</returns>
        public static bool InsertData(int atendidos, int noAtendidos) {
            bool success = false;
            try {
                ConnectionDAO.MyCommand.CommandText = $"INSERT INTO atenciones Values(@Atendidos, @NoAtendidos, @Alumno);";
                ConnectionDAO.MyCommand.Parameters.AddWithValue("@Atendidos", atendidos);
                ConnectionDAO.MyCommand.Parameters.AddWithValue("@NoAtendidos", noAtendidos);
                ConnectionDAO.MyCommand.Parameters.AddWithValue("@Alumno", "FacuFalcone");
                ConnectionDAO.Execute();
                success = true;
                ConnectionDAO.MyCommand.Parameters.Clear();
            } catch (Exception exe) {
                throw new Exception("Error While insert a atentions into the DB.", exe);
            }

            return success;
        }

        #endregion
    }
}
