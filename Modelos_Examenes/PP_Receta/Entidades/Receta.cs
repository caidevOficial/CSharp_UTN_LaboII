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

using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Receta
    {
        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        public enum Tipo
        {
            Clasica,
            Especial
        }

        #region Builders

        static Receta()
        {
            preparacion = Tipo.Clasica;
        }

        private Receta()
        {
            ingredientes = new List<Ingrediente>();
        }

        public Receta(int capacidad)
            : this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        #endregion

        #region Properties

        public Tipo TipoDePreparacion
        {
            set
            {
                preparacion = value;
            }
        }

        #endregion

        #region Operators

        public static bool operator +(Receta rec, Ingrediente ing)
        {
            if (!(rec is null) && !(ing is null))
            {
                if (rec.CapacidadLibre(ing) >= 0)
                {
                    rec.ingredientes.Add(ing);
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calcula la cantidad de espacio libre del recipiente.
        /// </summary>
        /// <returns>La cantidad de espacio libre del recipiente.</returns>
        private int CapacidadLibre()
        {
            int libre = capacidadDelContenedor;
            foreach (Ingrediente item in this.ingredientes)
            {
                libre -= item.Cantidad;
            }

            return libre;
        }

        /// <summary>
        /// Calcula el espacio libre incluyendo el ingrediente del parametro.
        /// </summary>
        /// <param name="planta"></param>
        /// <returns>El espacio libre del recipiente incluyendo el ingrediente.</returns>
        private int CapacidadLibre(Ingrediente planta)
        {
            return CapacidadLibre() - planta.Cantidad;
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Receta: {Receta.preparacion}");
            data.AppendLine($"Capacidad Libre: {this.CapacidadLibre()}");
            data.AppendLine($"Capacidad Total: {this.capacidadDelContenedor}");
            data.AppendLine($"Lista de ingredientes:");
            foreach (Ingrediente item in this.ingredientes)
            {
                data.AppendLine(item.Informacion());
            }

            return data.ToString();
        }

        #endregion
    }
}
