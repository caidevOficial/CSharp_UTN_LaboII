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
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SistemaSolar.Entidades;
using SistemaSolar.Events;

namespace _20191121_SP {
    public partial class FrmSistemaSolar : Form {

        #region Attributes

        private System.Windows.Forms.PictureBox picPlaneta1;
        private System.Windows.Forms.PictureBox picPlaneta2;
        private System.Windows.Forms.PictureBox picPlaneta3;
        private const string archivoPlanetas = "planetas.xml";
        private List<Planeta> planetas;
        private List<Thread> animaciones;
        Xml<List<Planeta>> xml;

        #endregion

        /// <summary>
        /// Basic Constructor
        /// </summary>
        public FrmSistemaSolar() {
            InitializeComponent();
            animaciones = new List<Thread>();
            xml = new Xml<List<Planeta>>();
            planetas = new List<Planeta>();
        }

        /// <summary>
        /// EventHandler of the Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSistemaSolar_Load(object sender, EventArgs e) {
            if (this.xml.FileExists(archivoPlanetas)) {
                // Leo mis planetas del archivo binario
                this.xml.Leer(FrmSistemaSolar.archivoPlanetas, out this.planetas);
            }
            this.InitializePlanets();
            foreach (Planeta p in this.planetas) {
                // Asociar Evento. Asocio metodo al manejador.
                p.InformarAvance += DibujarAvancePlaneta;
                PictureBox pic = (PictureBox)p.ObjetoAsociado;
                pic.Location = this.CalcularUbicacion(pic.Location, p.PosicionActual, p.RadioRespectoSol);
                this.Controls.Add(pic);
            }
        }

        private void P_InformarAvance(object sender, PlanetaEventArgs e) {
            throw new NotImplementedException();
        }

        private void InitializePlanets() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemaSolar));

            this.picPlaneta1 = new System.Windows.Forms.PictureBox();
            this.picPlaneta2 = new System.Windows.Forms.PictureBox();
            this.picPlaneta3 = new System.Windows.Forms.PictureBox();
            // 
            // picPlaneta1
            // 
            this.picPlaneta1.Image = ((System.Drawing.Image)(resources.GetObject("picPlaneta1.Image")));
            this.picPlaneta1.Location = new System.Drawing.Point(144, 177);
            this.picPlaneta1.Name = "picPlaneta1";
            this.picPlaneta1.Size = new System.Drawing.Size(64, 64);
            this.picPlaneta1.TabIndex = 1;
            this.picPlaneta1.TabStop = false;
            // 
            // picPlaneta2
            // 
            this.picPlaneta2.Image = ((System.Drawing.Image)(resources.GetObject("picPlaneta2.Image")));
            this.picPlaneta2.Location = new System.Drawing.Point(406, 194);
            this.picPlaneta2.Name = "picPlaneta2";
            this.picPlaneta2.Size = new System.Drawing.Size(64, 64);
            this.picPlaneta2.TabIndex = 3;
            this.picPlaneta2.TabStop = false;
            // 
            // picPlaneta3
            // 
            this.picPlaneta3.Image = ((System.Drawing.Image)(resources.GetObject("picPlaneta2.Image")));
            this.picPlaneta3.Location = new System.Drawing.Point(406, 194);
            this.picPlaneta3.Name = "picPlaneta3";
            this.picPlaneta3.Size = new System.Drawing.Size(64, 64);
            this.picPlaneta3.TabIndex = 4;
            this.picPlaneta3.TabStop = false;

            // Creo mis planetas
            if (this.planetas.Count == 0) {
                Planeta planeta1 = new Planeta(14, 0, 150, this.picPlaneta1);
                Planeta planeta2 = new Planeta(10, 0, 250, this.picPlaneta2);
                Planeta planeta3 = new Planeta(8, 0, 250, this.picPlaneta3);

                this.planetas.Add(planeta1);
                this.planetas.Add(planeta2);
                this.planetas.Add(planeta3);
            } else {
                this.planetas[0].ObjetoAsociado = this.picPlaneta1;
                this.planetas[1].ObjetoAsociado = this.picPlaneta2;
                this.planetas[2].ObjetoAsociado = this.picPlaneta3;
            }
        }

        /// <summary>
        /// necesario para pasar de grados a radianes, para poder operar con las funciones de seno y coseno
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public static double Grados_a_Radianes(short grados) {
            return grados * (Math.PI / 180);
        }

        /// <summary>
        /// Calcula el punto en el cual se ubicará el planeta según su avance.
        /// </summary>
        /// <param name="posicion"></param>
        /// <param name="avance"></param>
        /// <param name="radioRespectoSol"></param>
        /// <returns></returns>
        private Point CalcularUbicacion(Point posicion, short avance, short radioRespectoSol) {
            int x = 0;
            int y = avance;

            x = picSol.Location.X + (int)Math.Round(Math.Cos(Grados_a_Radianes(avance)) * radioRespectoSol);
            y = picSol.Location.Y + (int)Math.Round(Math.Sin(Grados_a_Radianes(avance)) * radioRespectoSol);

            return new Point(x, y);
        }

        /// <summary>
        /// Init a thread for each planet and add it in the list of animations
        /// then it will start every thread.
        /// </summary>
        private void InitThreads() {
            foreach (Planeta item in this.planetas) {
                Thread planetThread = new Thread(item.AnimarSistemaSolar);
                planetThread.Name = $"Planeta {this.planetas.IndexOf(item) + 1}";
                planetThread.Start();
                animaciones.Add(planetThread);
            }
        }

        private void btnSimular_Click(object sender, EventArgs e) {
            if (this.animaciones.Count == 0) {
                // Iniciar hilos
                this.InitThreads();
                this.btnSimular.Text = "Detener";
            } else {
                this.LimpiarAnimaciones();
                this.btnSimular.Text = "Simular";
            }
        }

        /// <summary>
        /// EventHandler of the formClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSistemaSolar_FormClosing(object sender, FormClosingEventArgs e) {
            this.xml.Guardar(FrmSistemaSolar.archivoPlanetas, this.planetas, Encoding.UTF8);
            this.LimpiarAnimaciones();
        }

        /// <summary>
        /// Cancels all the active threads in the list.
        /// </summary>
        private void CancelThreads() {
            foreach (Thread item in animaciones) {
                if (item.IsAlive) {
                    item.Abort();
                }
            }
        }

        /// <summary>
        /// Stops and Cleans the list of threads
        /// </summary>
        private void LimpiarAnimaciones() {
            // Cancelar hilos
            CancelThreads();
            this.animaciones.Clear();
        }

        /// <summary>
        /// Dibujar planeta según su nueva ubicación
        /// </summary>
        /// <param name="sender">Planeta</param>
        /// <param name="e">Argumentos asociados</param>
        private void DibujarAvancePlaneta(object sender, PlanetaEventArgs e) {
            PictureBox pic = (PictureBox)((Planeta)sender).ObjetoAsociado;
            // Invocación del hilo principal
            if (pic.InvokeRequired) {
                InformacionDeAvance info = new InformacionDeAvance(this.DibujarAvancePlaneta);
                this.Invoke(info, new object[] { sender, e });
            } else {
                pic.Location = this.CalcularUbicacion(pic.Location, e.Avance, e.RadioRespectoSol);
            }
        }
    }
}
