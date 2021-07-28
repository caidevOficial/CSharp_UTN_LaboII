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

namespace Entidades {
    [Serializable]
    public class Votacion {

        #region Event_Delegate

        public delegate void Voto(string senador, Votacion.EVoto voto);
        public event Voto EventoVotoEfectuado;

        #endregion

        #region Attributes

        public enum EVoto {
            Afirmativo,
            Negativo,
            Abstencion,
            Esperando
        }

        private Dictionary<string, EVoto> senadores;

        private string nombreLey;
        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        #endregion

        #region Builder

        /// <summary>
        /// Default Builder for xml
        /// </summary>
        public Votacion() { }

        /// <summary>
        /// Builder with law's name and a collection of senators.
        /// </summary>
        /// <param name="nombreLey">Law's name.</param>
        /// <param name="senadores">Collection of senators.</param>
        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores) : this() {
            this.NombreLey = nombreLey;
            this.Senadores = senadores;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: Senators and their votes.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public Dictionary<string, EVoto> Senadores {
            get => this.senadores;
            set {
                if (value.GetType() == typeof(Dictionary<string, EVoto>)) {
                    this.senadores = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: Law'a name.
        /// </summary>
        public string NombreLey {
            get => this.nombreLey;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.nombreLey = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: Afirmative amount.
        /// </summary>
        public short ContadorAfirmativo {
            get => this.contadorAfirmativo;
            set {
                if (value.GetType() == typeof(short)) {
                    this.contadorAfirmativo = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: Negative amount.
        /// </summary>
        public short ContadorNegativo {
            get => this.contadorNegativo;
            set {
                if (value.GetType() == typeof(short)) {
                    this.contadorNegativo = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: Abstention amount.
        /// </summary>
        public short ContadorAbstencion {
            get => this.contadorAbstencion;
            set {
                if (value.GetType() == typeof(short)) {
                    this.contadorAbstencion = value;
                }
            }
        }

        #endregion

        #region Method

        /// <summary>
        /// Simulates the Votation
        /// </summary>
        public void Simular() {
            // Reseteo contadores
            this.ContadorAbstencion = 0;
            this.ContadorAfirmativo = 0;
            this.ContadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.Senadores.Count; index++) {
                // Duermo el hilo
                System.Threading.Thread.Sleep(2134);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.Senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.Senadores[k.Key] = (EVoto)r.Next(0, 3);

                // Invocar Evento
                this.EventoVotoEfectuado.Invoke(k.Key, Senadores[k.Key]);
                // Incrementar contadores
                if (Senadores[k.Key] == EVoto.Afirmativo) {
                    this.ContadorAfirmativo += 1;
                } else if (Senadores[k.Key] == EVoto.Negativo) {
                    this.ContadorNegativo += 1;
                } else {
                    this.ContadorAbstencion += 1;
                }
            }
        }

        #endregion
    }
}
