﻿/*
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        #region Builders

        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal)
            :this()
        {
            this.espacioTotal = espacioTotal;
        }

        #endregion

        #region Properties

        public Tipo TipoSuelo
        {
            set
            {
                suelo = value;
            }
        }

        #endregion

        #region Methods

        public int EspacioOcupado()
        {
            int ocupado = 0;
            
            foreach (Planta plant in this.plantas)
            {
                ocupado += plant.Tamanio;
            }

            return ocupado;
         }

        public int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Composicion del Jardín: {Jardin.suelo}");
            data.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
            data.AppendLine("Lista de plantas:");
            foreach (Planta planta in this.plantas)
            {
                data.AppendLine(planta.ResumenDeDatos());
            }

            return data.ToString();
        }

        #endregion

        #region Operators

        public static bool operator +(Jardin j, Planta p)
        {
            if(!(j is null) && !(p is null))
            {
                if(j.EspacioOcupado(p) <= j.espacioTotal)
                {
                    j.plantas.Add(p);
                    return true;
                }
                
            }

            return false;
        }

        #endregion

    }
}
