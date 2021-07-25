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

namespace Models {
    public class Facturadora {

        private static string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\facturas.log";

        /// <summary>
        /// Saves a text file with a price.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="price">Float number to write inside the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public static bool ImprimirFactura(float price) {
            bool success = false;
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{DateTime.Now.ToShortTimeString()}");
            data.AppendLine($"Price: ${price}");

            using (StreamWriter sw = File.AppendText($"{path}")) {
                sw.WriteLine(data.ToString()); ;
                success = true;
            }

            return success;
        }

        /// <summary>
        /// Reads a file and returns the string contained inside of the file.
        /// </summary>
        /// <returns>A string with the info of the file.</returns>
        public static string ReadLog(string fullPath) {
            string myText = string.Empty;
            if (!File.Exists(fullPath)) {
                throw new Exception("Excepcion");
            } else {
                using (StreamReader sr = new StreamReader(fullPath)) {
                    myText = sr.ReadToEnd();
                }
            }

            return myText;
        }
    }
}
