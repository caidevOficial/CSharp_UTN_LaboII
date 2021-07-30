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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Testing {
    [TestClass]
    public class GestorArchivo_Test {
        
        /// <summary>
        /// Checks the exception when trying to read an incorreect or inexistent file.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void Test01_Exception_When_Incorrect_File() {
            #region Arrange
            Carrera carrera;
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\carrera.xmll";
            GestorDeArchivos gestor = new GestorDeArchivos(ruta);

            #endregion
            #region Act
            carrera = gestor.LeerXML();
            #endregion
        }

        /// <summary>
        /// Test that can serialize the race's data.
        /// </summary>
        [TestMethod]
        public void Test02_SerializeXML() {
            #region Arrange

            Carrera carrera = new Carrera(15);
            AutoF1 auto = new AutoF1("Ferrari", 4, 4);
            carrera += auto;
            Carrera carrera2;
            string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\carreraTest.xml";
            GestorDeArchivos gestor = new GestorDeArchivos(ruta);

            #endregion

            #region Act
            gestor.Guardar(carrera);
            carrera2 = gestor.LeerXML();
            #endregion

            #region Assert
            Assert.AreEqual(carrera.Autos.Count, carrera2.Autos.Count);
            #endregion
        }
    }
}
