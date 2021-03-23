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

namespace ClassLibrary
{
    public class Vaccination
    {
        private string name;

        public Vaccination()
        {

        }

        public Vaccination(string name) : this()
        {
            this.name = name;
        }

        /// <summary>
        /// Gets the namethe info of the vaccine.
        /// </summary>
        /// <returns>the namethe info of the vaccine.</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Sets the name of the vaccine.
        /// </summary>
        /// <param name="name">the name to set.</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Returns the info of the vaccine as a string.
        /// </summary>
        /// <returns>The info of the vaccine.</returns>
        public string VaccineToString()
        {
            return $"Vaccine Name: {this.GetName()}.";
        }
    }
}
