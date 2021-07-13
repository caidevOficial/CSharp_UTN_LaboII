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
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bomberos.Interface;
using Bomberos.Persistencia;
using Bomberos.Exceptions;

namespace Bomberos.Entidades {

    public delegate void FinDeSalida(int bomberoIndex);

    [Serializable]
    public class Bombero : IArchivos<Bombero>, IArchivos<string> {

        #region Attributes

        private string nombre;
        private List<Salidas> salidas;
        [field: NonSerialized]
        public event FinDeSalida MarcarFin;

        #endregion

        #region Builders

        /// <summary>
        /// Builder without parameters.
        /// </summary>
        public Bombero() {
            this.salidas = new List<Salidas>();
        }

        /// <summary>
        /// Builder with name of the firefighter.
        /// </summary>
        /// <param name="nombre">Name of the firefighter.</param>
        public Bombero(string nombre) : this() {
            this.Nombre = nombre;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: the name of the entity.
        /// </summary>
        public string Nombre { 
            get => this.nombre; 
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.nombre = value;
                }
            } 
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bomberoIndex"></param>
        public void AtenderSalida(object bomberoIndex) {
            Salidas salida = new Salidas();
            salidas.Add(salida);
            Thread.Sleep(3000);
            salidas[salidas.Count - 1].FinalizarSalida();
            string message = $"{this.Nombre} - {salidas[salidas.Count - 1].ToString()}";
            this.Guardar(message);
            this.MarcarFin((int)bomberoIndex);
        }

        /// <summary>
        /// Saves in binary format.
        /// </summary>
        /// <param name="info"></param>
        public void Guardar(Bombero info) {
            try {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Bombero_{0}.bin", info.Nombre));
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream myStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None)) {
                    formatter.Serialize(myStream, info);
                }
            } catch (Exception exe) {
                throw new Exception(exe.Message, exe);
            }
        }

        /// <summary>
        /// Saves the data into the DB.
        /// </summary>
        /// <param name="info">String to save into the DB.</param>
        public void Guardar(string info) {
            try {
                DataAccesDAO.InsertData(info);
            } catch (Exception exe) {
                throw new Exception(exe.Message, exe);
            }
        }

        /// <summary>
        /// Reads a Binary file.
        /// </summary>
        /// <returns></returns>
        public Bombero Leer() {
            Bombero fireFighter = null;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Bombero_{0}.bin", fireFighter.Nombre));
            try {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream myStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None)) {
                    fireFighter = (Bombero)formatter.Deserialize(myStream);
                }
            } catch (Exception exe) {
                throw new Exception(exe.Message, exe);
            }

            return fireFighter;
        }

        /// <summary>
        /// Reads the data from the DB.
        /// </summary>
        /// <returns>Data as a string.</returns>
        string IArchivos<string>.Leer() {
            string messages;
            try {
                messages = DataAccesDAO.GetData();
            } catch (Exception exe) {
                throw new Exception(exe.Message, exe);
            }

            return messages;
        }

        /// <summary>
        /// Info of the FireFighter.
        /// </summary>
        /// <returns>His info as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Name: {this.Nombre}");
            foreach (Salidas item in this.salidas) {
                data.AppendLine(item.ToString());
                data.AppendLine("______________");
            }

            return data.ToString();
        }

        #endregion
    }
}
