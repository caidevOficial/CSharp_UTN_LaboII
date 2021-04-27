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

using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public abstract class Personaje
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        protected List<EHabilidades> ataques;
        protected int nivelPoder;
        protected string nombre;

        #region Builders

        private Personaje() {
            ataques = new List<EHabilidades>();
        }

        protected Personaje(string nombre, int nivelPoder) : this() {
            this.nombre = nombre;
            this.nivelPoder = nivelPoder;
        }

        protected Personaje(string nombre, int nivelPoder, List<EHabilidades> ataques)
            : this(nombre, nivelPoder) {
            this.ataques = new List<EHabilidades>(ataques);
        }

        #endregion

        #region Properties

        protected abstract string Descripcion { get; }

        #endregion

        #region Operators

        public static bool operator ==(Personaje p, List<Personaje> listaPersonajes) {
            if (!(p is null) && !(listaPersonajes is null)) {
                return listaPersonajes.Contains(p);
            }

            return false;
        }

        public static bool operator !=(Personaje p, List<Personaje> listaPersonajes) {
            return !(p == listaPersonajes);
        }

        public static bool operator ==(Personaje p1, Personaje p2) {
            return p1.GetType().Name == p2.GetType().Name && p1.nombre == p2.nombre;
        }

        public static bool operator !=(Personaje p1, Personaje p2) {
            return !(p1 == p2);
        }

        #endregion

        #region Methods

        public virtual string InfoPersonaje() {
            StringBuilder data = new StringBuilder();
            data.AppendLine(String.Format("Nombre: {0}", this.nombre));
            data.AppendLine($"PowerLevel: {this.nivelPoder}");
            data.AppendLine($"Descripcion: {this.Descripcion}");
            data.AppendLine("Ataques:");
            foreach (EHabilidades eHabilidades in ataques) {
                data.AppendLine(eHabilidades.ToString());
            }

            return data.ToString();
        }


        public override string ToString() {
            return this.nombre;
        }
        public abstract string Transformarse();

        #endregion
    }
}
