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
    public class Customer
    {
        private string name;
        private string surname;
        private string address;
        private string phone;
        private Pet[] hisPet;

        public Customer()
        {

        }

        public Customer(string name, string surname, string address, string phone) : this()
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phone = phone;
            this.hisPet = new Pet[2];
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <returns>The name of the customer.</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Gets the surname of the customer.
        /// </summary>
        /// <returns>The surname of the customer.</returns>
        public string GetSurname()
        {
            return this.surname;
        }

        /// <summary>
        /// Gets the address of the customer.
        /// </summary>
        /// <returns>The address of the customer.</returns>
        public string GetAddress()
        {
            return this.address;
        }

        /// <summary>
        /// Gets the phone number of the customer.
        /// </summary>
        /// <returns>The phone number of the customer.</returns>
        public string GetPhone()
        {
            return this.phone;
        }

        /// <summary>
        /// Gets the array of pets of the customer.
        /// </summary>
        /// <returns>The array of pets.</returns>
        public Pet[] GetPet()
        {
            return this.hisPet;
        }

        /// <summary>
        /// Sets the name of the customer.
        /// </summary>
        /// <param name="name">The name to set.</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Sets the surname of the customer.
        /// </summary>
        /// <param name="surname">The surname to set.</param>
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        /// <summary>
        /// Sets the address of the customer
        /// </summary>
        /// <param name="address">The address to set.</param>
        public void SetAddress(string address)
        {
            this.address = address;
        }

        /// <summary>
        /// Sets the phone number of the customer.
        /// </summary>
        /// <param name="phone">The fone number as a string.</param>
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        /// <summary>
        /// Tryes to add a Pet in the array of pets.
        /// </summary>
        /// <param name="hisPet">The pet to add.</param>
        /// <returns>True if can add to the array, otherwise returns false.</returns>
        public bool SetPet(Pet hisPet)
        {
            for (int i = 0; i < this.GetPet().Length; i++)
            {
                if (this.GetPet()[i] == null)
                {
                    this.hisPet[i] = hisPet;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns all the info of the customer as a string.
        /// </summary>
        /// <returns>The info and his pet's info as a string.</returns>
        public string CustomerToString()
        {
            string info = 
                $"Name: {this.GetName()}.\n" +
                $"Surname: {this.GetSurname()}.\n" +
                $"Address: {this.GetAddress()}.\n" +
                $"Phone: {this.GetPhone()}.\n";
            string pets = "Pets: \n";
            string endMessage = "##############\n";
            if (this.GetPet() != null)
            {
                foreach (Pet aPet in this.GetPet())
                {
                    if (aPet != null)
                    {
                        pets += aPet.PetToString();
                    }
                }
                
                return info + pets + endMessage;
            }
            
            return info + endMessage;
        }
    }
}
