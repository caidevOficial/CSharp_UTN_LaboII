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

namespace Models
{
    public static class MiniSuper
    {
        static Usuario[] usuarios;

        #region Builders

        /// <summary>
        /// Builds the entity without parameters and initializes the array.
        /// </summary>
        static MiniSuper()
        {
            usuarios = new Usuario[0];
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get: gets all the users of the entity.
        /// </summary>
        /// <returns>The list of users of the entity.</returns>
        public static Usuario[] GetUsuarios()
        {
            return usuarios;
        }

        /// <summary>
        /// Tries to add a new user to the array if not exist.
        /// </summary>
        /// <param name="user">User to add.</param>
        /// <returns>True if can add the User, otherwise returns false.</returns>
        public static bool AddUsuarios(Usuario user)
        {
            foreach (Usuario item in usuarios)
            {
                if (user == item)
                {
                    return false;
                }
            }

            Array.Resize<Usuario>(ref usuarios, usuarios.Length + 1);
            usuarios[usuarios.Length - 1] = user;
            // Crear la sobrecarga del +
            //usuarios += user;

            return true;
        }

        #endregion
    }
}
