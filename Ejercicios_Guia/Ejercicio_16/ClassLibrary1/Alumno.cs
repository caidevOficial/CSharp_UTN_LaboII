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

namespace Ejercicio_16
{
    public class Alumno
    {
        //# Attributes
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        /// <summary>
        /// Sets the both scores of the student.
        /// </summary>
        /// <param name="score1">First score of the student.</param>
        /// <param name="score2">Second score of the student.</param>
        public void Estudiar(byte score1, byte score2)
        {
            this.nota1 = score1;
            this.nota2 = score2;
        }

        /// <summary>
        /// Calculates the final score of the student, if both scores are highers than 3, 
        /// sets a random score between 4 and 10, otherwise -1.
        /// </summary>
        public void CalcularFinal()
        {
            int finalScore = -1;

            if(this.nota1>3 && this.nota2 > 3)
            {
                Random score = new Random();
                finalScore = score.Next(4,10);
            }

            this.notaFinal = finalScore;
        }

        /// <summary>
        /// Creates the info of the student as a message.
        /// </summary>
        /// <returns>The info of the student as a message.</returns>
        public String Mostrar()
        {
            string nombre = this.nombre;
            string apellido = this.apellido;
            int legajo = this.legajo;
            byte nota1 = this.nota1;
            byte nota2 = this.nota2;
            float notaFinal = this.notaFinal;
            string message = $"Name: {nombre}.\n" +
                $"Surname: {apellido}.\n" +
                $"File: {legajo}.\n" +
                $"Exam Score 1: {nota1}.\n" +
                $"Exam Score 2: {nota2}.\n";

            if (notaFinal > -1)
            {
                message += $"Final Score: {notaFinal}.\n";
            }
            else
            {
                message += "Student disapproved.\n";
            }

            return message;
        }
    }
}
