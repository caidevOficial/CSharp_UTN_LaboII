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
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades {
    public class SerializarXML<T> : IArchivos<T> {

        /// <summary>
        /// Saves an object into a file.
        /// </summary>
        /// <param name="path">Path to save the file</param>
        /// <param name="objeto">Object to save</param>
        /// <returns>True if can save, otherwise returns false.</returns>
        public bool Guardar(string path, T objeto) {
            bool success = false;
            try {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    serial.Serialize(writer, objeto);
                    success = true;
                }
            } catch (Exception exe) {
                throw new ErrorArchivoException("Error al guardar archivo", exe);
            }
            return success;
        }

        /// <summary>
        /// Read a file and convert into an object
        /// </summary>
        /// <param name="path">Path to read the file</param>
        /// <returns>The object</returns>
        public T Leer(string path) {
            T vote = default;
            try {
                if (File.Exists(path)) {
                    using (XmlTextReader reader = new XmlTextReader(path)) {
                        XmlSerializer serial = new XmlSerializer(typeof(T));
                        vote = (T)serial.Deserialize(reader);
                    }
                }
            } catch (Exception exe) {
                throw new ErrorArchivoException("Error al leer archivo", exe);
            }
            return vote;
        }
    }
}
