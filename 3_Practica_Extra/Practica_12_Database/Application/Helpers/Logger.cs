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

using Application.Files.Text;
using System;
using System.Text;

namespace Application.Helpers {
    public static class Logger {

        #region Method

        /// <summary>
        /// Writes a File with the data of the exception.
        /// </summary>
        /// <param name="log">Data of the exception.</param>
        public static void LogException(string log) {
            Text<string> myText = new Text<string>();
            StringBuilder data = new StringBuilder();
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Log.txt";

            data.AppendLine($"{DateTime.Now} - {log}");
            myText.Save(path, data.ToString());

        }

        #endregion

    }
}
