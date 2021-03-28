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
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Builders

        /// <summary>
        /// Builds the entity with the static value.
        /// </summary>
        static Peso()
        {
            Peso.cotizRespectoDolar = 66;
        }

        /// <summary>
        /// Builds the entity.
        /// </summary>
        public Peso()
        {

        }

        /// <summary>
        /// Builds the entity with amount parameter.
        /// </summary>
        /// <param name="cantidad">Amount to set to the entity.</param>
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Builds the entity with amount parameter and the cotization.
        /// </summary>
        /// <param name="cantidad">Amount to set to the entity.</param>
        /// <param name="cotizacion">Cotization to set to the entity.</param>
        public Peso(double cantidad, double cotizacion):this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
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
            return Peso.cotizRespectoDolar;
        }
        
        #endregion

        #region Operators

        #region Cast_Operators

        /// <summary>
        /// Explicitly casts an object of type double to an object of type Peso.
        /// </summary>
        /// <param name="amount">Amount to cast to Peso.</param>
        public static implicit operator Peso(double amount)
        {
            return new Peso(amount);
        }
        
        /// <summary>
         /// Explicitly casts an object of type Peso to an object of type Dolar.
         /// </summary>
         /// <param name="thisCurrency">Peso object to cast.</param>
        public static explicit operator Dolar(Peso pesoCurrency)
        {
            return new Dolar(pesoCurrency.GetCantidad() / Peso.GetCotizacion());
        }

        /// <summary>
        /// Explicitly casts an object of type Peso to an object of type Euro.
        /// </summary>
        /// <param name="pesoCurrency">Peso object to cast.</param>
        public static explicit operator Euro(Peso pesoCurrency)
        {
            Euro euroCurrency = new Euro(((Dolar)pesoCurrency).GetCantidad() / Euro.GetCotizacion());
            return euroCurrency;
        }

        #endregion

        #region Equality
        
        /// <summary>
        /// Compares if the amount of Peso and Dolar are equals.
        /// </summary>
        /// <param name="p">Peso to Compare.</param>
        /// <param name="d">Dolar to compare.</param>
        /// <returns>True if are equals, otherwise returns False.</returns>
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == ((Peso)d).GetCantidad();
        }

        /// <summary>
        /// Compares if the amount of Peso and Euro are equals.
        /// </summary>
        /// <param name="p">Peso to Compare.</param>
        /// <param name="e">Euro to Compare.</param>
        /// <returns>True if are equals, otherwise returns False.</returns>
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == ((Peso)e).GetCantidad();
        }

        /// <summary>
        /// Compares if the amount of Peso and Peso are equals.
        /// </summary>
        /// <param name="p">Peso to Compare.</param>
        /// <param name="e">Peso to Compare.</param>
        /// <returns>True if are equals, otherwise returns False.</returns>
        public static bool operator ==(Peso p, Peso e)
        {
            return p.GetCantidad() == e.GetCantidad();
        }

        #endregion

        #region Inequality
        
        /// <summary>
        /// Compares if the amount of Peso and Dolar are differents.
        /// </summary>
        /// <param name="p">Peso to Compare.</param>
        /// <param name="d">Dolar to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        /// <summary>
        /// Compares if the amount of Peso and Euro are differents.
        /// </summary>
        /// <param name="p">Peso to Compare.</param>
        /// <param name="e">Euro to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        /// <summary>
        /// Compares if the amount of Peso and Peso are differents.
        /// </summary>
        /// <param name="p">Peso to Compare.</param>
        /// <param name="e">Peso to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Peso p, Peso e)
        {
            return !(p == e);
        }

        #endregion

        #region Addition

        /// <summary>
        /// adds to an object of type Peso, the equivalent amount of Peso of an object type Euro.
        /// </summary>
        /// <param name="p">Peso for sum.</param>
        /// <param name="e">Euro to cast to Peso</param>
        /// <returns>An object type Peso with The sum of Peso and the equivalent in Peso of Euro.</returns>
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
        }

        /// <summary>
        /// adds to an object of type Peso, the equivalent amount of Peso of an object type dollar.
        /// </summary>
        /// <param name="p">Peso for sum.</param>
        /// <param name="e">Dolar to cast to Peso</param>
        /// <returns>An object type Peso with The sum of Peso and the equivalent in Peso of Dolar.</returns>
        public static Peso operator +(Peso p, Dolar e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
        }

        #endregion

        #region Substraction

        /// <summary>
        /// Subtracts from an object of type Peso, the equivalent amount of Peso of an object of Euro type.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns>The Peso-type object minus the equivalent in Peso of a Euro-type object.</returns>
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }

        /// <summary>
        /// Subtracts from an object of type Peso, the equivalent amount of Peso of an object of dollar type.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns>The Peso-type object minus the equivalent in Peso of a dollar-type object.</returns>
        public static Peso operator -(Peso p, Dolar e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }

        #endregion

        #endregion
    }
}
