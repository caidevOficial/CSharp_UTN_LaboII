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
    public sealed class Provincial : Llamada, IGuardar<Provincial> {

        #region Attributes

        private Franja franjaHoraria;

        public enum Franja {
            Franja_01,
            Franja_02,
            Franja_03
        }

        #endregion

        #region Builders

        /// <summary>
        /// Default builder for serialize.
        /// </summary>
        public Provincial() : base() {

        }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="call">Llamada-type object.</param>
        /// <param name="franjaHoraria">Time zone of the call.</param>
        public Provincial(Llamada call, Franja franjaHoraria)
            : this(call.Duracion, call.NroOrigen, call.NroDestino, franjaHoraria) {
        }

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="duracion">Duration of the call.</param>
        /// <param name="origen">Origin of the call.</param>
        /// <param name="destino">Destiny of the call.</param>
        /// <param name="franjaHoraria">Time zone of the call.</param>
        public Provincial(float duracion, string origen, string destino, Franja franjaHoraria)
            : base(duracion, origen, destino) {
            this.FranjaHoraria = franjaHoraria;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the total price of the call.
        /// </summary>
        public override float CostoLlamada { get => CalcularCostos(); }

        /// <summary>
        /// Get: The string 'Ruta del archivo'.
        /// </summary>
        public string RutaDeArchivo { get => "Rota de Provincial"; set { } }

        /// <summary>
        /// Gets/Sets: The TimeZone of the call.
        /// </summary>
        public Franja FranjaHoraria {
            get => franjaHoraria;
            set {
                if (value.GetType() == typeof(Franja)) {
                    franjaHoraria = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// It will caltulate the cost of the call, based in the duration and its price.
        /// </summary>
        /// <returns>The cost of the call.</returns>
        private float CalcularCostos() {
            float price = 0;
            if (this.FranjaHoraria == Franja.Franja_01) {
                price = 0.99F;
            } else if (this.FranjaHoraria == Franja.Franja_02) {
                price = 1.25F;
            } else {
                price = 0.66F;
            }

            return base.Duracion * price;
        }

        /// <summary>
        /// Shows the info of the call.
        /// </summary>
        /// <returns>Returns the info as a string.</returns>
        protected override string Mostrar() {
            string data = string.Format("{0}", base.Mostrar());
            data += string.Format("Costo: ${0,3} | ", this.CostoLlamada);
            data += string.Format("Franja: {0}\n", this.FranjaHoraria);

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
            return (obj is Provincial);
        }

        /// <summary>
        /// Saves a Provincial call in a file.
        /// </summary>
        /// <returns>True if can save the file, otherwise returns false.</returns>
        public bool Guardar(string path, Provincial prov) {
            string fullPath = $"{path}\\{DateTime.Now.ToFileTimeUtc()}_Prov.xml";
            if (prov is Provincial) {
                using (XmlTextWriter writer = new XmlTextWriter($"{fullPath}", Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(Provincial));
                    serial.Serialize(writer, prov);
                    return true;
                }
            } else {
                throw new InvalidCastException("Llamada no es Provincial");
            }
        }

        /// <summary>
        ///  Reads a provincial call from a file.
        /// </summary>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public Provincial Leer() {
            Object aux;
            Provincial provincial;
            using (XmlTextReader reader = new XmlTextReader("")) {
                XmlSerializer serial = new XmlSerializer(typeof(Provincial));
                aux = (Object)serial.Deserialize(reader);
                if (aux is Provincial) {
                    provincial = aux as Provincial;
                } else {
                    throw new InvalidCastException("Llamada no es Provincial");
                }
            }

            return provincial;
        }

        #endregion
    }
}