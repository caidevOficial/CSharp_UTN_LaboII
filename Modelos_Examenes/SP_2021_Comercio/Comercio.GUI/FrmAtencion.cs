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

using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios {
    public partial class FrmAtencion : Form {
        private Comercio myComercio;
        private List<string> recientes;
        private static string initialPath = Environment.CurrentDirectory;
        private string pathToSave = $"{initialPath}\\recientes.txt";

        /// <summary>
        /// Basic Constructor.
        /// </summary>
        public FrmAtencion() {
            InitializeComponent();
            myComercio = new Comercio();
            openFileDialog.InitialDirectory = initialPath;
            saveFileDialog.InitialDirectory = initialPath;
            recientes = new List<string>();
        }

        /// <summary>
        /// Imports the list of customers into a file XML from the main directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importarToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                openFileDialog.ShowDialog();
                string importPath = openFileDialog.FileName;
                myComercio.LoadBackup(importPath);
                this.SavePath(importPath);
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Exports the list of customers into a file XML in the main directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportarToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                string selectedDir;
                saveFileDialog.ShowDialog();
                selectedDir = saveFileDialog.FileName;
                myComercio.SaveBackup(selectedDir);
                if (recientes.Count < 10) {
                    recientes.Add(selectedDir);
                }
                LoadTool();
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// EventHandler button add cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCliente_Click(object sender, EventArgs e) {
            FrmAgregarCliente frm = new FrmAgregarCliente();
            if (frm.ShowDialog() == DialogResult.OK) {
                myComercio += new Cliente(frm.GetCliente());
            }

        }

        /// <summary>
        /// Simulates the attention of the bussiness.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimular_Click(object sender, EventArgs e) {
            FrmSimularAtencion frm = new FrmSimularAtencion(this.myComercio);
            frm.ShowDialog();
        }

        /// <summary>
        /// Loads the last path.
        /// </summary>
        private void LoadTool() {
            ToolStripItem aux = new ToolStripMenuItem();
            foreach (string item in recientes) {
                aux.Text = item;
                abrirRecienteToolStripMenuItem.DropDownItems.Add(aux);
            }
        }

        private void abrirRecienteToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string path = e.ClickedItem.Text;
            try {
                if (MessageBox.Show("Seguro que desea abrir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    myComercio.LoadBackup(path);
                }
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Reads a text file from a path.
        /// </summary>
        /// <returns></returns>
        private string ReadPath() {
            string lineas = string.Empty;
            try {
                if (File.Exists(pathToSave)) {
                    using (StreamReader sr = new StreamReader(pathToSave)) {
                        lineas = sr.ReadToEnd().Trim();
                    }
                }

            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }

            return lineas;
        }

        /// <summary>
        /// Saves the historial of paths.
        /// </summary>
        /// <param name="text"></param>
        private void SavePath(string text) {
            List<string> lineas = new List<string>();
            string temp = string.Empty;
            try {
                temp += $"{text}\n";
                temp += this.ReadPath();
                using (FileStream fs = new FileStream(pathToSave, FileMode.Open, FileAccess.ReadWrite)) {
                    StreamWriter sw = new StreamWriter(fs);
                    fs.Seek(0, SeekOrigin.Begin);
                    sw.WriteLine(temp);
                    sw.Close();
                }

            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        private void FrmAtencion_Load(object sender, EventArgs e) {
            List<string> lineas = new List<string>();
            lineas = this.ReadPath().Split('\n').ToList();
            if (lineas.Count < 10) {
                for (int i = 0; i < lineas.Count; i++) {
                    recientes.Add(lineas[i]);
                }
            } else {
                for (int i = 0; i < 10; i++) {
                    recientes.Add(lineas[i]);
                }
            }

            LoadTool();
        }
    }
}
