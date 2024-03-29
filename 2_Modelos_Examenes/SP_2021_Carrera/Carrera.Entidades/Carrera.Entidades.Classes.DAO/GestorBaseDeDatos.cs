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

namespace Entidades {
    public class GestorBaseDeDatos : IGuardar<AutoF1> {

        private readonly string cadenaConexion;

        /// <summary>
        /// Default builder of the entity.
        /// </summary>
        public GestorBaseDeDatos() {
            this.cadenaConexion = "Server = localhost ; Database = 20210717-RSP; Trusted_Connection = true; ";
        }

        /// <summary>
        /// Saves the car into the DB.
        /// </summary>
        /// <param name="auto">Car to save into the DB.</param>
        public void Guardar(AutoF1 auto) {
            SqlConnection myConnection = new SqlConnection(cadenaConexion);
            SqlCommand myCommand = new SqlCommand {
                Connection = myConnection,
                CommandType = CommandType.Text
            };
            try {
                myConnection.Open();
                myCommand.CommandText = $"INSERT INTO resultados Values(@escuderia, @posicion, @horaLlegada);";
                myCommand.Parameters.AddWithValue("@escuderia", auto.Escuderia);
                myCommand.Parameters.AddWithValue("@posicion", auto.Posicion);
                myCommand.Parameters.AddWithValue("@horaLlegada", DateTime.Now.ToString());

                int rows = myCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                throw new Exception("Something get wrong while inserting a Robot into the DB.", ex);
            } finally {
                myConnection.Close();
            }
        }
    }
}
