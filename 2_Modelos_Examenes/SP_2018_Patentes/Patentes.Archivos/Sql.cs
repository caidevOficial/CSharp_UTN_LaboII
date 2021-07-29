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
using Entidades;

namespace Archivos {
    public class Sql : IArchivo<Queue<Patente>> {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private readonly static string server = "localhost";
        private readonly static string dataBase = "patentes-sp-2018";
        private readonly static bool tConecction = true;
        private static string connString;

        static Sql() {
            connString = $"Server = {server} ; Database = {dataBase}; Trusted_Connection = {tConecction}; ";
            conexion = new SqlConnection(connString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        /// <summary>
        /// Saves a queue of objects into the DB.
        /// </summary>
        /// <param name="tableName">Name of the table to save.</param>
        /// <param name="datos">Queue to save into the db.</param>
        public void Guardar(string tableName, Queue<Patente> datos) {
            try {
                Sql.conexion.Open();
                foreach (Patente item in datos) {
                    Sql.comando.CommandText = $"INSERT INTO {tableName} Values(@patente, @tipo);";
                    Sql.comando.Parameters.AddWithValue("@patente", item.CodigoPatente);
                    Sql.comando.Parameters.AddWithValue("@tipo", item.TipoCodigo.ToString());
                    int rows = Sql.comando.ExecuteNonQuery();
                    Sql.comando.Parameters.Clear();
                }
            } catch (Exception exe) {
                throw new PatenteInvalidaException("Patente invalida", exe);
            } finally {
                Sql.conexion.Close();
            }
        }

        /// <summary>
        /// Reads from the DB a collection of entities and retuns into a queue.
        /// </summary>
        /// <param name="tableName">Name of the table to read.</param>
        /// <param name="datos">Queue to save the entities.</param>
        public void Leer(string tableName, out Queue<Patente> datos) {
            Patente ActualPatente = null;
            datos = new Queue<Patente>();
            try {
                comando.CommandText = $"SELECT * FROM {tableName};";
                conexion.Open();
                using (SqlDataReader reader = Sql.comando.ExecuteReader()) {
                    DataTable myDT = new DataTable();
                    myDT.Load(reader);
                    foreach (DataRow item in myDT.Rows) {
                        ActualPatente = item["patente"].ToString().ValidarPatente();
                        datos.Enqueue(ActualPatente);
                    }
                }
            } catch (Exception exe) {
                throw new PatenteInvalidaException("Patente invalida", exe);
            }
        }
    }
}
