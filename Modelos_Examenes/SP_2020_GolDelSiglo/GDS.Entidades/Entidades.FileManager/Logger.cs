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

namespace Entidades {
    public class Logger : IFile {

        /// <summary>
        /// Guarda un archivo txt en escritorio.
        /// </summary>
        /// <param name="message">Mensaje a guardar en el archivo.</param>
        /// <returns>True si pudo guardarlo, sino false.</returns>
        public bool Guardar(string message) {
            try {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
                string fileName = "Log.txt";
                using (StreamWriter writer = new StreamWriter($"{path}\\{fileName}", true)) {
                    writer.WriteLine(message);
                    return true;
                }
            } catch (Exception exe) {
                throw new Exception(exe.Message);
            }
        }

        /// <summary>
        /// Lee un archivo en escritorio.
        /// </summary>
        /// <param name="file">Ruta de donde se leera el archivo.</param>
        /// <param name="data">Data que se sacara del archivo.</param>
        /// <returns>True si pudo leer, sino false.</returns>
        public bool Leer(string file, out string data) {
            if (!File.Exists(file)) {
                throw new Exception("Excepcion");
            } else {
                using (StreamReader sr = new StreamReader(file)) {
                    data = sr.ReadToEnd();
                    return true;
                }
            }
        }
    }
}
