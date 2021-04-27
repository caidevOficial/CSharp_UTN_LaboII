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
    public class Estacionamiento {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        #region Builders

        private Estacionamiento() {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this() {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        #endregion

        #region Operators

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

        public static bool operator !=(Estacionamiento e, Vehiculo v) {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v) {
            if (e != v) {
                if (e.vehiculos.Count < e.espacioDisponible) {
                    e.vehiculos.Add(v);
                }
            }

            return e;
        }

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
