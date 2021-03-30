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

namespace NewUser
{
    public class Usuario
    {
        private string name;
        private string surname;
        private string dni;
        string[] formasPago;
        private string tipoPago;
        private string provincia;

        public Usuario()
        {

        }

        public Usuario(string name, string surname, string dni, string[] formasPago, string tipoPago, string provincia)
        {
            this.name = name;
            this.surname = surname;
            this.dni = dni;
            this.formasPago = formasPago;
            this.tipoPago = tipoPago;
            this.provincia = provincia;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string MostrarNombre()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Name: {this.name}");
            data.AppendLine($"Surname: {this.surname}");
            return data.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarNombre();
        }
    }
}
