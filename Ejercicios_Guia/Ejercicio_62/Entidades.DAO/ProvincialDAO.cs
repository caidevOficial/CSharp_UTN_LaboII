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

using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAO {
    public class ProvincialDAO {

        #region Attributes

        private static string connString;
        private static SqlConnection myConnection;
        private static SqlCommand myCommand;

        #endregion

        #region Builders

        static ProvincialDAO() {
            connString = " Server = localhost ; Database = Centralita; Trusted_Connection = true ; ";
            myConnection = new SqlConnection(connString);
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Guarda una llamada tipo provincial en la base de datos
        /// </summary>
        /// <param name="llamadaProvincial">Entidad tipo Provincial a guardar en la base de datos</param>
        /// <returns>True si pudo guardar la entidad, sino false.</returns>
        public static bool Guardar(Llamada llamadaProvincial) {
            string insert = $"INSERT INTO Llamadas(Duracion,Origen,Destino,Costo,Tipo) ";
            string parameters = $" VALUES(@Duracion,@Origen,@Destino,@Costo,@Tipo)";
            string fullQuery = $"{insert}{parameters}";

            try {
                if (myConnection.State != System.Data.ConnectionState.Open) {
                    myConnection.Open();
                }

                myCommand.CommandText = fullQuery;
                myCommand.Parameters.AddWithValue("@Duracion", (int)llamadaProvincial.Duracion);
                myCommand.Parameters.AddWithValue("@Origen", llamadaProvincial.NroOrigen);
                myCommand.Parameters.AddWithValue("@Destino", llamadaProvincial.NroDestino);
                myCommand.Parameters.AddWithValue("@Costo", (int)llamadaProvincial.CostoLlamada);
                myCommand.Parameters.AddWithValue("@Tipo", 1);
                int rows = myCommand.ExecuteNonQuery();
                return true;
            } catch (Exception ex) {
                throw new Exception("Excepcion en ProvincialDAO.", ex);
            } finally {
                if (myConnection.State != System.Data.ConnectionState.Closed) {
                    myConnection.Close();
                }
            }
        }

        /// <summary>
        /// Lee una lista de llamadas y las retorna.
        /// </summary>
        /// <returns>Lista de llamadas.</returns>
        public static List<Llamada> Leer() {

            float cost = 0;
            List<Llamada> llamadas = new List<Llamada>();
            Provincial llamadaProvincial;
            myCommand.CommandText = "Select * from Llamadas";
            myConnection.Open();
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read()) {
                float.TryParse(myReader["Costo"].ToString(), out cost);
                llamadaProvincial = new Provincial(Convert.ToInt32(myReader["Duracion"]), myReader["Origen"].ToString(), myReader["Destino"].ToString(), Provincial.Franja.Franja_03);
                llamadas.Add(llamadaProvincial);
            }
            myReader.Close();
            myConnection.Close();

            return llamadas;
        }

        /// <summary>
        /// Muestra Lista de llamadas Provincial con su informacion.
        /// </summary>
        /// <param name="llamadas"> Lista de llamadas Provincial.</param>
        /// <returns>La info de todas las llamadas Provincial como un string.</returns>
        public static string MostrarDatos(List<Llamada> llamadas) {
            StringBuilder sb = new StringBuilder();
            foreach (Provincial item in llamadas) {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion
    }
}
