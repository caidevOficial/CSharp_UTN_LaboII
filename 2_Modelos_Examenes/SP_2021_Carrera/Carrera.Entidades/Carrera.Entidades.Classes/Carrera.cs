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
using System.Threading;

namespace Entidades {

    public delegate void InformacionDeAvance();
    public delegate void InformacionDeLlegada(string mensaje);

    public class Carrera {

        #region Attributes

        private List<AutoF1> autos;
        private int kms;
        public event InformacionDeAvance InformarAvance;
        public event InformacionDeLlegada InformarLlegada;

        #endregion

        /// <summary>
        /// Get/Set: Lista de autos.
        /// </summary>
        public List<AutoF1> Autos {
            get => this.autos;
            set {
                if (value.GetType() == typeof(List<AutoF1>)) {
                    this.autos = value;
                }
            }
        }

        /// <summary>
        /// Get/Set: Kilometros de la pista.
        /// </summary>
        public int Kms {
            get => this.kms;
            set {
                if (value.GetType() == typeof(int) && value > 0) {
                    this.kms = value;
                }
            }
        }

        /// <summary>
        /// Default Builder for serialize.
        /// </summary>
        public Carrera() {
            this.Autos = new List<AutoF1>();
        }

        /// <summary>
        /// Builder for the entity with kms.
        /// </summary>
        /// <param name="kms">distance of the race.</param>
        public Carrera(int kms) : this() {
            this.Kms = kms;
        }

        /// <summary>
        /// Agrego un auto a la carrera y la devuelvo.
        /// </summary>
        /// <param name="carrera">carrera para agregar auto.</param>
        /// <param name="auto">auto de la carrera.</param>
        /// <returns>carrera con el auto atroden</returns>
        public static Carrera operator +(Carrera carrera, AutoF1 auto) {
            if (!(carrera is null) && !(auto is null)) {
                carrera.autos.Add(auto);
            }

            return carrera;
        }

        /// <summary>
        /// Initializes the race.
        /// </summary>
        public void IniciarCarrera() {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\autos.txt";
            GestorBaseDeDatos bd = new GestorBaseDeDatos();
            GestorDeArchivos arch = new GestorDeArchivos(path);
            int posicion = 1;
            try {
                while (true) {
                    foreach (AutoF1 item in this.autos) {
                        item.Acelerar();
                        this.InformarAvance.Invoke();
                        Thread.Sleep(10);
                        if (item.UbicacionEnPista > this.Kms && item.Posicion == 0) {
                            item.Posicion = posicion;
                            this.InformarLlegada.Invoke(item.ToString());
                            posicion++;
                            bd.Guardar(item);
                            ((IGuardar<AutoF1>)arch).Guardar(item);
                        }
                    }
                }
            } catch (Exception exe) {
                throw exe;
            }
        }
    }
}
