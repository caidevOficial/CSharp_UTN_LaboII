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
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Archivos;
using Entidades;

namespace _20181122_SP {
    public partial class FrmPpal : Form {
        private readonly static string path = $"{Environment.CurrentDirectory}";
        private readonly static string pathXml = $"{path}\\patentes.xml";
        private readonly static string pathTxt = $"{path}\\patentes.txt";
        private Queue<Patente> cola;
        private List<Thread> threads;
        private delegate void VistaPatente(Patentes.VistaPatente vp);
        private Xml<List<Patente>> xmlManager;
        private Sql sqlManager;
        private Texto txtManager;

        public FrmPpal() {
            InitializeComponent();
            threads = new List<Thread>();
            cola = new Queue<Patente>();
            xmlManager = new Xml<List<Patente>>();
            sqlManager = new Sql();
            txtManager = new Texto();
        }

        /// <summary>
        /// EventHandler of formLoad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_Load(object sender, EventArgs e) {
            this.vistaPatente1.finExposicion += this.ProximaPatente;
            this.vistaPatente2.finExposicion += this.ProximaPatente;
        }

        /// <summary>
        /// EventHandler of formClosing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Desea Salir?", "Leaving", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                this.FinalizarSimulacion();
            } else {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Event Handler of the button XML.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e) {
            try {
                List<Patente> patentes = new List<Patente>();
                this.xmlManager.Leer(pathXml, out patentes);
                this.cola = new Queue<Patente>(patentes.AsEnumerable());
                this.IniciarSimulacion();
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Event Handler of the button TXT.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTxt_Click(object sender, EventArgs e) {
            try {
                this.txtManager.Leer(pathTxt, out this.cola);
                this.IniciarSimulacion();
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Event Handler of the button SQL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSql_Click(object sender, EventArgs e) {
            try {
                this.sqlManager.Leer("patentes", out this.cola);
                this.IniciarSimulacion();
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Finalizes the simuilation.
        /// </summary>
        private void FinalizarSimulacion() {
            if (!(this.threads is null)) {
                foreach (Thread item in this.threads) {
                    if (!(item is null) && item.IsAlive) {
                        item.Abort();
                    }
                }
            }
        }

        /// <summary>
        /// Initializes the simulation.
        /// </summary>
        private void IniciarSimulacion() {
            this.FinalizarSimulacion();
            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2);
        }

        /// <summary>
        /// Stats the event in another thread, then puts the thread in a list of threads.
        /// </summary>
        /// <param name="vp"></param>
        private void ProximaPatente(Patentes.VistaPatente vp) {
            if (this.cola.Count > 0) {
                Thread nuevoHilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                nuevoHilo.Start(this.cola.Dequeue());
                this.threads.Add(nuevoHilo);
            }
        }
    }
}
