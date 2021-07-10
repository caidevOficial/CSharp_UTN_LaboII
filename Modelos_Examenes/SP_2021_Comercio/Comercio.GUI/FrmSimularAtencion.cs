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
using System.Drawing;
using System.Windows.Forms;
using Entidades;

namespace Formularios {
    public partial class FrmSimularAtencion : Form {
        private Simulador simulador;

        /// <summary>
        /// Constructor basico.
        /// </summary>
        public FrmSimularAtencion() {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor con Comercio por paramentro.
        /// </summary>
        /// <param name="comercio">Comercio apra asociar al simulador.</param>
        public FrmSimularAtencion(Comercio comercio) : this() {
            this.simulador = new Simulador(comercio);
            this.simulador.SimularAtencion += VerCliente;
        }

        /// <summary>
        /// Evento load del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSimularAtencion_Load(object sender, EventArgs e) {
            try {
                this.simulador.EmpezarSimulacion();
            } catch (SinClientesException exe) {
                this.lblCliente.ForeColor = Color.Red;
                this.lblCliente.Text = exe.Message;
            }
        }

        /// <summary>
        /// Muestra los clientes en el label.
        /// </summary>
        /// <param name="cliente">Cliente a mostrar por el label.</param>
        private void VerCliente(Cliente cliente) {
            if (this.lblCliente.InvokeRequired) {
                this.lblCliente.BeginInvoke(
                    (MethodInvoker)delegate () {
                        //try {
                        this.lblCliente.ForeColor = Color.Azure;
                        this.lblCliente.Text = $"{cliente.Numero} - {cliente.Nombre}";
                        //} catch (SinClientesException exe) {
                        //    this.lblCliente.ForeColor = Color.Red;
                        //    this.lblCliente.Text = exe.Message;
                        //}
                    }
                );
            }
        }

        /// <summary>
        /// Evento de boton escape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSimularAtencion_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        /// <summary>
        /// Evento closing del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSimularAtencion_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                if (ConnectionDAO.InsertData(this.simulador.GetAtendidos(), this.simulador.GetSinAtender())) {
                    MessageBox.Show("Datos insertados en la tabla");
                }
                if (this.simulador.SimuThread().IsAlive) {
                    this.simulador.SimuThread().Abort();
                }
            } catch (Exception exc) {

                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
