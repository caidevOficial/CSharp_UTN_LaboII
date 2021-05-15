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

using CentralitaHerencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject {

    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void Test_01_Validar_Lista_Instanciada() {

            #region Arrange

            Centralita central = new Centralita();

            #endregion

            #region Act



            #endregion

            #region Assert

            Assert.AreNotEqual(null, central.Llamadas);

            #endregion
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Test_02_Cargar_Misma_Llamada_Local() {
            
            #region Arrange

            Centralita central = new Centralita();
            Local llamada = new Local("110", "12", 10, 25);
            Local llamada2 = new Local("110", "12", 15, 35);

            #endregion

            #region Act

            central = central + llamada;
            central = central + llamada2;

            #endregion

            #region Assert

            #endregion

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Test_03_Cargar_Misma_Llamada_Prov() {

            #region Arrange

            Centralita central = new Centralita();
            Provincial llamada = new Provincial(10,"110", "12",  Provincial.Franja.Franja_01);
            Provincial llamada2 = new Provincial(15, "110", "12", Provincial.Franja.Franja_02);

            #endregion

            #region Act

            central = central + llamada;
            central = central + llamada2;

            #endregion

            #region Assert

            #endregion

        }

        [TestMethod]
        public void Test_04_Cargar_Misma_2_Llamadas_Loc_Prov() {

            #region Arrange

            Provincial llamadaP1 = new Provincial(10, "110", "12", Provincial.Franja.Franja_01);
            Provincial llamadaP2 = new Provincial(15, "110", "12", Provincial.Franja.Franja_02);
            Local llamadaL1 = new Local("110", "12", 10, 25);
            Local llamadaL2 = new Local("110", "12", 15, 35);

            #endregion

            #region Act

            #endregion

            #region Assert

            Assert.AreNotSame(llamadaP1, llamadaP2, "Al toque roque");
            Assert.AreNotSame(llamadaL1, llamadaL2, "Al toque roque");

            #endregion

        }

    }
}
