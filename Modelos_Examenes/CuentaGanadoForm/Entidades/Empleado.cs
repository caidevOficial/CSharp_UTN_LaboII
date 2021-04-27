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

namespace Entidades
{
    public class Empleado : Persona
    {

        private int dni;

        #region Builders
        
        public Empleado(string nombre, short edad)
            : this(nombre, edad, -1)
        {
        }

        public Empleado(string nombre, short edad, int dni)
            : base(nombre, edad) 
        {
            this.dni = dni;
        }

        #endregion

        #region Operators
        
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.Nombre == e2.Nombre && e1.Edad == e2.Edad;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        #endregion

        #region Methods
        
        public override bool Validar()
        {
            return this.Edad > 20 && this.Nombre.Length > 1;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine(base.Mostrar());
            if (this.dni != -1)
            {
                data.AppendLine($"DNI: {this.dni}");
            }

            return data.ToString();
        }

        #endregion
    }
}
