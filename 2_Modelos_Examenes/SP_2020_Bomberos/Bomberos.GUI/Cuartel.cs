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
using System.Threading;
using System.Windows.Forms;
using Bomberos.Entidades;
using Bomberos.Exceptions;

namespace Formulario {
    public partial class Cuartel : Form {

        #region Attributes

        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        private List<Thread> salidasEnAccion;

        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Cuartel() {
            InitializeComponent();

            PictureBox fuego1 = new PictureBox();
            PictureBox fuego2 = new PictureBox();
            PictureBox fuego3 = new PictureBox();
            PictureBox fuego4 = new PictureBox();

            // 
            // fuego4
            // 
            fuego4.Image = global::Formulario.Properties.Resources.fire;
            fuego4.Location = new System.Drawing.Point(83, 225);
            fuego4.Name = "fuego4";
            fuego4.Size = new System.Drawing.Size(64, 64);
            fuego4.TabIndex = 12;
            fuego4.TabStop = false;
            fuego4.Visible = false;
            // 
            // fuego3
            // 
            fuego3.Image = global::Formulario.Properties.Resources.fire;
            fuego3.Location = new System.Drawing.Point(83, 155);
            fuego3.Name = "fuego3";
            fuego3.Size = new System.Drawing.Size(64, 64);
            fuego3.TabIndex = 11;
            fuego3.TabStop = false;
            fuego3.Visible = false;
            // 
            // fuego2
            // 
            fuego2.Image = global::Formulario.Properties.Resources.fire;
            fuego2.Location = new System.Drawing.Point(83, 85);
            fuego2.Name = "fuego2";
            fuego2.Size = new System.Drawing.Size(64, 64);
            fuego2.TabIndex = 10;
            fuego2.TabStop = false;
            fuego2.Visible = false;
            // 
            // fuego1
            // 
            fuego1.Image = global::Formulario.Properties.Resources.fire;
            fuego1.Location = new System.Drawing.Point(83, 13);
            fuego1.Name = "fuego1";
            fuego1.Size = new System.Drawing.Size(64, 64);
            fuego1.TabIndex = 9;
            fuego1.TabStop = false;
            fuego1.Visible = false;

            this.Controls.Add(fuego1);
            this.Controls.Add(fuego2);
            this.Controls.Add(fuego3);
            this.Controls.Add(fuego4);

            this.fuegos = new List<PictureBox>();
            this.fuegos.Add(fuego1);
            this.fuegos.Add(fuego2);
            this.fuegos.Add(fuego3);
            this.fuegos.Add(fuego4);
        }

        /// <summary>
        /// EventHandler of the form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e) {
            this.salidasEnAccion = new List<Thread>();
            this.bomberos = new List<Bombero>();
            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += FinalDeSalida;
            this.bomberos.Add(b4);
        }

        /// <summary>
        /// Event handler of the button 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar1_Click(object sender, EventArgs e) {
            this.DespacharServicio(0);
        }

        /// <summary>
        /// Event handler of the button 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar2_Click(object sender, EventArgs e) {
            this.DespacharServicio(1);
        }

        /// <summary>
        /// Event handler of the button 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar3_Click(object sender, EventArgs e) {
            this.DespacharServicio(2);
        }

        /// <summary>
        /// Event handler of the button 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar4_Click(object sender, EventArgs e) {
            this.DespacharServicio(3);
        }

        /// <summary>
        /// Deploys the service of the firefighter.
        /// </summary>
        /// <param name="index">Index of the firefighter in service.</param>
        private void DespacharServicio(int index) {
            try {
                if (this.fuegos[index].Visible) {
                    throw new BomberoOcupadoException("El bombero ya esta en una salida");
                } else {
                    this.fuegos[index].Visible = true;
                    Thread newSalida = new Thread(new ParameterizedThreadStart(this.bomberos[index].AtenderSalida));
                    newSalida.Start(index);
                    salidasEnAccion.Add(newSalida);
                }
            } catch (Exception exe) {
                string message = $"Salida bombero {bomberos[index].Nombre} no concretada";
                this.bomberos[index].Guardar(message);
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Creates and Invokes a delegate.
        /// </summary>
        /// <param name="bomberoIndex">Index of the firefighter in to finish the service.</param>
        private void InvokeDelegate(int bomberoIndex) {
            FinDeSalida fSalida = new FinDeSalida(this.FinalDeSalida);
            this.Invoke(fSalida, new object[] { bomberoIndex });
        }

        /// <summary>
        /// Finish the service of the firefighter.
        /// </summary>
        /// <param name="index">Index of the firefighter in to finish the service.</param>
        private void FinalDeSalida(int bomberoIndex) {
            if (this.fuegos[bomberoIndex].InvokeRequired) {
                this.InvokeDelegate(bomberoIndex);
            } else {
                this.fuegos[bomberoIndex].Visible = false;
            }
        }

        /// <summary>
        /// Event handler of the form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cuartel_FormClosing(object sender, FormClosingEventArgs e) {
            if(MessageBox.Show("Desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                foreach (Thread item in salidasEnAccion) {
                    if (item.IsAlive) {
                        item.Abort();
                    }
                }
            } else {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Event handler of the button Reporte 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReporte1_Click(object sender, EventArgs e) {
            try {
                this.bomberos[0].Guardar(bomberos[0]);
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Event handler of the button Reporte 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReporte2_Click(object sender, EventArgs e) {
            try {
                this.bomberos[1].Guardar(bomberos[1]);
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Event handler of the button Reporte 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReporte3_Click(object sender, EventArgs e) {
            try {
                this.bomberos[2].Guardar(bomberos[2]);
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }

        /// <summary>
        /// Event handler of the button Reporte 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReporte4_Click(object sender, EventArgs e) {
            try {
                this.bomberos[3].Guardar(bomberos[3]);
            } catch (Exception exe) {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
