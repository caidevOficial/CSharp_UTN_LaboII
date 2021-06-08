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

namespace Application.Files.Text {
    public class Text<T> : IFile<string> {

        #region Methods

        /// <summary>
        /// Reads a path and gets the content of the file.
        /// </summary>
        /// <param name="file">Path to read.</param>
        /// <param name="data">Data of the readed file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public bool Read(string file, out string data) {
            if (!File.Exists(file)) {
                throw new Exception("Excepcion");
            } else {
                using (StreamReader sr = new StreamReader(file)) {
                    data = sr.ReadToEnd();
                    return true;
                }
            }
        }

        /// <summary>
        /// Saves a stream into a file.
        /// </summary>
        /// <param name="file">Path to save the file.</param>
        /// <param name="data">Data to write into the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool Save(string file, string data) {
            StringBuilder fulldata = new StringBuilder();
            fulldata.AppendLine($"{DateTime.Now} - {data}\n-----------------------------");
            if (!Directory.Exists(file)) {
                Directory.CreateDirectory(file);
            }
            using (StreamWriter sw = File.AppendText($"{file}")) {
                sw.WriteLine(fulldata);
                return true;
            }
        }

        #endregion

    }
}
