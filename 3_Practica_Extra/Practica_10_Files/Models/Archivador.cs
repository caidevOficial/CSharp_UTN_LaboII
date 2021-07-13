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
using System.Runtime.Serialization.Formatters.Binary;

namespace Models {
    public static class Archivador {

        #region Methods

        /// <summary>
        /// Saves a file into an specified directory.
        /// </summary>
        /// <param name="textToSave">Text to write in the file.</param>
        /// <param name="pathToSave">Path to save the file.</param>
        /// <param name="nameOfFile">Name of the file.</param>
        /// <param name="seAnexa">boolean state that indicate if we can overwrite the file or just append the new data.</param>
        /// <returns>True if can save the file, otherwise returns false.</returns>
        public static bool Guardar(string textToSave, string pathToSave, string nameOfFile, bool seAnexa) {
            if (Directory.Exists(pathToSave)) {
                string fullDirectory = $"{pathToSave}\\{nameOfFile}.txt";
                using (StreamWriter sw = new StreamWriter(fullDirectory, seAnexa)) {
                    sw.WriteLine(textToSave);
                    return true;
                }
            } else {
                throw new Exception("Excepcion");
            }
        }

        /// <summary>
        /// Reads a file, just that.
        /// </summary>
        /// <param name="filePath">Path to find the file to read.</param>
        /// <returns>A string with the text of the file.</returns>
        public static string Leer(string filePath) {
            if (!File.Exists(filePath)) {
                throw new Exception("Excepcion");
            } else {
                using (StreamReader sr = new StreamReader(filePath)) {
                    return sr.ReadToEnd();
                }
            }
        }

        public static bool GuardarBin(string textToSave, string pathToSave) {
            bool retorno = false;
            try {
                //string fullDirectory = $"{pathToSave}\\{nameOfFile}.bin";
                using (FileStream fileStream = new FileStream(pathToSave, FileMode.OpenOrCreate)) {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, textToSave);
                    retorno = true;
                }
            } catch (Exception) {

                throw new Exception();
            }
            return retorno;
        }

        public static string LeerBin(string pathToRead) {
            string retorno = string.Empty;
            using (FileStream fileStream = new FileStream(pathToRead, FileMode.Open)) {
                BinaryFormatter formatter = new BinaryFormatter();
                retorno = (string)formatter.Deserialize(fileStream);
            }
            return retorno;
        }

        #endregion

    }
}
