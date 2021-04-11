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
    public class Pet
    {
        private string kind;
        private string name;
        private DateTime birthdate;
        private Vaccination[] history;

        #region Builders

        /// <summary>
        /// Builds the entity without parameters.
        /// </summary>
        public Pet(){}

        /// <summary>
        /// Builds the entity with all its parameters.
        /// </summary>
        /// <param name="kind">Kind of the entity.</param>
        /// <param name="name">Name of the entity.</param>
        /// <param name="birthdate">birthdate of the entity.</param>
        public Pet(string kind, string name, DateTime birthdate) : this()
        {
            this.kind = kind;
            this.name = name;
            this.birthdate = birthdate;
            this.history = new Vaccination[2];
        }

        #endregion

        #region Getters and Setters

        /// <summary>
        /// Gets the kind of the pet.
        /// </summary>
        /// <returns>the kind of the pet.</returns>
        public string GetKind()
        {
            return this.kind;
        }

        /// <summary>
        /// Gets the name of the pet.
        /// </summary>
        /// <returns>The name of the pet.</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Gets the birthday of the pet.
        /// </summary>
        /// <returns>The birthday of the pet.</returns>
        public DateTime GetBirthdate()
        {
            return this.birthdate;
        }

        /// <summary>
        /// Gets the vaccine history of the pet.
        /// </summary>
        /// <returns>The vaccine history.</returns>
        public Vaccination[] GetVaccineHistory()
        {
            return this.history;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sets a vaccine for the pet.
        /// </summary>
        /// <param name="thisVaccine">The vaccine to set.</param>
        /// <returns>true if can add, otherwise returns false.</returns>
        public bool SetVaccine(Vaccination thisVaccine)
        {
            for (int i = 0; i < this.GetVaccineHistory().Length; i++)
            {
                if (this.GetVaccineHistory()[i] == null)
                {
                    this.history[i] = thisVaccine;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the info of the pet as a string.
        /// </summary>
        /// <returns>All the info of the pet as a string.</returns>
        public string PetToString()
        {
            string petInfo = 
                $"Name: {this.GetName()}.\n" +
                $"Kind: {this.GetKind()}.\n" +
                $"Birthdate: {this.GetBirthdate()}.\n" +
                $"Vaccines: \n";
            string vaccines = "";
            if (this.GetVaccineHistory() != null)
            {
                foreach (Vaccination vaccine in this.GetVaccineHistory())
                {
                    if (vaccine != null)
                    {
                        vaccines += vaccine.GetName() + "\n";
                    }
                }
                return petInfo + vaccines;
            }
            
            return petInfo;
        }

        #endregion
    }
}
