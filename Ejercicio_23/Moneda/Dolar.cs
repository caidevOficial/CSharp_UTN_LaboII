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

namespace Currency
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Builders

        /// <summary>
        /// Builds the entity withthe static value.
        /// </summary>
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        /// <summary>
        /// Builds the entity.
        /// </summary>
        public Dolar()
        {

        }

        /// <summary>
        /// Builds the entity with amount parameter.
        /// </summary>
        /// <param name="cantidad">Amount to set to the entity.</param>
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Builds the entity with amount parameter and the cotization.
        /// </summary>
        /// <param name="cantidad">Amount to set to the entity.</param>
        /// <param name="cotizacion">Cotization to set to the entity.</param>
        public Dolar(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }

        #endregion

        #region Getters

        /// <summary>
        /// Gets the amount of the entity.
        /// </summary>
        /// <returns>The actual amount of the entity.</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Gets the cotization of the class Peso.
        /// </summary>
        /// <returns>Cotizacion of Peso respect the Dolar.</returns>
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        #endregion

        #region Operators

        #region Cast_Operators

        /// <summary>
        /// Explicitly casts an object of type double to an object of type Dolar.
        /// </summary>
        /// <param name="d">Amount to cast to Dolar.</param>
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        /// <summary>
        /// Explicitly casts an object of type Dolar to an object of type Euro.
        /// </summary>
        /// <param name="dolarCurrency">Dolar object to cast to Euro</param>
        public static explicit operator Euro(Dolar dolarCurrency)
        {
            Euro euroCurrency = new Euro(dolarCurrency.GetCantidad() / Euro.GetCotizacion());
            return euroCurrency;
        }

        /// <summary>
        /// Explicitly casts an object of type Dolar to an object of type Peso.
        /// </summary>
        /// <param name="dolarCurrency">Dolar object to cast to Peso</param>
        public static explicit operator Peso(Dolar dolarCurrency)
        {
            Peso pesoCurrency = new Peso(dolarCurrency.GetCantidad() * Peso.GetCotizacion());
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
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }

        /// <summary>
        /// Compares if the amount of Peso and Dolar are equals.
        /// </summary>
        /// <param name="d">Dolar to compare.</param>
        /// <param name="e">Peso to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Dolar d, Peso e)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }

        /// <summary>
        /// Compares if the amount of Dolar and Dolar are equals.
        /// </summary>
        /// <param name="d">Dolar to compare.</param>
        /// <param name="e">Dolar to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Dolar d, Dolar e)
        {
            return d.GetCantidad() == e.GetCantidad();
        }

        #endregion

        #region Inequality

        /// <summary>
        /// Compares if the amount of Euro and Dolar are differents.
        /// </summary>
        /// <param name="d">Dolar to Compare.</param>
        /// <param name="e">Euro to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        /// <summary>
        /// Compares if the amount of Peso and Dolar are differents.
        /// </summary>
        /// <param name="d">Dolar to Compare.</param>
        /// <param name="e">Peso to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Dolar d, Peso e)
        {
            return !(d == e);
        }

        /// <summary>
        /// Compares if the amount of Dolar and Dolar are differents.
        /// </summary>
        /// <param name="d">Dolar to Compare.</param>
        /// <param name="e">Dolar to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Dolar d, Dolar e)
        {
            return !(d == e);
        }

        #endregion

        #region Addition

        /// <summary>
        /// Adds to an object of type Dolar, the equivalent amount of Dolar of an object type Euro.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>An object type Dolar with The sum of the equivalent in Dolar of an object Euro-type.</returns>
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }

        /// <summary>
        /// Adds to an object of type Dolar, the equivalent amount of Dolar of an object type Peso.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>An object type Dolar with The sum of the equivalent in Dolar of an object Peso-type.</returns>
        public static Dolar operator +(Dolar d, Peso e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }

        #endregion

        #region Substraction

        /// <summary>
        /// Subtracts from an object of type Dolar, the equivalent amount of Dolar of an object of Euro type.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>The Dolar-type object minus the equivalent in Dolar of a Euro-type object.</returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }

        /// <summary>
        /// Subtracts from an object of type Dolar, the equivalent amount of Dolar of an object of Peso type.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns>The Dolar-type object minus the equivalent in Dolar of a Peso-type object.</returns>
        public static Dolar operator -(Dolar d, Peso e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }

        #endregion

        #endregion
    }
}