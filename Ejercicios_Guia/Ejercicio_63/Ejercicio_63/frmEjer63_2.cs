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
    public partial class frmEjer63_2 : Form {

        private delegate void MyDelegate();
        private Thread myThread;

        public frmEjer63_2() {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler of the button Main Thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainThread_Click(object sender, EventArgs e) {
            if (myThread is null) {
                this.myThread = new Thread(new ThreadStart(this.AumentaHora)); // Receives the method's reference and it saves in the thread to execute.
                this.myThread.Start(); // invokes the raiseHour in a secondary thread
                MessageBox.Show("Main Thread Suscribed", "Suscribed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Event Handler of the button Close Main Thread. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseMainThread_Click(object sender, EventArgs e) {
            if (myThread.IsAlive) {
                myThread.Abort();
                MessageBox.Show("Main Thread Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Assign the time to the label or invoke the main thread.
        /// </summary>
        private void AsignarHora() {
            if (this.lblHora.InvokeRequired) {
                MyDelegate myDel = new MyDelegate(this.AsignarHora);
                this.Invoke(myDel);
            } else {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Increment the time each second.
        /// </summary>
        private void AumentaHora() {
            do {
                this.AsignarHora();
                Thread.Sleep(1000);
                //TODO: try to improve this
            } while (true);
        }

        /// <summary>
        /// Event Handler of form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEjer63_2_FormClosing(object sender, FormClosingEventArgs e) {
            if (myThread.IsAlive) {
                myThread.Abort();
            }
        }
    }
}
