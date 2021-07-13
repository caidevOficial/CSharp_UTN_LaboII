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
using System.IO;
using System.Windows.Forms;

namespace ArchivoLocoForm {
    public partial class FormLoco : Form {

        private const string EXTENSION_VALIDA = ".txt";
        private const string TXTFILTER = "txt files(*.txt)|*.txt";
        private const string BINFILTER = "bin files (*.bin)|*.bin";
        private const string XMLFILTER = "xml files (*.xml)|*.xml";
        

        public FormLoco() {
            InitializeComponent();
        }

        /// <summary>
        /// EventHandler of Read Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeer_OnClick(object sender, EventArgs e) {
            string miPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = miPath;
            if (openFile.ShowDialog() == DialogResult.OK) {
                string file = openFile.FileName;
                try {
                    richTextBoxTexto.Text = Archivador.LeerBin(file);
                    
                } catch (Exception exe) {
                    MessageBox.Show(exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //if (Path.GetExtension(file) == EXTENSION_VALIDA) {
                //    richTextBoxTexto.Text = Archivador.Leer(openFile.FileName);
                //} else {
                //    MessageBox.Show("Error opening the file", "Invalid Extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        /// <summary>
        /// EventHandler of Save Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_OnClick(object sender, EventArgs e) {
            string miPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = miPath;
            saveFile.Filter = BINFILTER;
            saveFile.ShowDialog();
            //MessageBox.Show($"{saveFile.FileName}");

            //if (Archivador.Guardar(richTextBoxTexto.Text, saveFile.InitialDirectory, saveFile.FileName, false)) {
            //    MessageBox.Show("File Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            try {
                if (Archivador.GuardarBin(richTextBoxTexto.Text, saveFile.FileName)) {
                    MessageBox.Show("File Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception exe) {
                MessageBox.Show(exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
