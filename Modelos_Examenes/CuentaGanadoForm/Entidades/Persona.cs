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
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        #region Builders
       
        protected Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        #endregion

        #region Properties
        
        public short Edad
        {
            get => this.edad;
            set
            {
                if (value > 0)
                {
                    this.edad = value;
                }
            }
        }
        
        public string Nombre
        {
            get => this.nombre;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }

        #endregion

        #region Operators
        
        public static explicit operator string(Persona persona)
        {
            return persona.Mostrar();
        }

        #endregion

        #region Methods
        
        protected virtual string Mostrar()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Tipo: {this.GetType().Name}");
            if (!(String.IsNullOrWhiteSpace(this.Nombre)))
            {
                data.AppendLine($"Nombre: {this.Nombre}");
            }
            data.AppendLine($"Edad: {this.Edad}");

            return data.ToString();
        }

        public abstract bool Validar();

        #endregion
    }
}
