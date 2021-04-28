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

namespace Currency {
    public class Euro {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Builders

        /// <summary>
        /// 
        /// </summary>
        static Euro() {
            Euro.cotizRespectoDolar = 1.08;
        }

        /// <summary>
        /// 
        /// </summary>
        public Euro() {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        public Euro(double cantidad) {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="cotizacion"></param>
        public Euro(double cantidad, double cotizacion) : this(cantidad) {
            Euro.cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Getters

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetCantidad() {
            return this.cantidad;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static double GetCotizacion() {
            return Euro.cotizRespectoDolar;
        }

        #endregion

        #region Operators

        #region Cast_Operators

        /// <summary>
        /// Explicitly casts an object of type Dolar to an object of type Euro.
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Euro(double d) {
            return new Euro(d);
        }

        /// <summary>
        /// Explicitly casts an object of type Euro to an object of type Dolar.
        /// </summary>
        /// <param name="euroCurrency">Euro object to cast to Dolar</param>
        public static explicit operator Dolar(Euro euroCurrency) {
            Dolar dolarCurrency = new Dolar(euroCurrency.GetCantidad() * Euro.GetCotizacion());
            return dolarCurrency;
        }

        /// <summary>
        /// Explicitly casts an object of type Euro to an object of type Peso.
        /// </summary>
        /// <param name="euroCurrency">Euro object to cast to Peso</param>
        public static explicit operator Peso(Euro euroCurrency) {
            Peso pesoCurrency = new Peso(((Dolar)euroCurrency).GetCantidad() * Peso.GetCotizacion());
            return pesoCurrency;
        }

        #endregion

        #region Equality

        /// <summary>
        /// Compares if the amount of Euro and Dolar are equals.
        /// </summary>
        /// <param name="d">Dolar to compare.</param>
        /// <param name="e">Euro to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Euro e, Dolar d) {
            return e.GetCantidad() == ((Euro)d).GetCantidad();
        }

        /// <summary>
        /// Compares if the amount of Peso and Euro are equals.
        /// </summary>
        /// <param name="d">Euro to compare.</param>
        /// <param name="e">Peso to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Euro e, Peso p) {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }

        /// <summary>
        /// Compares if the amount of Euro and Euro are equals.
        /// </summary>
        /// <param name="d">Euro to compare.</param>
        /// <param name="e">Euro to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Euro e, Euro ee) {
            return e.GetCantidad() == ee.GetCantidad();
        }

        #endregion

        #region Inequality

        /// <summary>
        /// Compares if the amount of Euro and Dolar are differents.
        /// </summary>
        /// <param name="d">Dolar to Compare.</param>
        /// <param name="e">Euro to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Euro e, Dolar d) {
            return !(d == e);
        }

        /// <summary>
        /// Compares if the amount of Peso and Euro are differents.
        /// </summary>
        /// <param name="d">Euro to Compare.</param>
        /// <param name="e">Peso to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Euro e, Peso p) {
            return !(e == p);
        }

        /// <summary>
        /// Compares if the amount of Euro and Euro are differents.
        /// </summary>
        /// <param name="d">Euro to Compare.</param>
        /// <param name="e">Euro to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Euro e, Euro ee) {
            return !(e == ee);
        }

        #endregion

        #region Addition

        /// <summary>
        /// Adds to an object of type Euro, the equivalent amount of Euro of an object type Dolar.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>An object type Euro with The sum of the equivalent in Euro of an object Dolar-type.</returns>
        public static Euro operator +(Euro e, Dolar d) {
            return new Euro(((Euro)d).GetCantidad() + e.GetCantidad());
        }

        /// <summary>
        /// Adds to an object of type Euro, the equivalent amount of Euro of an object type Peso.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>An object type Euro with The sum of the equivalent in Euro of an object Peso-type.</returns>
        public static Euro operator +(Euro e, Peso d) {
            return new Euro(((Euro)d).GetCantidad() + e.GetCantidad());
        }

        #endregion

        #region Substraction

        /// <summary>
        /// Subtracts from an object of type Euro, the equivalent amount of Euro of an object of Dolar type.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>The Euro-type object minus the equivalent in Euro of a Dolar-type object.</returns>
        public static Euro operator -(Euro e, Dolar d) {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }

        /// <summary>
        /// Subtracts from an object of type Euro, the equivalent amount of Euro of an object of Peso type.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>The Euro-type object minus the equivalent in Euro of a Peso-type object.</returns>
        public static Euro operator -(Euro e, Peso p) {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }

        #endregion

        #endregion
    }
}
