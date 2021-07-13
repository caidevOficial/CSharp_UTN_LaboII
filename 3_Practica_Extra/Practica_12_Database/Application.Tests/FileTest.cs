using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Application.Repositories;
using Application.Models;
using Application.Files.Text;
using Application.Files.Xml;

namespace Application.Tests
{
    [TestClass]
    public class FileTest
    {
        Text<string> textManager = new Text<string>();
        Xml<string> xmlManager = new Xml<string>();


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test01_Text_Exception_When_Invalid_Path()
        {
            #region Arrange

            string data;
            textManager.Read("Texto.txt", out data);

            #endregion
            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test02_Xml_Exception_When_Invalid_Path()
        {

            #region Arrange

            string data;
            xmlManager.Read("Texto.txt", out data);

            #endregion
            //TODO implementar
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod]
        public void Test03_Xml_Deserialize()
        {
            #region Arrange

            string path = $"{Environment.CurrentDirectory}\\Customers.xml";
            string data = null;

            #endregion

            #region Act

            xmlManager.Read(path, out data);

            #endregion

            #region Assert

            Assert.IsNotNull(data);

            #endregion

        }

    }
}
