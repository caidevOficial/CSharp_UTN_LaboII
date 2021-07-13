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
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Models {
    [Serializable]
    public class Persona {

        #region Attributes

        private string nombre;
        private string apellido;

        #endregion

        #region Builders

        public Persona() { }

        /// <summary>
        /// Creates the entity with name and surname.
        /// </summary>
        /// <param name="nombre">Name of the entity</param>
        /// <param name="apellido">Surname of the entity</param>
        public Persona(string nombre, string apellido) {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: The name of the entity.
        /// </summary>
        public string Nombre {
            get => this.nombre;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: The surname of the entity.
        /// </summary>
        public string Apellido {
            get => this.apellido;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.apellido = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Saves an xml file
        /// </summary>
        /// <param name="path">Path to save the xml.</param>
        /// <param name="aPerson">Objecto to be writed into the file.</param>
        public static void Guardar(string path, Persona aPerson) {
            using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8)) {
                XmlSerializer serial = new XmlSerializer(typeof(Persona));
                serial.Serialize(writer, aPerson);
            }
        }

        /// <summary>
        /// Reads a file, extract the data and creates an object.
        /// </summary>
        /// <param name="path">Path to read the file.</param>
        /// <returns>An object type Persona.</returns>
        public static Persona Leer(string path) {
            Persona aux;
            using (XmlTextReader reader = new XmlTextReader(path)) {
                XmlSerializer serial = new XmlSerializer(typeof(Persona));
                aux = (Persona)serial.Deserialize(reader);
            }

            return aux;
        }

        /// <summary>
        /// Gets the info of the entity.
        /// </summary>
        /// <returns>The info of the entity as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Name: {this.Nombre}");
            data.AppendLine($"Surname: {this.Apellido}");

            return data.ToString();
        }

        #endregion
    }
}
