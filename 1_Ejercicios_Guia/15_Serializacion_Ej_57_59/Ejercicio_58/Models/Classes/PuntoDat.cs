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

using Exceptions;
using Interface;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Models {

    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat> {

        #region Attributes

        private string contenido;

        #endregion

        #region Builders

        public PuntoDat() { }

        public PuntoDat(string content) : this() {
            this.contenido = content;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: the content of the entity.
        /// </summary>
        public string Contenido {
            get => this.contenido;
            set {
                this.contenido = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Serializes the objet into a binnary object.
        /// </summary>
        /// <param name="path">Path to save the object.</param>
        /// <param name="objeto">Object to serialize.</param>
        /// <returns>True if can serialize the object, otherwise returns false.</returns>
        public bool Guardar(string path, PuntoDat objeto) {
            if (this.ValidarArchivo(path, true)) {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate)) {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, objeto);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Serializes the objet into a binnary object.
        /// </summary>
        /// <param name="path">Path to save the object.</param>
        /// <param name="objeto">Object to serialize.</param>
        /// <returns>True if can serialize the object, otherwise returns false.</returns>
        public bool GuardarComo(string path, PuntoDat objeto) {
            return this.Guardar(path, objeto);
        }

        /// <summary>
        /// Deserialize a binary object.
        /// </summary>
        /// <param name="path">Path of the binary objet to be deserialized.</param>
        /// <returns>The object deserialized or a null object.</returns>
        public PuntoDat Leer(string path) {
            PuntoDat item = null;
            if (this.ValidarArchivo(path, true)) {
                using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    BinaryFormatter bf = new BinaryFormatter();
                    item = (PuntoDat)bf.Deserialize(fs);
                }
            }

            return item;
        }

        /// <summary>
        /// It will validate that the file exist only if 'calidateExistence' is true
        /// otherwise will throw an exception.
        /// </summary>
        /// <param name="path">Path to verify if the file exist.</param>
        /// <param name="validateExistence">Boolean state that indicates fi the method need to validate the existence of the file.</param>
        /// <returns>True if is a valid file, othewise returns false</returns>
        protected override bool ValidarArchivo(string path, bool validateExistence) {
            try {
                if (base.ValidarArchivo(path, validateExistence)) {
                    if (Path.GetExtension(path) == ".dat") {
                        return true;
                    } else {
                        throw new ArchivoIncorrectoException("El File no es un dat.");
                    }
                }
            } catch (Exception fn) {
                throw new ArchivoIncorrectoException("El archivo no es un dat.", fn);
            }

            return false;
        }

        #endregion
    }
}
