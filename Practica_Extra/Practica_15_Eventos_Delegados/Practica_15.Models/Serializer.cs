﻿/*
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Models {
    public class Serializer {

        #region Attributes

        #endregion

        #region Builders

        #endregion

        #region Properties

        #endregion

        #region Operators

        #endregion

        #region Methods

        public bool Guardar(Persona persona) {
            try {
                string path = $"{Environment.CurrentDirectory}\\Log";
                string fileName = "File.xml";
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                using(XmlTextWriter writer = new XmlTextWriter($"{path}\\{fileName}", Encoding.UTF8)) {
                    XmlSerializer anotherWriter = new XmlSerializer(typeof(Persona));
                    anotherWriter.Serialize(writer, persona);
                    return true;
                }
            } catch (Exception exe) {

                throw new Exception(exe.Message);
            }
        }

        #endregion
    }
}