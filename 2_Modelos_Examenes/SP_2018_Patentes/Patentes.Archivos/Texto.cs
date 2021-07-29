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
using Entidades;

namespace Archivos {
    public class Texto : IArchivo<Queue<Patente>> {

        /// <summary>
        /// Saves an object type T into a txt file.
        /// </summary>
        /// <param name="archivo">Path to save the file.</param>
        /// <param name="datos">Object to save into a file.</param>
        public void Guardar(string archivo, Queue<Patente> datos) {
            using (StreamWriter file = new StreamWriter(archivo, true)) {
                foreach (Patente item in datos) {
                    file.WriteLine(item);
                }
            }
        }

        /// <summary>
        /// Reads a file to parse an abject.
        /// </summary>
        /// <param name="archivo">Path to read the file.</param>
        /// <param name="datos">Object to read from a file.</param>
        public void Leer(string archivo, out Queue<Patente> datos) {
            datos = new Queue<Patente>();
            try {
                string myText = string.Empty;
                using (StreamReader sr = new StreamReader(archivo)) {
                    while (!sr.EndOfStream) {
                        datos.Enqueue(sr.ReadLine().ValidarPatente());
                    }
                }
            } catch (Exception exe) {
                throw new PatenteInvalidaException("Patente invalida", exe);
            }
        }
    }
}
