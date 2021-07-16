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
using System.Xml;
using System.Xml.Serialization;

namespace Entidades {
    public class XmlManager<T> : IReadData<T> {

        private const string XML_EXTENSION = ".xml";

        /// <summary>
        /// Reads an xml and gets a list of patients.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        /// <param name="data">List to get.</param>
        /// <returns>True if can, otherwise returns false.</returns>
        public T ReadData(string path, T data) {
            try {
                if (path.EndsWith(XML_EXTENSION)) {
                    using (XmlTextReader reader = new XmlTextReader(path)) {
                        XmlSerializer serial = new XmlSerializer(typeof(T));
                        if (serial.CanDeserialize(reader)) {
                            data = (T)serial.Deserialize(reader);
                        }
                    }
                } else {
                    throw new ArchivoInvalidoException("Solo se permite XML");
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying reading xml", ex);
            }
            return data;
        }
    }
}
