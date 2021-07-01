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

namespace ComiqueriaLogic {
    public class ArchivoTexto {

        /// <summary>
        /// Writes a file with an specific info contained inside an entity.
        /// </summary>
        /// <param name="myObject">Entity to extract the data.</param>
        /// <param name="append">Append text or replaces it.</param>
        /// <returns>True if can write, otherwise returns false.</returns>
        public static bool Escribir(ComiqueriaException myObject, bool append) {
            using (StreamWriter sw = new StreamWriter(myObject.Ruta, append, Encoding.UTF8)) {
                sw.WriteLine(myObject.Texto);
                return true;
            }
        }

        /// <summary>
        /// Reads a file in a specific path, then obtains its data.
        /// </summary>
        /// <param name="path">Path to read the file.</param>
        /// <param name="data">Data of the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public static bool Leer(string path, out string data) {
            if (File.Exists(path)) {
                using (StreamReader sr = new StreamReader(path)) {
                    data = sr.ReadToEnd();
                    return true;
                }
            }
            data = default;
            return false;
        }
    }
}
