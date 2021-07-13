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

using Application.Helpers;
using Application.Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class FrmPrincipal : Form {

        #region Attribute

        private CustomerRepository customerRepository;

        #endregion

        #region Builder

        public FrmPrincipal() {
            InitializeComponent();
            this.customerRepository = new CustomerRepository();

        }

        #endregion

        #region ButtonsEventHandlers

        /// <summary>
        /// EventHandler of the button exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// EventHandler of the form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)//SE VA
        {

        }

        /// <summary>
        /// EventHandler of the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visualizerToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmCustomerVisualizer frm = new FrmCustomerVisualizer(this.customerRepository);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        /// <summary>
        /// EventHandler of the button open file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = Environment.CurrentDirectory;
                if (open.ShowDialog() == DialogResult.OK) {
                    string file = open.FileName;
                    if (File.Exists(file)) {
                        customerRepository.LoadFromFile(file);
                    } else {
                        throw new NotImplementedException();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"No se puede abrir: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }

        /// <summary>
        /// EventHandler of the button load file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (this.customerRepository.SaveToFile(customerRepository.GetAll())) {
                    MessageBox.Show("Clientes serializados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show($"No se puede Guardar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show($"No se puede Guardar: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }

        #endregion
    }
}
