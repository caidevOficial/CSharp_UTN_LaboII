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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic {
    public class ComiqueriaException : Exception, IArchivoTexto {

        /// <summary>
        /// Default Constructor of the Exception ComiqueriaException
        /// </summary>
        /// <param name="message">Message of ComiqueriaException</param>
        /// <param name="innerException">Inner Exception of ComiqueriaException</param>
        public ComiqueriaException(string message, Exception innerException)
            : base(message, innerException) { }

        /// <summary>
        /// Gets the path of the file Log.txt
        /// </summary>
        public string Ruta {
            get => $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\log.txt";
        }

        /// <summary>
        /// Retuns the actual date and the message of all the exceptions.
        /// </summary>
        public string Texto {
            get {
                StringBuilder data = new StringBuilder();
                data.AppendLine($"{DateTime.Now.ToShortDateString()} - {this.Message}");
                if (!(this.InnerException is null)) {
                    Exception anExe = this.InnerException;
                    data.AppendLine($" {anExe.Message}");
                    while(!(anExe is null)) {
                        anExe = anExe.InnerException;
                        data.AppendLine($" {anExe.Message}");
                    }
                }
                return data.ToString();
            }
        }
    }
}
