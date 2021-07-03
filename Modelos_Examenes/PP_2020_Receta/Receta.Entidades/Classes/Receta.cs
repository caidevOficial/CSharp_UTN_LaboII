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

namespace Entidades {
    public class Receta {
        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        public enum Tipo {
            Clasica,
            Especial
        }

        #region Builders

        /// <summary>
        /// Initializes the recipe as a classic type.
        /// </summary>
        static Receta() {
            preparacion = Tipo.Clasica;
        }

        /// <summary>
        /// Istances the list of ingredients of the entity.
        /// </summary>
        private Receta() {
            ingredientes = new List<Ingrediente>();
        }

        /// <summary>
        /// Instances the entity with the size of the recipe.
        /// </summary>
        /// <param name="capacidad">Size of the recipe.</param>
        public Receta(int capacidad)
            : this() {
            this.capacidadDelContenedor = capacidad;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the type of preparation
        /// </summary>
        public Tipo TipoDePreparacion {
            set {
                preparacion = value;
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Overloads the operator + to add an ingredient into the recipe.
        /// </summary>
        /// <param name="rec">Recipe to add the ingredient.</param>
        /// <param name="ing">Ingredient to add into the recipe.</param>
        /// <returns>True if can add the ingredient into the recipe, otherwise returns false.</returns>
        public static bool operator +(Receta rec, Ingrediente ing) {
            if (!(rec is null) && !(ing is null)) {
                if (rec.CapacidadLibre(ing) >= 0) {
                    rec.ingredientes.Add(ing);
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the free space of the recipe
        /// </summary>
        /// <returns>the free space of the recipe.</returns>
        private int CapacidadLibre() {
            int libre = capacidadDelContenedor;
            foreach (Ingrediente item in this.ingredientes) {
                libre -= item.Cantidad;
            }

            return libre;
        }

        /// <summary>
        /// Calculates the free space of the recipe
        /// </summary>
        /// <param name="planta">Another ingredient to add.</param>
        /// <returns>the free space of the recipe.</returns>
        private int CapacidadLibre(Ingrediente planta) {
            return CapacidadLibre() - planta.Cantidad;
        }

        /// <summary>
        /// Gets the info of the entire recipe as a string.
        /// </summary>
        /// <returns>The info of the entire recipe as a string.</returns>
        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Receta: {Receta.preparacion}");
            data.AppendLine($"Capacidad Libre: {this.CapacidadLibre()}");
            data.AppendLine($"Capacidad Total: {this.capacidadDelContenedor}");
            data.AppendLine($"Lista de ingredientes:");
            foreach (Ingrediente item in this.ingredientes) {
                data.AppendLine(item.Informacion());
            }

            return data.ToString();
        }

        #endregion
    }
}
