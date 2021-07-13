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

using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest {
    [TestClass]
    public class UnitTest1 {

        #region Test_01

        [TestMethod]
        public void Test_01_Retorna_0_Cuando_Recibe_Vacio() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add(string.Empty);

            #endregion

            #region Assert

            Assert.AreEqual(0, result);

            #endregion
        }

        #endregion

        #region Test_02

        [TestMethod]
        public void Test_02_Retorna_Suma_Cuando_Recibe_Un_Numero_String() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add("25");

            #endregion

            #region Assert

            Assert.AreEqual(25, result);

            #endregion
        }

        #endregion

        #region Test_03

        [TestMethod]
        public void Test_03_Retorna_Suma_Cuando_Recibe_Dos_Numeros_String() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add("2, 5");

            #endregion

            #region Assert

            Assert.AreEqual(7, result);

            #endregion
        }

        #endregion

        #region Test_04

        [TestMethod]
        public void Test_04_Retorna_Suma_De_Muchos_Numeros_String() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add("2, 5, 3, 10");

            #endregion

            #region Assert

            Assert.AreEqual(20, result);

            #endregion
        }

        #endregion

        #region Test_05

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Test_05_Retorna_FormatException_Al_Recibir_Letra() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add("2, a, 3, 10");

            #endregion

            #region Assert

            //Assert.ThrowsException<FormatException>(PerformAdd);

            #endregion
        }

        #endregion

        #region Test_06

        [TestMethod]
        public void Test_06_Retorna_Suma_Al_Recibir_Letra_Y_Salto() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add("2, 5\n 3, 10");

            #endregion

            #region Assert

            Assert.AreEqual(20, result);

            #endregion

        }

        #endregion

        #region Test_07

        [TestMethod]
        public void Test_07_Empieza_Con_Doble_Barra() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add("//;0\n1;2");

            #endregion

            #region Assert

            Assert.AreEqual(3, result);

            #endregion
        }

        #endregion

        #region Test_08

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Test_08_Si_LLega_Negativo_Lanzo_NegativoNoPermitidoException() {

            #region Arrange

            CalculadoraNumeros calc = new CalculadoraNumeros();

            #endregion

            #region Act

            int result = calc.Add("-2,5");

            #endregion

        }

        #endregion
    }
}
