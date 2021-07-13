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

namespace IO {
    public class ArchivoTexto {

        #region Methods

        /// <summary>
        /// Tries to write a file.
        /// </summary>
        /// <param name="path">Path to the file to create.</param>
        /// <param name="infoToSave">Information to save into the new file.</param>
        /// <returns>True if can create the file with the information, otherwise returns false.</returns>
        public static bool Guardar(string path, string infoToSave) {
            if (!String.IsNullOrWhiteSpace(path)) {
                using (StreamWriter sw = new StreamWriter($"{path}")) {
                    sw.WriteLine(infoToSave);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Tries to open a file and return its content.
        /// </summary>
        /// <param name="path">Path of the file to read.</param>
        /// <returns>The content of the file or an exception.</returns>
        public static string Leer(string path) {
            string fileContent = string.Empty;
            if (!String.IsNullOrWhiteSpace(path) && File.Exists(path)) {
                using (StreamReader sr = new StreamReader(path)) {
                    fileContent = sr.ReadToEnd();
                }
            } else {
                throw new FileNotFoundException("File not found, perri");
            }

            return fileContent;
        }

        #endregion

    }
}
