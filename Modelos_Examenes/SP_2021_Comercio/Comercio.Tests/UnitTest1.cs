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
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class UnitTest1 {

        private Comercio myCom;
        private Comercio myCom2;
        private Cliente myCustomer;

        /// <summary>
        /// Chequea que arroje la escepcion.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SinClientesException))]
        public void Test01_Exception() {
            #region Arrange

            myCom = new Comercio();

            #endregion

            #region Act

            myCom.LlamarCliente();

            #endregion
        }

        /// <summary>
        /// Chequea que al guardar una lista y cargarla en otra instancia, ambas tengan la misma cantidad.
        /// </summary>
        [TestMethod]
        public void Test02_SaveAndLoadSame() {

            #region Arrange

            myCom = new Comercio();
            myCom2 = new Comercio();
            string path = $"{Environment.CurrentDirectory}\\Customers.xml";

            #endregion

            #region Act

            myCom += new Cliente("Test1");
            myCom += new Cliente("Test2");
            myCom.SaveBackup(path);
            myCom2.LoadBackup(path);

            #endregion

            #region Assert

            Assert.AreEqual(myCom.Clientes.Count, myCom2.Clientes.Count);

            #endregion
        }

        /// <summary>
        /// Chequea que el cliente sea igual en dos listas diferentes
        /// </summary>
        [TestMethod]
        public void Test03_CheckSameCustomerInDifferentLists() {
            #region Arrange
            myCom = new Comercio();
            myCom2 = new Comercio();
            myCustomer = new Cliente("Test01");
            #endregion

            #region Act
            myCom += myCustomer;
            myCom2 += myCustomer;
            #endregion

            #region Assert
            Assert.AreEqual(myCom2.Clientes[0], myCom.Clientes[0]);
            #endregion
        }
    }
}
