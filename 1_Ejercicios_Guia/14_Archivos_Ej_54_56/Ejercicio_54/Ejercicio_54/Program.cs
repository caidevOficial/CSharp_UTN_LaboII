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
using IO;
using System;
using System.IO;

namespace Ejercicio_54 {
    class Program {
        static void Main(string[] args) {

            string fileName = $"{DateTime.Today.Year}{DateTime.Today.Month}{DateTime.Today.Day}-{DateTime.Now.Hour}{DateTime.Now.Minute}.txt";
            string pathToSave = $"{Environment.CurrentDirectory}\\Logs";
            string absolutePath = $"{pathToSave}\\{fileName}";
            string message;

            try {
                OtraClase otraClase = new OtraClase();
                otraClase.OtroMetodoInstancia(); //provoco la excepción.
            } catch (MiExcepcion e) {

                #region FileHandlerSave

                message = $"Date: {DateTime.Now}.\nMessage: {e.Message}.\nInner: {e.InnerException.Message}.";

                if (!Directory.Exists(pathToSave)) {
                    Directory.CreateDirectory(pathToSave);
                }

                if (ArchivoTexto.Guardar(absolutePath, message)) {
                    Console.WriteLine($"Archivo guardado en: {pathToSave}");
                } else {
                    Console.WriteLine("Error al guardar el archivo.");
                }

                #endregion

                #region MensajeDe_MiException

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n### Mensaje de la E ###");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);

                #endregion

                #region PathDeInnerException

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n### Path de la IE ###");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(e.InnerException); //deberia mostrar el path de errores.

                #endregion

                #region MensajeDe_IE

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n### Mensaje de la IE ###");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.InnerException.Message);

                #endregion

                #region MensajeCompletoDe_IE

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n### Mensaje Completo de la IE ###");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Exception ex = e.InnerException;
                Console.WriteLine($"MENSAJE: {ex.Message} EN: {ex.Source}"); //Muestro la IE.

                #endregion

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n### Mensaje de todas las IE ###");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Exception ie = e.InnerException; //guardo la IE

                //Loopeo hasta recorer todos los IE
                while (!Object.ReferenceEquals(ie, null)) {
                    Console.WriteLine(ie.Message);
                    ie = ie.InnerException;
                }
            }

            #region FileHandlerLoad

            try {
                Console.WriteLine(ArchivoTexto.Leer(absolutePath));
            } catch (FileNotFoundException fe) {

                Console.WriteLine("FileNotFound");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
