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

using System.Text;

namespace SistemaSolar.Interfaces {
    public interface IFiles<T> {

        /// <summary>
        /// Saves an object into a file xml-type.
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Objecto to save into the file.</param>
        void Guardar(string nombreArchivo, T objeto);

        /// <summary>
        /// Saves an object into a file xml-type.
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Objecto to save into the file.</param>
        /// <param name="encoding">Type of encoding.</param>
        void Guardar(string nombreArchivo, T objeto, Encoding encoding);

        /// <summary>
        /// If exist, Reads a file in desktop-dir
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Object to save the info of the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        bool Leer(string nombreArchivo, out T objeto);

        /// <summary>
        /// If exist, Reads a file in desktop-dir
        /// </summary>
        /// <param name="nombreArchivo">Name of the File.</param>
        /// <param name="objeto">Object to save the info of the file.</param>
        /// <param name="encoding">Type of encoding.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        bool Leer(string nombreArchivo, out T objeto, Encoding encoding);
    }
}
