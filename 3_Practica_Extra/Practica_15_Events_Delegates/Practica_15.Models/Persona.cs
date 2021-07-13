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
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Models {
    public class Persona {

        #region Attributes

        private List<Factura> facturas;
        private string codigoPersona;
        private EEstado estado;
        private float montoTotal;

        public enum EEstado {
            Ingresando,
            Cobrando,
            Atendido
        }

        #endregion

        #region Builders

        public Persona() {

        }

        public Persona(string codigoPersona) : this() {
            this.Facturas = new List<Factura>();
            this.CodigoPersona = codigoPersona;
            this.Estado = EEstado.Ingresando;
        }

        #endregion

        #region Properties

        internal List<Factura> Facturas {
            get => this.facturas;
            set => this.facturas = value;
        }

        public string CodigoPersona {
            get => this.codigoPersona;
            set => this.codigoPersona = value;
        }

        public EEstado Estado {
            get => this.estado;
            set => this.estado = value;
        }

        public float MontoTotal {
            get => montoTotal;
            set => montoTotal = value;
        }

        #endregion

        #region Methods

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado informaEstado;
        public static event DelegadoCajero InformaCajero;

        public override string ToString() {
            StringBuilder data = new StringBuilder();
            data.Append($"Codigo: {this.CodigoPersona}");
            return data.ToString();
        }

        public static Persona HarcoPersona() {
            Random rd = new Random(DateTime.Now.Millisecond);
            Persona persona = new Persona(rd.Next().ToString());
            for (int i = 0; i < rd.Next(1, 10); i++) {
                Factura fatura = new Factura(rd.Next(1000, 10000) / 100, rd.Next());
                persona.Facturas.Add(fatura);
            }
            Thread.Sleep(100);

            return persona;
        }

        public void MockClicCajero() {
            while (!(this.Estado is EEstado.Atendido)) {
                switch (this.Estado) {
                    case EEstado.Ingresando:
                        Thread.Sleep(2000);
                        this.Estado = EEstado.Cobrando;
                        this.informaEstado.Invoke(this, EventArgs.Empty); // Lanza al evento
                        break;
                    case EEstado.Cobrando:
                        Thread.Sleep(2000);
                        this.Estado = EEstado.Atendido;
                        this.informaEstado.Invoke(this, EventArgs.Empty); // Lanza al evento
                        break;
                    default:
                        break;
                }
            }
            try {
                InformaCajero.Invoke(this);
            } catch (Exception exe) {

                throw new Exception(exe.Message);
            }
        }

        #endregion

    }
}
