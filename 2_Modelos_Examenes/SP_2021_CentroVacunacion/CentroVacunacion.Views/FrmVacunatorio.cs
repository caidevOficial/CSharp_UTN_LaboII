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
using System.Windows.Forms;
using Entidades;

namespace Views {
    public partial class FrmVacunatorio : Form {

        #region Attributes

        private FrmLlamador llamador;
        private CentroDeVacunacion salita;
        private static string filePath = $"{Environment.CurrentDirectory}";
        private List<Paciente> pacientes;

        private const string XMLFILTER = "xml files(*.xml)|*.xml";
        private const string BINFILTER = "bin files(*.bin)|*.bin";
        private XmlManager<CentroDeVacunacion> xml;
        private BinManager<CentroDeVacunacion> bin;
        private TxTManager txt;
        private DAO dao;

        #endregion

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FrmVacunatorio() {
            InitializeComponent();
            bin = new BinManager<CentroDeVacunacion>();
            xml = new XmlManager<CentroDeVacunacion>();
            txt = new TxTManager();
            dao = new DAO();
            pacientes = new List<Paciente>();
            salita = new CentroDeVacunacion();
        }

        /// <summary>
        /// EventHandler Close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// EventHandler del boton XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e) {
            string file;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = filePath;
            openFile.Filter = XMLFILTER;
            try {
                if (openFile.ShowDialog() == DialogResult.OK) {
                    file = openFile.FileName;
                    this.salita = this.xml.ReadData(file, this.salita);
                    this.llamador = new FrmLlamador(this.salita.Pacientes);
                    this.llamador.ShowDialog();
                    this.txt.Guardar(filePath, this.salita.Pacientes);
                }
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// EventHandler del boton DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaseDeDatos_Click(object sender, EventArgs e) {
            try {
                this.salita = this.dao.ReadData("Pacientes", this.salita);
                this.llamador = new FrmLlamador(this.salita.Pacientes);
                this.llamador.ShowDialog();
                this.txt.Guardar(filePath, this.salita.Pacientes);
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// EventHandler del boton BIN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinario_Click(object sender, EventArgs e) {
            string file;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = filePath;
            openFile.Filter = BINFILTER;
            try {
                if (openFile.ShowDialog() == DialogResult.OK) {
                    file = openFile.FileName;
                    this.salita = this.bin.ReadData(file, this.salita);
                    this.llamador = new FrmLlamador(this.salita.Pacientes);
                    this.llamador.ShowDialog();
                    this.txt.Guardar(filePath, this.salita.Pacientes);
                }
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// EventHandler FormClosing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVacunatorio_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Desea Salir", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Dispose();
            } else {
                e.Cancel = true;
            }
        }
    }
}
