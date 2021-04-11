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
    public class Kelvin
    {
        private double amount;
        
        #region Builders

        /// <summary>
        /// Builds the entity.
        /// </summary>
        public Kelvin()
        {

        }

        /// <summary>
        /// Builds the entity with amount parameter.
        /// </summary>
        /// <param name="cantidad">Amount to set to the entity.</param>
        public Kelvin(double amount)
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
        /// Explicitly casts an object of type double to an object of type Kelvin.
        /// </summary>
        /// <param name="d">Amount to cast to Kelvin.</param>
        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }

        /// <summary>
        /// Explicitly casts an object of type Kelvin to an object of type Fahrenheit.
        /// </summary>
        /// <param name="kTemperature">Kelvin object to cast to Fahrenheit</param>
        public static explicit operator Fahrenheit(Kelvin kTemperature)
        {
            Fahrenheit fTemperature = new Fahrenheit(kTemperature.GetAmount() * 9 / 5 - 459.67);
            return fTemperature;
        }

        /// <summary>
        /// Explicitly casts an object of type Kelvin to an object of type Celsius.
        /// </summary>
        /// <param name="kTemperature">Kelvin object to cast to Celsius</param>
        public static explicit operator Celsius(Kelvin kTemperature)
        {
            Celsius cTemperature = new Celsius(Math.Round((((Fahrenheit)kTemperature).GetAmount() - 32) * 5 / 9));
            return cTemperature;
        }

        #endregion

        #region Equality

        /// <summary>
        /// Compares if the amount of Fahrenheit and Kelvin are equals.
        /// </summary>
        /// <param name="k">Kelvin to compare.</param>
        /// <param name="f">Fahrenheit to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.GetAmount() == ((Kelvin)f).GetAmount();
        }

        /// <summary>
        /// Compares if the amount of Kelvin and Celsius are equals.
        /// </summary>
        /// <param name="k">Kelvin to compare.</param>
        /// <param name="c">Celsius to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.GetAmount() == ((Kelvin)c).GetAmount();
        }

        /// <summary>
        /// Compares if the amount of Kelvin and Kelvin are equals.
        /// </summary>
        /// <param name="d">Kelvin to compare.</param>
        /// <param name="e">Kelvin to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Kelvin k, Kelvin e)
        {
            return k.GetAmount() == e.GetAmount();
        }

        #endregion

        #region Inequality

        /// <summary>
        /// Compares if the amount of Fahrenheit and Kelvin are differents.
        /// </summary>
        /// <param name="k">Kelvin to Compare.</param>
        /// <param name="f">Fahrenheit to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        /// <summary>
        /// Compares if the amount of Kelvin and Celsius are differents.
        /// </summary>
        /// <param name="k">Kelvin to Compare.</param>
        /// <param name="c">Celsius to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        /// <summary>
        /// Compares if the amount of Kelvin and Kelvin are differents.
        /// </summary>
        /// <param name="c">Kelvin to Compare.</param>
        /// <param name="e">Kelvin to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Kelvin c, Kelvin e)
        {
            return !(c == e);
        }

        #endregion

        #region Addition

        /// <summary>
        /// Adds to an object of type Kelvin, the equivalent amount of Kelvin of an object type Fahrenheit.
        /// </summary>
        /// <param name="k">Kelvin for sum.</param>
        /// <param name="f">Fahrenheit to cast to Kelvin</param>
        /// <returns>An object type Kelvin with The sum of the equivalent in Kelvin of an object Fahrenheit-type.</returns>
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetAmount() + ((Kelvin)f).GetAmount());
        }

        /// <summary>
        /// Adds to an object of type Kelvin, the equivalent amount of Kelvin of an object type Celsius.
        /// </summary>
        /// <param name="k">Kelvin for sum.</param>
        /// <param name="c">Celsius to cast to Kelvin</param>
        /// <returns>An object type Kelvin with The sum of the equivalent in Kelvin of an object Celsius-type.</returns>
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetAmount() + ((Kelvin)c).GetAmount());
        }

        #endregion

        #region Substraction

        /// <summary>
        /// Subtracts from an object of type Kelvin, the equivalent amount of Kelvin of an object of Fahrenheit type.
        /// </summary>
        /// <param name="k">Kelvin for substract.</param>
        /// <param name="f">Fahrenheit to cast to Kelvin</param>
        /// <returns>The Kelvin-type object minus the equivalent in Kelvin of a Fahrenheit-type object.</returns>
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetAmount() - ((Kelvin)f).GetAmount());
        }

        /// <summary>
        /// Subtracts from an object of type Kelvin, the equivalent amount of Kelvin of an object of Celsius type.
        /// </summary>
        /// <param name="k">Kelvin for substract.</param>
        /// <param name="c">Celsius to cast to Kelvin</param>
        /// <returns>The Kelvin-type object minus the equivalent in Kelvin of a Celsius-type object.</returns>
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetAmount() - ((Kelvin)c).GetAmount());
        }

        #endregion

        #endregion

    }
}
