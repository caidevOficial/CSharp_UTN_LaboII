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

using Application.Exceptions;
using Application.Files.Xml;
using Application.Models;
using System;
using System.Collections.Generic;

namespace Application.DataAcces {
    // <summary>
    // Servicio para deserializar y serializar un cliente
    // </summary>
    public class CustomerSerializer : Xml<List<Customer>> {
        public bool Save(List<Customer> customer) {
            string path = AppDomain.CurrentDomain.BaseDirectory + "OtherCustomers.xml";
            return base.Save(path, customer);
        }

        public List<Customer> Read(string path) {
            List<Customer> customers = new List<Customer>();

            if (!base.Read(path, out customers)) {
                throw new TechnicalException("No se pudo abrir el archivo");
            }

            return customers;

        }
    }
}
