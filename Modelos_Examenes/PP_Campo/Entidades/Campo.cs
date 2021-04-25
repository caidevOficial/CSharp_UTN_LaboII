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
    public class Campo
    {
        private int alimentoDisponible;
        private List<Animal> animales;
        private static Tipo servicio;

        public enum Tipo
        {
            Pastoreo,
            Engorde
        }

        #region Builders

        static Campo()
        {
            Campo.servicio = Tipo.Pastoreo;
        }

        private Campo()
        {
            animales = new List<Animal>();
        }

        public Campo(int alimento)
            : this()
        {
            this.alimentoDisponible = alimento;
        }

        #endregion

        #region Properties

        public Tipo TipoServicio
        {
            set
            {
                Campo.servicio = value;
            }
        }

        #endregion

        #region Methods

        private int AlimentoComprometido()
        {
            int cantidad = 0;
            foreach (Animal item in this.animales)
            {
                cantidad += item.KilosAlimento;
            }

            return cantidad;
        }

        private int AlimentoComprometido(Animal animal)
        {
            return AlimentoComprometido() + animal.KilosAlimento;
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Servicio del campo {Campo.servicio}");
            data.AppendLine($"Alimento Comprometido {this.AlimentoComprometido()} de {this.alimentoDisponible}");
            data.AppendLine("Lista de animales:");
            foreach (Animal item in this.animales)
            {
                data.AppendLine(item.Datos());
            }

            return data.ToString();
        }

        #endregion

        #region Operators

        public static bool operator +(Campo c, Animal a)
        {
            if (!(c is null) && !(a is null))
            {
                if (c.AlimentoComprometido(a) <= c.alimentoDisponible)
                {
                    c.animales.Add(a);
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
