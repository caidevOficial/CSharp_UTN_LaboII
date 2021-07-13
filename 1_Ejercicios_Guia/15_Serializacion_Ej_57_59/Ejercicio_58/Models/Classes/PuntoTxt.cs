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

using Exceptions;
using Interface;
using System;
using System.IO;

namespace Models {

    public class PuntoTxt : Archivo, IArchivos<string> {

        #region Methods

        /// <summary>
        /// Saves the file
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="objeto">Content of the file to save.</param>
        /// <returns>True if can save the file, otherwise returns false.</returns>
        public bool Guardar(string path, string objeto) {
            if (this.ValidarArchivo(path, true)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine(objeto);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Saves the file
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="objeto">Content of the file to save.</param>
        /// <returns>True if can save the file, otherwise returns false.</returns>
        public bool GuardarComo(string path, string objeto) {
            return this.Guardar(path, objeto);
        }

        /// <summary>
        /// Reads a file and get its content.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        /// <returns>The content of the file if can read it.</returns>
        public string Leer(string path) {
            string text = string.Empty;
            if (this.ValidarArchivo(path, true)) {
                using (StreamReader sr = new StreamReader(path)) {
                    text = sr.ReadToEnd();
                }
            }

            return text;
        }

        /// <summary>
        /// It will validate that the file exist only if 'calidateExistence' is true
        /// otherwise will throw an exception.
        /// </summary>
        /// <param name="path">Path to verify if the file exist.</param>
        /// <param name="validateExistence">Boolean state that indicates fi the method need to validate the existence of the file.</param>
        /// <returns>True if is a valid file, othewise returns false</returns>
        protected override bool ValidarArchivo(string path, bool validateExistence) {
            try {
                if (base.ValidarArchivo(path, validateExistence)) {
                    if (Path.GetExtension(path) == ".txt") {
                        return true;
                    } else {
                        throw new ArchivoIncorrectoException("El archivo no es un txt.");
                    }
                }
            } catch (FileNotFoundException fn) {
                throw new ArchivoIncorrectoException("El archivo no es un txt.", fn);
            } catch (ArchivoIncorrectoException fn) {
                throw new ArchivoIncorrectoException("El archivo no es un txt.", fn);
            }

            return false;
        }

        #endregion

    }
}
