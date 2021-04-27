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

using System.Collections.Generic;
using System.Text;

namespace Entidades {
    public class Bar {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        #region Builders

        private Bar() {
            this.empleados = new List<Empleado>();// { new Empleado("Facu", 31)};
            this.gente = new List<Gente>();// { new Gente(52), new Gente(42), new Gente(56)};

        }

        public static Bar GetBar() {
            if (Bar.singleton is null) {
                Bar.singleton = new Bar();
            }

            return Bar.singleton;
        }

        #endregion

        #region Properties

        public List<Empleado> Empleados {
            get => this.empleados;
        }

        public List<Gente> Gente {
            get => this.gente;
        }

        #endregion

        #region Operators

        public static bool operator +(Bar bar, Empleado empleado) {
            if (!(bar is null) && !(empleado is null)) {
                if (bar.empleados.Count == 0 && empleado.Validar()) {
                    bar.empleados.Add(empleado);
                    return true;
                } else {
                    foreach (Empleado empleadoDeBar in bar.empleados) {
                        if ((empleadoDeBar != empleado) && empleado.Validar()) {
                            bar.empleados.Add(empleado);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static bool operator +(Bar bar, Gente gente) {
            if (!(bar is null) && !(gente is null)) {
                if (bar.gente.Count < (bar.empleados.Count * 10) &&
                    gente.Validar()) {
                    bar.gente.Add(gente);
                    return true;
                }

            }

            return false;
        }

        #endregion

        #region Methods

        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine("=== Empleados =====#");
            foreach (Empleado e in this.empleados) {
                data.Append(e.ToString());
            }
            data.AppendLine("=== Clientes =====#");
            foreach (Gente g in this.gente) {
                data.Append(g.ToString());
            }
            data.Append("========#");

            return data.ToString();
        }

        #endregion
    }
}
