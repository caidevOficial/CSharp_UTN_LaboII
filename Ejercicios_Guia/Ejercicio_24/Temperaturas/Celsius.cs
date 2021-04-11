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

namespace Temperaturas
{
    public class Celsius
    {
        private double amount;

        #region Builders

        /// <summary>
        /// Builds the entity.
        /// </summary>
        public Celsius()
        {

        }

        /// <summary>
        /// Builds the entity with amount parameter.
        /// </summary>
        /// <param name="amount">Amount to set to the entity.</param>
        public Celsius(double amount)
        {
            this.amount = amount;
        }

        #endregion

        #region Getters

        /// <summary>
        /// Gets the amount of the entity.
        /// </summary>
        /// <returns>The actual amount of the entity.</returns>
        public double GetAmount()
        {
            return this.amount;
        }

        #endregion

        #region Operators

        #region Cast_Operators

        /// <summary>
        /// Explicitly casts an object of type double to an object of type Celsius.
        /// </summary>
        /// <param name="d">Amount to cast to Celsius.</param>
        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }

        /// <summary>
        /// Explicitly casts an object of type Celsius to an object of type Fahrenheit.
        /// </summary>
        /// <param name="cTemperature">Celsius object to cast to Fahrenheit</param>
        public static explicit operator Fahrenheit(Celsius cTemperature)
        {
            Fahrenheit fTemperature = new Fahrenheit(cTemperature.GetAmount() * 9 / 5 + 32);
            return fTemperature;
        }

        /// <summary>
        /// Explicitly casts an object of type Celsius to an object of type Kelvin.
        /// </summary>
        /// <param name="cTemperature">Celsius object to cast to Kelvin</param>
        public static explicit operator Kelvin(Celsius cTemperature)
        {
            Kelvin kTemperature = new Kelvin((((Fahrenheit)cTemperature).GetAmount() + 459.67) * 5 / 9);
            return kTemperature;
        }

        #endregion

        #region Equality

        /// <summary>
        /// Compares if the amount of Fahrenheit and Celsius are equals.
        /// </summary>
        /// <param name="c">Celsius to compare.</param>
        /// <param name="f">Fahrenheit to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.GetAmount() == ((Celsius)f).GetAmount();
        }

        /// <summary>
        /// Compares if the amount of Kelvin and Celsius are equals.
        /// </summary>
        /// <param name="c">Celsius to compare.</param>
        /// <param name="k">Kelvin to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.GetAmount() == ((Celsius)k).GetAmount();
        }

        /// <summary>
        /// Compares if the amount of Celsius and Celsius are equals.
        /// </summary>
        /// <param name="d">Celsius to compare.</param>
        /// <param name="e">Celsius to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Celsius d, Celsius e)
        {
            return d.GetAmount() == e.GetAmount();
        }

        #endregion

        #region Inequality

        /// <summary>
        /// Compares if the amount of Fahrenheit and Celsius are differents.
        /// </summary>
        /// <param name="c">Celsius to Compare.</param>
        /// <param name="f">Fahrenheit to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        /// <summary>
        /// Compares if the amount of Kelvin and Celsius are differents.
        /// </summary>
        /// <param name="c">Celsius to Compare.</param>
        /// <param name="k">Kelvin to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        /// <summary>
        /// Compares if the amount of Celsius and Celsius are differents.
        /// </summary>
        /// <param name="c">Celsius to Compare.</param>
        /// <param name="e">Celsius to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Celsius c, Celsius e)
        {
            return !(c == e);
        }

        #endregion

        #region Addition

        /// <summary>
        /// Adds to an object of type Celsius, the equivalent amount of Celsius of an object type Fahrenheit.
        /// </summary>
        /// <param name="c">Celsius for sum.</param>
        /// <param name="f">Fahrenheit to cast to Celsius</param>
        /// <returns>An object type Celsius with The sum of the equivalent in Celsius of an object Fahrenheit-type.</returns>
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetAmount() + ((Celsius)f).GetAmount());
        }

        /// <summary>
        /// Adds to an object of type Celsius, the equivalent amount of Celsius of an object type Kelvin.
        /// </summary>
        /// <param name="c">Celsius for sum.</param>
        /// <param name="k">Kelvin to cast to Celsius</param>
        /// <returns>An object type Celsius with The sum of the equivalent in Celsius of an object Kelvin-type.</returns>
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetAmount() + ((Celsius)k).GetAmount());
        }

        #endregion

        #region Substraction

        /// <summary>
        /// Subtracts from an object of type Celsius, the equivalent amount of Celsius of an object of Fahrenheit type.
        /// </summary>
        /// <param name="c">Celsius for substract.</param>
        /// <param name="f">Fahrenheit to cast to Celsius</param>
        /// <returns>The Celsius-type object minus the equivalent in Celsius of a Fahrenheit-type object.</returns>
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetAmount() - ((Celsius)f).GetAmount());
        }

        /// <summary>
        /// Subtracts from an object of type Celsius, the equivalent amount of Celsius of an object of Kelvin type.
        /// </summary>
        /// <param name="c">Celsius for substract.</param>
        /// <param name="k">Kelvin to cast to Celsius</param>
        /// <returns>The Celsius-type object minus the equivalent in Celsius of a Kelvin-type object.</returns>
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetAmount() - ((Celsius)k).GetAmount());
        }

        #endregion

        #endregion
    }
}