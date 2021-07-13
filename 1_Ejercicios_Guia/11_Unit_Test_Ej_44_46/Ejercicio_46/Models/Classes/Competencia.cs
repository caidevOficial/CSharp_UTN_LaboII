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

namespace Models {
    public sealed class Competencia {

        #region Attributes

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoCarrera> competidores;
        private TipoCompetencia tipo;

        #endregion

        public enum TipoCompetencia {
            F1,
            MotoCross
        }

        #region Builders

        /// <summary>
        /// Initializes the list of vehicles.
        /// </summary>
        private Competencia() {
            competidores = new List<VehiculoCarrera>();
        }

        /// <summary>
        /// Builds the entity with amount of competitors and laps.
        /// </summary>
        /// <param name="cantidadCompetidores">Amount of competitors</param>
        /// <param name="cantidadVueltas">Number of total laps.</param>
        /// <param name="competenciaDe">Type of competence.</param>
        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia competenciaDe)
            : this() {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = competenciaDe;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the amount of competitors.
        /// Set: Sets the amount of competitors.
        /// </summary>
        public short CantidadCompetidores {
            get => cantidadCompetidores;
            set {
                if (value > 2) {
                    cantidadCompetidores = value;
                }
            }
        }

        /// <summary>
        /// Get: Gets the number of laps.
        /// Set: Sets the number of laps.
        /// </summary>
        public short CantidadVueltas {
            get => cantidadVueltas;
            set {
                if (value > 1) {
                    cantidadVueltas = value;
                }
            }
        }

        /// <summary>
        /// Its will read the index requested if teh range is correct, otherwise it will return a null.
        /// If the index is bigger than maximus, it will add the new element.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public VehiculoCarrera this[int i] {
            get {
                if (i < this.competidores.Count) {
                    return this.competidores[i];
                } else {
                    return null;
                }
            }
            set {
                if (i < this.competidores.Count) {
                    this.competidores[i] = value;
                } else {
                    competidores.Add(value);
                }
            }
        }

        /// <summary>
        /// Get: Gets the type of competence.
        /// Set: Sets the type of competence.
        /// </summary>
        public TipoCompetencia Tipo {
            get => tipo;
            set {
                if (value >= 0) {
                    tipo = value;
                }
            }
        }

        /// <summary>
        /// Get: gets the list of competitors.
        /// </summary>
        public List<VehiculoCarrera> Competidores {
            get => this.competidores;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Tries to add a Vehicle to the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Vehicle to add into the competence.</param>
        /// <returns>True if can add the Vehicle, otherwise returns false.</returns>
        public static bool operator +(Competencia c, VehiculoCarrera a) {
            Random rdm = new Random();
            if (!(c is null) && !(a is null)) {
                try {
                    if ((c.competidores.Count < c.CantidadCompetidores)) {
                        if (!(c == a)) {
                            a.EnCompetencia = true;
                            a.VueltasRestantes = c.CantidadVueltas;
                            a.CantidadCombustible = (short)rdm.Next(15, 100);
                            c.competidores.Add(a);
                            return true;
                        }
                    }
                } catch (CompetenciaNoDisponibleException ce) {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia.cs", "Operador +", ce);
                }
            }

            return false;
        }

        /// <summary>
        /// Tries to remove the Vehicle from the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Vehicle to remove from the competence.</param>
        /// <returns>True if can remove the Vehicle, otherwise returns false.</returns>
        public static bool operator -(Competencia c, VehiculoCarrera a) {
            if (!(c is null) && !(a is null)) {
                if (c == a) {
                    c.competidores.RemoveAt(c.competidores.IndexOf(a));
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Compares if the Vehicle is in the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Vehicle to verify if is in the competence.</param>
        /// <returns>True if the Vehicle is inside the competence, otherwise returns false.</returns>
        public static bool operator ==(Competencia c, VehiculoCarrera a) {
            if (!(c.competidores is null) && !(a is null)) {
                if (c.Tipo == Competencia.TipoCompetencia.F1 && a.GetType() != typeof(AutoF1) ||
                    c.Tipo == Competencia.TipoCompetencia.MotoCross && a.GetType() != typeof(MotoCross)) {
                    throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia.cs", "Validacion ==");
                }
            } else {
                foreach (VehiculoCarrera vehicle in c.competidores) {
                    if (vehicle == a) {
                        return true;
                    }
                }

            }

            return false;
        }

        /// <summary>
        /// Compares if the Vehicle is not in the competence.
        /// </summary>
        /// <param name="c">Competence to check.</param>
        /// <param name="a">Vehicle to verify if is not in the competence.</param>
        /// <returns>True if the Vehicle is not inside the competence, otherwise returns false.</returns>
        public static bool operator !=(Competencia c, VehiculoCarrera a) {
            return !(c == a);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the stats of the competence.
        /// </summary>
        /// <returns>Returns the stats as a string.</returns>
        public string MostrarDatos() {
            string stats = String.Format("Data of Competence:\nCompetitors: {0,2} | remaining Laps: {1,2}\nRegistered Vehicles:\n", this.CantidadCompetidores, this.CantidadVueltas);
            foreach (VehiculoCarrera vechicle in competidores) {
                stats += vechicle.MostrarDatos();
            }

            return stats;
        }

        #endregion

    }
}