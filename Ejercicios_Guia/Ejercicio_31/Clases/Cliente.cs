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


namespace Clases {
    public sealed class Cliente {
        private string nombre;
        private int numero;

        #region Builders

        /// <summary>
        /// Crea la entidad pasandole un numero.
        /// </summary>
        /// <param name="numero">Numero de orden del cliente.</param>
        public Cliente(int numero) {
            this.numero = numero;
        }

        /// <summary>
        /// Crea la entidad con el nombre y numero del cliente.
        /// </summary>
        /// <param name="nombre">Nombre que llevara el cliente.</param>
        /// <param name="numero">Numero de orden que llevara el cliente.</param>
        public Cliente(string nombre, int numero) : this(numero) {
            this.Nombre = nombre;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Retorna el numero de orden del cliente.
        /// </summary>
        public int Numero {
            get {
                return this.numero;
            }
        }

        /// <summary>
        /// Get: Retorna el nombre del cliente.
        /// Set: Asigna el nombre al cliente.
        /// </summary>
        public string Nombre {
            get {
                return this.nombre;
            }
            set {
                this.nombre = value;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compara los numeros de dos clientes.
        /// </summary>
        /// <param name="c1">Primer cliente a comparar</param>
        /// <param name="c2">Segundo cliente a comparar</param>
        /// <returns>Retorna true si ambos tienen el mismo numero.</returns>
        public static bool operator ==(Cliente c1, Cliente c2) {
            return c1.Numero == c2.Numero;
        }

        /// <summary>
        /// Compara los numeros de dos clientes.
        /// </summary>
        /// <param name="c1">Primer cliente a comparar</param>
        /// <param name="c2">Segundo cliente a comparar</param>
        /// <returns>Retorna true si ambos tienen distinto numero.</returns>
        public static bool operator !=(Cliente c1, Cliente c2) {
            return !(c1.Numero == c2.Numero);
        }

        #endregion

    }
}
