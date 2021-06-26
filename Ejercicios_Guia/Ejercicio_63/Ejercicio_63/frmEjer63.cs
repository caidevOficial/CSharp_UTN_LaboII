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
using System.Threading;
using System.Windows.Forms;

namespace Ejercicio_63 {
    public partial class frmEjer63 : Form {

        public delegate void DelegadoHora(string dato);
        public event DelegadoHora myEvent;
        public Thread myThread;

        /// <summary>
        /// Builds the form.
        /// </summary>
        public frmEjer63() {
            InitializeComponent();
            myThread = new Thread(IniciarHora);
            myEvent += AsignarHora;
        }

        /// <summary>
        /// Load Event Handler of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEjer63_Load(object sender, EventArgs e) {
            myThread.Start();
        }

        /// <summary>
        /// Assign the time to the label.
        /// </summary>
        /// <param name="dato">Time in string formato to assign.</param>
        private void AsignarHora(string dato) {
            if (this.lblHora.InvokeRequired) {
                DelegadoHora dh = new DelegadoHora(AsignarHora);
                object[] objs = new object[] { dato };
                this.Invoke(dh, objs);
            } else {
                this.lblHora.Text = dato;
            }
        }

        /// <summary>
        /// Initializes the time.
        /// </summary>
        private void IniciarHora() {
            for (; ; ) {
                myEvent.Invoke(DateTime.Now.ToString());
            }
        }

        /// <summary>
        /// Close event Handler of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEjer63_FormClosing(object sender, FormClosingEventArgs e) {
            if (myThread.IsAlive) {
                myThread.Abort();
            }
        }
    }
}
