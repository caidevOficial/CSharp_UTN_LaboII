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
using System.Collections.Generic;
using Archivos;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Patentes.Testing {
    [TestClass]
    public class Patentes_Test {

        private List<Patente> patentesList;
        private Queue<Patente> patentesQueue;
        private static string path = $"{Environment.CurrentDirectory}";
        private static string pathXml = $"{path}\\patentes.xml";
        private static string pathTxt = $"{path}\\patentes.txt";

        public Patentes_Test() {
            patentesList = new List<Patente>();
            patentesQueue = new Queue<Patente>();
            Patente pat1 = "AYK143".ValidarPatente();
            Patente pat2 = "AYK142".ValidarPatente();
            this.patentesQueue.Enqueue(pat1);
            this.patentesQueue.Enqueue(pat2);
        }

        /// <summary>
        /// Test that the xml file saved and the readed file are the same.
        /// </summary>
        [TestMethod]
        public void Test01_Check_Save_Xml() {
            #region Arrange
            Xml<List<Patente>> xmlManager = new Xml<List<Patente>>();
            foreach (Patente item in this.patentesQueue) {
                this.patentesList.Add(item);
            }
            #endregion

            #region Act
            xmlManager.Guardar(pathXml, this.patentesList);
            xmlManager.Leer(pathXml, out this.patentesList);
            Queue<Patente> patenQueue = new Queue<Patente>(patentesList);

            #endregion

            #region Assert

            foreach (Patente item in this.patentesQueue) {
                if (item.CodigoPatente != patenQueue.Dequeue().CodigoPatente) {
                    Assert.Fail("Diferentes");
                }
            }

            #endregion

        }

        /// <summary>
        /// Test that the file into the db and the readed file are the same.
        /// </summary>
        [TestMethod]
        public void Test02_Check_Save_SQL() {
            #region Arrange

            Queue<Patente> patenQueue2 = new Queue<Patente>();
            Sql sqlManager = new Sql();
            sqlManager.Guardar("patentes", this.patentesQueue);
            sqlManager.Leer("patentes", out patenQueue2);

            #endregion

            #region Assert

            foreach (Patente item in this.patentesQueue) {
                if (item.CodigoPatente != patenQueue2.Dequeue().CodigoPatente) {
                    Assert.Fail("Diferentes");
                }
            }

            #endregion

        }

        /// <summary>
        /// Test that the txt file saved and the readed file are the same.
        /// </summary>
        [TestMethod]
        public void Test03_Check_Save_TxT() {
            #region Arrange

            Texto txtManager = new Texto();
            Queue<Patente> patenQueue3 = new Queue<Patente>(patentesList);
            txtManager.Guardar(pathTxt, this.patentesQueue);
            txtManager.Leer(pathTxt, out patenQueue3);

            #endregion

            #region Assert

            foreach (Patente item in this.patentesQueue) {
                if (item.CodigoPatente != patenQueue3.Dequeue().CodigoPatente) {
                    Assert.Fail("Diferentes");
                }
            }

            #endregion

        }
    }
}
