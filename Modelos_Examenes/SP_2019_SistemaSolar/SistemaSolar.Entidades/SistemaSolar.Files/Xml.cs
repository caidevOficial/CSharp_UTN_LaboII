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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSolar.Interfaces;
using SistemaSolar.Exceptions;
using System.Xml;
using System.Xml.Serialization;

namespace SistemaSolar.Entidades {
    public class Xml<T> : IFiles<T> {

        #region Properties

        /// <summary>
        /// Gets the directory path of the desktop.
        /// </summary>
        public string GetDirectoryPath {
            get => $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
        }

        #endregion

        #region Methods

        /// <summary>
        /// Checks if the file Exist in Desktop dir.
        /// </summary>
        /// <param name="nombreArchivo">Name of the file to search in desktop.</param>
        /// <returns>True if the file exist, otherwise returns false.</returns>
        public bool FileExists(string nombreArchivo) {
            string dir = $"{this.GetDirectoryPath}{nombreArchivo}";
            return File.Exists(dir);
        }

        /// <summary>
        /// Saves an object into a file xml-type.
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Objecto to save into the file.</param>
        public void Guardar(string nombreArchivo, T objeto) {
            Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }

        /// <summary>
        /// Saves an object into a file xml-type.
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Objecto to save into the file.</param>
        /// <param name="encoding">Type of encoding.</param>
        public void Guardar(string nombreArchivo, T objeto, Encoding encoding) {
            try {
                using (XmlTextWriter writer = new XmlTextWriter($"{this.GetDirectoryPath}{nombreArchivo}", encoding)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    serial.Serialize(writer, objeto);
                }
            } catch (Exception exe) {
                throw new ErrorArchivosException(exe.Message, exe);
            }
        }

        /// <summary>
        /// If exist, Reads a file in desktop-dir
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Object to save the info of the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public bool Leer(string nombreArchivo, out T objeto) {
            return Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }

        /// <summary>
        /// If exist, Reads a file in desktop-dir
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Object to save the info of the file.</param>
        /// <param name="encoding">Type of encoding.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding) {
            try {
                if (FileExists(nombreArchivo)) {
                    using (XmlTextReader reader = new XmlTextReader($"{this.GetDirectoryPath}{nombreArchivo}")) {
                        XmlSerializer serial = new XmlSerializer(typeof(T));
                        objeto = (T)serial.Deserialize(reader);
                        return true;
                    }
                }
            } catch (Exception exe) {
                throw new ErrorArchivosException(exe.Message, exe);
            }
            objeto = default(T);
            return false;
        }

        #endregion
    }
}
