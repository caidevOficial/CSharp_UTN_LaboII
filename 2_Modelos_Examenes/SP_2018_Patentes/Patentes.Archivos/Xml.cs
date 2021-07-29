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
using Entidades;

namespace Archivos {
    public class Xml<T> : IArchivo<T> {

        /// <summary>
        /// Saves an object type T into a xml file.
        /// </summary>
        /// <param name="archivo">Path to save the file.</param>
        /// <param name="datos">Object to save into a file.</param>
        public void Guardar(string archivo, T datos) {
            try {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    serial.Serialize(writer, datos);
                }
            } catch (Exception ex) {
                throw new PatenteInvalidaException("Patente invalida", ex);
            }
        }

        /// <summary>
        /// Reads a file to parse an abject.
        /// </summary>
        /// <param name="archivo">Path to read the file.</param>
        /// <param name="datos">Object to read from a file.</param>
        public void Leer(string archivo, out T datos) {
            datos = default;
            try {
                using (XmlTextReader reader = new XmlTextReader(archivo)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    //if (serial.CanDeserialize(reader)) {
                        datos = (T)serial.Deserialize(reader);
                    //}
                }
            } catch (Exception ex) {
                throw new PatenteInvalidaException("Patente invalida", ex);
            }
        }
    }
}
