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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        #region Builders

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.edad = edad;
        }

        #endregion

        #region Properties

        public string Apellido
        {
            get => this.apellido;
        }

        public string Nombre
        {
            get => this.nombre;
        }

        public int Edad
        {
            get => this.edad;
        }

        public int Dni
        {
            get => this.dni;
        }

        #endregion

        #region Methods

        public virtual string Mostrar()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {this.nombre}");
            data.AppendLine($"Apellido: {this.apellido}");
            data.AppendLine($"DNI: {this.dni}");
            data.AppendLine($"Edad: {this.edad}");

            return data.ToString();
        }

        public abstract bool ValidarAptitud();

        #endregion
    }
}
