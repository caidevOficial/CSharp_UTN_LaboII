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

using Exceptions;
using Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio_56 {
    public partial class frmNoteSharp : Form {

        PuntoTxt txtManager;
        PuntoDat datManager;
        string lastFilePath = null;

        public frmNoteSharp() {
            InitializeComponent();
            txtManager = new PuntoTxt();
            datManager = new PuntoDat();
        }

        /// <summary>
        /// EventHandler of rtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbText_TextChanged(object sender, EventArgs e) {
            tsStatus.Text = $"{rtbText.Text.Length} caracteres";
        }

        /// <summary>
        /// EventHandler of Open Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select a File";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string file = openFileDialog1.FileName;
                lastFilePath = file;
                MessageBox.Show($"{lastFilePath}");
                try {
                    if (Path.GetExtension(lastFilePath) == ".txt") {
                        rtbText.Text = txtManager.Leer(lastFilePath);
                    } else if (Path.GetExtension(lastFilePath) == ".dat") {
                        datManager = datManager.Leer(lastFilePath);
                        rtbText.Text = datManager.Contenido;
                    }
                } catch (ArchivoIncorrectoException ai) {
                    MessageBox.Show($"Excepcion: {ai.Message}");
                }
            }
        }

        private bool SaveFile(string path) {
            try {
                if (Path.GetExtension(path) == ".txt") {
                    return txtManager.GuardarComo(path, rtbText.Text);
                } else if (Path.GetExtension(path) == ".dat") {
                    datManager.Contenido = rtbText.Text;
                    return datManager.GuardarComo(path, datManager);
                }
            } catch (Exception e) {
                MessageBox.Show($"Exception: {e.Message}");
            }

            return false;
        }

        /// <summary>
        /// EventHandler of 'Save as' Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save the file";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                string path = $"{saveFileDialog1.FileName}";
                MessageBox.Show($"{saveFileDialog1.FileName}");
                if (this.SaveFile(path)) {
                    MessageBox.Show($"{Path.GetExtension(path)} file saved successfully!");
                }
            }
        }

        /// <summary>
        /// EventHandler of 'Save' Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!String.IsNullOrWhiteSpace(lastFilePath)) {
                if (this.SaveFile(lastFilePath)) {
                    MessageBox.Show($"{Path.GetExtension(lastFilePath)} file saved successfully!");
                }
            } else {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
