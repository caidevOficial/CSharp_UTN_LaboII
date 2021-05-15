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

using Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void Test_01_List_Instanced() {

            #region Arrange

            Competencia tc = new Competencia(10, 10, Competencia.TipoCompetencia.F1);

            #endregion

            #region Assert

            Assert.IsNotNull(tc.Competidores);

            #endregion
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Test_02_Incorrect_Vehicle() {

            #region Arrange

            Competencia tc = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            AutoF1 formula = new AutoF1(1, "McLaren");

            #endregion

            #region Act

            bool addCar = tc + formula;

            #endregion

        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Test_03_Correct_Vehicle() {

            #region Arrange

            Competencia tc = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross formula = new MotoCross(1, "Honda");

            #endregion

            #region Act

            bool addMoto = tc + formula;

            #endregion

        }

        [TestMethod]
        public void Test_04_Cargar_Vehiculo_Existente() {

            #region Arrange

            Competencia tc = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross formulaF1 = new MotoCross(1, "Honda");
            MotoCross formulaF2 = new MotoCross(1, "Honda");

            #endregion

            #region Act

            bool vehicles = formulaF1 == formulaF2;
            bool addMoto = tc + formulaF1;
            bool addMoto2 = tc + formulaF2;

            #endregion

            #region Assert

            Assert.IsTrue(vehicles);

            #endregion

        }

        [TestMethod]
        public void Test_05_Cargar_Vehiculo_Quitado() {

            #region Arrange

            Competencia tc = new Competencia(10, 10, Competencia.TipoCompetencia.MotoCross);
            MotoCross formulaF1 = new MotoCross(1, "Honda");
            MotoCross formulaF2 = new MotoCross(1, "Honda");

            #endregion

            #region Act

            bool addMoto = tc + formulaF1;
            bool delete = tc - formulaF1;

            #endregion

            #region Assert

            Assert.IsTrue(tc != formulaF1);

            #endregion

        }
    }
}
