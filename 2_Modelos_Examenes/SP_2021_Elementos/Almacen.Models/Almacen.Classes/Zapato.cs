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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Interfaces;

namespace Models {
    public class Zapato : Producto, ISerializa, IDeserializa {


        public Zapato() : base() { }

        public Zapato(string type, string brand, float price) : base(type, brand, price) { }

        /// <summary>
        /// Gets: the path of the file.
        /// </summary>
        public string Path {
            get {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
                string fileName = "Facundo.Falcone.zapato.xml";
                string absPath = $"{path}{fileName}";

                return absPath;
            }
        }

        public bool Xml() {
            try {
                using (XmlTextWriter writer = new XmlTextWriter(this.Path, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(Zapato));
                    serial.Serialize(writer, this);
                    return true;
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying saving XML", ex);
            }
        }

        /// <summary>
        /// Reads a file and deserialize an objecto.
        /// </summary>
        /// <param name="zapato">Shoe to deserialize.</param>
        /// <returns>True if can, otherwise returns false.</returns>
        bool IDeserializa.Xml(out Zapato zapato) {
            bool aux = false;
            try {
                using (XmlTextReader reader = new XmlTextReader(this.Path)) {
                    XmlSerializer serial = new XmlSerializer(typeof(Zapato));
                    zapato = (Zapato)serial.Deserialize(reader);
                    aux = true;
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying reading Buckets", ex);
            }

            return aux;
        }
    }
}
