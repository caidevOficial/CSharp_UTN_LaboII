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

namespace Clases
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        #region Builders

        /// <summary>
        /// Builds the entity with all the stats in 0.
        /// </summary>
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        /// <summary>
        /// Builds the entity with the 'dni' and 'name'.
        /// </summary>
        /// <param name="dni">[PK] Unique number of the entity.</param>
        /// <param name="nombre">Name of the entity.</param>
        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        /// <summary>
        /// Builds the entity with all the fields..
        /// </summary>
        /// <param name="dni">[PK] Unique number of the entity.</param>
        /// <param name="nombre">Name of the entity.</param>
        /// <param name="partidosJugados">Amount of matchs played by the entity.</param>
        /// <param name="totalGoles">Amount of goals achieved by the entity.</param>
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        #endregion

        #region Getter

        /// <summary>
        /// Returns the average of goals by matches of the entity.
        /// </summary>
        /// <returns>The average of goals by matches</returns>
        public float GetPromedioGoles()
        {
            if (this.partidosJugados != 0)
            {
                this.promedioGoles = this.totalGoles / (float)this.partidosJugados;
            }
            return this.promedioGoles;
        }

        #endregion

        #region ShowStatics

        /// <summary>
        /// Shows the stats of the entity.
        /// </summary>
        /// <returns>The stats of the entity.</returns>
        public string MostrarDatos()
        {
            //StringBuilder fichaTecnica = new StringBuilder();
            string fichaTecnica = string.Format("| Nombre: {0,-6} | DNI: {1,-8} | PJ: {2,3} | Goles: {3,3} | Promedio: {4,4} |\n",
                this.nombre, this.dni, this.partidosJugados, this.totalGoles, this.GetPromedioGoles());

            return fichaTecnica.ToString();
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares if the two entities have the same pk.
        /// </summary>
        /// <param name="j1">First entity to compare.</param>
        /// <param name="j2">Second entity to compare.</param>
        /// <returns>True if both have the same pk, otherwise returns false.</returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        /// <summary>
        /// Compares if the two entities have different pk.
        /// </summary>
        /// <param name="j1">First entity to compare.</param>
        /// <param name="j2">Second entity to compare.</param>
        /// <returns>True if both have different pk, otherwise returns false.</returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }

        #endregion

    }
}
