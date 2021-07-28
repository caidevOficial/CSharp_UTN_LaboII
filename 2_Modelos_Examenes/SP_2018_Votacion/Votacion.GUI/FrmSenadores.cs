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
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using Entidades;

namespace _20180628_SP.v1 {
    public partial class FrmSenadores : Form {

        #region Attributes

        private Thread myThread;
        private Votacion votacion;
        private DAO dbManager;
        private SerializarXML<Votacion> serializator;
        private Dictionary<string, Votacion.EVoto> participantes;
        private List<PictureBox> graficos;
        private static string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Votation.xml";

        #endregion

        #region Builder

        /// <summary>
        /// Default Builder
        /// </summary>
        public FrmSenadores() {
            InitializeComponent();
            // Instancio el Diccionario de Senadores y sus votos
            this.participantes = new Dictionary<string, Votacion.EVoto>();
            this.serializator = new SerializarXML<Votacion>();
            this.dbManager = new DAO();
            // Creo las Bancas y sus Senadores
            this.graficos = new List<PictureBox>();
            int x = 20;
            int y = 20;
            for (int i = 1; i <= 72; i++) {
                this.participantes.Add(i.ToString(), Votacion.EVoto.Esperando);
                PictureBox p = new PictureBox();
                p.BackColor = Color.White;
                p.Size = new Size(20, 20);
                p.Location = new Point(x, y);
                x += 25;
                if (x > 595) {
                    x = 20;
                    y += 25;
                }

                this.gpbSenado.Controls.Add(p);
                this.graficos.Add(p);
            }
        }

        #endregion

        #region VoteHandler

        /// <summary>
        /// EventHandler Vote
        /// </summary>
        /// <param name="senador">Name of senator.</param>
        /// <param name="voto">Type of vote.</param>
        public void ManejadorVoto(string senador, Votacion.EVoto voto) {
            if (this.groupBox2.InvokeRequired) {
                Votacion.Voto recall = new Votacion.Voto(this.ManejadorVoto);
                this.Invoke(recall, new object[] { senador, voto });
            } else {
                // Leo la banca del Senador actual
                PictureBox p = this.graficos.ElementAt(int.Parse(senador) - 1);
                switch (voto) {
                    case Votacion.EVoto.Afirmativo:
                        // Sumo votantes al Label correspondiente
                        lblAfirmativo.Text = (int.Parse(lblAfirmativo.Text) + 1).ToString();
                        // Marco la banca con color Verde
                        p.BackColor = Color.Green;
                        break;
                    case Votacion.EVoto.Negativo:
                        // Sumo votantes al Label correspondiente
                        lblNegativo.Text = (int.Parse(lblNegativo.Text) + 1).ToString();
                        // Marco la banca con color Rojo
                        p.BackColor = Color.Red;
                        break;
                    case Votacion.EVoto.Abstencion:
                        // Sumo votantes al Label correspondiente
                        lblAbstenciones.Text = (int.Parse(lblAbstenciones.Text) + 1).ToString();
                        // Marco la banca con color Amarillo
                        p.BackColor = Color.Yellow;
                        break;
                }
                // Quito un Senador de los que un no votaron, para marcar cuando termina la votación
                //int aux = int.Parse(lblEsperando.Text) - 1;
                int aux;
                int.TryParse(lblEsperando.Text, out int auxNumber);
                aux = auxNumber - 1;
                lblEsperando.Text = $"{aux}";
                // Si finaliza la votación, muestro si Es Ley o No Es Ley
                if (aux == 0) {
                    MessageBox.Show((int.Parse(lblAfirmativo.Text) - int.Parse(lblNegativo.Text)) > 0 ? "Es Ley" : "No es Ley", txtLeyNombre.Text);
                    // Guardar resultados
                    try {
                        if (serializator.Guardar(path, votacion) && dbManager.Guardar("Votaciones", votacion)) {
                            MessageBox.Show("Datos Guardados en XML y DB", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            MessageBox.Show("Error al guardar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } catch (Exception exe) {
                        MessageBox.Show(exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        #region Button

        /// <summary>
        /// EventHandler Simulate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimular_Click(object sender, EventArgs e) {
            if (myThread is null) {
                // Creo una nueva votación
                votacion = new Votacion(txtLeyNombre.Text, this.participantes);
                // Mostrar Quorum
                lblEsperando.Text = this.participantes.Count.ToString();
                // Reseteo de la votación
                foreach (PictureBox p in this.graficos)
                    p.BackColor = Color.White;
                lblAfirmativo.Text = "0";
                lblNegativo.Text = "0";
                lblAbstenciones.Text = "0";
                // EVENTO
                votacion.EventoVotoEfectuado += ManejadorVoto;
                // THREAD
                myThread = new Thread(votacion.Simular);
                myThread.Start();
            }
        }

        #endregion

        #region Closing

        /// <summary>
        /// EventHandler Form Closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSenadores_FormClosing(object sender, FormClosingEventArgs e) {
            if (!(myThread is null) && myThread.IsAlive) {
                myThread.Abort();
            }
            if (MessageBox.Show("Desea salir?", "Leaving", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                this.Dispose();
            } else {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
