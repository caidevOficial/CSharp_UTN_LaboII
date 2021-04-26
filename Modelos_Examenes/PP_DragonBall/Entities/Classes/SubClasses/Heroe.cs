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

using Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes.SubClasses
{
    public class Heroe : Personaje
    {
        private bool esSaiyan;
        private ETransformacionSaiyan transformacion;
        private string mensaje;

        #region Buidlers

        public Heroe(string nombre, int nivelPoder, List<EHabilidades> ataques, bool esSaiyan)
            : base(nombre, nivelPoder, ataques)
        {
            this.mensaje = "Aun me falta mucho por entrenar!";
            this.esSaiyan = esSaiyan;
        }

        #endregion

        #region Properties

        protected override string Descripcion
        {
            get
            {
                if (esSaiyan)
                    return "Disfruta los combates. Su poder no tiene límite";
                else
                    return "Siempre pelea junto a un Saiyan. Fiel amigo";
            }
        }

        public string Mensaje
        {
            get => this.mensaje;
        }

        public bool Saiyajin
        {
            get => esSaiyan;
        }

        #endregion

        #region Methods

        public override string InfoPersonaje()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.InfoPersonaje());
            data.AppendLine($"Es Saiyan: {this.esSaiyan}");
            data.AppendLine($"Transformacion: {this.transformacion.ToString()}");

            return data.ToString();
        }

        public override string Transformarse()
        {
            if (esSaiyan)
            {
                switch (this.transformacion)
                {
                    case ETransformacionSaiyan.Base:
                        this.nivelPoder *= 10;
                        this.transformacion++;
                        this.mensaje = "Ya basta freezer!!";
                        break;
                    case ETransformacionSaiyan.SSJ:
                        this.nivelPoder *= 20;
                        this.transformacion++;
                        this.mensaje = "Este es el SSJ2, admito que es muy poderoso!";
                        break;
                    case ETransformacionSaiyan.SSJ2:
                        this.nivelPoder *= 30;
                        this.transformacion++;
                        this.mensaje = "Esta transformacion, supera los poderes del SSJ2!";
                        break;
                    case ETransformacionSaiyan.SSJ3:
                        this.nivelPoder *= 50;
                        this.transformacion++;
                        this.mensaje = "Hora de convertirse en un dios!!";
                        break;
                    case ETransformacionSaiyan.SSJG:
                        this.nivelPoder *= 60;
                        this.transformacion++;
                        this.mensaje = "Soy un SSJ dios que alcanzo el estado de SSJ!";
                        break;
                    case ETransformacionSaiyan.SSJGSSJ:
                        this.nivelPoder *= 100;
                        this.transformacion++;
                        this.mensaje = "Así que este es el ultra instinto...";
                        break;
                    case ETransformacionSaiyan.MigatteNoGokui:
                        this.nivelPoder = 100;
                        this.transformacion = ETransformacionSaiyan.Base;
                        this.mensaje = "Aun me falta mucho por entrenar!";
                        break;
                }
            }

            return this.transformacion.ToString();
        }

        #endregion
    }
}
