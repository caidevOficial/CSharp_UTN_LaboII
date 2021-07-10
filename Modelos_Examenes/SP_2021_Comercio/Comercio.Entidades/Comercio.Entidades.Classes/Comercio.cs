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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades {
    public class Comercio : IBackup {

        #region Attributes

        private List<Cliente> clientes;

        #endregion

        #region Builders

        /// <summary>
        /// Default builder.
        /// </summary>
        public Comercio() {
            this.clientes = new List<Cliente>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets the list of customers.
        /// </summary>
        public List<Cliente> Clientes { 
            get => this.clientes; 
            set => this.clientes = value; 
        }

        #endregion

        #region Operators

        /// <summary>
        /// Assigns the number of the customer and add into the list.
        /// </summary>
        /// <param name="comercio">Bussiness to check the list.</param>
        /// <param name="cliente">Customer to add into the list.</param>
        /// <returns>Tye bussines with the customer inside.</returns>
        public static Comercio operator +(Comercio comercio, Cliente cliente) {
            int nextNumber = 1;
            if(!(comercio is null) && !(cliente is null)) {
                if(comercio.clientes.Count > 0) {
                    nextNumber = (comercio.clientes.Count+1);
                }
                cliente.Numero = nextNumber;
                comercio.clientes.Add(cliente);
            }

            return comercio;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Loads a xml file.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        public void LoadBackup(string path) {
            try {
                if (File.Exists(path)) {
                    using (XmlTextReader reader = new XmlTextReader(path)) {
                        XmlSerializer serial = new XmlSerializer(typeof(List<Cliente>));
                        this.clientes = (List<Cliente>)serial.Deserialize(reader);
                    }
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying reading customers", ex);
            }
        }

        /// <summary>
        /// Saves the list of customers.
        /// </summary>
        /// <param name="path">Path to save the list.</param>
        public void SaveBackup(string path) {
            try {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(List<Cliente>));
                    serial.Serialize(writer, this.Clientes);
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying saving customers", ex);
            }
        }

        /// <summary>
        /// Calls the first customer of the list, then removes it or throws an exception 
        /// if the list is empty.
        /// </summary>
        /// <returns>The customer.</returns>
        public Cliente LlamarCliente() {
            Cliente myCliente = new Cliente();
            if (this.clientes.Count == 0) {
                throw new SinClientesException();
            } else {
                myCliente.Nombre = this.clientes[0].Nombre;
                myCliente.Numero = this.clientes[0].Numero;
                this.clientes.RemoveAt(0);
            }

            return myCliente;
        }

        #endregion
    }
}
