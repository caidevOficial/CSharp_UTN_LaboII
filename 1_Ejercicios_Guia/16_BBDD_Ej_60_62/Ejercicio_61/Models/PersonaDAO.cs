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

namespace Models {
    public static class PersonaDAO {

        #region Attributes

        private static string connString;
        private static SqlConnection myConnection;
        private static SqlCommand myCommand;

        #endregion

        static PersonaDAO() {
            connString = " Server = localhost ; Database = Personas; Trusted_Connection = true ; ";
            myConnection = new SqlConnection(connString);
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        #region Methods

        /// <summary>
        /// Reads a list of persons from the DB.
        /// </summary>
        /// <returns>list of persons from the DB.</returns>
        public static List<Persona> Leer() {
            List<Persona> personas = new List<Persona>();
            myCommand.CommandText = String.Format($"SELECT * FROM Personas");
            myConnection.Open();
            SqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read()) {
                personas.Add(new Persona(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["surname"].ToString()));
            }
            reader.Close();
            myCommand.Parameters.Clear();
            myConnection.Close();

            return personas;
        }

        /// <summary>
        /// Reads a person bassed by its id.
        /// </summary>
        /// <param name="idPersona">Id of the person to read.</param>
        /// <returns>A person bassed by its id.</returns>
        public static Persona LeerPorID(int idPersona) {
            myCommand.CommandText = String.Format($"SELECT * FROM Personas WHERE id = @idPersona");
            myCommand.Parameters.AddWithValue("@idPersona", idPersona);
            SqlDataReader reader = myCommand.ExecuteReader();
            Persona actualPerson = null;
            myConnection.Open();
            while (reader.Read()) {
                actualPerson = new Persona(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["surname"].ToString());
            }
            reader.Close();
            myCommand.Parameters.Clear();
            myConnection.Close();

            return actualPerson;
        }

        /// <summary>
        /// Saves a person into the DB.
        /// </summary>
        /// <param name="entity">Person to save into the DB.</param>
        public static void Guardar(Persona entity) {
            try {
                myConnection.Open();
                myCommand.CommandText = $"INSERT INTO Personas Values(@Name,@Surname);";
                myCommand.Parameters.AddWithValue("@Name", entity.Nombre);
                myCommand.Parameters.AddWithValue("@Surname", entity.Apellido);
                int rows = myCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                throw new Exception("Error Saving.", ex);
            } finally {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }
        }

        /// <summary>
        /// Updates a customer from the DB.
        /// </summary>
        /// <param name="entity">Customer to update.</param>
        public static void Modificar(Persona entity) {
            try {
                myConnection.Open();
                if (!(entity is null)) {
                    myCommand.CommandText = $"UPDATE Personas SET name = @Name, surname = @Surname WHERE id = @id;";
                    myCommand.Parameters.AddWithValue("@name", entity.Nombre);
                    myCommand.Parameters.AddWithValue("@surname", entity.Apellido);
                    myCommand.Parameters.AddWithValue("@id", entity.ID);
                    int rows = myCommand.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                throw new Exception("Error updating", ex);
            } finally {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }
        }

        /// <summary>
        /// Deletes a Person from the DB.
        /// </summary>
        /// <param name="idPersona">ID of the person to delete.</param>
        public static void Borrar(int idPersona) {
            try {
                myConnection.Open();
                myCommand.CommandText = $"DELETE FROM Personas WHERE id=@id;";
                myCommand.Parameters.AddWithValue("@id", idPersona);
                int rows = myCommand.ExecuteNonQuery();
            } catch (Exception e) {
                throw new Exception("Error deleting", e);
            } finally {
                myCommand.Parameters.Clear();
                myConnection.Close();
            }
        }

        #endregion
    }
}
