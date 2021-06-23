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
using System.Text;

namespace Practica_16.Models {
    public static class ExtensionMethod {

        /// <summary>
        /// Extension method for the class DateTime.
        /// </summary>
        /// <param name="days">Instance DateTime-Type</param>
        /// <param name="season">Enum of Seasons</param>
        /// <returns>A string with a message of the days left to the season.</returns>
        public static string ObtenerPlacaCronica(this DateTime days, Seasons season) {
            DateTime timeTo = DateTime.Now;
            switch (season) {
                case Seasons.Verano:
                    timeTo = new DateTime(DateTime.Now.Year, 12, 21);
                    break;
                case Seasons.Otonio:
                    timeTo = new DateTime(DateTime.Now.Year, 03, 21);
                    break;
                case Seasons.Invierno:
                    timeTo = new DateTime(DateTime.Now.Year, 06, 21);
                    break;
                case Seasons.Primavera:
                    timeTo = new DateTime(DateTime.Now.Year, 09, 21);
                    break;
                default:
                    break;
            }

            return DaysLeft(DateTime.Now, timeTo, season);
        }

        /// <summary>
        /// Message Formatter to show the Days left.
        /// </summary>
        /// <param name="timeFrom">DateTime Object to compare the date.</param>
        /// <param name="timeTo">DateTime Object to compare the date.</param>
        /// <param name="season">Season Enum.</param>
        /// <returns>A String with the message formatted.</returns>
        private static string DaysLeft(DateTime timeFrom, DateTime timeTo, Seasons season) {
            StringBuilder data = new StringBuilder();
            
            if (timeTo < timeFrom) {
                timeTo = timeTo.AddYears(1);
            }
            int daysLeft = (timeTo - timeFrom).Days;

            for (int i = 0; i < 20; i++) {
                data.AppendLine("                           ");
            }
            data.AppendLine($"          Reiteramos!! ");
            data.AppendLine(String.Format("    Quedan {0, -3} Dias para {1, -9}", daysLeft, Enum.GetName(typeof(Seasons), season)));
            for (int i = 0; i < 20; i++) {
                data.AppendLine("                           ");
            }

            return data.ToString();
        }
    }
}
