﻿/*
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

using System.Collections.Generic;

namespace Clases {
    public class Libro {
        private List<string> paginas = new List<string>();

        /// <summary>
        /// leerá la página pedida, siempre y cuando el subíndice se encuentre 
        /// dentro de un rango correcto, sino retornará un string vacio “”. 
        /// Si el índice es superior al máximo existente, agregará una nueva página.
        /// </summary>
        /// <param name="i"></param>
        /// <returns>La página pedida o un string vacio.</returns>
        public string this[int i] {

            get {
                if (i < this.paginas.Count) {
                    return this.paginas[i];
                } else {
                    return "";
                }
            }
            set {
                if (i < this.paginas.Count) {
                    this.paginas[i] = value;
                } else {
                    paginas.Add(value);
                }
            }
        }
    }
}
