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
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades {
    public class GestorDeArchivos : IGuardar<Carrera>, IGuardar<AutoF1> {

        private readonly string ruta;

        /// <summary>
        /// Builder with path of the file to read or save.
        /// </summary>
        /// <param name="ruta"></param>
        public GestorDeArchivos(string ruta) {
            this.ruta = ruta;
        }

        /// <summary>
        /// Serializes a race.
        /// </summary>
        /// <param name="tipo">Race class to serialize.</param>
        public void Guardar(Carrera tipo) {
            string absPath = this.ruta;
            try {
                using (XmlTextWriter writer = new XmlTextWriter(absPath, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(Carrera));
                    serial.Serialize(writer, tipo);
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying saving Race", ex);
            }
        }

        /// <summary>
        /// Saves an object of 'AutoF1' class into a txt file..
        /// </summary>
        /// <param name="tipo">Objecto to save.</param>
        void IGuardar<AutoF1>.Guardar(AutoF1 tipo) {
            string absPath = this.ruta;
            StringBuilder data = new StringBuilder();
            data.AppendLine(tipo.ToString());
            try {
                using (StreamWriter sw = File.AppendText($"{absPath}")) {
                    sw.WriteLine(data);
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying saving Document", ex);
            }
        }

        /// <summary>
        /// Reads an xml's file and convert to an object of type 'Carrera'.
        /// </summary>
        /// <returns>The entity Carrera</returns>
        public Carrera LeerXML() {
            Carrera thisOne = null;
            string absPath = this.ruta;
            try {
                if (!File.Exists(absPath)) {
                    throw new ArchivoException("Error al leer archivo");
                }
                using (XmlTextReader reader = new XmlTextReader(absPath)) {
                    XmlSerializer serial = new XmlSerializer(typeof(Carrera));
                    thisOne = (Carrera)serial.Deserialize(reader);
                }
            } catch (Exception exe) {
                throw new ArchivoException("Error al leer archivo", exe);
            }
            return thisOne;
        }
    }
}
