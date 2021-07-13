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
using System.Text;

namespace CentralitaHerencia {
    public class Centralita : IGuardar<string> {

        #region Attributes

        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        #endregion

        #region Builders

        /// <summary>
        /// Builds and initialize the List of the entity.
        /// </summary>
        public Centralita() {
            this.listaDeLlamadas = new List<Llamada>();
        }

        /// <summary>
        /// /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="nombreEmpresa">Name of the enterprice</param>
        public Centralita(string nombreEmpresa)
            : this() {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get: Gets the profits of the local calls.
        /// </summary>
        public float GananciasPorLocal {
            get => CalcularGanancias(Llamada.TipoLlamada.Local);
        }

        /// <summary>
        /// Get: Gets the profits of the province calls.
        /// </summary>
        public float GananciasPorProvincial {
            get => CalcularGanancias(Llamada.TipoLlamada.Provincial);
        }

        /// <summary>
        /// Get: Gets the profits of the total calls.
        /// </summary>
        public float GananciasPorTotal {
            get => CalcularGanancias(Llamada.TipoLlamada.Todas);
        }

        /// <summary>
        /// Get: Gets all the calls.
        /// </summary>
        public List<Llamada> Llamadas { get => listaDeLlamadas; }

        /// <summary>
        /// Get: The string 'Ruta del archivo'.
        /// </summary>
        public string RutaDeArchivo { get => "Ruta Del Archivo"; set { } }

        #endregion

        #region Operators

        /// <summary>
        /// Checks if the call is in the list of calls of centralita.
        /// </summary>
        /// <param name="c">Centralita</param>
        /// <param name="l1">Call to check.</param>
        /// <returns>True if the call is in the list, otherwise returns false.</returns>
        public static bool operator ==(Centralita c, Llamada l1) {
            if (!(c is null) && !(l1 is null)) {
                foreach (Llamada call in c.listaDeLlamadas) {
                    if (call == l1) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the call isn't in the list of calls of centralita.
        /// </summary>
        /// <param name="c">Centralita</param>
        /// <param name="l1">Call to check.</param>
        /// <returns>True if the call isn't in the list, otherwise returns false.</returns>
        public static bool operator !=(Centralita c, Llamada l1) {
            return !(c == l1);
        }

        /// <summary>
        /// Tries to add a call into the list of calls.
        /// </summary>
        /// <param name="c">Centralita with the list of calls.</param>
        /// <param name="l1">Call to try to add.</param>
        /// <returns></returns>
        public static Centralita operator +(Centralita c, Llamada l1) {
            if (!(c is null) && !(l1 is null)) {
                if (c != l1) {
                    if ((l1 is Local) || (l1 is Provincial)) {
                        c.AgregarLlamada(l1);
                        //if (!c.Guardar($"{Path.GetFullPath(Environment.CurrentDirectory)}", "Bitacora")) {
                        //    throw new FallaLogException("Fallo al guardar el log", "Centralita.cs", "Centralita +");
                        //}
                    }
                } else {
                    throw new CentralitaException("Llamada existente", "Centralita", "Agregar llamada a Centralita");
                }
            }

            return c;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculate the profits of the enterprise.
        /// </summary>
        /// <param name="tipoLlamada">Type of the call.</param>
        /// <returns>Returns the profits of the calls.</returns>
        private float CalcularGanancias(Llamada.TipoLlamada tipoLlamada) {
            float profits = 0;
            foreach (Llamada call in listaDeLlamadas) {
                switch (tipoLlamada) {
                    case Llamada.TipoLlamada.Local:
                        if (call is Local) {
                            profits += ((Local)call).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (call is Provincial) {
                            profits += ((Provincial)call).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (call is Provincial) {
                            profits += ((Provincial)call).CostoLlamada;
                        } else if (call is Local) {
                            profits += ((Local)call).CostoLlamada;
                        }
                        break;
                }
            }

            return profits;

        }

        /// <summary>
        /// Sorts the calls of the list.
        /// </summary>
        public void OrdenarLlamadas() {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        /// <summary>
        /// Shows the info of the Centralita.
        /// </summary>
        /// <returns>The info of centralita as a string.</returns>
        private string Mostrar() {
            StringBuilder data = new StringBuilder();
            data.Append($"Razon Social: {this.razonSocial}.\n");
            data.Append($"Costo Total Local: {this.GananciasPorLocal}.\n");
            data.Append($"Costo Total Provincial: {this.GananciasPorProvincial}.\n");
            data.Append($"Costo Total Llamadas: {this.GananciasPorTotal}.\n");
            data.Append("Llamadas:\n");
            foreach (Llamada call in Llamadas) {
                data.Append(call.ToString());
                data.Append("________________________________________________________________\n");
            }


            return data.ToString();
        }

        /// <summary>
        /// Adds the call into the list of the centralita.
        /// </summary>
        /// <param name="l1">Call to add into the list.</param>
        private void AgregarLlamada(Llamada l1) {
            this.listaDeLlamadas.Add(l1);
        }

        /// <summary>
        /// Shows the info of the Centralita.
        /// </summary>
        /// <returns>The info of centralita as a string.</returns>
        public override string ToString() {
            return this.Mostrar();
        }

        /// <summary>
        /// It will check the info of the 
        /// </summary>
        /// <returns></returns>
        public bool Guardar(string path, string fileName) {
            string pathToSave = $"{path}\\Logs";
            string fullDirectory = $"{pathToSave}\\{fileName}.txt";
            string message = $"{DateTime.Now.DayOfWeek} {DateTime.Now.Day} de {DateTime.Now.Month} de {DateTime.Now.Year} - {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond} - Se realizo una llamada.";
            if (!Directory.Exists(pathToSave)) {
                Directory.CreateDirectory(pathToSave);
            }

            using (StreamWriter sw = File.AppendText(fullDirectory)) {
                sw.WriteLine(message);
                return true;
            }
        }

        /// <summary>
        /// It will throw the NotImplementedException.
        /// </summary>
        /// <returns>NotImplementedException.</returns>
        public string Leer() {
            string pathToSave = $"{Environment.CurrentDirectory}\\Logs";
            string nameOfFile = "Bitacora";
            string fullDirectory = $"{pathToSave}\\{nameOfFile}.txt";
            string message = string.Empty;
            using (StreamReader sr = new StreamReader(fullDirectory)) {
                message = sr.ReadToEnd();
            }

            return message;
        }

        #endregion

    }
}