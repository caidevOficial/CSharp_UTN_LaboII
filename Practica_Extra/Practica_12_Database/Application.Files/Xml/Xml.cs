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

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Application.Files.Xml {
    public class Xml<T> : IFile<T> {

        #region Methods

        /// <summary>
        /// Reads a path and gets the content of the file.
        /// </summary>
        /// <param name="file">Path to read.</param>
        /// <param name="data">Data of the readed file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public bool Read(string file, out T data) {
            if (File.Exists(file)) {
                using (XmlTextReader reader = new XmlTextReader(file)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    data = (T)serial.Deserialize(reader);
                }

                return true;
            }
            data = default(T);
            return false;
        }

        /// <summary>
        /// Saves a stream into a file.
        /// </summary>
        /// <param name="file">Path to save the file.</param>
        /// <param name="data">Data to write into the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool Save(string file, T data) {
            using (XmlTextWriter writer = new XmlTextWriter(file, Encoding.UTF8)) {
                XmlSerializer serial = new XmlSerializer(typeof(T));
                serial.Serialize(writer, data);
                return true;
            }
        }

        #endregion

    }
}
