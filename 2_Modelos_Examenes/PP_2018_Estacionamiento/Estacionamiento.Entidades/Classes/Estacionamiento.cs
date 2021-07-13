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

using System.Collections.Generic;
using System.Text;

namespace Entidades {
    public sealed class Estacionamiento {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        #region Builders

        /// <summary>
        /// Creates the entity and instances its list of vehicles.
        /// </summary>
        private Estacionamiento() {
            vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Creates the entity with the total space and name.
        /// </summary>
        /// <param name="nombre">Name of the entity</param>
        /// <param name="espacioDisponible">Amount of free places</param>
        public Estacionamiento(string nombre, int espacioDisponible) : this() {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cast and gets the info of the parking as a string
        /// </summary>
        /// <param name="e">Parking to get its info.</param>
        public static explicit operator string(Estacionamiento e) {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Nombre: {e.nombre}");
            data.AppendLine($"Espacio disponible: {e.espacioDisponible}");
            data.AppendLine($"Lista de vehiculos:");
            data.AppendLine("___________________");
            foreach (Vehiculo item in e.vehiculos) {
                data.Append(item.ConsultarDatos());
                data.AppendLine("___________________");
            }

            return data.ToString();
        }

        /// <summary>
        /// Compares if the vehicle is into the parking.
        /// </summary>
        /// <param name="e">Parking to check.</param>
        /// <param name="v">Vehicle to search into the parking.</param>
        /// <returns>True if the vehicle is into the parking, otherwise returns false.</returns>
        public static bool operator ==(Estacionamiento e, Vehiculo v) {
            if (!(e is null) && !(v is null)) {
                foreach (Vehiculo item in e.vehiculos) {
                    if (item == v) {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Compares if the vehicle is not into the parking.
        /// </summary>
        /// <param name="e">Parking to check.</param>
        /// <param name="v">Vehicle to search into the parking.</param>
        /// <returns>True if the vehicle is not into the parking, otherwise returns false.</returns>
        public static bool operator !=(Estacionamiento e, Vehiculo v) {
            return !(e == v);
        }

        /// <summary>
        /// Adds a vehicle into the parking if not exist inside.
        /// </summary>
        /// <param name="e">Parking to check.</param>
        /// <param name="v">Vehicle to search into the parking.</param>
        /// <returns>A entity with the vehicle inside or the same, if cannot add the vehicle inside.</returns>
        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v) {
            if (e != v) {
                if (e.vehiculos.Count < e.espacioDisponible) {
                    e.vehiculos.Add(v);
                }
            }

            return e;
        }

        /// <summary>
        /// Removes a vehicle from the parking if exist.
        /// </summary>
        /// <param name="e">Parking to check.</param>
        /// <param name="v">Vehicle to search into the parking.</param>
        /// <returns>A string with the ticket if exist, otherwise returns a message of error.</returns>
        public static string operator -(Estacionamiento e, Vehiculo v) {
            if (e == v) {
                e.vehiculos.Remove(v);
                return v.ImprimirTicket();
            }

            return "El vehículo no es parte del estacionamiento";
        }

        #endregion
    }
}
