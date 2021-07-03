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
using System.Windows.Forms;

namespace SPUnitTest {
    [TestClass]
    public class UnitTest1 {

        /// <summary>
        /// Testea que funcione la JugadaActivaException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(JugadaActivaException))]
        public void Test01_JugadaActivaException() {

            #region Arrange
            GolDelSiglo gds = new GolDelSiglo();
            #endregion

            #region Act
            gds.IniciarJugada();
            gds.IniciarJugada();
            #endregion
        }

        /// <summary>
        /// Verifica que el metodo de extension retorne la ultima 
        /// letra del nombre de un picture box.
        /// </summary>
        [TestMethod]
        public void Test02_ExtensionMethod() {
            #region Arrange

            PictureBox myPB = new PictureBox();
            myPB.Name = "My Box";

            #endregion

            #region Act

            string lastChar = myPB.ExtensionPB();

            #endregion

            #region Assert

            Assert.AreEqual("x", lastChar);

            #endregion
        }
    }
}
