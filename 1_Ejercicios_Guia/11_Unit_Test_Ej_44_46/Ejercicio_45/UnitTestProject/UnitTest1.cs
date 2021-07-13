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

namespace UnitTestProject {
    [TestClass]
    public class UnitTest1 {
        
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Test_01_MiClase_E1() {

            #region Arrange

            MiClase mc = new MiClase();

            #endregion

        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Test_02_MiClase_E2() {

            #region Arrange

            MiClase mc = new MiClase(7);

            #endregion

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_03_MiClase_E3() {

            #region Arrange

            MiClase.MostrarAtributo();

            #endregion

        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void Test_04_OtraClase_E1() {

            #region Arrange

            OtraClase oc = new OtraClase();

            #endregion

            #region Act

            oc.OtroMetodoInstancia();

            #endregion

        }
    }
}
