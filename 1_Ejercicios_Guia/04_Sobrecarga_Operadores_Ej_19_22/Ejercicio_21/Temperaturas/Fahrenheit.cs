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


namespace Temperaturas {
    public class Fahrenheit {
        private double amount;

        #region Builders

        /// <summary>
        /// Builds the entity.
        /// </summary>
        public Fahrenheit() {

        }

        /// <summary>
        /// Builds the entity with amount parameter.
        /// </summary>
        /// <param name="cantidad">Amount to set to the entity.</param>
        public Fahrenheit(double amount) {
            this.amount = amount;
        }

        #endregion

        #region Getters

        /// <summary>
        /// Gets the amount of the entity.
        /// </summary>
        /// <returns>The actual amount of the entity.</returns>
        public double GetAmount() {
            return this.amount;
        }

        #endregion

        #region Operators

        #region Cast_Operators

        /// <summary>
        /// Explicitly casts an object of type double to an object of type Fahrenheit.
        /// </summary>
        /// <param name="d">Amount to cast to Fahrenheit.</param>
        public static implicit operator Fahrenheit(double d) {
            return new Fahrenheit(d);
        }

        /// <summary>
        /// Explicitly casts an object of type Fahrenheit to an object of type Celsius.
        /// </summary>
        /// <param name="fTemperature">Fahrenheit object to cast to Celsius</param>
        public static explicit operator Celsius(Fahrenheit fTemperature) {
            Celsius cTemperature = new Celsius((fTemperature.GetAmount() - 32) * 5 / 9);
            return cTemperature;
        }

        /// <summary>
        /// Explicitly casts an object of type Fahrenheit to an object of type Kelvin.
        /// </summary>
        /// <param name="fTemperature">Fahrenheit object to cast to Kelvin</param>
        public static explicit operator Kelvin(Fahrenheit fTemperature) {
            Kelvin kTemperature = new Kelvin((fTemperature.GetAmount() + 459.67) * 5 / 9);
            return kTemperature;
        }

        #endregion

        #region Equality

        /// <summary>
        /// Compares if the amount of Fahrenheit and Celsius are equals.
        /// </summary>
        /// <param name="f">Fahrenheit to compare.</param>
        /// <param name="c">Celsius to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Fahrenheit f, Celsius c) {
            return f.GetAmount() == ((Fahrenheit)c).GetAmount();
        }

        /// <summary>
        /// Compares if the amount of Fahrenheit and Celsius are equals.
        /// </summary>
        /// <param name="f">Fahrenheit to compare.</param>
        /// <param name="k">Kelvin to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Fahrenheit f, Kelvin k) {
            return f.GetAmount() == ((Celsius)k).GetAmount();
        }

        /// <summary>
        /// Compares if the amount of Fahrenheit and Fahrenheit are equals.
        /// </summary>
        /// <param name="f">Fahrenheit to compare.</param>
        /// <param name="e">Fahrenheit to compare.</param>
        /// <returns>True if are equals, otherwise returns False</returns>
        public static bool operator ==(Fahrenheit f, Fahrenheit e) {
            return f.GetAmount() == e.GetAmount();
        }

        #endregion

        #region Inequality

        /// <summary>
        /// Compares if the amount of Fahrenheit and Celsius are differents.
        /// </summary>
        /// <param name="f">Fahrenheit to Compare.</param>
        /// <param name="c">Celsius to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Fahrenheit f, Celsius c) {
            return !(f == c);
        }

        /// <summary>
        /// Compares if the amount of Fahrenheit and Celsius are differents.
        /// </summary>
        /// <param name="f">Fahrenheit to Compare.</param>
        /// <param name="k">Kelvin to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Fahrenheit f, Kelvin k) {
            return !(f == k);
        }

        /// <summary>
        /// Compares if the amount of Fahrenheit and Fahrenheit are differents.
        /// </summary>
        /// <param name="f">Fahrenheit to Compare.</param>
        /// <param name="e">Fahrenheit to Compare.</param>
        /// <returns>True if are differents, otherwise returns False.</returns>
        public static bool operator !=(Fahrenheit f, Fahrenheit e) {
            return !(f == e);
        }

        #endregion

        #region Addition

        /// <summary>
        /// Adds to an object of type Fahrenheit, the equivalent amount of Fahrenheit of an object type Fahrenheit.
        /// </summary>
        /// <param name="f">Fahrenheit for sum.</param>
        /// <param name="c">Celsius to cast to Celsius</param>
        /// <returns>An object type Fahrenheit with The sum of the equivalent in Fahrenheit of an object Celsius-type.</returns>
        public static Fahrenheit operator +(Fahrenheit f, Celsius c) {
            return new Fahrenheit(f.GetAmount() + ((Fahrenheit)c).GetAmount());
        }

        /// <summary>
        /// Adds to an object of type Fahrenheit, the equivalent amount of Fahrenheit of an object type Kelvin.
        /// </summary>
        /// <param name="f">Fahrenheit for sum.</param>
        /// <param name="k">Kelvin to cast to Celsius</param>
        /// <returns>An object type Fahrenheit with The sum of the equivalent in Fahrenheit of an object Kelvin-type.</returns>
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k) {
            return new Fahrenheit(f.GetAmount() + ((Fahrenheit)k).GetAmount());
        }

        #endregion

        #region Substraction

        /// <summary>
        /// Subtracts from an object of type Fahrenheit, the equivalent amount of Fahrenheit of an object of Celsius type.
        /// </summary>
        /// <param name="f">Fahrenheit for substract.</param>
        /// <param name="c">Celsius to cast to Celsius</param>
        /// <returns>The Fahrenheit-type object minus the equivalent in Fahrenheit of a Celsius-type object.</returns>
        public static Fahrenheit operator -(Fahrenheit f, Celsius c) {
            return new Fahrenheit(f.GetAmount() - ((Fahrenheit)c).GetAmount());
        }

        /// <summary>
        /// Subtracts from an object of type Fahrenheit, the equivalent amount of Fahrenheit of an object of Kelvin type.
        /// </summary>
        /// <param name="f">Fahrenheit for substract.</param>
        /// <param name="k">Kelvin to cast to Celsius</param>
        /// <returns>The Fahrenheit-type object minus the equivalent in Fahrenheit of a Kelvin-type object.</returns>
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k) {
            return new Fahrenheit(f.GetAmount() - ((Fahrenheit)k).GetAmount());
        }

        #endregion

        #endregion
    }
}
