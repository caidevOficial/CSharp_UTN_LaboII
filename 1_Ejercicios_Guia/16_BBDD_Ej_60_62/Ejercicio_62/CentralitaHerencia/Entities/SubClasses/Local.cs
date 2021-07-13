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
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia {
    public sealed class Local : Llamada, IGuardar<Local> {

        #region Attributes

        private float costo;

        #endregion

        #region Builders

        public Local():base() {}

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="call">Object Llamada-type.</param>
        /// <param name="costo">Price of the call.</param>
        public Local(Llamada call, float costo)
            : this(call.NroOrigen, call.NroDestino, call.Duracion, costo) {

        }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="origen">Origin of the call.</param>
        /// <param name="destino">Destiny of the call.</param>
        /// <param name="duracion">Duration of the call.</param>
        /// <param name="costo">Price of the call.</param>
        public Local(string origen, string destino, float duracion, float costo)
            : base(duracion, origen, destino) {
            this.costo = costo;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the price of the call.
        /// </summary>
        public override float CostoLlamada { get => CalcularCostos(); }
        
        /// <summary>
        /// Get: The string 'Ruta del archivo'.
        /// </summary>
        public string RutaDeArchivo { get => "Ruta de Local"; set { } }
        
        #endregion

        #region Methods

        /// <summary>
        /// It will caltulate the cost of the call, based in the duration and its price.
        /// </summary>
        /// <returns>The cost of the call.</returns>
        private float CalcularCostos() {
            return this.Duracion * this.costo;
        }

        /// <summary>
        /// Shows the info of the call.
        /// </summary>
        /// <returns>Returns the info as a string.</returns>
        protected override string Mostrar() {
            string data = string.Format("{0}", base.Mostrar());
            data += string.Format("Costo: ${0,3}\n", this.CostoLlamada);

            return data;
        }

        /// <summary>
        /// Override Implementation of ToString()
        /// </summary>
        /// <returns>Returns the dhata as a string.</returns>
        public override string ToString() {
            return this.Mostrar();
        }

        /// <summary>
        /// An override implementation of Equals.
        /// </summary>
        /// <param name="obj">Objet to compare with this object.</param>
        /// <returns>True if both object are equals, otherwise returns false.</returns>
        public override bool Equals(object obj) {
            return (obj is Local);
        }

        /// <summary>
        /// .
        /// </summary>
        /// <returns>.</returns>
        public bool Guardar(string path, Local local) {
            using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8)) {
                XmlSerializer serial = new XmlSerializer(typeof(Local));
                serial.Serialize(writer, local);
                return true;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        /// <returns>.</returns>
        public Local Leer() {
            Object aux;
            Local local;
            using(XmlTextReader reader = new XmlTextReader("")) {
                XmlSerializer serial = new XmlSerializer(typeof(Local));
                aux = (Object)serial.Deserialize(reader);
                if(aux is Local) {
                    local = aux as Local;
                } else {
                    throw new InvalidCastException("Llamada no es Local");
                }
            }

            return local;
        }

        #endregion
    }
}