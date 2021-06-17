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

using Models;
using System;
using System.Windows.Forms;

namespace Practica_15_Eventos_Delegados {
    public partial class frmDelegado : Form {

        private Cajero cajero;

        public frmDelegado() {
            InitializeComponent();
            cajero = new Cajero();
        }

        private void ActualizarEstados() {
            this.lstIngresado.Items.Clear();
            this.lstAtendido.Items.Clear();
            this.lstCobrado.Items.Clear();

            foreach (Persona item in Cajero.Personas) {
                switch (item.Estado) {
                    case Persona.EEstado.Ingresando:
                        this.lstIngresado.Items.Add(item);
                        break;
                    case Persona.EEstado.Atendido:
                        this.lstAtendido.Items.Add(item);
                        break;
                    case Persona.EEstado.Cobrando:
                        this.lstCobrado.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }
        }

        private void per_InformaEstado(object sender, EventArgs e) {
            if (this.InvokeRequired) {
                Persona.DelegadoEstado d = new Persona.DelegadoEstado(per_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            } else {
                this.ActualizarEstados();
            }
        }

        private void frmDelegado_Load(object sender, EventArgs e) {
            Cajero.Personas.Enqueue(Persona.HarcoPersona());
            Cajero.Personas.Enqueue(Persona.HarcoPersona());
            Cajero.Personas.Enqueue(Persona.HarcoPersona());
            Cajero.Personas.Enqueue(Persona.HarcoPersona());
            Cajero.Personas.Enqueue(Persona.HarcoPersona());

            foreach (Persona item in Cajero.Personas) {
                this.lstIngresado.Items.Add(item);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e) {
            Persona.InformaCajero -= Archivos.Guardar;
            Persona.InformaCajero -= Serializer.Guardar;
            Persona.InformaCajero -= PersonaDAO.Insertar;

            try {
                if ((Persona)this.lstIngresado.SelectedItem != null) {

                    Persona nuevaPersona = (Persona)this.lstIngresado.SelectedItem;
                    nuevaPersona.informaEstado += this.per_InformaEstado;

                    Persona.InformaCajero += Archivos.Guardar;
                    Persona.InformaCajero += Serializer.Guardar;
                    Persona.InformaCajero += PersonaDAO.Insertar;

                    cajero.Cobrar(cajero, nuevaPersona);
                    PersonaDAO.Insertar(nuevaPersona);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmDelegado_FormClosing(object sender, FormClosingEventArgs e) {
            cajero.CerrarCajero();
        }
    }
}
