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
using System.IO;
using System.Windows.Forms;

namespace Ejercicio_56 {
    public partial class frmNoteSharp : Form {

        string lastFilePath = null;

        public frmNoteSharp() {
            InitializeComponent();
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

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string file = openFileDialog1.FileName;
                lastFilePath = file;
                using (StreamReader sr = new StreamReader(file)) {
                    rtbText.Text = sr.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// EventHandler of 'Save as' Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                string path = $"{saveFileDialog1.FileName}";
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine(rtbText.Text);
                    MessageBox.Show("File Saved");
                }
            }
        }

        /// <summary>
        /// EventHandler of 'Save' Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1 = new SaveFileDialog();
            if (!String.IsNullOrWhiteSpace(lastFilePath)) {
                using (StreamWriter sw = File.AppendText(lastFilePath)) {
                    sw.WriteLine(rtbText.Text);
                    MessageBox.Show("File Saved");
                }
            } else {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
