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
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace Views {
    public partial class FrmLlamador : Form {

        private List<Paciente> thisPacientes;
        private SimuladorDeAtencion<Paciente> simuPaciente;
        private Thread hiloSimulador;

        /// <summary>
        /// Default builder.
        /// </summary>
        public FrmLlamador() {
            InitializeComponent();
        }

        /// <summary>
        /// Builder with list of patients.
        /// </summary>
        /// <param name="pacientes">List of patients.</param>
        public FrmLlamador(List<Paciente> pacientes) : this() {
            this.thisPacientes = new List<Paciente>(pacientes);
            this.simuPaciente = new SimuladorDeAtencion<Paciente>();
            this.simuPaciente.AvisoDeUso += this.IniciarAtencion;
            this.simuPaciente.FinDeUso += this.FinAtencion;
        }

        /// <summary>
        /// kills all the threads
        /// </summary>
        private void KillThread() {
            if (!(hiloSimulador is null) && hiloSimulador.IsAlive) {
                hiloSimulador.Abort();
            }
        }

        /// <summary>
        /// EventHandler Escape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLlamador_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.simuPaciente.AvisoDeUso -= this.IniciarAtencion;
                this.simuPaciente.FinDeUso -= this.FinAtencion;
                this.KillThread();
                this.Close();
            }
        }

        /// <summary>
        /// EventHandler Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLlamador_Load(object sender, EventArgs e) {
            this.hiloSimulador = new Thread(new ParameterizedThreadStart(this.simuPaciente.SimularVacunacion));
            this.hiloSimulador.Start(thisPacientes);
        }

        /// <summary>
        /// Manejador de evento Iniciar Atencion.
        /// </summary>
        /// <param name="paciente">Paciente a mostrar por los labels.</param>
        private void IniciarAtencion(Paciente paciente) {
            Paciente pac = paciente as Paciente;
            if (this.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate () {
                    this.lblInfoAdjunta.Text = pac.ToString();
                    this.lblTurno.Text = pac.Turno.ToString();
                });
            } else {
                this.lblInfoAdjunta.Text = pac.ToString();
                this.lblTurno.Text = pac.Turno.ToString();
            }
        }

        /// <summary>
        /// Manejador de evento Fin de atencion.
        /// </summary>
        /// <param name="o">Mensaje en string.</param>
        private void FinAtencion(object o) {
            string message = o as string;
            if (!String.IsNullOrWhiteSpace(message)) {
                MessageBox.Show(message, "Fin de Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
