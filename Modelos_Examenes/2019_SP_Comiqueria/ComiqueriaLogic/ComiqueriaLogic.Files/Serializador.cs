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
using System.Xml;
using System.Xml.Serialization;

namespace ComiqueriaLogic {
    public static class Serializador<T>
        where T: class, new() {

        /// <summary>
        /// Saves a data into a binnary File. 
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="data">Data to save into the file.</param>
        /// <returns>True if can save the data, otherwise returns false.</returns>
        public static bool BinnarySave(string path, T data) {
            try {
                using(BinaryWriter writer = new BinaryWriter(File.OpenWrite(path))) {
                    writer.Write(data.ToString());
                    return true;
                }
            } catch (DirectoryNotFoundException exe) {
                ComiqueriaException comExe = new ComiqueriaException("Error: Directorio no encontrado", exe);
                ArchivoTexto.Escribir(comExe, true);
                throw comExe;
            } catch (ArgumentException exe) {
                throw new ArgumentException(exe.Message);
            } catch (Exception exe) {
                ComiqueriaException comExe = new ComiqueriaException("Ocurrió un error, contacte al administrador.", exe);
                ArchivoTexto.Escribir(comExe, true);
                throw comExe;
            }
        }

        /// <summary>
        /// Saves a data into a xml File. 
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="data">Data to save into the file.</param>
        /// <returns>True if can save the data, otherwise returns false.</returns>
        public static bool XMLSave(string path, T data) {
            try {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    serial.Serialize(writer, data);
                    return true;
                }
            } catch (ArgumentException exe) {
                throw new ArgumentException(exe.Message);
            } catch (Exception exe) {
                ComiqueriaException comExe = new ComiqueriaException("Ocurrió un error, contacte al administrador.", exe);
                ArchivoTexto.Escribir(comExe, true);
                throw comExe;
            }
        }

        /// <summary>
        /// Reads a file from a path and returns its content.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        /// <param name="data">Content of the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public static bool BinnaryRead(string path, out string data) {
            try {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(path))) {
                    data = reader.ReadString();
                    return true;
                }
            } catch (DirectoryNotFoundException exe) {
                ComiqueriaException comExe = new ComiqueriaException("Error: Directorio no encontrado", exe);
                ArchivoTexto.Escribir(comExe, true);
                throw comExe;
            } catch (ArgumentException exe) {
                throw new ArgumentException(exe.Message);
            } catch (Exception exe) {
                ComiqueriaException comExe = new ComiqueriaException("Ocurrió un error, contacte al administrador.", exe);
                ArchivoTexto.Escribir(comExe, true);
                throw comExe;
            }
        }

        /// <summary>
        /// Reads a file from a path and returns its content.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        /// <param name="data">Content of the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public static bool XMLRead(string path, out T data) {
            try {
                if (File.Exists(path)) {
                    using (XmlTextReader reader = new XmlTextReader(path)) {
                        XmlSerializer serial = new XmlSerializer(typeof(T));
                        data = (T)serial.Deserialize(reader);
                        return true;
                    }
                }
            } catch (DirectoryNotFoundException exe) {
                ComiqueriaException comExe = new ComiqueriaException("Error: Directorio no encontrado", exe);
                ArchivoTexto.Escribir(comExe, true);
                throw comExe;
            } catch (Exception exe) {
                ComiqueriaException comExe = new ComiqueriaException("Ocurrió un error, contacte al administrador.", exe);
                ArchivoTexto.Escribir(comExe, true);
                throw comExe;
            }

            data = default(T);
            return false;
        }
    }
}
