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

using PrestamosPersonales;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera {
    public sealed class Financiera {

        #region Attributes

        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        #endregion

        #region Builders

        /// <summary>
        /// Inicializa la lista de prestamos.
        /// </summary>
        private Financiera() {
            listaDePrestamos = new List<Prestamo>();
        }

        /// <summary>
        /// Inicializa la entidad con su nombre y lista de prestamos.
        /// </summary>
        /// <param name="razonSocial">Nombre que tendra la entidad.</param>
        public Financiera(string razonSocial) : this() {
            this.razonSocial = razonSocial;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Retorna los intereses ganados de prestamos en dolares.
        /// </summary>
        public float InteresesEnDolares {
            get => CalcularInteresGanado(TipoDePrestamos.Dolares);
        }

        /// <summary>
        /// Get: Retorna los intereses ganados de prestamos en pesos.
        /// </summary>
        public float InteresesEnPesos {
            get => CalcularInteresGanado(TipoDePrestamos.Pesos);
        }

        /// <summary>
        /// Get: Retorna los intereses ganados de todos los prestamos.
        /// </summary>
        public float InteresesTotales {
            get => CalcularInteresGanado(TipoDePrestamos.Todos);
        }

        /// <summary>
        /// Retorna la lista de prestamos.
        /// </summary>
        public List<Prestamo> ListaDePrestamos {
            get => this.listaDePrestamos;
        }

        /// <summary>
        /// Get: Retorna el nombre de la financiera.
        /// </summary>
        public string RazonSocial {
            get => this.razonSocial;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compara si un prestamo ya esta en la lista de prestamos
        /// de la financiera.
        /// </summary>
        /// <param name="f">Financiera a chequear su lista de prestamos</param>
        /// <param name="p">Prestamo a buscar</param>
        /// <returns>True si tiene el prestamo cargado, sino false.</returns>
        public static bool operator ==(Financiera f, Prestamo p) {
            if (!(f is null) && !(p is null)) {
                foreach (Prestamo item in f.ListaDePrestamos) {
                    if (p.Equals(item)) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Compara si un prestamo no esta en la lista de prestamos
        /// de la financiera.
        /// </summary>
        /// <param name="f">Financiera a chequear su lista de prestamos</param>
        /// <param name="p">Prestamo a buscar</param>
        /// <returns>True si no tiene el prestamo cargado, sino false.</returns>
        public static bool operator !=(Financiera f, Prestamo p) {
            return !(f == p);
        }

        /// <summary>
        /// Agrega un prestamo a la lista si este no esta cargado. 
        /// Retorna la financiera con la lista actualizada si pudo agregarlo
        /// o sino tal cual esta.
        /// </summary>
        /// <param name="f">Financiera a intentar agregar prestamo</param>
        /// <param name="p">Prestamo a cargar en la financiera.</param>
        /// <returns>Retorna la financiera con o sin el prestamo.</returns>
        public static Financiera operator +(Financiera f, Prestamo p) {
            if (f != p) {
                f.ListaDePrestamos.Add(p);
            }

            return f;
        }

        /// <summary>
        /// Castea explicitamente una entidad financiera a string
        /// y obtiene todos sus datos.
        /// </summary>
        /// <param name="f">Financiera a castear explicitamente.</param>
        public static explicit operator string(Financiera f) {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Financiera: {f.RazonSocial}");
            data.AppendLine($"Intereses Pesos: ${f.InteresesEnPesos}");
            data.AppendLine($"Intereses Dolar: USD{f.InteresesEnDolares}");
            data.AppendLine($"Intereses Total: ${f.InteresesTotales}");
            data.AppendLine("Prestamos Por Fecha:");
            f.OrdenarPrestamos();
            foreach (Prestamo item in f.ListaDePrestamos) {
                data.Append(item.Mostrar());
            }
            data.AppendLine();

            return data.ToString();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calcula el interes ganado segun el tipo.
        /// </summary>
        /// <param name="tipo">Tipo de interes a calcular.</param>
        /// <returns>Retorna el monto total del tipo de interes.</returns>
        private float CalcularInteresGanado(TipoDePrestamos tipo) {
            float monto = 0;
            foreach (Prestamo item in this.ListaDePrestamos) {
                switch (tipo) {
                    case TipoDePrestamos.Dolares:
                        if (item is PrestamoDolar) {
                            monto += ((PrestamoDolar)item).Interes;
                        }
                        break;
                    case TipoDePrestamos.Pesos:
                        if (item is PrestamoPesos) {
                            monto += ((PrestamoPesos)item).Interes;
                        }
                        break;
                    default:
                        if (item is PrestamoDolar) {
                            monto += ((PrestamoDolar)item).Interes;
                        } else {
                            monto += ((PrestamoPesos)item).Interes;
                        }
                        break;
                }
            }

            return monto;
        }

        /// <summary>
        /// Ordena la lista de prestamos por fecha.
        /// </summary>
        public void OrdenarPrestamos() {
            listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        /// <summary>
        /// Muestr la info de la entidad financiera.
        /// </summary>
        /// <param name="f">Entidad financiera la cual se obtendra su info</param>
        /// <returns>la info de la entidad financiera como string.</returns>
        public static string Mostrar(Financiera f) {
            return (string)f;
        }

        #endregion
    }
}
